using Endava.University.BankApp.Domain.Models;
using MediatR;

namespace Endava.University.BankApp.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<User>
    {
        public string UserId { get; set; }
    }
}