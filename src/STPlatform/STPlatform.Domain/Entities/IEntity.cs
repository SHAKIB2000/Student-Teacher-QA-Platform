using System;
using System.Linq;

namespace STPlatform.Domain.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
