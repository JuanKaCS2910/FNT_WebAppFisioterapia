using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Common.DependencyResolver
{
    public class DependencyResolver
    {
        public static UnityContainer DIContainer()
        {
            var container = new UnityContainer();

            return container;
        }

    }
}
