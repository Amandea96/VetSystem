using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;

namespace VetSystemEngineer.Controllers
{

    public class VisitController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public VisitController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        //tworzenie pierwszej wizyty (wraz z właścicielem)
        [Authorize(Roles = "BossVet,Vet")]
        [HttpGet]
        public IActionResult CreatePatientVisit()
        {
            var types = _context.Genus.OrderBy(o => o.NameGenus).Select(a =>
                                      new SelectListItem()
                                      {
                                          Value = a.IdGenus.ToString(),
                                          Text = a.NameGenus
                                      }).ToList();
            return View(new CreatePatientVisit { ListType = types });
        }

        [Authorize(Roles = "BossVet,Vet")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePatientVisit(CreatePatientVisit cpv)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
               
                var checkEmail = _context.ApplicationUser.Where(e => e.Email == cpv.Email).SingleOrDefault();
                
                ApplicationUser owner = new ApplicationUser();
                Patient newPatient = new Patient();


                if (checkEmail == null)
                {

                    owner.Email = cpv.Email;
                    owner.UserName = cpv.Email;
                    owner.Surname = cpv.Surname;

                    owner.Address = cpv.Address;
                    owner.Name = cpv.NameOwner;
                    owner.PhoneNumber = cpv.PhoneNumber;


                    await _userManager.CreateAsync(owner, cpv.Password);

                    await _userManager.AddToRoleAsync(owner, "Owner");
                }
                else if (checkEmail != null)
                {

                    owner = _context.ApplicationUser.Where(e => e.Email == cpv.Email).SingleOrDefault();
                }
                else
                {

                    return View();
                }

                if (owner != null) {
                    newPatient.Id = owner.Id;
                    newPatient.Sex = cpv.Sex;
                    newPatient.Breed = cpv.Breed;
                    newPatient.Weight = cpv.Weight;
                    newPatient.Age = cpv.Age;
                    newPatient.Name = cpv.NamePet;
                    newPatient.IdGenus = cpv.SelectedType;
                    newPatient.SterilizedCastration = cpv.SterilizedCastration;
                    _context.Add(newPatient);
                    _context.SaveChanges();
                }

                if (owner != null && newPatient != null)
                {
                    PatientInstitution patientInstitution = new PatientInstitution
                    {
                        IdInst = applicationUser.IdInst,
                        IdPatient = newPatient.IdPatient
                    };

                    Visit firstVisit = new Visit
                    {

                        Purpose = cpv.Purpose,
                        DecrDisActions = cpv.DecrDisActions,
                        IdPatient = newPatient.IdPatient,
                        Id = applicationUser.Id,
                        DateVisit = DateTime.Now
                    };


                   await _context.AddAsync(patientInstitution);
                    _context.Add(firstVisit);
                    await _context.SaveChangesAsync();
                }



                return RedirectToAction("PatientList");


            }




