﻿using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
    {
        public int Id { get; set; }
        public GetBlogByAuthorIdQuery(int id)
        {
            Id = id;
        }
    }
}
