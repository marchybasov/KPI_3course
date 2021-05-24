using System;

namespace EventLogger
{
    public class UnitOfWork : IDisposable
    {
        private EventDbContext context = new EventDbContext();
        private EfRepository<EventEntity> eventsRepository;

        public EfRepository<EventEntity> EventsRepositore
        {
            get
            {
                if (this.eventsRepository == null)
                {
                    this.eventsRepository = new EfRepository<EventEntity>(new EventDbContext());
                }
                return eventsRepository;
            }
        }

        public UnitOfWork()
        {

        }
        public UnitOfWork(EventDbContext ctx)
        {
            context = ctx;
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
