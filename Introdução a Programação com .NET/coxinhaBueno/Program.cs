using System;

class Classe {
    static void Main() {
        string[] line = Console.ReadLine().Split(" ");
        double coxinha = double.Parse(line[0]);
        double participantes = double.Parse(line[1]);
        double media = coxinha / participantes;
        Console.WriteLine(media.ToString("F2"));
    }
}