using FizzBuzzWeb.Forms;
using Microsoft.EntityFrameworkCore;
using System;

namespace FizzBuzzWeb.Data
{
    public class WyszukiwaniaContext : DbContext
    {
        public WyszukiwaniaContext(DbContextOptions options) : base(options) { }
        public DbSet<FizzBuzzForm> DanePrzestepne { get; set; }
    }
}
