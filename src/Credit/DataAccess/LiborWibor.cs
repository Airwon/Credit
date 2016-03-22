using System.ComponentModel.DataAnnotations.Schema;

namespace Credit.DataAccess
{
  public class LiborWibor
  {
    public int Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public string Libor3MChf { get; set; }

    public decimal Wibor3M { get; set; }

    public decimal RatePlnChf { get; set; }
  

  public double Libor3MChf1 // to u¿ywasz do obliczeñ zamiast value
{
  get 
  {
    return double.Parse(Libor3MChf);
  }
}
}

}