            else
            {
                CreatePatientVisit();
                return View();
            }


        }

        //lista pacjentów wyświetlana przez lakarzy/techników weterynynarii
        [Authorize(Roles = "BossVet,Vet")]
        public async Task<IActionResult> PatientList(string surname = null, string petName = null)
        {
            ApplicationUser vet = await _userManager.GetUserAsync(User);

            //1.wyszukanie pacjentów należących do danej placówki (poprzez Id instytucji) 
            List<PatientInstitution> listP = _context.PatientInstitution.Where(idI => idI.IdInst == vet.IdInst).ToList();
            List<Patient> listPatients = _context.Patient.ToList();
            List<ApplicationUser> listOwners = _context.ApplicationUser.ToList();
            List<Genus> types = _context.Genus.ToList();


            var patient = from p in listPatients
                          join o in listOwners on p.Id equals o.Id into table1
                          from o in table1.ToList()
                          join t in types on p.IdGenus equals t.IdGenus into table3
                          from t in table3.ToList()
                          join pi in listP on p.IdPatient equals pi.IdPatient into table2
                          from pi in table2.ToList()


                          orderby o.Surname

                          select new JoinPatientOwner
                          {
                              TypePet = t,
                              Pet = p,
                              Owner = o,
                              PaInst = pi
                          };
            if (!String.IsNullOrEmpty(surname) && !String.IsNullOrEmpty(petName))

            { patient = patient.Where(o => o.Owner.Surname.Contains(surname) && o.Pet.Name.Contains(petName)); }
            else if (!String.IsNullOrEmpty(surname))
            { patient = patient.Where(o => o.Owner.Surname.Contains(surname)); }

            else if (!String.IsNullOrEmpty(petName))
            { patient = patient.Where(o => o.Pet.Name.Contains(petName)); }


            return View("Index", patient);
        }







        //wyświetlenie: danych wlasciciela, pacjenta, dokumentacji medycznej oraz formularza wizyty

        [Authorize(Roles = "BossVet,Vet")]
        [HttpGet]
        public async Task<IActionResult> NewVisit(int id)
        {
            ApplicationUser logUser = await _userManager.GetUserAsync(User);



            var patient = _context.Patient.Single(pa => pa.IdPatient == id);
            var owner = _context.ApplicationUser.Where(o => o.Id == patient.Id).Single();
            var medical = _context.Visit.Where(v => v.IdPatient == id).ToList();
            var haveAccess = _context.PatientInstitution.Where(pi => pi.IdPatient == id && pi.IdInst == logUser.IdInst).SingleOrDefault();
           
            List<ApplicationUser> vetInfo = new List<ApplicationUser>();
            ViewBag.Age = patient.Age;

            var type = _context.Genus.Where(t => t.IdGenus == patient.IdGenus).Single();
            ViewBag.Type = type.NameGenus;
            List<SelectListItem> types=new List<SelectListItem>();

            if (ViewBag.Type == "Inny") { 
            types = _context.Genus.OrderBy(o => o.NameGenus).Select(a =>
                                      new SelectListItem()
                                      {
                                          Value = a.IdGenus.ToString(),
                                          Text = a.NameGenus
                                      }).ToList();

            }

            if (haveAccess != null)
            {
                for (int i = 0; i < medical.Count(); i++)
                {
                    var vet = _context.ApplicationUser.Where(o => o.Id == medical[i].Id).Single();
                    vetInfo.Add(vet);
                }




                return View(new MedicalDocumentation
                {   SterilizedCastration = patient.SterilizedCastration,
                    SelectedType=type.IdGenus,
                    PetType=type,
                    ListType = types,
                    VetInfo = vetInfo,
                    medicalHistory = medical,
                    Pet = patient,
                    Owner = owner
                }) ;
            }
            else { return new ForbidResult(); }
        }



        [Authorize(Roles = "BossVet,Vet")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewVisit(int id, MedicalDocumentation cv)
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {


                var patient = _context.Patient.Where(pa => pa.IdPatient == id).SingleOrDefault();
                var checkType = _context.Genus.Where(t => t.IdGenus == patient.IdGenus).SingleOrDefault();
                Visit anotherVisit = new Visit
                {

                    Purpose = cv.Purpose,
                    DecrDisActions = cv.DecrDisActions,
                    IdPatient = patient.IdPatient,
                    Id = applicationUser.Id,
                    DateVisit = DateTime.Now
                };

               
                if (cv.SterilizedCastration != patient.SterilizedCastration)
                {
                    patient.SterilizedCastration = cv.SterilizedCastration;
                    _context.Update(patient);
                }


                if (cv.Weight != null)
                {
                    patient.Weight = cv.Weight;
                    _context.Update(patient);
                }

               
                if (cv.SelectedType!=0)
                {
                    var newType = _context.Genus.Where(t => t.IdGenus == cv.SelectedType).SingleOrDefault();

                    patient.IdGenus = newType.IdGenus;
                    _context.Update(patient);

                }


                _context.Add(anotherVisit);
                _context.SaveChanges();
                return RedirectToAction("PatientList");
            }




            else
            {
                await NewVisit(id);
                return View();

            }




        }



        // wyświetlanie całej dokumentacji pacjenta
        [Authorize(Roles = "Vet, BossVet, Owner")]
        [HttpGet]
        public async Task<IActionResult> MedicalDocumentation(int id)
        {

            ApplicationUser logUser = await _userManager.GetUserAsync(User);
            var haveAccess = _context.PatientInstitution.Where(pi => pi.IdPatient == id && pi.IdInst == logUser.IdInst).SingleOrDefault();
            var patientOwner = _context.Patient.Single(pa => pa.IdPatient == id);
            var owner = _context.ApplicationUser.Where(o => o.Id == patientOwner.Id).Single();
            var type = _context.Genus.Where(t => t.IdGenus == patientOwner.IdGenus).Single();

            if (haveAccess != null || patientOwner.Id == logUser.Id)
            {

                var medical = _context.Visit.Where(v => v.IdPatient == id).ToList();
                List<ApplicationUser> vetInfo = new List<ApplicationUser>();

                for (int i = 0; i < medical.Count(); i++)
                {
                    var vet = _context.ApplicationUser.Where(o => o.Id == medical[i].Id).Single();
                    vetInfo.Add(vet);


                }


                return View(new MedicalDocumentation
                {
                    PetType = type,
                    VetInfo = vetInfo,
                    medicalHistory = medical,
                    Pet = _context.Patient.Where(pa => pa.IdPatient == id).FirstOrDefault(),
                    Owner = owner
                });

            }
            else { return new ForbidResult(); }

        }
    }
}
