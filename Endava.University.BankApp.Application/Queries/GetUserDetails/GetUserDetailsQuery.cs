using Endava.University.BankApp.Domain.Dtos;
using MediatR;

namespace Endava.University.BankApp.Application.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IRequest<UserDetails>
    {
        public string Username { get; set; }
    }
}