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
        public readonly ILoggingHelper logger = QPC.BMS.Helpers.DependencyResolution.IoC
          .Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

        /// <summary>
        /// Handle instance connection to database
        /// </summary>
        private BMSContext db = new BMSContext();

        /// <summary>
        /// implementtation delete account by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool DeleteAccount(Func<Account, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //change status of account is deleted
            try
            {
                db.Accounts.Where(expression);
                logger.Info("Delete acocunt is successfully!");
                return true;
            }
            catch (Exception e)
            {
                logger.Warn("Delete account is unsuccessfuly!");
                logger.Debug("Delete account is unsuccessfuly! " + e.Message);
                throw new Exception("Delete account is unsuccessfully! " + e.Message);
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// implement delete account by id
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public bool DeleteAccount(Guid accountID)
        {
            //log enter method
            logger.EnterMethod();

            //change status account
            try
            {
                Account account = db.Accounts.SingleOrDefault(x => x.ID.Equals(accountID));
                if (account == null) throw new Exception("Account id does not exist!.");
                else account.Status = AccountStatus.Deleted;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                logger.Warn("Delete account is unsuccessfully!");
                logger.Debug("Delete account is unsuccessfully!", e);
                throw new Exception("Delete account is unsuccessfully! ", e);
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        public bool DeleteAccountForever(Func<Account, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //lay danh sach cac tai khoan can xoa

            //lay ra danh sach series lien quan den tung tai khoan can xoa => thang bang tai khoan dufault

            //lay ra cac luot download lien quan den tung tai khoan can xoa => thang bang tai khoan dufault

            //lay ra danh sach cac hinh anh lien quan den ung tao => thang bang tai khoan dufault

            //lay ra danh sach cac comment lien quan => thang bang tai khoan dufault

            //lay ra danh sach cac bai viet lien quan => thang bang tai khoan dufault

            //lay ra cac tag lien quan => thang bang tai khoan dufault

            //log release method
            logger.ReleaseMethod();
            throw new NotImplementedException();
        }

        public bool DeleteAllAuthorizations()
        {
            //log enter method
            logger.EnterMethod();

            //delete all Authorizations

            //log releae method
            logger.ReleaseMethod();
            throw new NotImplementedException();
        }

        public bool DeleteAuthorization(Func<Authorization, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuthorization(Guid authorizationID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteModule(Func<Module, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteModule(Guid moduleID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(Guid roleID)
        {
            throw new NotImplementedException();
        }

        public bool EditAccount(Func<Account, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditAccount(Account modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditAuthorization(Func<Authorization, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditAuthorization(Authorization modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditModule(Func<Module, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditModule(Module modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditRole(Func<Role, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditRole(Role modelEdit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get account by account id
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public Account GetAccount(Guid accountID)
        {
            //log enter method
            logger.EnterMethod();

            //create object account
            Account outPut = new Account();

            //get account by id
            outPut = db.Accounts.SingleOrDefault(x => x.ID.Equals(accountID));
            if (outPut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return outPut;
        }

        /// <summary>
        /// Get account by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Account> GetAccount(Func<Account, bool> expression)
        {
            ///log enter method
            logger.EnterMethod();

            // create storage
            List<Account> lstOut = new List<Account>();

            //get data
            lstOut = db.Accounts.Where(expression).ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            ///log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get all account
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Account> GetAllAccounts()
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Account> lstOut = new List<Account>();

            //get data
            lstOut = db.Accounts.ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get all authorizations
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Authorization> GetAllAuthorizations()
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Authorization> lstOut = new List<Authorization>();

            //get data
            lstOut = db.Authorizations.ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get all modules
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Module> GetAllModules()
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Module> lstOut = new List<Module>();

            //get data
            lstOut = db.Modules.ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get all roles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Role> GetAllRoles()
        {
            // log enter method
            logger.EnterMethod();

            //create storage
            List<Role> lstOut = new List<Role>();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get authorization by id
        /// </summary>
        /// <param name="authorizationID"></param>
        /// <returns></returns>
        public Authorization GetAuthorization(Guid authorizationID)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            Authorization outPut = new Authorization();

            //get data
            outPut = db.Authorizations.SingleOrDefault(x => x.ID.Equals(authorizationID));

            if (outPut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            // log release method
            logger.ReleaseMethod();
            return outPut;
        }

        /// <summary>
        /// Get authorization by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Authorization> GetAuthorization(Func<Authorization, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Authorization> lstOut = new List<Authorization>();

            //get data
            lstOut = db.Authorizations.Where(expression).ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //logg release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get module by id
        /// </summary>
        /// <param name="moduleID"></param>
        /// <returns></returns>
        public Module GetModule(int moduleID)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            Module outPut = new Module();

            //get data
            outPut = db.Modules.SingleOrDefault(x => x.ID == moduleID);

            if (outPut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return outPut;
        }

        /// <summary>
        /// Get module by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Module> GetModule(Func<Module, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Module> lstOut = new List<Module>();

            //get data
            lstOut = db.Modules.Where(expression).ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public Role GetRole(int roleID)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            Role outPut = new Role();

            //get data
            outPut = db.Roles.SingleOrDefault(x => x.ID == roleID);

            if (outPut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return outPut;
        }

        /// <summary>
        /// Get role by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Role> GetRole(Func<Role, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            //create storage
            List<Role> lstOut = new List<Role>();

            //get data
            lstOut = db.Roles.Where(expression).ToList();

            if (lstOut == null)
                logger.Info(MessageContants.NOT_FOUND);
            else
                logger.Info(MessageContants.LOCKING_DATA);

            //log release method
            logger.ReleaseMethod();
            return lstOut;
        }

        /// <summary>
        /// Insert account by object account
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public bool SetAccount(Account models)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                //check exists email
                if (GetAccount(x => x.Email.ToLower().Equals(models.Email.ToLower())) == null)
                {
                    logger.Warn(MessageContants.EMAIL_EXISTS);
                    throw new Exception(MessageContants.EMAIL_EXISTS);
                }

                //insert into database
                db.Accounts.Add(models);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                logger.Warn("Insert data is unsuccessfully! ");
                logger.Debug("Insert data is unsuccessfully! " + e.Message);
                throw new Exception("Insert data is unsuccessfully! " + e.Message);
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
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
