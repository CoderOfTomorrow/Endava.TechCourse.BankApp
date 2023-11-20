using Endava.University.BankApp.Domain.Models;
using MediatR;

namespace Endava.University.BankApp.Application.Queries
{
    public class GetAllCurrenciesQuery : IRequest<IEnumerable<Currency>>
    {
    }
}