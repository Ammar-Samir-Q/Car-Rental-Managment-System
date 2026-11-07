using CarRental.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Factories
{
    //This Class Will Create DbContext Every Time And Give The Options
    public static class DbContextFactory
    {
        private static readonly DbContextOptions<AppDbContext> _Options;

        static DbContextFactory()
        {
            string ConnectionString = "Server=.;Database=CarRental;User=sa;Password=sa123456";
            _Options = new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(ConnectionString).Options;
        }

        public static AppDbContext CreateDbContext()
        {
            return new AppDbContext(_Options);
        }

    }
}
