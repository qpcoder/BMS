/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository.EF;

    /// <summary>
    /// Implementation interface IAccountRepository
    /// </summary>
    public class AccountRepositoryImp : IAccountRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        public readonly ILoggingHelper logger =
            QPC.BMS.Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

        /// <summary>
        /// Handle instance connection to database
        /// </summary>
        private BMSContext context = new BMSContext();

        public bool DeleteAccountByExpression(Func<Account, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //change status of account is deleted


            //log release method
            logger.ReleaseMethod();
            return true;
        }

        public bool DeleteAccountByID(Guid accountID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllAccounts()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllAuthorizations()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllModules()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllRoles()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuthorizationByExpression(Func<Authorization, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuthorizationByID(Guid authorizationID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteModuleByExpression(Func<Module, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteModuleByID(Guid moduleID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoleByExpression(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoleByID(Guid roleID)
        {
            throw new NotImplementedException();
        }

        public bool EditAccountByExpression(Func<Account, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditAccountByObject(Account modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditAuthorizationByExpression(Func<Authorization, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditAuthorizationByObject(Authorization modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditModuleByExpression(Func<Module, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditModuleByObject(Module modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditRoleByExpression(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditRoleByObject(Role modelEdit)
        {
            throw new NotImplementedException();
        }

        public Comment GetAccountByID(Guid accountID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAccountsByExpression(Func<Account, bool> expression)
        {
            ///log enter method
            logger.EnterMethod();
            ///log release method
            logger.ReleaseMethod();
            return context.Accounts.Where(expression).ToList();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Authorization> GetAllAuthorizations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Module> GetAllModules()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public Authorization GetAuthorizationByID(Guid authorizationID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Authorization> GetAuthorizationsByExpression(Func<Authorization, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Module GetModuleByID(Module moduleID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Module> GetModulesByExpression(Func<Module, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Role GetRoleByID(Guid roleID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetRolesByExpression(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool SetAccount(Account models)
        {
            throw new NotImplementedException();
        }

        public bool SetAuthorization(Authorization models)
        {
            throw new NotImplementedException();
        }

        public bool SetListAccounts(List<Account> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListAuthorizations(List<Authorization> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListModules(List<Module> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListRoles(List<Role> models)
        {
            throw new NotImplementedException();
        }

        public bool SetModule(Module models)
        {
            throw new NotImplementedException();
        }

        public bool SetRole(Role models)
        {
            throw new NotImplementedException();
        }
    }
}
