using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
         private readonly ApplicationDbContext _context;
        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        
        {_context=context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Nr telefonu")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Adres")]
            public string Address { get; set; }

            [Display(Name = "Imię")]
            public string Name { get; set; }

            [Display(Name = "Nazwisko")]
            public string Surname { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            //var address = User.FindFirst("LogAddress").Value;
            //var name = User.FindFirst("LogName").Value;
            //var surname = User.FindFirst("LogSurName").Value;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Address=user.Address,
                Name=user.Name,
                Surname=user.Surname
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }

            
            user.Name = Input.Name;
            user.Surname = Input.Surname;
            user.Address = Input.Address;

            //await _signInManager.RefreshSignInAsync(userS);
            _context.Update(user);
            _context.SaveChanges();
            //User.FindFirst("LogName").Properties=user.Name;
          //User.FindFirst("LogSurName").Value;
            StatusMessage = "Dane twojego konta zostały poprawnie zmienione";
            return RedirectToPage();
        }
    }
}
