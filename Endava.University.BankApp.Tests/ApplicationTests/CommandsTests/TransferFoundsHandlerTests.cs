using Endava.University.BankApp.Application.Commands.TransferFounds;

namespace Endava.University.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class TransferFoundsHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(TransferFoundsHandler).GetConstructors());
    }
}