using orderflow.views.Models;

namespace orderflow.views.Repository;

/// <summary>
/// Defines the contract for interacting with the Order data in the repository.
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// Retrieves all orders from the repository.
    /// </summary>
    /// <returns>A list of all orders.</returns>
    Task<IEnumerable<OrderModel>> GetAllOrdersAsync();

    /// <summary>
    /// Retrieves an order from the repository by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the order.</param>
    /// <returns>The order with the specified ID, or null if not found.</returns>
    Task<OrderModel?> GetOrderByIdAsync(int id);
}

