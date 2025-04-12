using orderflow.views.Models;

namespace orderflow.views.Services;
public interface IOrderService
{
    /// <summary>
    /// Retrieves all orders.
    /// </summary>
    /// <returns>A list of all Order objects.</returns>
    Task<IEnumerable<OrderModel>> GetAllOrdersAsync();

    /// <summary>
    /// Retrieves a specific order by ID.
    /// </summary>
    /// <param name="id">The ID of the order to retrieve.</param>
    /// <returns>The Order object if found, otherwise null.</returns>
    Task<OrderModel?> GetOrderByIdAsync(int id);
}