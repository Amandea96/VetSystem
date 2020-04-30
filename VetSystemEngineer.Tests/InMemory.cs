using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VetSystemEngineer.Data;

namespace VetSystemEngineer.Tests
{
    public class InMemory
    {

        


        protected readonly ApplicationDbContext _context;

        public InMemory()
        {
            var inMemory = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(inMemory);

            _context.Database.EnsureCreated();

            Seeder.Check(_context);
        }
    }
}
