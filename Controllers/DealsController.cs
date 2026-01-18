using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealsController : ControllerBase
{
    private readonly CrmDbContext _db;
    public DealsController(CrmDbContext db) => _db = db;

    // GET: api/deals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Deal>>> GetAll() =>
        await _db.Deals.OrderByDescending(x => x.CreatedAt).ToListAsync();

    // GET: api/deals/{id}
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Deal>> GetById(Guid id)
    {
        var deal = await _db.Deals.FindAsync(id);
        return deal is null ? NotFound() : deal;
    }

    // POST: api/deals
    [HttpPost]
    public async Task<ActionResult<Deal>> Create([FromBody] Deal input)
    {
        if (input.Id == Guid.Empty) input.Id = Guid.NewGuid();
        if (input.CreatedAt == default) input.CreatedAt = DateTime.UtcNow;

        _db.Deals.Add(input);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Deal input)
    {
        if (id != input.Id)
            return BadRequest("Deal ID mismatch.");

        var dbDeal = await _db.Deals.FindAsync(id);
        if (dbDeal is null)
            return NotFound();
        dbDeal.Title = input.Title;
        dbDeal.Stage = input.Stage;
        dbDeal.Amount = input.Amount;
        dbDeal.CloseDate = input.CloseDate;
        dbDeal.ContactId = input.ContactId;
        dbDeal.CompanyId = input.CompanyId;

        await _db.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/deals/{id}
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var dbDeal = await _db.Deals.FindAsync(id);
        if (dbDeal is null) return NotFound();

        _db.Deals.Remove(dbDeal);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
