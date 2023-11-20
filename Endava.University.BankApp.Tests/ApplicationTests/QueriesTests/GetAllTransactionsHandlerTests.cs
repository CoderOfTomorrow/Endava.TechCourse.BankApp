using Endava.University.BankApp.Application.Queries.GetAllTransactions;
using Endava.University.BankApp.Domain.Models;
using Endava.University.BankApp.Infrastructure.Persistence;

namespace Endava.University.BankApp.Tests.ApplicationTests.QueriesTests
{
    public class GetAllTransactionsHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(GetAllTransactionsHandler).GetConstructors());

        [Test, ApplicationData]
        public async Task ShouldGetAllTransactions(
            [Frozen] ApplicationDbContext context,
            GetAllTransactionsQuery query,
            GetAllTransactionsHandler handler,
            Transaction transaction)
        {
            context.Add(transaction);
            context.SaveChanges();

            var result = await handler.Handle(query, default);

            using (new AssertionScope())
            {
                result.Count().Should().Be(1);
                result.Should().ContainEquivalentOf(transaction);
            }
        }
    }
}