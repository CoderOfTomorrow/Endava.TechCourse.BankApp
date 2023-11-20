using MediatR;

namespace Endava.University.BankApp.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<CommandStatus>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}