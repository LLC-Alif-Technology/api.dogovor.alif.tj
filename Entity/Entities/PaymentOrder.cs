using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PaymentOrder
    {
        public int Id { get; set; }
        public string PaymentOrderName { get; set; }
    }
}
    