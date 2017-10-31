using TesteHandsonCurriculum.Infra.Data.Context;
using System;

namespace TesteHandsonCurriculum.Infra.Data.IoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HandsOnAspNETContext _context;
        private bool _disposed;

        public UnitOfWork(HandsOnAspNETContext context)
        {
            _context = context;
            _disposed = false;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}