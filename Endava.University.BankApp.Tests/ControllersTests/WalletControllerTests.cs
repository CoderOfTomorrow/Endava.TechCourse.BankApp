using Endava.University.BankApp.Application.Commands;
using Endava.University.BankApp.Application.Commands.CreateWallet;
using Endava.University.BankApp.Server.Controllers;
using Endava.University.BankApp.Shared;
using MediatR;
using NSubstitute;

namespace Endava.University.BankApp.Tests.ControllersTests
{
    public class WalletControllerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(WalletController).GetConstructors());

        [Test, ApplicationData]
        public async Task ShouldSendCreateWalletCommand(
            [Frozen] IMediator mediator,
            [Greedy] WalletController controller,
            WalletDto walletDto)
        {
            mediator.Send(Arg.Any<CreateWalletCommand>(), default).Returns(new CommandStatus());

            await controller.CreateWallet(walletDto);

            await mediator.Received(1).Send(Arg.Any<CreateWalletCommand>(), default);
        }
    }
}