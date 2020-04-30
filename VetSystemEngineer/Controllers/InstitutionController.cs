using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;

namespace VetSystemEngineer.Controllers
{

    public class InstitutionController : Controller
    {
        
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        

        public InstitutionController(ApplicationDbContext context)
        {
           
            _context = context;
        }
        [ActivatorUtilitiesConstructor]
        public InstitutionController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult InstMain()
        {


            

            var insts = _context.Institution.OrderBy(c => c.City).ToList();
            return View(insts);


        }

        public  IActionResult Details(int id)
        {

            return View(new ShowInstitution
            {
                Inst = _context.Institution.Where(p => p.IdInst == id).Single(),
                Employees = _context.ApplicationUser.Where(p => p.IdInst == id).ToList()
            });
        }
       
        
        
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult CreateInstitution()
        {

            return View();


        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateInstitution(Institution cInst)

        {
            if (ModelState.IsValid)
            {
            
                var instAdd = new Institution
                {
                    NameInst = cInst.NameInst,
                    AddressInst = cInst.AddressInst,
                    PhNumInst = cInst.PhNumInst,
                    City = cInst.City,
                    Postcode = cInst.Postcode,
                    EmailInst = cInst.EmailInst

                };


                _context.Add(instAdd);
                _context.SaveChanges();
                return RedirectToAction("InstMain");
            }

            else { return View(); }


        }

        [HttpGet]
        public IActionResult AddBossVet(int id)
        {
            var ins = _context.Institution.Where(p => p.IdInst == id).Single();

            var bossVet = new CreateBossVet
            {
                IdInst = ins.IdInst

            };
            ViewBag.idInst = bossVet.IdInst;


            return View(bossVet);
        }


        [HttpPost]
        public async Task<IActionResult> AddBossVet(int id, CreateBossVet bossVet)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser boss = new ApplicationUser
                {
                    Email = bossVet.Email,

                    UserName = bossVet.Email,
                    Surname = bossVet.Surname,
                    IdInst = id,

                    Education = bossVet.Education,

                    Address = bossVet.Address,
                    Name = bossVet.NameVet,
                    PhoneNumber = bossVet.PhoneNumber
                };

                var result = await _userManager.CreateAsync(boss, bossVet.Password);




                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(boss, "BossVet");
                    return RedirectToAction("InstMain");


                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View();
                }

            }




            else { return View(); }


        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddType()
        {

            return View();

        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddType(Genus type)
        {


            if (ModelState.IsValid)
            {
                var types = _context.Genus.Where(t => t.NameGenus == type.NameGenus).FirstOrDefault();

                if (types == null)
                {
                    var newType = new Genus
                    {
                        NameGenus = type.NameGenus


                    };


                    _context.Add(newType);
                    _context.SaveChanges();
                    return RedirectToAction("InstMain");


                }

                else
                {
                    TempData["Exist"] = "Ten typ już istnieje w bazie!";
                    return View();
                }
            }

            else { return View(); }

        }

    }
}