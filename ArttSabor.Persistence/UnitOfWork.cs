using ArttSabor.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArttSabor.Persistence
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationContext applicationContext;
        private bool disposed;

        public UnitOfWork(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
