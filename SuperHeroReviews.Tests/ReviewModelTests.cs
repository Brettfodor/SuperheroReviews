using Xunit;
using SuperHeroReviews.Models;

namespace SuperHeroReviews.Tests
{
    public class ReviewModelTests
    {
        
        ReviewModel herotest;
        public ReviewModelTests()
        {
            herotest = new ReviewModel(21, "review", "name", 5, "10/10/2019",1);

        }

        [Fact]
        public void ReviewConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }

        [Fact]
        public void ReviewConstructor_Sets_Review()
        {
            var result = herotest.Content;

            Assert.Equal("review", result);
        }
    }
}
