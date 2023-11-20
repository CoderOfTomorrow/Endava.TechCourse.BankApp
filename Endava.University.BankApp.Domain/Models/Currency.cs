using Endava.University.BankApp.Domain.Common;

namespace Endava.University.BankApp.Domain.Models
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ChangeRate { get; set; }
        public bool CanBeRemoved { get; set; } = true;
    }
}