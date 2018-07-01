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
/// 
namespace QPC.BMS.Domain.AutoMapper
{
    public class SystemExceptionLogMapperImpV1 : BaseDomain, IBaseMapper<SystemExceptionLogModel, SystemExceptionLog>
    {
        public SystemExceptionLogModel MappingEntity2Model(SystemExceptionLog entity)
        {
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SystemExceptionLog, SystemExceptionLogModel>()
                .ForMember(e => e.Id, opt => opt.MapFrom(source => source.Id))
                .ForMember(e => e.Message, opt => opt.MapFrom(source => source.Message))
                .ForMember(e => e.Source, opt => opt.MapFrom(source => source.Source))
                .ForMember(e => e.StackTrace, opt => opt.MapFrom(source => source.StackTrace))
                .ForMember(e => e.TargetSite, opt => opt.MapFrom(source => source.TargetSite))
                .ForMember(e => e.Url, opt => opt.MapFrom(source => source.Url))
                .ForMember(e => e.Username, opt => opt.MapFrom(source => source.Username));
            }).CreateMapper();

            return Mapper.Map<SystemExceptionLog, SystemExceptionLogModel>(entity);
        }

        public SystemExceptionLog MappingModel2Entity(SystemExceptionLogModel model)
        {
            mapper = new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<SystemExceptionLogModel, SystemExceptionLog>()
               .ForMember(e => e.Message, opt => opt.MapFrom(source => source.Message))
               .ForMember(e => e.Source, opt => opt.MapFrom(source => source.Source))
               .ForMember(e => e.StackTrace, opt => opt.MapFrom(source => source.StackTrace))
               .ForMember(e => e.TargetSite, opt => opt.MapFrom(source => source.TargetSite))
               .ForMember(e => e.Url, opt => opt.MapFrom(source => source.Url))
               .ForMember(e => e.Username, opt => opt.MapFrom(source => source.Username));
           }).CreateMapper();

            return mapper.Map<SystemExceptionLogModel, SystemExceptionLog>(model);
        }
    }
}
