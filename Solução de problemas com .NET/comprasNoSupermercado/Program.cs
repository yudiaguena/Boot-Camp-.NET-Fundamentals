using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse 
{
  public static void Main (string[] args) 
  {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < totalDeCasosDeTeste; i++) 
    {
      List<string> lista = new List<String>(Console.ReadLine().Split(" "));
      List<string> listaFormatado = lista.Distinct().ToList();
      listaFormatado.Sort();
      
      foreach (var x in listaFormatado) 
      {
            Console.Write("{0} ", x);
      }
      Console.WriteLine(" ");
    }
  }
}