﻿using CatalogService.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Domain.Aggregates.AuthorAggregate
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author Add(Author author);

        void Update(Author author);

        Task<Author> GetAsync(int authorId);
        void Delete(Author author);
    }
}
