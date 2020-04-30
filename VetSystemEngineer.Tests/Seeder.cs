using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.Tests
{
    public class Seeder
    {
        
        public static void Check(ApplicationDbContext context)
            {

            
            if (context.Institution.Any())
                {
                    return;
                }

                Employees(context);
            }
        

        private static void Employees(ApplicationDbContext context)
        {

            var insts = new[]
                {
                new Institution{ IdInst = 1, NameInst = "MaryVet", AddressInst = "Sienkiewicza 5", EmailInst = "maryVet@gmail.com", City = "Warszawa", InterList = "badania", PhNumInst = "7679800098", Postcode = "78-098" },
            new Institution { IdInst = 2, NameInst = "TomVET", AddressInst = "Mickiewicza 6", EmailInst = "tomVET@gmail.com", City = "Kraków", InterList = "badania", PhNumInst = "7678790098", Postcode = "78-798" }};
            var emp = new[]
            {
                new ApplicationUser{Id="1",Name="Karolina",Address="Armii Krajowejj 16",IdInst=1,Email="karo@gmail.com", Education="Lekarz weterynarii", UserName="karo@gmail.com", Surname="Głowacka", Password="aA@jhkjqsuyH7"},
            new ApplicationUser{Id="2",Name="Roman",Address="Wojska Polskiego 16",IdInst=1,Email="roman@gmail.com", Education="Lekarz weterynarii", UserName="roman@gmail.com", Surname="Roman",Password="aA@jhkjqsuyH7"}


            };
            context.Institution.AddRange(insts);
            context.ApplicationUser.AddRange(emp);
            context.SaveChanges();
        }
    }
}
