﻿using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class ControleService : BaseService<ControleDto, Controle>, IControleService
    {
        private readonly IMapper _mapper;
        private readonly FCDbContext _dbContext;
        public ControleService(FCDbContext db, IMapper mapper) : base(db, mapper)
        {
            _dbContext = db;
            _mapper = mapper;
        }
    }
}
