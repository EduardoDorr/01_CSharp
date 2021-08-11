using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_TwelvethCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the twelveth code!");

      double initalValue = 1000.0;
      double percentage = 1.0036;

      Console.WriteLine("The initial value is R$" + initalValue);

      for (int year = 1; year <= 5; year++) {
        for (int month = 1; month <= 12; month++) {
          initalValue *= percentage;
          Console.WriteLine("The final value is R$" + initalValue + " on month " + month + " of year " + year);
        }

        percentage += 0.001;
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
