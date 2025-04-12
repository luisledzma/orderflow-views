using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using orderflow.views.Models;
using orderflow.views.Services;

namespace orderflow.views.Controllers;

/// <summary>
/// This controller provides CRUD operations for this microservice.
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/views/order")]
[ApiVersion("1.0")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderController"/> class.
    /// </summary>
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    /// <summary>
    /// Retrieves all orders.
    /// </summary>
    /// <returns>A list of all orders.</returns>
    [HttpGet("read/all")]
    [Authorize]
    [ProducesResponseType(typeof(IEnumerable<OrderModel>), 200)]
    public async Task<IActionResult> GetOrders()
    {
        var orders = await _orderService.GetAllOrdersAsync();
        return Ok(orders);
    }

    /// <summary>
    /// Retrieves a specific order by its ID.
    /// </summary>
    /// <param name="id">The ID of the order to retrieve.</param>
    /// <returns>The order if found, or 404 if not found.</returns>
    [HttpGet("read/{id}")]
    [Authorize]
    [ProducesResponseType(typeof(OrderModel), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetOrderById(int id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }


}
