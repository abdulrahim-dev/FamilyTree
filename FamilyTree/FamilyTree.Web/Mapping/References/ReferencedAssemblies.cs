using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FamilyTree.Web.Mapping.References
{
    public static class ReferencedAssemblies
    {
        public static Assembly Services
        {
            get { return Assembly.Load("FamilyTree.Services"); }
        }

        public static Assembly Repositories
        {
            get { return Assembly.Load("FamilyTree.Data"); }
        }

        public static Assembly Dto
        {
            get
            {
                return Assembly.Load("FamilyTree.Dto");
            }
        }

        public static Assembly Domain
        {
            get
            {
                return Assembly.Load("FamilyTree.Core");
            }
        }
    }
}