using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EighthCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the eighth code!");

      int ageJohn = 16;
      bool companions = true;
      string message = "John hasn't friends!";

      if (companions == true) {
        message = "John has friends!";
      }

      if (ageJohn >= 18 || companions) {
        Console.WriteLine("John can enter!");
        Console.WriteLine(message);
      }
      else {
        Console.WriteLine("John cannot enter!");
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
