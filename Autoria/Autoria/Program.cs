// See https://aka.ms/new-console-template for more information
using System;

    {
        Random random = new Random();
        int num, soma;
        string escolhaUsuario, respostaUsuario;

        Console.WriteLine("Jogo do Par ou Ímpar");
        Console.WriteLine("Você quer jogar? (s/n)");
        respostaUsuario = Console.ReadLine().ToUpper();
        if (respostaUsuario == "S")
        {
            Console.Write("Digite par ou impar: ");
            escolhaUsuario = Console.ReadLine().ToUpper();
            Console.Write("Digite um número entre 0 e 10: ");
            int numeroUsuario = int.Parse(Console.ReadLine());

            num = random.Next(0, 11);
            soma = numeroUsuario + num;

            Console.WriteLine($"Você escolheu {numeroUsuario} e o computador escolheu {num}.");
            Console.WriteLine($"A soma foi {soma} → {(soma % 2 == 0 ? "PAR" : "IMPAR")}");

            if ((soma % 2 == 0 && escolhaUsuario == "PAR") ||
                (soma % 2 != 0 && escolhaUsuario == "IMPAR"))
            {
                Console.WriteLine("Você venceu, parabens!");
            }
            else
            {
                Console.WriteLine("O computador venceu, mais sorte na proxima");
            }
        }
        else
        {
            Console.WriteLine("OK. Quando quiser jogar, só abrir o Visual");
        }
    }