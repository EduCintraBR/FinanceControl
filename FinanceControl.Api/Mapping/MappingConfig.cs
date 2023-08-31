﻿using AutoMapper;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;

namespace FinanceControl.Api.Mapping
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Cartao, CartaoDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
