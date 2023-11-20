using MediatR;

namespace Endava.University.BankApp.Application.Commands.RemoveCurrency
{
    public class RemoveCurrencyCommand : IRequest<CommandStatus>
    {
        public string Id { get; set; }
    }
}