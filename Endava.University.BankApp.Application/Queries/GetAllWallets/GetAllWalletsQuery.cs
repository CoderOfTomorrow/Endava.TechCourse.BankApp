using Endava.University.BankApp.Domain.Models;
using MediatR;

namespace Endava.University.BankApp.Application.Queries.GetAllWallets
{
    public class GetAllWalletsQuery : IRequest<IEnumerable<Wallet>>
    {
    }
}