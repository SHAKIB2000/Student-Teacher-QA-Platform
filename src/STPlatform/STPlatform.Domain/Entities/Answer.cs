using System;
using System.Linq;

namespace STPlatform.Domain.Entities
{
    public class Answer : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public Guid TeacherId { get; set; }
        public Guid QuestionId { get; set; }
    }
}
