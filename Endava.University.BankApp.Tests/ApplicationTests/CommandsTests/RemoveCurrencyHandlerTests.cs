using Endava.University.BankApp.Application.Commands.RemoveCurrency;

namespace Endava.University.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class RemoveCurrencyHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(RemoveCurrencyHandler).GetConstructors());
    }
}