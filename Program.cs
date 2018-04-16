using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        new Context().Database.Migrate();
    }
}

class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=26257;Database=infraserver;Username=kierenj;Password=;Integrated Security=false;");
    }
}
