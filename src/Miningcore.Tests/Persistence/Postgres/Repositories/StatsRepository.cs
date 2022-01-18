using System;
using System.Data;
using System.Threading.Tasks;
using AutoMapper;
using Miningcore.Persistence.Model;
using Miningcore.Persistence.Model.Projections;
using Miningcore.Persistence.Repositories;
using Miningcore.Time;
using MinerStats = Miningcore.Persistence.Model.Projections.MinerStats;

namespace Miningcore.Tests.Persistence.Postgres.Repositories
{
    public class StatsRepository : IStatsRepository
    {
        public StatsRepository(IMapper mapper, IMasterClock clock)
        {
            this.mapper = mapper;
            this.clock = clock;
        }

        private readonly IMapper mapper;
        private readonly IMasterClock clock;

        public Task InsertPoolStatsAsync(IDbConnection con, IDbTransaction tx, PoolStats stats)
        {
            throw new NotImplementedException();
        }

        public Task InsertMinerWorkerPerformanceStatsAsync(IDbConnection con, IDbTransaction tx, MinerWorkerPerformanceStats stats)
        {
            throw new NotImplementedException();
        }

        public Task<PoolStats> GetLastPoolStatsAsync(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalPoolPaymentsAsync(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<PoolStats[]> GetPoolPerformanceBetweenAsync(IDbConnection con, string poolId, SampleInterval interval, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<MinerStats> GetMinerStatsAsync(IDbConnection con, IDbTransaction tx, string poolId, string miner)
        {
            throw new NotImplementedException();
        }

        public Task<MinerWorkerHashrate[]> GetPoolMinerWorkerHashratesAsync(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<MinerWorkerPerformanceStats[]> PagePoolMinersByHashrateAsync(IDbConnection con, string poolId, DateTime @from, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<WorkerPerformanceStatsContainer[]> GetMinerPerformanceBetweenHourlyAsync(IDbConnection con, string poolId, string miner, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<WorkerPerformanceStatsContainer[]> GetMinerPerformanceBetweenDailyAsync(IDbConnection con, string poolId, string miner, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePoolStatsBeforeAsync(IDbConnection con, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteMinerStatsBeforeAsync(IDbConnection con, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
