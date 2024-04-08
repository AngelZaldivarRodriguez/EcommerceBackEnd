using Core.Entitites.OrderAggregate;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class OrderByPaymentsIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentsIntentIdSpecification(string paymentIntentId) : 
            base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}
