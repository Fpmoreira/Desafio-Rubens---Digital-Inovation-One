using System;
namespace DesafioRubens {
  
  class CalcularCombustivel {
    
    static void Main(string[] args) {
      
      string[] km = Console.ReadLine().Split(" ");
      
      int hora = Int32.Parse(km[0]);
      int velocidade = Int32.Parse(km[1]);
      
      double kmPorLitro = 12;
      double litros = (hora * velocidade);
      double totalLitros = litros/kmPorLitro;
      
      Console.WriteLine(totalLitros.ToString("N3"));
      
    }
  }
}