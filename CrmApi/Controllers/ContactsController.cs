using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly CrmDbContext _db;
    public ContactsController(CrmDbContext db) => _db = db;

    // GET: api/contacts
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contact>>> GetAll() =>
        await _db.Contacts.OrderByDescending(x => x.CreatedAt).ToListAsync();

    // GET: api/contacts/{id}
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Contact>> GetById(Guid id)
    {
        var contact = await _db.Contacts.FindAsync(id);
        return contact is null ? NotFound() : contact;
    }

    // POST: api/contacts
    [HttpPost]
    public async Task<ActionResult<Contact>> Create([FromBody] Contact input)
    {
        if (input.Id == Guid.Empty) input.Id = Guid.NewGuid();
        if (input.CreatedAt == default) input.CreatedAt = DateTime.UtcNow;

        _db.Contacts.Add(input);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }


    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Contact input)
    {
        if (id != input.Id)
            return BadRequest("Contact ID mismatch.");

        var dbContact = await _db.Contacts.FindAsync(id);
        if (dbContact is null)
            return NotFound();

        // Update fields
        dbContact.FirstName = input.FirstName;
        dbContact.LastName = input.LastName;
        dbContact.Email = input.Email;
        dbContact.Mobile = input.Mobile;
        dbContact.Dob = input.Dob;
        dbContact.ReportingTo = input.ReportingTo;

        dbContact.MailingStreet = input.MailingStreet;
        dbContact.OtherStreet = input.OtherStreet;
        dbContact.MailingCity = input.MailingCity;
        dbContact.OtherCity = input.OtherCity;
        dbContact.MailingState = input.MailingState;
        dbContact.OtherState = input.OtherState;
        dbContact.MailingZip = input.MailingZip;
        dbContact.MailingCountry = input.MailingCountry;

        dbContact.CompanyId = input.CompanyId;
        // keep CreatedAt unchanged
        dbContact.CreatedAt = dbContact.CreatedAt;

        await _db.SaveChangesAsync();

        return NoContent();
    }
    // DELETE: api/contacts/{id}
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var dbContact = await _db.Contacts.FindAsync(id);
        if (dbContact is null) return NotFound();

        _db.Contacts.Remove(dbContact);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
