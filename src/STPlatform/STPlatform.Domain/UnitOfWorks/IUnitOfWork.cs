using System;
using System.Linq;

namespace STPlatform.Domain.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
