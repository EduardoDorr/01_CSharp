using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_TenthCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the tenth code!");

      double initalValue = 1000.0;
      double percentage = 0.0036;
      int month = 1;

      Console.WriteLine("The initial value is R$" + initalValue);

      while (month <= 12) {
        initalValue += initalValue * percentage;
        Console.WriteLine("The final value is R$" + initalValue + " on month " + month);
        month++;
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
