using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDay.WebApp.Repository
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions option) : base(option)
        {

        }
    }
    
    
}
