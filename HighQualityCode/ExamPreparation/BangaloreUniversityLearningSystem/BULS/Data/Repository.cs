﻿namespace UniversityLearningSystem.Data
{
    using System;
    using System.Collections.Generic;

    using UniversityLearningSystem.Contracts;

    public class Repository<T> : IRepository<T>
    {
        private List<T> items;

        public Repository()
        {
            this.items = new List<T>();
        }

        public IEnumerable<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.items;
        }

        public virtual T Get(int id)
        {
            T item;
            try
            {
                item = this.items[id - 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                item = default(T);
            }

            return item;
        }

        public virtual void Add(T user)
        {
            this.items.Add(user);
        }
    }
}