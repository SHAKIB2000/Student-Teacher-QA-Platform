using System;
using System.Linq;

namespace STPlatform.Domain.Entities
{
    public class Question : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public Guid StudentId { get; set; }
    }
}
