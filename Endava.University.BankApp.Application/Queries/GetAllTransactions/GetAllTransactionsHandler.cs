using Endava.University.BankApp.Domain.Models;
using Endava.University.BankApp.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Endava.University.BankApp.Application.Queries.GetAllTransactions
{
    public class GetAllTransactionsHandler : IRequestHandler<GetAllTransactionsQuery, IEnumerable<Transaction>>
    {
        private readonly ApplicationDbContext context;

        public GetAllTransactionsHandler(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            this.context = context;
        }

        public async Task<IEnumerable<Transaction>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
            => await context.Transactions.AsNoTracking().ToListAsync(cancellationToken);
    }
}