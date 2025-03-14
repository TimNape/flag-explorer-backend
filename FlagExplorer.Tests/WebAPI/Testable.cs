using FlagExplorer.Core.Interfaces;
using FlagExplorer.WebAPI.Repositories;
using Xunit;

namespace FlagExplorer.Tests.WebAPI
{
    public class Testable
    {
        [Fact]
        public void Basic()
        {
            var rep = new CountryRepository();
            var country = rep.GetByNameAsync("South Africa");
            Assert.NotNull(country);
        }
    }
}
