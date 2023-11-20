using Endava.University.BankApp.Application.Queries.GetUser;

namespace Endava.University.BankApp.Tests.ApplicationTests.QueriesTests
{
    public class GetUserDetailsHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(GetUserHandler).GetConstructors());
    }
}