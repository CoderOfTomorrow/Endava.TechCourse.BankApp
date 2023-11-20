using Endava.University.BankApp.Server.Controllers;

namespace Endava.University.BankApp.Tests.ControllersTests
{
    public class AccountControllerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(AccountController).GetConstructors());
    }
}