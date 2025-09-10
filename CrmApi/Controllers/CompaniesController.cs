using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly CrmDbContext _db;
    public CompaniesController(CrmDbContext db) => _db = db;

    // GET: api/companies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Company>>> GetAll() =>
        await _db.Companies.OrderByDescending(x => x.CreatedAt).ToListAsync();

    // GET: api/companies/{id}
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Company>> GetById(Guid id)
    {
        var company = await _db.Companies.FindAsync(id);
        return company is null ? NotFound() : company;
    }

    // POST: api/companies
    [HttpPost]
    public async Task<ActionResult<Company>> Create([FromBody] Company input)
    {
        if (input.Id == Guid.Empty) input.Id = Guid.NewGuid();
        if (input.CreatedAt == default) input.CreatedAt = DateTime.UtcNow;

        _db.Companies.Add(input);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Company input)
    {
        if (id != input.Id)
            return BadRequest("Company ID mismatch.");

        var dbCompany = await _db.Companies.FindAsync(id);
        if (dbCompany is null)
            return NotFound();

        // Update fields (keep CreatedAt as is)
        dbCompany.Name = input.Name;
        dbCompany.Industry = input.Industry;
        dbCompany.Website = input.Website;
        dbCompany.CreatedAt = dbCompany.CreatedAt; 

        await _db.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/companies/{id}
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var dbCompany = await _db.Companies.FindAsync(id);
        if (dbCompany is null) return NotFound();

        _db.Companies.Remove(dbCompany);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
