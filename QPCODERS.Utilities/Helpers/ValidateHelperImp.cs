/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPCODERS.Utilities.Helpers
{
    using log4net;
    using QPCODERS.Utilities.DependencyResolution;

    public class ValidateImp : IValidateHelper
    {
        /// <summary>
        /// Declare instance for log4net
        /// </summary>
        private readonly ILoggerHelper logger =
            IoC.Container().GetInstance<ILoggerHelper>();

        public bool Email(string inpEmail)
        {
            throw new System.NotImplementedException();
        }

        public bool Password(string inpPassword, out string outPasswordsEncrypted)
        {
            throw new System.NotImplementedException();
        }

        public bool Phone(string inpPhone, out int outPhone)
        {
            throw new System.NotImplementedException();
        }
    }
}
