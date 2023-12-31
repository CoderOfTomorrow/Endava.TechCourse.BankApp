﻿using Endava.University.BankApp.Application.Queries.GetAllWallets;
using Endava.University.BankApp.Domain.Models;
using Endava.University.BankApp.Infrastructure.Persistence;

namespace Endava.University.BankApp.Tests.ApplicationTests.QueriesTests
{
    public class GetAllWalettsHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(GetAllWalletsHandler).GetConstructors());

        [Test, ApplicationData]
        public async Task ShouldGetAllWallets(
            [Frozen] ApplicationDbContext context,
            GetAllWalletsQuery query,
            GetAllWalletsHandler handler,
            Wallet wallet)
        {
            context.Add(wallet);
            context.SaveChanges();

            var result = await handler.Handle(query, default);

            using (new AssertionScope())
            {
                result.Count().Should().Be(1);
                result.Should().ContainEquivalentOf(wallet);
            }
        }
    }
}