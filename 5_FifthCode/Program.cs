using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_FifthCode {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executing the fiveth code!");

      char firstLetter = 'A';
      Console.WriteLine(firstLetter);

      firstLetter = (char)65;
      Console.WriteLine(firstLetter);

      firstLetter = (char)(firstLetter + 1);
      Console.WriteLine(firstLetter);

      string title = "Alura courses!";
      Console.WriteLine(title);

      string svoid = "";
      Console.WriteLine(svoid);

      string list = " - .NET" +
        " - Java" +
        " - Python";
      Console.WriteLine(list);

      string glist = @" - .NET
      - Java
      - Python";
      Console.WriteLine(glist);

      Console.WriteLine("Code Ends! Key enter to finish!");
      Console.ReadLine();
    }
  }
}
