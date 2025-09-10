using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LeadsController : ControllerBase
{
    private readonly CrmDbContext _db;
    public LeadsController(CrmDbContext db) => _db = db;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lead>>> GetAll() =>
        await _db.Leads.OrderByDescending(x => x.CreatedAt).ToListAsync();

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Lead>> GetById(Guid id)
    {
        var lead = await _db.Leads.FindAsync(id);
        return lead is null ? NotFound() : lead;
    }

    [HttpPost]
    public async Task<ActionResult<Lead>> Create([FromBody] Lead input)
    {
        // If client didn’t send Id, generate it
        if (input.Id == Guid.Empty) input.Id = Guid.NewGuid();
        _db.Leads.Add(input);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Lead input)
    {
        if (id != input.Id) return BadRequest("ID in URL and body do not match.");
        var dbLead = await _db.Leads.FindAsync(id);
        if (dbLead is null) return NotFound();
        dbLead.Name = input.Name;
        dbLead.Email = input.Email;
        dbLead.Phone = input.Phone;
        dbLead.Status = input.Status;
        dbLead.Source = input.Source;
        dbLead.Product = input.Product;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var dbLead = await _db.Leads.FindAsync(id);
        if (dbLead is null) return NotFound();
        _db.Leads.Remove(dbLead);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
