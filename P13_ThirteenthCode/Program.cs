using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ThirteenthCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the thirteenth code!");

      for (int line = 0; line <= 10; line++) {
        for (int colunm = 0; colunm <= line; colunm++) {
          Console.Write("*");
        }

        Console.WriteLine();
      }

      for (int line = 0; line <= 10; line++) {
        for (int colunm = 0; colunm <= 10; colunm++) {
          Console.Write("*");
          if (colunm >= line)
            break;
        }

        Console.WriteLine();
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
