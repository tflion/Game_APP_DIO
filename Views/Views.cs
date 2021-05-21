using System;

namespace DIO.Games
{
    public class Views
    {
        public string InitialMenu(string name)
        {
            string option;
            Console.Clear();
            Console.Write($"\n                                                  Bem Vindo à Tseam {name}.          ");
            Console.Write("\n");
            Console.Write("\n                              A plataforma de gerenciamento de jogos mais robusta do mercado!          ");
            Console.WriteLine("\n\n* O que deseja fazer?");
            Console.WriteLine("\n                                          1 -         Listar todos os Jogos");
            Console.WriteLine("                                          2 -     Visualizar um jogo específico");
            Console.WriteLine("                                          3 -        Adicionar um novo Jogo");
            Console.WriteLine("                                          4 -    Atualizar Informações de um Jogo");
            Console.WriteLine("                                          5 -            Excluir um jogo");
            Console.WriteLine("                                          C -             Limpar a tela");
            Console.WriteLine("                                          X -                  Sair");


            Console.Write("\n=> Sua escolha: ");
            option = Console.ReadLine();
            return option;
        }

        public string GetNameUser()
        {
            string name = "";
            Console.Clear();
            Console.WriteLine("                                                   Bem Vindo à Tseam.          ");
            Console.Write("\nInforme o seu nome: ");

            name = Console.ReadLine();
            return name;
        }
    }
}