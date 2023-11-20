namespace Endava.University.BankApp.Tests.ControllersTests
{
    public class TransactionController
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(TransactionController).GetConstructors());
    }
}