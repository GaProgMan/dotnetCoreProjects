using System;

namespace HiFive.Models
{
    public class AuditRecord
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class HiFiveRecord : AuditRecord
    {
        public int Id { get; set; }
        public string HiFiver { get; set; }
    }
}