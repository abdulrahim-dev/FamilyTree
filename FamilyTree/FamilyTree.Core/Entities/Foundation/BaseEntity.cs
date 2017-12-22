using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Core.Entities.Foundation
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
