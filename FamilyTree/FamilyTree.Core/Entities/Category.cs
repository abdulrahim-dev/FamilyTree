using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Core.Entities.Foundation;

namespace FamilyTree.Core.Entities
{
    public class Category :BaseEntity
    {
        public string Name { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }
    }
}
