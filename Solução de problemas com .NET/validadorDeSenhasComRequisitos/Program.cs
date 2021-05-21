using System;
using System.Collections.Generic;
using System.Linq;

class Desafio {
    static void Main() {
        string S;
        List<string> senhas = new List<string>();
        while (!string.IsNullOrEmpty(S = Console.ReadLine())) 
        {
            senhas.Add(S);
        }
        for (int i = 0; i < senhas.Count; i++) 
        {
            int flag = 0;
            string senha = senhas[i];
            string specialChar = " !@#$%¨&*()_+{`^}?:><»«@£§€.,;/~[]´=-";
            foreach (var item in specialChar) 
            {
                if (senha.Contains(item)) 
                {
                    flag = 1;
                }
            }
            if (((senha.Length >= 6) && (senha.Length <= 32)) && (flag == 0) ) 
            {
                if (senha.Any(char.IsUpper) && senha.Any(char.IsLower) && senha.Any(char.IsDigit)) 
                {
                    Console.WriteLine("Senha valida.");
                } else 
                {
                    Console.WriteLine("Senha invalida.");
                }
            } else 
            {
                Console.WriteLine("Senha invalida.");
            }
        }
    }
}