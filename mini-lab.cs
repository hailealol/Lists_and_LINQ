using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    List<string> employees = new List<string> {"James", "Mary", "Noah", "Ava", "Sophia", "Mason"};

    var names1 = 
      from m in employees
      where m.Contains("a") && m.Length > 4
      select m.ToUpper();

    var names2 = 
      from e in employees
      where e.Length < 4
      select e.ToLower();

    employees.Add("Bob");
    employees.Add("Alexa");

    foreach (string a in names1)
    {
      Console.WriteLine(a);
    };
    foreach (string b in names2)
    {
      Console.WriteLine(b);
    };
  }
}
