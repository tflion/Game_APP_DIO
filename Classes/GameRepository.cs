using System.Collections.Generic;
using DIO.Games.Interfaces;

namespace DIO.Games
{
    public class GameRepository : IRepository<Game>
    {
        
        public List<Game> gameList = new List<Game>();
        
        public void Update(int id,Game obj)
        {
            gameList[id] = obj;
        }

        public void Delete(int id)
        {
            gameList[id].Inative();
        }

        public void Insert(Game obj)
        {
            gameList.Add(obj);
        }

        public List<Game> List()
        {
            return gameList;
        }

        public Game ReturnByID(int id)
        {
            return gameList[id];
        }


        public int NextID()
        {
            return gameList.Count;
        }

    }
}