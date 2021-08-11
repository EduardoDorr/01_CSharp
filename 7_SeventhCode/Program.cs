using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_SeventhCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the seventh code!");

      int ageJohn = 16;
      int qtdPeople = 2;
      bool companions = qtdPeople >= 2;

      if(ageJohn >= 18 || companions) {
        Console.WriteLine("John's age is greater than 18 years old or has companions!");
        //Console.WriteLine(ageJohn);
      }
      else {
        Console.WriteLine("John's age is lower than 18 years old! Yours age is " + ageJohn + ".");
      }

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
