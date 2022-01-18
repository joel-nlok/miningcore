using System;
using System.Data;
using System.Threading.Tasks;
using AutoMapper;
using Miningcore.Persistence.Model;
using Miningcore.Persistence.Model.Projections;
using Miningcore.Persistence.Repositories;

namespace Miningcore.Tests.Persistence.Postgres.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public PaymentRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private readonly IMapper mapper;

        public Task InsertAsync(IDbConnection con, IDbTransaction tx, Payment payment)
        {
            throw new NotImplementedException();
        }

        public Task<Payment[]> PagePaymentsAsync(IDbConnection con, string poolId, string address, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<AmountByDate[]> PageMinerPaymentsByDayAsync(IDbConnection con, string poolId, string address, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<PoolState> GetPoolState(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task SetPoolState(IDbConnection con, PoolState state)
        {
            throw new NotImplementedException();
        }
    }
}
