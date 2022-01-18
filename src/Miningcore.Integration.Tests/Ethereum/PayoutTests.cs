using System;
using System.Threading.Tasks;
using Miningcore.PoolCore;
using Xunit;

namespace Miningcore.Integration.Tests.Ethereum
{
    public class PayoutTests : TestBase
    {
        [Fact]
        public async Task BalanceCalculation()
        {
            //Start fresh
            await DataHelper.CleanupShares();

            //Data setup
            await DataHelper.AddTestSharesAsync();
            await DataHelper.AddPoolStateAsync();
            await DataHelper.AddPoolStatisticsAsync();

            //Run pool for 30 secs  
            Pool.Stop(TimeSpan.FromSeconds(30), false);
            Pool.StartMiningCorePool("config_test.json");

            // Validate if shares were processed successfully
            Assert.Equal(0, await DataHelper.GetUnProcessedSharesCountAsync());
            Assert.NotNull(await DataHelper.GetBalanceAsync());
        }
    }
}
