namespace UniversityLearningSystem.Contracts
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        void Add(T user);

        T Get(int id);

        IEnumerable<T> GetAll();
    }
}