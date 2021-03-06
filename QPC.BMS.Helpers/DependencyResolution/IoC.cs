﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Helpers.DependencyResolution
{
    using StructureMap;

    /// <summary>
    /// Handle IoC in project for structure map
    /// </summary>
    public class IoC
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <returns></returns>
        public static IContainer Container()
        {
            Registry registry = new Registry();
            registry.IncludeRegistry<HelperRegistry>();
            Container container = new Container(registry);
            return container;
        }
    }
}
