using Endava.University.BankApp.Application.Commands.RegisterUser;

namespace Endava.University.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class RegisterUserHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(RegisterUserHandler).GetConstructors());
    }
}