using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SuperHeroReviews.Models;

namespace SuperHeroReviews.Tests
{
    public class ReviewModelTests
    {
        ReviewModel herotest;
        public ReviewModelTests()
        {
            herotest = new ReviewModel(21, "review");

        }
        [Fact]
        public void CourseConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }
        [Fact]
        public void CourseConstructor_Sets_Review()
        {
            var result = herotest.Review;

            Assert.Equal("review", result);
        }
    }
}
