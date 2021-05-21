using System;
using System.Collections.Generic;
using System.Linq;

class Desafio {
    static void Main() {
        
        int totalDeCasos = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalDeCasos; i++) 
        {
            int clientes = int.Parse(Console.ReadLine());
            var senhas = Console.ReadLine().Split(" ");
            var filaChegada = senhas.Select(x => int.Parse(x)).ToArray();
            var filaCorrigida = senhas.Select(x => int.Parse(x)) 
				.OrderByDescending(x => x).ToArray();
            var resultado = 0;
            for (int x = 0; x < clientes; x++) 
            {
                if (filaChegada[x] == filaCorrigida[x]) 
                {
                  resultado++;
                }
            }
            Console.WriteLine(resultado);
        }
    }
}