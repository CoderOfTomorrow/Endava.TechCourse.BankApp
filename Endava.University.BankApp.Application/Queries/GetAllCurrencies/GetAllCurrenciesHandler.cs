using Endava.University.BankApp.Domain.Models;
using Endava.University.BankApp.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Endava.University.BankApp.Application.Queries
{
    public class GetAllCurrenciesHandler : IRequestHandler<GetAllCurrenciesQuery, IEnumerable<Currency>>
    {
        private readonly ApplicationDbContext context;

        public GetAllCurrenciesHandler(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            this.context = context;
        }

        public async Task<IEnumerable<Currency>> Handle(GetAllCurrenciesQuery request, CancellationToken cancellationToken)
            => await context.Currencies.AsNoTracking().ToListAsync(cancellationToken);
    }
}