using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SuperHeroReviews.Models;

namespace SuperHeroReviews.Tests
{
    public class UniverseModelTests
    {
        UniverseModel herotest;
        public UniverseModelTests()
        {
            herotest = new UniverseModel(21, "Universe", "Faction");

        }
        [Fact]
        public void CourseConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }

        [Fact]
        public void CourseConstructor_Sets_Universe()
        {
            var result = herotest.Universe;

            Assert.Equal("Universe", result);

        }

        [Fact]
        public void CourseConstructor_Sets_Faction()
        {
            var result = herotest.Faction;

            Assert.Equal("Faction", result);

        }
    }
}
