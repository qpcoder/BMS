/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPC.BMS.Domain.AutoMapper
{
    public interface IBaseMapper<Model, Entity>
    {
        /// <summary>
        /// Map dữ liệu từ kiểu Entity sang Model
        /// </summary>
        /// <param name="entity"> dữ liệu entity </param>
        /// <returns> dữ liệu kiểu model </returns>
        Model MappingEntity2Model(Entity entity);

        /// <summary>
        /// Map dữ liệu từ kiểu Model sang Entity
        /// </summary>
        /// <param name="model"> dữ liệu model </param>
        /// <returns> dữ liểu kiểu entity </returns>
        Entity MappingModel2Entity(Model model);
    }
}
