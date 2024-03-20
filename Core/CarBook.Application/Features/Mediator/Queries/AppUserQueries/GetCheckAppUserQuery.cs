using CarBook.Application.Features.Mediator.Results.AppUserResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.AppUserQueries
{
    public class GetCheckAppUserQuery : IRequest<GetCheckAppUserQueryResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
