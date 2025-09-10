using Microsoft.EntityFrameworkCore;

namespace CrmApi.Data
{
    public class IdentityDbContext<T1, T2, T3>
    {
        private DbContextOptions<CrmDbContext> options;

        public IdentityDbContext(DbContextOptions<CrmDbContext> options)
        {
            this.options = options;
        }

        internal void OnModelCreating(ModelBuilder b)
        {
            throw new NotImplementedException();
        }
    }
}