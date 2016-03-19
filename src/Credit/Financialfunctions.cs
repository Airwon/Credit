using System;

namespace Credit
{
  public class Financialfunctions
  {

    //public  double PMT1(double yearlyInterestRate, int totalNumberOfMonths, double loanAmount)
    //{
    //  var rate = (double)yearlyInterestRate / 100 / 12;
    //  var denominator = Math.Pow((1 + rate), totalNumberOfMonths) - 1;
    //  return (rate + (rate / denominator)) * loanAmount;
    //}




    public double Ppmt(double rate, int paymentPeriod, int numberOfPayments, double amount)
    {
      double payment0 = Pmt(rate, numberOfPayments, amount);
      double paymetnt1 = IPmt(rate, paymentPeriod, numberOfPayments, amount);
      return paymetnt1 - payment0;
    }


    public double Pmt(double rate, int numberOfPayments, double amount)

    {

      double temp = System.Math.Pow((rate + 1), numberOfPayments);



      return ((-amount * temp) / ((temp - 1)) * rate);

    }



    public double FV(double rate, int numberOfPayments, double payment, double amount)

    {

      double temp = System.Math.Pow(rate + 1, numberOfPayments);



      return ((-amount) * temp) - ((payment / rate) * (temp - 1));

    }

    public double IPmt(double rate, int paymentPeriod, int numberOfPayments, double amount)

    {

      if (paymentPeriod < 1 || paymentPeriod > numberOfPayments)

        throw new ArgumentException("paymentPeriod must be between 1 and numberOfPayments ")
      ;

      if (rate == 0)

        throw new ArgumentException("This implementation doesn’ t handle zero interest rate")
      ;



      double payment = Pmt(rate, numberOfPayments, amount);

      double futureValue = FV(rate, (paymentPeriod - 1), payment, amount);



      return (futureValue * rate);

    }


  }

}
