using System.Collections.Generic;
using SuperHeroReviews.Models;
using Xunit;

namespace SuperHeroReviews.Tests
{
    public class HeroControllerTests
    {
        HeroModel herotest;
        ICollection<ReviewModel> reviews;
        public HeroControllerTests()
        {
            herotest = new HeroModel(21, "Hero Name", "Content", "Img", reviews, 6); 

        }
            
        [Fact]
        public void CourseConstructor_Sets_Name_On_Course_Model()
        {
            var result = herotest.Name;

            Assert.Equal("Hero Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }

        [Fact]
        public void CourseConstructor_Sets_Content()
        {
            var result = herotest.Content;

            Assert.Equal("Content", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Image()
        {
            var result = herotest.Image;

            Assert.Equal("Img", result);
        }


    }
}
