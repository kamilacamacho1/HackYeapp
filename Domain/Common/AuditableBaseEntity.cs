using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public int id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
