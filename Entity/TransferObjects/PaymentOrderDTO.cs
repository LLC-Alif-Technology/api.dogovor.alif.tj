using Domain.Entities;

namespace Domain.TransferObjects
{
    public class PaymentOrderDTO
    {
        public List<PaymentOrder> PaymentOrder { get; set; }
        public List<PaymentTerm> PaymentTerm { get; set; }
    }
}
    