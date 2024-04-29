using BookStore.Domain.Entities;
using BookStore.Domain.Entities.Auth;
using MediatR;

namespace BookStore.Application.useCases.Users.Queries
{
    public class GetAllNewUsersQuery : IRequest<List<User>>
    {
    }
}
