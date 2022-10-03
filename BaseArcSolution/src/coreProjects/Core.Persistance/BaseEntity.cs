using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public BaseEntity()
        {
        }

        public BaseEntity(string id) : this()
        {
            Id = id;
        }
    }
}
