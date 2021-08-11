using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_EleventhCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the eleventh code!");

      double initalValue = 1000.0;
      double percentage = 1.0036;

      Console.WriteLine("The initial value is R$" + initalValue);

      for(int month = 1; month <= 12; month++) {
        initalValue *= percentage;
        Console.WriteLine("The final value is R$" + initalValue + " on month " + month);
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
