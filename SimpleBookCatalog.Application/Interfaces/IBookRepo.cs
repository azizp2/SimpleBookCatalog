﻿using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Application.Interfaces
{
    public interface IBookRepo
    {
        Task AddAsync(Book book);
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}
