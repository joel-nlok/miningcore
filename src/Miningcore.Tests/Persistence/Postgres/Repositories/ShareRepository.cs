using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using AutoMapper;
using Miningcore.Persistence.Model;
using Miningcore.Persistence.Model.Projections;
using Miningcore.Persistence.Repositories;

namespace Miningcore.Tests.Persistence.Postgres.Repositories
{
    public class ShareRepository : IShareRepository
    {
        public ShareRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private readonly IMapper mapper;

        public Task InsertAsync(IDbConnection con, IDbTransaction tx, Share share)
        {
            throw new NotImplementedException();
        }

        public Task BatchInsertAsync(IDbConnection con, IDbTransaction tx, IEnumerable<Share> shares)
        {
            throw new NotImplementedException();
        }

        public Task<Share[]> ReadSharesBeforeAcceptedAsync(IDbConnection con, string poolId, DateTime before, bool inclusive, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Share[]> ReadSharesBeforeCreatedAsync(IDbConnection con, string poolId, DateTime before, bool inclusive, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Share[]> ReadSharesBeforeAndAfterCreatedAsync(IDbConnection con, string poolId, DateTime before, DateTime after, bool inclusive, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Share[]> PageSharesBetweenCreatedAsync(IDbConnection con, string poolId, DateTime start, DateTime end, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Share[]> ReadUnprocessedSharesBeforeAcceptedAsync(IDbConnection con, string poolId, DateTime before, bool inclusive, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task ProcessSharesForUserBeforeAcceptedAsync(IDbConnection con, IDbTransaction tx, string poolId, string miner, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountSharesBeforeCreatedAsync(IDbConnection con, IDbTransaction tx, string poolId, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSharesBeforeCreatedAsync(IDbConnection con, IDbTransaction tx, string poolId, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSharesBeforeAcceptedAsync(IDbConnection con, IDbTransaction tx, string poolId, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProcessedSharesBeforeAcceptedAsync(IDbConnection con, IDbTransaction tx, string poolId, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSharesForUserBeforeAcceptedAsync(IDbConnection con, IDbTransaction tx, string poolId, string miner, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountSharesSoloBeforeCreatedAsync(IDbConnection con, IDbTransaction tx, string poolId, string miner, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSharesSoloBeforeCreatedAsync(IDbConnection con, IDbTransaction tx, string poolId, string miner, DateTime before)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountSharesBetweenCreatedAsync(IDbConnection con, string poolId, string miner, DateTime? start, DateTime? end)
        {
            throw new NotImplementedException();
        }

        public Task<double?> GetAccumulatedShareDifficultyBetweenCreatedAsync(IDbConnection con, string poolId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<MinerWorkerHashes[]> GetAccumulatedShareDifficultyTotalAsync(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<MinerWorkerHashes[]> GetHashAccumulationBetweenCreatedAsync(IDbConnection con, string poolId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<MinerWorkerHashes[]> GetHashAccumulationBetweenAcceptedAsync(IDbConnection con, string poolId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
