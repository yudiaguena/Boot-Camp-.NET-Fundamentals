using System; 

class Desafio {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            Array.Sort(s);
            Array.Reverse(s);
            
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
            
            double A = a;
            double B = b;
            double C = c;
            
            double A2 = A*A;
            double B2 = B*B;
            double C2 = C*C;
 
            
              //continue a solucao
            if (A >= (B + C))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (A2 == (B2 + C2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (A2 >= (B2 + C2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (A2 < (B2 + C2))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (A == B && A == C)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((A == B && A != C) || (A != B && B == C))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
}
