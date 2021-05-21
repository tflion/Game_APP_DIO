using System;

namespace DIO.Games
{
    public class Functions
    {
        static GameRepository repository = new GameRepository();

        public void ShowGames()
        {
            Console.Clear();
            Console.WriteLine("\n                                                    * Jogos no Catálogo *");
            Console.WriteLine("");

            var list = repository.List();


            if(list.Count == 0){
                Console.Clear();
                Console.WriteLine("                                     * Não há nenhum jogo cadastrado no momento! * ");
                Console.WriteLine("\n");
                Console.WriteLine("                              Selecione a opção [3] do Menu para adicionar um novo jogo. ");
                Console.WriteLine("\n");
                Console.WriteLine("                                       PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
                Console.ReadLine();
                return;
            }

            foreach(var jogo in list)
            {
                var available = jogo.returnDeleted();

                if(available)
                {
                    Console.WriteLine($"#ID {jogo.returnID()}: - {jogo.returnName()}  ( Preço: {jogo.returnPrice()} )");

                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("                                           PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
            Console.ReadLine();
        }

        public void InsertGame()
        {
            Console.Clear();
            Console.WriteLine("\n                                                    * Adicionar um novo jogo *");
            Console.WriteLine("");

            foreach (int i in Enum.GetValues(typeof(EGenre)))
            {
                Console.WriteLine("                                                          [{0}] - {1}", i, Enum.GetName(typeof(EGenre), i));
            }

            Console.Write("\nInforme o Gênero de acordo com as opções acima: ");
            int getGenGame = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do jogo: ");
            string getTitleGame = Console.ReadLine();

            Console.Write($"Informe o ano de lançamento de {getTitleGame}: ");
            int getYearGame = int.Parse(Console.ReadLine());

            Console.Write("Informe a descrição deste jogo: ");
            string getDescriptionGame = Console.ReadLine();

            Console.Write("Informe quem desenvolveu este jogo: ");
            string getDevGame = Console.ReadLine();

            Console.Write("Informe quem publicou este jogo: ");
            string getPubliGame = Console.ReadLine();

            Console.Write("Informe preço atual deste jogo: ");
            int getPriceGame = int.Parse(Console.ReadLine());

            Game newGame = new Game(id: repository.NextID(),
                                        genre: (EGenre)getGenGame,
                                        name: getTitleGame,
                                        relYear: getYearGame,
                                        description: getDescriptionGame,
                                        dev: getDevGame,
                                        publi: getPubliGame,
                                        price: getPriceGame);

            repository.Insert(newGame);


            Console.Clear();
            Console.WriteLine($"\n                                                  {newGame.returnName()} foi adicionado com sucesso ao catálogo. ");
            Console.WriteLine("\n");
            Console.WriteLine("                                              PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
            Console.ReadLine();
        }


        public void UpdateGame()
        {
            var list = repository.List();

            Console.Clear();
            Console.WriteLine("\n                                             * Atualizar informações de um  jogo *");

            foreach(var jogo in list)
            {
                var available = jogo.returnDeleted();

                if(available)
                {
                    Console.WriteLine($"#ID {jogo.returnID()}: - {jogo.returnName()}");
                }

            }
            
            Console.Write("\nDigite o ID da série a ser atualizada: ");
            int indiceGame = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\n                                                                  Gêneros: ");      
            Console.WriteLine("");
            foreach(int i in Enum.GetValues(typeof(EGenre))){
                Console.WriteLine("                                                          [{0}] - {1}", i, Enum.GetName(typeof(EGenre), i));
            }
            Console.Write("\nInforme o Gênero de acordo com as opções acima: ");
            int getGenGame = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do jogo: ");
            string getTitleGame = Console.ReadLine();

            Console.Write($"Informe o ano de lançamento de {getTitleGame}: ");
            int getYearGame = int.Parse(Console.ReadLine());

            Console.Write("Informe a descrição deste jogo: ");
            string getDescriptionGame = Console.ReadLine();

            Console.Write("Informe quem desenvolveu este jogo: ");
            string getDevGame = Console.ReadLine();

            Console.Write("Informe quem publicou este jogo: ");
            string getPubliGame = Console.ReadLine();

            Console.Write("Informe preço atual deste jogo: ");
            int getPriceGame = int.Parse(Console.ReadLine());

            Game updateGame = new Game(id: indiceGame,
                                        genre: (EGenre)getGenGame,
                                        name: getTitleGame,
                                        relYear: getYearGame,
                                        description: getDescriptionGame,
                                        dev: getDevGame,
                                        publi: getPubliGame,
                                        price: getPriceGame);

            repository.Update(indiceGame, updateGame);

            Console.Clear();
            Console.WriteLine($"\n                                    {updateGame.returnName()} foi atualizado com sucesso no catálogo. ");
            Console.WriteLine("\n");
            Console.WriteLine("                                              PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
            Console.ReadLine();
        }

        public void DeleteGame()
        {
            var list = repository.List();

            Console.Clear();
            Console.WriteLine("\n                                               * Deletar jogo selecionado *");

            foreach(var jogo in list)
            {
                var available = jogo.returnDeleted();

                if(available)
                {
                    Console.WriteLine($"#ID {jogo.returnID()}: - {jogo.returnName()}");
                }

            }

            Console.Write("\nInforme o ID do jogo a ser excluído: ");
            int indiceGame = int.Parse(Console.ReadLine());

            var game = repository.ReturnByID(indiceGame);

            Console.Clear();

            Console.Write($"\n\n                                         Tem certeza que deseja excluir o jogo a seguir?");          
            Console.Write("\n");
            Console.Write("\n");
            Console.Write(game);
            Console.Write("\n");
            Console.Write("\nSim [S] / Não [N]: ");
            string choice = Console.ReadLine().ToUpper();

            if(choice == "S")
            {
                repository.Delete(indiceGame);
                Console.Clear();
                Console.WriteLine($"\n                                                     Jogo excluído com sucesso! ");
                Console.WriteLine("\n");
                Console.WriteLine("                                             PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
                Console.ReadLine();
            }else{
                Console.Clear();
                Console.WriteLine($"\n                                                   Nenhum jogo deletado! ");
                Console.WriteLine("\n");
                Console.WriteLine("                                             PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
                Console.ReadLine();
            }
        }

        public void ShowIdGame()
        {
            var list = repository.List();

            Console.Clear();
            Console.WriteLine("                                                       * Visualizar um Jogo * ");
            Console.WriteLine("\n");

            foreach(var jogo in list)
            {             
                    Console.WriteLine($"#ID {jogo.returnID()}: - {jogo.returnName()}");

            }

            Console.Write("\nInforme o ID do jogo a ser visualizado: ");
            int indiceGame = int.Parse(Console.ReadLine());

            var game = repository.ReturnByID(indiceGame);

            Console.Clear();
            Console.WriteLine(game);
            Console.WriteLine("\n");
            Console.WriteLine("                                             PRESSIONE 'ENTER' PARA RETORNAR AO MENU!");
            Console.ReadLine();

            //TODO: Mostrar excluído sim ou não baseado em true or false.
        }
    }
}