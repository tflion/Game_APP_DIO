using System;

namespace DIO.Games
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Views view = new Views();
            Functions use = new Functions();
            string option = "";
            
                  
            string name = view.GetNameUser(); // Início

            do
            {             
                option = view.InitialMenu(name);

                switch (option)
                {
                    case "1":
                        use.ShowGames(); // Mostra os jogos adicionados
                        break;
                    case "2":
                        use.ShowIdGame(); // Mostra o jogo informando o ID dele
                        break;
                    case "3":
                        use.InsertGame(); // Insere um jogo com seus dados
                        break;
                    case "4":
                        use.UpdateGame(); // Atualiza os dados de um jogo
                        break;
                    case "5":
                        use.DeleteGame(); // Deleta um jogo cadastrado
                        break;
                    case "C":
                        Console.Clear(); // Limpa o console
                        break;

                }

            } while (option.ToUpper() != "X");

        }     
    }
}
