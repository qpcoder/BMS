using AutoMapper;
using QPC.BMS.Models;
using QPC.BMS.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Domain.AutoMapper
{
    public class AccountMapperImpV1 : BaseDomain, IBaseMapper<AccountModel, Account>
    {
        /// <summary>
        /// Ánh xạ dự liệu bảng account từ Entity sang Model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public AccountModel MappingEntity2Model(Account entity)
        {
            return Mapper.Map<Account, AccountModel>(entity);
        }

        /// <summary>
        /// Ánh xạ dự liệu bảng account từ Model sang Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Account MappingModel2Entity(AccountModel model)
        {
            return Mapper.Map<AccountModel, Account>(model);
        }
    }
}
