using MediatR;

namespace Endava.University.BankApp.Application.Commands.CreateWallet
{
    public class CreateWalletCommand : IRequest<CommandStatus>
    {
        public string Currency { get; set; }
    }
}