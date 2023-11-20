using Endava.University.BankApp.Domain.Models;
using Endava.University.BankApp.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Endava.University.BankApp.Application.Queries.GetAllWallets
{
    public class GetAllWalletsHandler : IRequestHandler<GetAllWalletsQuery, IEnumerable<Wallet>>
    {
        private readonly ApplicationDbContext context;

        public GetAllWalletsHandler(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            this.context = context;
        }

        public async Task<IEnumerable<Wallet>> Handle(GetAllWalletsQuery request, CancellationToken cancellationToken)
            => await context.Wallets.AsNoTracking().ToListAsync(cancellationToken);
    }
}