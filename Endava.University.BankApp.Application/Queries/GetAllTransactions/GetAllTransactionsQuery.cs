using Endava.University.BankApp.Domain.Models;
using MediatR;

namespace Endava.University.BankApp.Application.Queries.GetAllTransactions
{
    public class GetAllTransactionsQuery : IRequest<IEnumerable<Transaction>>
    {
    }
}