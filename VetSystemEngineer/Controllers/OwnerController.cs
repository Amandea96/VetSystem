using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace VetSystemEngineer.Controllers
{
    [Authorize(Roles = "Owner")]
    public class OwnerController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public OwnerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }
       
        [HttpGet]
        public async Task<IActionResult> Pets()
        {
            ApplicationUser owner = await _userManager.GetUserAsync(User);
            var ownerAnimals = _context.Patient.Where(oa => oa.Id == owner.Id).Include(t=>t.IdGenusNavigation).ToList();
            var myPets = _context.Patient.Where(oa => oa.Id == owner.Id).Select(a =>
                                  new SelectListItem()
                                  {
                                      Value = a.IdPatient.ToString(),
                                      Text = a.Name + " " + a.Breed
                                  }).ToList();


            var allInst = _context.Institution.Select(a =>
                                 new SelectListItem()
                                 {
                                     Value = a.IdInst.ToString(),
                                     Text = a.NameInst + " " + a.City + " " + a.AddressInst
                                 }).ToList();

            var viewPetnst = _context.Patient.Where(oa => oa.Id == owner.Id).Select(o => new PetsBelongsToInst
            {
                PetID = o.IdPatient,
                NamePet = o.Name,

                Insts = o.PatientInstitution.Select(ot => ot.IdInstNavigation).ToList()
            }).ToList();
            ViewBag.Count = viewPetnst.Count();
            return View(new Pets { PetsList = ownerAnimals, ListNamePet = myPets, ListInst = allInst, DocInInst = viewPetnst });

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Pets(Pets pets)
        {
            if (ModelState.IsValid)
            {

                var petInInstExist = _context.PatientInstitution.Where(pe => pe.IdInst == pets.SelectedInst && pe.IdPatient == pets.SelectedPet).SingleOrDefault();
                if (petInInstExist == null)
                {

                    PatientInstitution petInInst = new PatientInstitution
                    {
                        IdPatient = pets.SelectedPet,
                        IdInst = pets.SelectedInst
                    };

                    _context.Add(petInInst);
                    _context.SaveChanges();

                }

            }

            return RedirectToAction("Pets");

        }


        
    }


}