using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using VetSystemEngineer.Models;
using VetSystemEngineer.ViewModels;
using Microsoft.AspNetCore.Http;
using MimeKit;
using System.Configuration;
using VetSystemEngineer.Services;

namespace VetSystemEngineer.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Services.IEmailSender _emailSender;
        
        public ForgotPasswordModel(UserManager<ApplicationUser> userManager, Services.IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null)
                {
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }

                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code },
                    protocol: Request.Scheme);

                var message = new Message(new string[] { Input.Email }, "Resetowanie hasła", "VetSys otrzymał prośbę o utworzenie nowego hasła powiązanego z twoim adresem email. Jeżeli chcesz zresetować hasło wejdź na link:  " + callbackUrl);

               
                await _emailSender.SendEmailAsync(message);
                
                return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }
    }
}
