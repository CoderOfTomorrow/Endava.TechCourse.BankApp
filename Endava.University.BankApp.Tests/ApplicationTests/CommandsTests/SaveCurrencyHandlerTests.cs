using Endava.University.BankApp.Application.Commands.SaveCurrency;

namespace Endava.University.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class SaveCurrencyHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(SavecurrencyHandler).GetConstructors());
    }
}