using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;
using VetSystemEngineer.Claims;

namespace VetSystemEngineer.Controllers
{
    
    [Authorize(Roles = "BossVet")]
    public class EmployeeController : Controller
    {
       
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
       


        

        public EmployeeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }
       
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
           
           
            ApplicationUser logInUser = await _userManager.GetUserAsync(User);
            

            var empList = _context.ApplicationUser.OrderBy(n => n.Surname).Where(inst => inst.IdInst == logInUser.IdInst).ToList();
            ViewBag.idInst = logInUser.IdInst;
            return View(empList);

            
        }
        [HttpGet]
        public async Task<IActionResult> ChangeDataInst()
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser logInUser = await _userManager.GetUserAsync(User);
            var ins = _context.Institution.Where(p => p.IdInst == logInUser.IdInst).SingleOrDefault();

            
            return View(ins);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeDataInst(Institution ei)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ApplicationUser logInUser = await _userManager.GetUserAsync(User);
             
            var ins = _context.Institution.Where(p => p.IdInst == logInUser.IdInst).Single();
            if (ModelState.IsValid) { 
                ins.InterList = ei.InterList;
            ins.AddressInst = ei.AddressInst;
            ins.PhNumInst = ei.PhNumInst;
            ins.City = ei.City;
            ins.Postcode = ei.Postcode;
           ins.EmailInst =ins.EmailInst;
            ins.NameInst = ei.NameInst;
            _context.Update(ins);
            _context.SaveChanges();

            return RedirectToAction("Index");
            }
            else { return View(); }
        }

       
       
        [HttpGet]
        public async Task <IActionResult> AddVet(int id)
        {
            ApplicationUser logInUser = await _userManager.GetUserAsync(User);
            if (logInUser.IdInst == id) { 

            ViewBag.idInst = id;


            return View();
            }

            else { return new ForbidResult(); }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVet(int id, CreateBossVet newVet)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser vet = new ApplicationUser
                {
                    Email = newVet.Email,

                    UserName = newVet.Email,
                    Surname = newVet.Surname,
                    IdInst = id,

                    Education = newVet.Education,

                    Address = newVet.Address,
                    Name = newVet.NameVet,
                    PhoneNumber = newVet.PhoneNumber
                };

                var result = await _userManager.CreateAsync(vet, newVet.Password);




                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(vet, "Vet");
                    return RedirectToAction("Index");


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



    }
}