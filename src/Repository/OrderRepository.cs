using orderflow.views.Data;
using orderflow.views.Models;
using Microsoft.EntityFrameworkCore;

namespace orderflow.views.Repository;

/// <summary>
/// Implements the <see cref="IOrderRepository"/> interface for interacting with the Order data using Entity Framework.
/// </summary>
public class OrderRepository : IOrderRepository
{
    private readonly OrderFlowDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderRepository"/> class with the specified <see cref="OrderFlowDbContext"/>.
    /// </summary>
    /// <param name="context">The database context to interact with the database.</param>
    public OrderRepository(OrderFlowDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Retrieves all orders from the repository.
    /// </summary>
    /// <returns>A list of all orders.</returns>
    public async Task<IEnumerable<OrderModel>> GetAllOrdersAsync()
    {
        return await _context.Orders.ToListAsync();
    }


    /// <summary>
    /// Retrieves an order from the repository by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the order.</param>
    /// <returns>The order with the specified ID, or null if not found.</returns>
    public async Task<OrderModel?> GetOrderByIdAsync(int id)
    {
        return await _context.Orders.FindAsync(id);
    }


}

