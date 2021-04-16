using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Entities.Concrete
{
    public class BaseEntity
    {
        private Guid _id = Guid.NewGuid(); // For ID, I choose Guid method. Guid is a 128-bit integer (16 bytes) that can be used across all computers and networks wherever a unique identifier is required. Such an identifier has a very low probability of being duplicated.
        public Guid Id
        {
            get { return _id; }
            // set {}=> we don't need set method.
        }

        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
    }
}
