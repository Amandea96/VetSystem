using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VetSystemEngineer.ViewModels;

namespace VetSystemEngineer.Services
{
   
        public interface IEmailSender
        {
            
            Task SendEmailAsync(Message message);
        }
    
}
