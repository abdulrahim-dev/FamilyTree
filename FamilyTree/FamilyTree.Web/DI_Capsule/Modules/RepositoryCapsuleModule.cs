using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using FamilyTree.Core.Data.Repositories;
using FamilyTree.Data.Repositories;
using FamilyTree.Web.Mapping.References;

namespace FamilyTree.Web.DI_Capsule.Modules
{
    public class RepositoryCapsuleModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ReferencedAssemblies.Repositories).
                Where(_ => _.Name.EndsWith("Repository")).
                AsImplementedInterfaces().
                InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>)).InstancePerDependency();
        }

    }
}