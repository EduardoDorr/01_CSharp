using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SecondCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the new code!");

      int Age;

      Age = 32;
      Console.WriteLine(Age);

      Age = 10 + 5;
      Console.WriteLine(Age);

      Age = 10 + 5 * 2;
      Console.WriteLine(Age);

      Age = (10 + 5) * 2;
      Console.WriteLine("I am " + Age + " years old!");

      Console.WriteLine("Code Ends! Key enter to finish");
      Console.ReadLine();
    }
  }
}
