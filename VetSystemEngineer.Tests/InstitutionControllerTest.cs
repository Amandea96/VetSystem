using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VetSystemEngineer.Controllers;
using VetSystemEngineer.Data;
using VetSystemEngineer.Models;

using VetSystemEngineer.ViewModels;
using Xunit;

namespace VetSystemEngineer.Tests
{
    public class InstitutionControllerTest:InMemory
    {

        [Theory]
        [InlineData(1, "MaryVet", 2)]
        [InlineData(2, "TomVET", 0)]
        public  void InstDetailsTest(int id, string name, int count) {
           
            var instController = new InstitutionController(_context);
            var actual = instController.Details(id);
            
            var result = Assert.IsType<ViewResult>(actual);
            var ins = (ShowInstitution)result.ViewData.Model;
            Assert.Equal(name, ins.Inst.NameInst);
            Assert.Equal(count, ins.Employees.Count());

        }
    }
}
