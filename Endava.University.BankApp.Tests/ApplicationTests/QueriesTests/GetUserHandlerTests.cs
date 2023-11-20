using Endava.University.BankApp.Application.Queries.GetUserDetails;

namespace Endava.University.BankApp.Tests.ApplicationTests.QueriesTests
{
    public class GetUserHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(GetUserDetailsHandler).GetConstructors());
    }
}