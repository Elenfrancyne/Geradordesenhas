using System;

namespace geradordesenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int dia, mes, ano, idade;

            Console.Clear();
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Seja Bem Vindo, "+ nome + "! ");

            Console.WriteLine("Digite o seu dia de nascimento:");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Você nasceu no dia " + dia + "! ");

            Console.WriteLine("Digite o seu mês de nascimento:");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nasceu no mês " + mes + "! ");

            Console.WriteLine("Digite o seu ano de nascimento:");
            ano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("E  no ano " + ano + "! ");
            idade= 2021 - ano;

            Console.WriteLine("Olá, "+ nome + ", você nasceu em " + dia+"/"+mes+"/"+ano + ", portanto você tem " + idade + " anos. " );
            
            if(idade<18)
            {
                Console.WriteLine("Sua Senha é: "+nome + idade); 
            } 
            else
            {
                Console.WriteLine(" E a sua Senha é: "+idade + nome);
            } 

        }
    }
}
