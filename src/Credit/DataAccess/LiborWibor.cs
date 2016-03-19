namespace Credit.DataAccess
{
  public class LiborWibor
  {
    public int Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public string Libor3MChf { get; set; }

    public string Wibor3M { get; set; }


    public string RatePlnChf { get; set; }




  }


  public class WiborLibor
  {

    public int Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    string Libor3MChf { get; set; } // to przychodzi np z bazki

    public double _Libor3MChf // to u¿ywasz do obliczeñ zamiast value
    {
      get { return double.Parse(Libor3MChf); }
    }

    string Wibor3M { get; set; } // to przychodzi np z bazki

    public double _Wibor3M // to u¿ywasz do obliczeñ zamiast value
    {
      get { return double.Parse(Wibor3M); }
    }

    string RatePlnChf { get; set; } // to przychodzi np z bazki

    public decimal _RatePlnChf// to u¿ywasz do obliczeñ zamiast value
    {
      get { return decimal.Parse(RatePlnChf); }
    }

  }



}