/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Helpers
{
    using QPC.BMS.Helpers.DependencyResolution;
    using QPC.BMS.Helpers.Enum;

    public class ValidateHelperImp : IValidateHelper
    {
        /// <summary>
        /// Declare instance for log4net
        /// </summary>
        private readonly ILoggingHelper logger =
            IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

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
