using System.Collections.Generic;
using Xunit;
using SuperHeroReviews.Models;

namespace SuperHeroReviews.Tests
{
    public class UniverseModelTests
    {
        UniverseModel herotest;
        ICollection<HeroModel> heroes;
        public UniverseModelTests()
        {
            herotest = new UniverseModel(21, "Universe", heroes );

        }

        [Fact]
        public void UniverseConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }

        [Fact]
        public void UniverseConstructor_Sets_Universe()
        {
            var result = herotest.Universe;

            Assert.Equal("Universe", result);

        }

    }
}
