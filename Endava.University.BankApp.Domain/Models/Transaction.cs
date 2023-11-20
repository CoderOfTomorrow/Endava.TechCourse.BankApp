using Endava.University.BankApp.Domain.Common;

namespace Endava.University.BankApp.Domain.Models
{
    public class Transaction : BaseEntity
    {
        public Guid SourceWalletId { get; set; }
        public Guid DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime TransactionTime { get; set; }
    }
}