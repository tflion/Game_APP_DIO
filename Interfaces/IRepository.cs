using System.Collections.Generic;

namespace DIO.Games.Interfaces
{
    public interface IRepository<G>
    {
        List<G> List();

        G ReturnByID(int id);
        void Insert(G entity);
        void Delete(int id);
        void Update(int id, G entity);
        int NextID();

    }
}