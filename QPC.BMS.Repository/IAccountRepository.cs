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
        IEnumerable<Account> GetAccountsByExpression(Func<Account, bool> expression);

        /// <summary>
        /// Get account by id
        /// </summary>
        /// <param name="roleID">account id</param>
        /// <returns>object account</returns>
        Comment GetAccountByID(Guid accountID);

        /// <summary>
        /// Insert list account into database
        /// </summary>
        /// <param name="models">list accounts</param>
        /// <returns>true or false</returns>
        Boolean SetListAccounts(List<Account> models);

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
        Boolean EditAccountByExpression(Func<Account, bool> expression);

        /// <summary>
        /// Update account by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditAccountByObject(Account modelEdit);

        /// <summary>
        /// Delete account by ID
        /// </summary>
        /// <param name="accountID">account id</param>
        /// <returns>true or false</returns>
        Boolean DeleteAccountByID(Guid accountID);

        /// <summary>
        /// Delete account by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteAccountByExpression(Func<Account, bool> expression);

        /// <summary>
        /// Delete all accounts
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllAccounts();

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
        IEnumerable<Role> GetRolesByExpression(Func<Role, bool> expression);

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="roleID">role id</param>
        /// <returns>object role</returns>
        Role GetRoleByID(Guid roleID);

        /// <summary>
        /// Insert list role into database
        /// </summary>
        /// <param name="models">list roles</param>
        /// <returns>true or false</returns>
        Boolean SetListRoles(List<Role> models);

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
        Boolean EditRoleByExpression(Func<Role, bool> expression);

        /// <summary>
        /// Update role by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditRoleByObject(Role modelEdit);

        /// <summary>
        /// Delete role by ID
        /// </summary>
        /// <param name="roleID">role id</param>
        /// <returns>true or false</returns>
        Boolean DeleteRoleByID(Guid roleID);

        /// <summary>
        /// Delete role by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteRoleByExpression(Func<Role, bool> expression);

        /// <summary>
        /// Delete all roles
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllRoles();

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
        IEnumerable<Module> GetModulesByExpression(Func<Module, bool> expression);

        /// <summary>
        /// Get module by id
        /// </summary>
        /// <param name="moduleID">module id</param>
        /// <returns>object module</returns>
        Module GetModuleByID(Module moduleID);

        /// <summary>
        /// Insert list module into database
        /// </summary>
        /// <param name="models">list modules</param>
        /// <returns>true or false</returns>
        Boolean SetListModules(List<Module> models);

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
        Boolean EditModuleByExpression(Func<Module, bool> expression);

        /// <summary>
        /// Update module by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditModuleByObject(Module modelEdit);

        /// <summary>
        /// Delete module by ID
        /// </summary>
        /// <param name="moduleID">module id</param>
        /// <returns>true or false</returns>
        Boolean DeleteModuleByID(Guid moduleID);

        /// <summary>
        /// Delete module by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteModuleByExpression(Func<Module, bool> expression);

        /// <summary>
        /// Delete all modules
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllModules();

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
        IEnumerable<Authorization> GetAuthorizationsByExpression(Func<Authorization, bool> expression);

        /// <summary>
        /// Get authorization by id
        /// </summary>
        /// <param name="authorizationID">authorization id</param>
        /// <returns>object authorization</returns>
        Authorization GetAuthorizationByID(Guid authorizationID);

        /// <summary>
        /// Insert list authorization into database
        /// </summary>
        /// <param name="models">list authorizations</param>
        /// <returns>true or false</returns>
        Boolean SetListAuthorizations(List<Authorization> models);

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
        Boolean EditAuthorizationByExpression(Func<Authorization, bool> expression);

        /// <summary>
        /// Update authorization by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditAuthorizationByObject(Authorization modelEdit);

        /// <summary>
        /// Delete authorization by ID
        /// </summary>
        /// <param name="authorizationID">authorization id</param>
        /// <returns>true or false</returns>
        Boolean DeleteAuthorizationByID(Guid authorizationID);

        /// <summary>
        /// Delete authorization by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteAuthorizationByExpression(Func<Authorization, bool> expression);

        /// <summary>
        /// Delete all authorizations
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllAuthorizations();

        #endregion
    }
}
