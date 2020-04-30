using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;

namespace VetSystemEngineer.Areas.Identity.Pages.Account.Manage
{
    public partial class EmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly Services.IEmailSender _emailSender;

        public EmailModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            Services.IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public string Username { get; set; }

        public string Email { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "New email")]
            public string NewEmail { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var email = await _userManager.GetEmailAsync(user);
            Email = email;

            Input = new InputModel
            {
                NewEmail = email,
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
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

        public async Task<IActionResult> OnPostChangeEmailAsync()
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
            
            var email = await _userManager.GetEmailAsync(user);
                if (Input.NewEmail != email && user.EmailConfirmed==true)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateChangeEmailTokenAsync(user, Input.NewEmail);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmailChange",
                        pageHandler: null,
                        values: new { userId = userId, email = Input.NewEmail, code = code },
                        protocol: Request.Scheme);

                    var message = new Message(new string[] { Input.NewEmail }, "Zmiana adresu email", "VetSys otrzymał prośbę o zmianę adresu email konta powiązanego z twoim adresem email. Jeżeli chcesz zmienić email wejdź na link:" + callbackUrl);


                    await _emailSender.SendEmailAsync(message);
                    StatusMessage = "Link uprawniający do zmiany adresu email został przesłany. Proszę sprawdź swój email.";
                    return RedirectToPage();
                

                
            }
                else if (user.EmailConfirmed == false)
                {
                    StatusMessage = "Proszę aktywuj konto.";
                    return RedirectToPage();
                }
            
            StatusMessage = "Link uprawniający do zmiany adresu email został przesłany. Proszę sprawdź swój email.";
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
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

            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code },
                protocol: Request.Scheme);
           
            var message = new Message(new string[] { email }, "Aktywowanie konta", "VetSys otrzymał prośbę o wygenerowanie linku aktywacyjnego dla konta powiązanego z twoim adresem email. Kliknij link, aby aktywować:  " + callbackUrl);


                await _emailSender.SendEmailAsync(message);

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToPage();
        }
    }
}
