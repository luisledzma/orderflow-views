using orderflow.views.Models;
using orderflow.views.Repository;

namespace orderflow.views.Services;

/// <summary>
/// Service class that handles business logic and operations related to orders.
/// </summary>
public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderService"/> class.
    /// </summary>
    /// <param name="orderRepository">The repository instance for order data access.</param>
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    /// <summary>
    /// Retrieves all orders.
    /// </summary>
    /// <returns>A list of all Order objects.</returns>
    public async Task<IEnumerable<OrderModel>> GetAllOrdersAsync()
    {
        return await _orderRepository.GetAllOrdersAsync();
    }

    /// <summary>
    /// Retrieves a specific order by ID.
    /// </summary>
    /// <param name="id">The ID of the order to retrieve.</param>
    /// <returns>The Order object if found, otherwise null.</returns>
    public async Task<OrderModel?> GetOrderByIdAsync(int id)
    {
        return await _orderRepository.GetOrderByIdAsync(id);
    }
}
