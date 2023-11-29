using Endava.University.BankApp.Application.Queries;

namespace Endava.University.BankApp.Tests.ApplicationTests.QueriesTests
{
    public class GetAllCurrenciesHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(GetAllCurrenciesHandler).GetConstructors());
    }
}