/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Domain.DependencyResolution
{
    using StructureMap;

    public static class IoC
    {
        /// <summary>
        /// Kho chua cac dang ky cua bo Utility
        /// </summary>
        /// <returns></returns>
        public static IContainer Container()
        {
            Registry registry = new Registry();
            registry.IncludeRegistry<DomainRegistry>();
            Container container = new Container(registry);
            return container;
        }
    }
}
