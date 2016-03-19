using System.Data.Entity;

namespace Credit.DataAccess
{
  public class CreditContext : DbContext
  {

    public CreditContext() : base("name=Credit")
    {
    }

    public DbSet<LiborWibor> LiborWibor { get; set; }
   // public DbSet<WiborLibor> WiborLibor { get; set; }
  }
}