using UnderwareStore.Core.Models;

namespace UnderwareStore.Core.Contracts
{
    public interface IOrderService
    {
        Task PlaceOrder(CustomerOrder order);
    }
}
