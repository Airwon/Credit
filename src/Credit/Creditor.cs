using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Windows.Forms;
using Credit.DataAccess;
using static System.Convert;

namespace Credit
{
  public partial class Creditor : Form
  {
    public Financialfunctions Finansial;
    public Creditor()
    {
      InitializeComponent();
      Database.SetInitializer<CreditContext>(new CreateDatabaseIfNotExists<CreditContext>());

    }

    private void Find_Click(object sender, EventArgs e)
    {
      Finansial = new Financialfunctions();
      ///////////////////
      CultureInfo englishCulture = CultureInfo.CreateSpecificCulture("pl-PL");
      string dateString = mc_uruchomienia.Text;
      string formatString = "MMMM";

      DateTime extendedWay = DateTime.ParseExact(
          dateString,
          formatString,
          englishCulture.DateTimeFormat);


      var date = new DateTime(ToInt32(rok_uruchomienia.Text), extendedWay.Month, 1);
      var year = date.AddMonths(1).Year;
      var month = date.AddMonths(1).Month;
      List<LiborWibor> rows;
      using (var context = new CreditContext())
      {
        rows = context.LiborWibor.Where(l => l.Year >= year && l.Month >= month).ToList();  ///wartosci od danej daty
      }

      List<LiborWibor> rows0;
      var year0 = date.Year;
      var month0 = date.Month;
      using (var context0 = new CreditContext())
      {
        rows0 = context0.LiborWibor.Where(z => z.Year == year0 && z.Month == month0).ToList();
      }
      foreach (var row1 in rows0)
      {

        kurs_chf.Text = Convert.ToString(System.Decimal.Round(ToDecimal(row1.RatePlnChf), 8));
      }

      string dateString1 = mc_aktualny.Text;
      DateTime extendedWay1 = DateTime.ParseExact(
    dateString1,
    formatString,
    englishCulture.DateTimeFormat);
      var date1 = new DateTime(ToInt32(rok_aktualny.Text), extendedWay1.Month, 1);
      var year1 = date1.Year;
      var month1 = date1.Month;
      var t2 = rows.Where(z => z.Year == year1 && z.Month == month1).ToList();
      foreach (var row in t2)
      {
        kurs_chf_aktualny.Text = row.RatePlnChf;
        saldo_kapitalu_chf_aktualny.Text = "";
        saldo_kap_pln.Text = "";
      }

      kwota_kredytu_chf.Text = (Convert.ToString(System.Decimal.Round((ToDecimal(kwota_kredytu_pln.Text)) / (ToDecimal(kurs_chf.Text)), 0)));


      int i = 1;
      var result = rows.Where(l => l.Id <= ToInt32((okres_kredytowania.Text))).Select(l => new CreditForms
      {

        Nrraty = i++,
        Year = l.Year,
        Month = l.Month,
        Libor3Mchf = l.Libor3MChf,
        Marza = 2,
        OdsetkiChf = System.Decimal.Round(ToDecimal(Finansial.IPmt((ToDouble(l.Libor3MChf) + 0.02) / 12, 1, ToInt32(okres_kredytowania.Text) - i - 1, -(ToDouble(kwota_kredytu_chf.Text)))), 2),

        KapitalChf = System.Decimal.Round(ToDecimal(Finansial.Ppmt((ToDouble(l.Libor3MChf) + 0.02) / 12, 1, ToInt32(okres_kredytowania.Text) - i - 1, (ToDouble(kwota_kredytu_chf.Text)))), 2),
        SaldokapitaluChf = ToDecimal(kwota_kredytu_chf.Text) -
        (System.Decimal.Round(ToDecimal(Finansial.Ppmt((ToDouble(l.Libor3MChf) + 0.02) / 12, 1, ToInt32(okres_kredytowania.Text) - i - 1, (ToDouble(kwota_kredytu_chf.Text)))), 2)),
        KursChf = Convert.ToString(decimal.Round(ToDecimal(l.RatePlnChf), 4), CultureInfo.CurrentCulture),
        Wibor3m = Convert.ToString(decimal.Round(ToDecimal(l.Wibor3M), 4), CultureInfo.CurrentCulture),
        Marza1 = 2,
        WplataPln = System.Decimal.Round(decimal.Round(ToDecimal(l.RatePlnChf), 2) * (ToDecimal(Finansial.Pmt((ToDouble(l.Libor3MChf) + 0.02) / 12, ToInt32(okres_kredytowania.Text) - i - 1, -(ToDouble(kwota_kredytu_chf.Text))))), 2),
        OdsetkiPln = System.Decimal.Round(ToDecimal(kwota_kredytu_pln.Text) * ToDecimal((ToDouble(l.Wibor3M) + 0.02) / 12), 2),
        KapitalPln = System.Decimal.Round(decimal.Round(ToDecimal(l.RatePlnChf), 2) * (ToDecimal(Finansial.Pmt((ToDouble(l.Libor3MChf) + 0.02) / 12, ToInt32(okres_kredytowania.Text) - i - 1, -(ToDouble(kwota_kredytu_chf.Text))))), 2) -
        System.Decimal.Round(ToDecimal(kwota_kredytu_pln.Text) * ToDecimal((ToDouble(l.Wibor3M) + 0.02) / 12), 2),
        SaldokapitaluPln = (ToDecimal(kwota_kredytu_pln.Text) -
        (System.Decimal.Round(decimal.Round(ToDecimal(l.RatePlnChf), 2) * (ToDecimal(Finansial.Pmt((ToDouble(l.Libor3MChf) + 0.02) / 12, ToInt32(okres_kredytowania.Text) - i - 1, -(ToDouble(kwota_kredytu_chf.Text))))), 2) -
        System.Decimal.Round(ToDecimal(kwota_kredytu_pln.Text) * ToDecimal((ToDouble(l.Wibor3M) + 0.02) / 12), 2))),


      }).ToList();

      dataGridView1.DataSource = result;

      var dataGridViewColumn = dataGridView1.Columns["Nrraty"];
      if (dataGridViewColumn != null) dataGridViewColumn.HeaderText = @"Nr raty";
      var gridViewColumn = dataGridView1.Columns["Month"];
      if (gridViewColumn != null) gridViewColumn.HeaderText = @"Miesiąc";
      var viewColumn = dataGridView1.Columns["Libor3MchdecimalF"];
      if (viewColumn != null)
        viewColumn.HeaderText = @"Libor 3 miecisęczny";
      var column = dataGridView1.Columns["Marza"];
      if (column != null) column.HeaderText = @"Marża";
      var dataGridViewColumn1 = dataGridView1.Columns["OdsetkiChf"];
      if (dataGridViewColumn1 != null) dataGridViewColumn1.HeaderText = "Odsetki CHF";
      var o = dataGridView1.Columns["KapitalChf"];
      if (o != null) o.HeaderText = "Kapitał CHF";
      var gridViewColumn1 = dataGridView1.Columns["SaldokapitaluChf"];
      if (gridViewColumn1 != null)
        gridViewColumn1.HeaderText = "Saldo kapitału CHF";
      var viewColumn1 = dataGridView1.Columns["KursChf"];
      if (viewColumn1 != null) viewColumn1.HeaderText = "Kurs CHF";
      var column1 = dataGridView1.Columns["Wibor3m"];
      if (column1 != null) column1.HeaderText = @"Wibor 3 miesięczny";
      var o1 = dataGridView1.Columns["Marza1"];
      if (o1 != null) o1.HeaderText = @"Marża";
      dataGridView1.Columns["WplataPln"].HeaderText = @"Wpłata PLN";
      dataGridView1.Columns["OdsetkiPln"].HeaderText = @"Odsetki PLN";
      dataGridView1.Columns["KapitalPln"].HeaderText = @"Kapitał PLN";
      dataGridView1.Columns["SaldokapitaluPln"].HeaderText = @"Saldo kapitału PLN";
    }

    private void Creditor_Load(object sender, EventArgs e)
    {

      string resxFile = @".\Months.resx";
      using (ResXResourceReader resxReader = new ResXResourceReader(resxFile))
      {
        foreach (DictionaryEntry entry in resxReader)
        {

          this.mc_aktualny.Items.AddRange(new object[] { entry.Value });
          this.mc_uruchomienia.Items.AddRange(new object[] { entry.Value });
        }
      }
    }
  }
}