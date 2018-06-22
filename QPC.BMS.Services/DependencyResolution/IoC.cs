/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services.DependencyResolution
{
    using StructureMap;

    public class IoC
    {
        /// <summary>
        /// Kho chua cac dang ky cua bo Services
        /// </summary>
        /// <returns></returns>
        public static IContainer Container()
        {
            Registry registry = new Registry();
            registry.IncludeRegistry<ServicesRegistry>();
            Container container = new Container(registry);
            return container;
        }
    }
}
