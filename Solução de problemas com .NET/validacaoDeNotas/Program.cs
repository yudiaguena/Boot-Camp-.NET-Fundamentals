using System;

class Desafio 
{
    
    static void Main(string[] args) 
    {

        int flag = 1;
        double nota1;
        double nota2;
        while (flag == 1) 
        {
            nota1 = double.Parse(Console.ReadLine());
            while ((nota1 > 10) || (nota1 < 0)) 
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }
            
            nota2 = double.Parse(Console.ReadLine());
            while ((nota2 > 10) || (nota2 < 0)) 
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }
            
            double media = ((nota1 + nota2) / 2);
            Console.WriteLine(media.ToString("media = " + "0.00"));
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            flag = int.Parse(Console.ReadLine());
            while (((flag != 1) && (flag != 2))) 
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                flag = int.Parse(Console.ReadLine());
            }
            
        }
    }
}