﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;



namespace exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "";
            string caminho = "usuario.txt";
            string nome = "", email = "", telefone = "", rg = "";

            Console.WriteLine("#########################");
            Console.WriteLine("#########################");
            Console.WriteLine("G- GRAVAR ###############");
            Console.WriteLine("L- LER ##################");
            Console.WriteLine("S- SAIR #################");
            Console.WriteLine("#########################");
            Console.WriteLine("#########################");
            Console.Write("Digite uma operação: ");


            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {
                if (acao == "G")
                {
                    Console.Write("Informe seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Informe seu e-mail: ");
                    email = Console.ReadLine();

                    Console.Write("Informe seu telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write("Informe seu RG: ");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("Nome: " + nome);
                    sw.WriteLine("E-mail: " + email);
                    sw.WriteLine("Telefone: " + telefone);
                    sw.WriteLine("RG: " + rg);
                    sw.WriteLine("------------------------------");

                    sw.Close();
                }
                else if (acao == "L")
                {
                    StreamReader sr = new StreamReader(caminho);

                    while (sr.EndOfStream !=true)

                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("#########################");
                Console.WriteLine("#########################");
                Console.WriteLine("G- GRAVAR ###############");
                Console.WriteLine("L- LER ##################");
                Console.WriteLine("S- SAIR #################");
                Console.WriteLine("#########################");
                Console.WriteLine("#########################");
                Console.WriteLine("Digite uma operação: ");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
            }

        }
    }
