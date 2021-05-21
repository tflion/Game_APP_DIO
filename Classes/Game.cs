using System;

namespace DIO.Games
{
    public class Game : Base
    {
        private EGenre Genre {get; set;} // Genero
        private string Name {get; set;} // Nome
        private string Description { get; set; } // Descrição
        private int ReleaseYear { get; set; } // Ano de lançamento
        private string Developer { get; set; } // Desenvolvedor
        private string Publisher { get; set; } // Editora
        private int Price { get; set; } // Preço
        private bool Available {get; set;}
        
        public Game(int id, EGenre genre, string name, string description, int relYear, string dev, string publi,int price)
        {
            this.Id = id;
            this.Genre = genre;
            this.Name = name;
            this.Description = description;
            this.ReleaseYear = relYear;
            this.Developer = dev;
            this.Publisher = publi;
            this.Price = price;
            this.Available = true;
        }

        public override string ToString()
        {
            string _return = "";

            _return += "                                                  * " + this.Name.ToUpper() + " * " + Environment.NewLine;
            _return += "\n";
            _return += "Gênero: " + this.Genre + Environment.NewLine;
            _return += "Descrição: " + this.Description + Environment.NewLine;
            _return += "Ano de lançamento: " + this.ReleaseYear + Environment.NewLine;
            _return += "Desenvolvedor(a): " + this.Developer + Environment.NewLine;
            _return += "Publicado por: " + this.Publisher + Environment.NewLine;
            _return += "Preço atual: " + this.Price + Environment.NewLine; 

            string available = AvailableVerify();
            _return += "Disponível: " + available;

            return _return;

        }

        private string AvailableVerify()
        {
            string available = "";

            if (this.Available == true)
            {
                available = "Sim";
            }
            else
            {
                available = "Não";
            }

            return available;
        }

        public string returnName(){
            return this.Name;
        }

        public int returnID(){
            return this.Id;
        }
        public int returnPrice(){
            return this.Price;
        }
        public bool returnDeleted(){
            return this.Available;
            
        }
        public void Inative()
        {
            this.Available = false;
        }
    }
        
}