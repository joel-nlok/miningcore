using System;
using System.Data;
using System.Threading.Tasks;
using AutoMapper;
using Miningcore.Persistence.Model;
using Miningcore.Persistence.Repositories;

namespace Miningcore.Tests.Persistence.Postgres.Repositories
{
    public class BlockRepository : IBlockRepository
    {
        public BlockRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private readonly IMapper mapper;

        public Task InsertAsync(IDbConnection con, IDbTransaction tx, Block block)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlockAsync(IDbConnection con, IDbTransaction tx, Block block)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlockAsync(IDbConnection con, IDbTransaction tx, Block block)
        {
            throw new NotImplementedException();
        }

        public Task<Block[]> PageBlocksAsync(IDbConnection con, string poolId, BlockStatus[] status, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Block[]> PageBlocksAsyncPaged(IDbConnection con, string poolId, BlockStatus[] status, int page, int pageSize, int _start, int _end, string _order, string _sort)
        {
            throw new NotImplementedException();
        }

        public Task<Block[]> PageBlocksAsync(IDbConnection con, BlockStatus[] status, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Block[]> GetPendingBlocksForPoolAsync(IDbConnection con, string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<Block> GetBlockBeforeAsync(IDbConnection con, string poolId, BlockStatus[] status, DateTime before)
        {
            throw new NotImplementedException();
        }
    }
}
