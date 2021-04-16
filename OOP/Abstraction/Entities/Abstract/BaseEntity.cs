using Abstraction.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Abstract
{
    public abstract class BaseEntity // If we want BaseEntity.cs class to be an abstract class, we must mark it as abstract.
    {
        public abstract Guid  Id { get; set; } // I marked it as an abstract class because I wanted Id to be override in the child class which is Car.cs.

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        private Status _status = Status.Active;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
