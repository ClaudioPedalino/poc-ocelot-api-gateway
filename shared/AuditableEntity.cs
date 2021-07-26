using System;
using System.ComponentModel.DataAnnotations;

namespace book_api.Entities
{
    public abstract class AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime DeleteAt { get; set; }
        public string DeleteBy { get; set; }
        public bool IsDelete { get; set; }
    }
}