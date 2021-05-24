﻿using System;
using System.Collections.Generic;

namespace DIO.Bank
{
	class Program
	{
		static List<Conta> listContas = new List<Conta>();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirConta();
						break;
					case "3":
						Transferir();
						break;
					case "4":
						Sacar();
						break;
					case "5":
						Depositar();
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}


		private static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			verificacao(indiceConta);
			int flag = verificacao(indiceConta);
			if (flag == 1)
			{
				Console.WriteLine("Nenhuma conta cadastrada. Retornando ao menu inicial.");
				return;
			}
				Console.Write("Digite o valor a ser depositado: ");
				double valorDeposito = double.Parse(Console.ReadLine());
				listContas[indiceConta].Depositar(valorDeposito);
		}

		private static void Sacar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			verificacao(indiceConta);
			int flag = verificacao(indiceConta);
			if (flag == 1)
			{
				Console.WriteLine("Nenhuma conta cadastrada. Retornando ao menu inicial.");
				return;
			}
				Console.Write("Digite o valor a ser sacado: ");
				double valorSaque = double.Parse(Console.ReadLine());
				listContas[indiceConta].Sacar(valorSaque);
		}

		private static int verificacao(int indiceConta)
		{
			int flag = 0;
			if (listContas.Count == 0 | indiceConta + 1 > listContas.Count)
			{
				flag = 1;
				return flag;
			}
			return flag;
        }

		private static void Transferir()
		{
			Console.Write("Digite o número da conta de origem: ");
			int indiceContaOrigem = int.Parse(Console.ReadLine());

			verificacao(indiceContaOrigem);
			int flag = verificacao(indiceContaOrigem);
			if (flag == 1)
			{
				Console.WriteLine("Nenhuma conta cadastrada. Retornando ao menu inicial.");
				return;
			}

            Console.Write("Digite o número da conta de destino: ");
			int indiceContaDestino = int.Parse(Console.ReadLine());

			verificacao(indiceContaDestino);
			flag = verificacao(indiceContaDestino);
			if (flag == 1)
			{
				Console.WriteLine("Nenhuma conta cadastrada. Retornando ao menu inicial.");
				return;
			}

			Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
		}

		private static void InserirConta()
		{
			Console.WriteLine("Inserir nova conta");

			Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
			int entradaTipoConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
										saldo: entradaSaldo,
										credito: entradaCredito,
										nome: entradaNome);

			listContas.Add(novaConta);
		}

		private static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(conta);
			}
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Bank a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Transferir");
			Console.WriteLine("4- Sacar");
			Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}