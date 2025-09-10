using CrmApi.Models;
using CrmApi.Services;
using Microsoft.AspNetCore.Mvc;


using TaskModel = CrmApi.Models.Task;
using NoteModel = CrmApi.Models.Note;
using EventModel = CrmApi.Models.Event;

namespace CrmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ActivityService _service;

        public ActivityController(ActivityService service)
        {
            _service = service;
        }

        // ------------------- TASK -------------------
        [HttpGet("tasks")]
        public IActionResult GetAllTasks()
        {
            var tasks = _service.GetAllTasks();
            return Ok(tasks);
        }
        [HttpGet("{entityType}/{entityId}/tasks")]
        public IActionResult GetTasks(string entityType, Guid entityId) =>
            Ok(_service.GetTasks(entityType, entityId));

        [HttpPost("task")]
        public IActionResult AddTask(TaskModel task)
        {
            _service.AddTask(task);
            return Ok(task);
        }

        [HttpPut("task/{id}")]
        public IActionResult UpdateTask(Guid id, TaskModel task)
        {
            if (id != task.Id)
                return BadRequest("Task ID mismatch");

            var updated = _service.UpdateTask(task);
            if (!updated) return NotFound();

            return Ok(task);
        }

        [HttpDelete("task/{id}")]
        public IActionResult DeleteTask(Guid id)
        {
            var deleted = _service.DeleteTask(id);
            if (!deleted) return NotFound();

            return NoContent();
        }

        // ------------------- NOTE -------------------


        [HttpGet("notes")]
        public IActionResult GetAllNotes()
        {
            var notes = _service.GetAllNotes(); // Changed from GetTasks to GetNotes
            return Ok(notes);
        }

        [HttpGet("{entityType}/{entityId}/notes")]
        public IActionResult GetNotes(string entityType, Guid entityId) =>
            Ok(_service.GetNotes(entityType, entityId));

        [HttpPost("notes")] // Changed from "note" to "notes"
        public IActionResult AddNote(NoteModel note)
        {
            _service.AddNote(note);
            return Ok(note);
        }

        [HttpPut("notes/{id}")] // Changed from "note/{id}" to "notes/{id}"
        public IActionResult UpdateNote(Guid id, NoteModel note)
        {
            if (id != note.Id)
                return BadRequest("Note ID mismatch");

            var updated = _service.UpdateNote(note);
            if (!updated) return NotFound();

            return Ok(note);
        }

        [HttpDelete("notes/{id}")] // Changed from "note/{id}" to "notes/{id}"
        public IActionResult DeleteNote(Guid id)
        {
            var deleted = _service.DeleteNote(id);
            if (!deleted) return NotFound();

            return NoContent();
        }

        // ------------------- EVENT -------------------

        [HttpGet("events")]
        public IActionResult GetAllEvents()
        {
            var events = _service.GetAllEvents();
            return Ok(events);
        }

        [HttpGet("{entityType}/{entityId}/events")]
        public IActionResult GetEvents(string entityType, Guid entityId) =>
            Ok(_service.GetEvents(entityType, entityId));

        [HttpPost("event")]
        public IActionResult AddEvent(EventModel ev)
        {
            _service.AddEvent(ev);
            return Ok(ev);
        }

        [HttpPut("event/{id}")]
        public IActionResult UpdateEvent(Guid id, EventModel ev)
        {
            if (id != ev.Id)
                return BadRequest("Event ID mismatch");

            var updated = _service.UpdateEvent(ev);
            if (!updated) return NotFound();

            return Ok(ev);
        }

        [HttpDelete("event/{id}")]
        public IActionResult DeleteEvent(Guid id)
        {
            var deleted = _service.DeleteEvent(id);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
