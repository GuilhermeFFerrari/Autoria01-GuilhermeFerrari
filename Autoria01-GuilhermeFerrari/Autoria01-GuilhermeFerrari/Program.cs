// See https://aka.ms/new-console-template for more information

string resposta;
int nota;
Console.WriteLine("Você acabou o jogo, e esse é um questionario feito para melhor o desempenho do jogo por meio de opinião de usuarios\n");
Console.WriteLine("Gostaria de fazer o questionario? (s/n)");
resposta = Console.ReadLine();
if (resposta == "s")
{
    Console.WriteLine("Ok, vamos começar\n");
    Console.WriteLine("Você gostou do jogo? (s/n)");
    resposta = Console.ReadLine();
    if (resposta == "s")
    {
        Console.WriteLine("\nOtimo! de 0 a 10 qual sua nota para o jogo?");
        Console.WriteLine("Sendo 0 = Vast nas ultimas semanas e 10 = ponto extra pro Ferrari!");
        nota = int.Parse(Console.ReadLine());
        if (nota >= 7)
        {
            Console.WriteLine("Que bom! Agradeçemos sua aprovação, acredito que seja o suficiente para um extra!!!");
        }
        else
        {
            Console.WriteLine("porque?");
            resposta = Console.ReadLine();
            Console.WriteLine("Respeito seu feedback, mesmo você estando errado");
        }
    }
    else
    {
        Console.WriteLine("porque?");
        resposta = Console.ReadLine();
        Console.WriteLine("Respeito sua opinião, mesmo você estando errado");
    }
}
else
{
    Console.WriteLine("ok");
}
