/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    public interface IAccountRepository
    {
        #region Table Account

        /// <summary>
        /// Get all accounts
        /// </summary>
        /// <returns>list accounts</returns>
        IEnumerable<Account> GetAllAccounts();

        /// <summary>
        /// Get account by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list accounts</returns>
        IEnumerable<Account> GetAccount(Func<Account, bool> expression);

        /// <summary>
        /// Get account by id
        /// </summary>
        /// <param name="roleID">account id</param>
        /// <returns>object account</returns>
        Account GetAccount(int accountID);

        /// <summary>
        /// Insert object into account
        /// </summary>
        /// <param name="models">object account</param>
        /// <returns>true or false</returns>
        Boolean SetAccount(Account models);

        /// <summary>
        /// Update account by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditAccount(Func<Account, bool> expression);

        /// <summary>
        /// Update account by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditAccount(Account modelEdit);

        /// <summary>
        /// Delete account by ID
        /// </summary>
        /// <param name="accountID">account id</param>
        /// <returns>true or false</returns>
        Boolean DeleteAccount(int accountID);

        /// <summary>
        /// Delete account by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteAccount(Func<Account, bool> expression);

        #endregion

        #region Table Role

        /// <summary>
        /// Get all roles
        /// </summary>
        /// <returns>list roles</returns>
        IEnumerable<Role> GetAllRoles();

        /// <summary>
        /// Get role by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list roles</returns>
        IEnumerable<Role> GetRole(Func<Role, bool> expression);

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="roleID">role id</param>
        /// <returns>object role</returns>
        Role GetRole(int roleID);

        /// <summary>
        /// Insert object into role
        /// </summary>
        /// <param name="models">object role</param>
        /// <returns>true or false</returns>
        Boolean SetRole(Role models);

        /// <summary>
        /// Update role by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditRole(Func<Role, bool> expression);

        /// <summary>
        /// Update role by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditRole(Role modelEdit);

        /// <summary>
        /// Delete role by ID
        /// </summary>
        /// <param name="roleID">role id</param>
        /// <returns>true or false</returns>
        Boolean DeleteRole(int roleID);

        /// <summary>
        /// Delete role by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteRole(Func<Role, bool> expression);

        #endregion

        #region Table Module

        /// <summary>
        /// Get all modules
        /// </summary>
        /// <returns>list modules</returns>
        IEnumerable<Module> GetAllModules();

        /// <summary>
        /// Get module by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list modules</returns>
        IEnumerable<Module> GetModule(Func<Module, bool> expression);

        /// <summary>
        /// Get module by id
        /// </summary>
        /// <param name="moduleID">module id</param>
        /// <returns>object module</returns>
        Module GetModule(int moduleID);

        /// <summary>
        /// Insert object into module
        /// </summary>
        /// <param name="models">object module</param>
        /// <returns>true or false</returns>
        Boolean SetModule(Module models);

        /// <summary>
        /// Update module by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditModule(Func<Module, bool> expression);

        /// <summary>
        /// Update module by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditModule(Module modelEdit);

        /// <summary>
        /// Delete module by ID
        /// </summary>
        /// <param name="moduleID">module id</param>
        /// <returns>true or false</returns>
        Boolean DeleteModule(int moduleID);

        /// <summary>
        /// Delete module by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteModule(Func<Module, bool> expression);

        #endregion

        #region Table Authorization

        /// <summary>
        /// Get all authorizations
        /// </summary>
        /// <returns>list authorizations</returns>
        IEnumerable<Authorization> GetAllAuthorizations();

        /// <summary>
        /// Get authorization by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list authorizations</returns>
        IEnumerable<Authorization> GetAuthorization(Func<Authorization, bool> expression);

        /// <summary>
        /// Get authorization by id
        /// </summary>
        /// <param name="authorizationID">authorization id</param>
        /// <returns>object authorization</returns>
        Authorization GetAuthorization(Guid authorizationID);

        /// <summary>
        /// Insert object into authorization
        /// </summary>
        /// <param name="models">object authorization</param>
        /// <returns>true or false</returns>
        Boolean SetAuthorization(Authorization models);

        /// <summary>
        /// Update authorization by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditAuthorization(Func<Authorization, bool> expression);

        /// <summary>
        /// Update authorization by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditAuthorization(Authorization modelEdit);

        /// <summary>
        /// Delete authorization by ID
        /// </summary>
        /// <param name="authorizationID">authorization id</param>
        /// <returns>true or false</returns>
        Boolean DeleteAuthorization(Guid authorizationID);

        /// <summary>
        /// Delete authorization by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteAuthorization(Func<Authorization, bool> expression);

        /// <summary>
        /// Delete all authorizations
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllAuthorizations();

        #endregion
    }
}
