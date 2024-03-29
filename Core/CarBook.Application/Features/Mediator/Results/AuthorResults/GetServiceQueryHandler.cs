﻿using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Results.AuthorResults
{
    public class GetServiceQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        public GetServiceQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Name = x.Name,
                AuthorID = x.AuthorID,
                ImageUrl = x.ImageUrl,
                Description = x.Description
            }).ToList();
        }
    }
}
