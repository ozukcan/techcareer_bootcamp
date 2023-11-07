using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Models
{
    public abstract class EntityBase<TId> //TId = Type of Id
    {
        public TId Id { get; set; }
    }
}
