﻿namespace AdsMicroService.Service
{
    public interface IRepository<T> where T : class
    {
        public T GetById(int id);
        public IReadOnlyCollection<T> GetProducts();
    }
}
