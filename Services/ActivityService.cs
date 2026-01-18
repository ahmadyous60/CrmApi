using CrmApi.Data;
using CrmApi.Models;

namespace CrmApi.Services
{
    public class ActivityService
    {
        private readonly CrmDbContext _context;

        public ActivityService(CrmDbContext context)
        {
            _context = context;
        }

        // ------------------- TASK -------------------

        public IEnumerable<Models.Task> GetTasks(string entityType, Guid entityId)
        {
            return _context.Tasks
                .Where(t => t.EntityType == entityType && t.EntityId == entityId)
                .ToList();
        }

        public void AddTask(Models.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public bool UpdateTask(Models.Task task)
        {
            var existing = _context.Tasks.Find(task.Id);
            if (existing == null) return false;

            _context.Entry(existing).CurrentValues.SetValues(task);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteTask(Guid id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return false;

            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<Models.Task> GetAllTasks()
        {
            return _context.Tasks.ToList(); 
        }
        // ------------------- NOTE -------------------

        public IEnumerable<Note> GetNotes(string entityType, Guid entityId)
        {
            return _context.Notes
                .Where(n => n.EntityType == entityType && n.EntityId == entityId)
                .ToList();
        }

        public void AddNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public bool UpdateNote(Note note)
        {
            var existing = _context.Notes.Find(note.Id);
            if (existing == null) return false;

            _context.Entry(existing).CurrentValues.SetValues(note);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteNote(Guid id)
        {
            var note = _context.Notes.Find(id);
            if (note == null) return false;

            _context.Notes.Remove(note);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _context.Notes.ToList();
            return notes;
        }
        // ------------------- EVENT -------------------

        public IEnumerable<Event> GetEvents(string entityType, Guid entityId)
        {
            return _context.Events
                .Where(e => e.EntityType == entityType && e.EntityId == entityId)
                .ToList();
        }

        public void AddEvent(Event ev)
        {
            _context.Events.Add(ev);
            _context.SaveChanges();
        }

        public bool UpdateEvent(Event ev)
        {
            var existing = _context.Events.Find(ev.Id);
            if (existing == null) return false;

            _context.Entry(existing).CurrentValues.SetValues(ev);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteEvent(Guid id)
        {
            var ev = _context.Events.Find(id);
            if (ev == null) return false;

            _context.Events.Remove(ev);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }
    }
}
