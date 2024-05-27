﻿
using CatalogService.Application.Queries.GetBookListBySpec;
using CatalogService.Domain.Aggregates;
using LinqSpecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Application.LinqSpecs.Factory
{
    public class BookSpecFactory : ISpecFactory<Book>
    {
        public Specification<Book> CreateSpecification(string? title,
            string? author,
            Genre genre,
            bool titleSpec,
            bool authorSpec,
            bool genreSpec,
            bool availabilitySpec)
        {
            Specification<Book> specification = new DefaultSpec();

            if (availabilitySpec)
            {
                specification = new AvailabilitySpec(true);
            }
            if (titleSpec)
            {
                specification = specification & new TittleSpec(title);
            }
            if (authorSpec)
            {
                specification = specification & new AuthorSpec(author);
            }
            if (genreSpec)
            {
                specification = specification & new GenreSpec(genre);
            }
            return specification;
        }
    }
}