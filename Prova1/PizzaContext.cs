using Microsoft.EntityFrameworkCore;
using MyPizzeriaModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzeriaModel
    {
    public class PizzaContext : DbContext
        {
        public DbSet<Pizza> Pizzas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzeriaDB;Integrated Security=True;TrustServerCertificate=True");

            }
        }
    }
