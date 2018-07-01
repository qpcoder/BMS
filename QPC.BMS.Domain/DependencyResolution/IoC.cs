/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Helpers.Enum;
using StructureMap;

namespace QPC.BMS.Domain.DependencyResolution
{
    public class IoC
    {
        /// <summary>
        /// Kho chua cac dang ky cua lớp domain
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
