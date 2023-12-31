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
                config.CreateMap<Categoria, CategoriaDto>().ReverseMap();
                config.CreateMap<Parcelamento, ParcelamentoDto>().ReverseMap();
                config.CreateMap<Parcela, ParcelaDto>().ReverseMap();
                config.CreateMap<Ganhos, GanhosDto>().ReverseMap();
                config.CreateMap<Custos, CustosDto>().ReverseMap();
                config.CreateMap<Controle, ControleDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
