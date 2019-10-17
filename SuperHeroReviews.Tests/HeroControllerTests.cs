using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using SuperHeroReviews.Controllers;
using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;
using Xunit;


namespace SuperHeroReviews.Tests
{
    public class HeroControllerTests
    {
        HeroController underTest;
        IRepository<HeroModel> heroRepo;
        HeroModel herotest;
        ICollection<ReviewModel> reviews;
        public HeroControllerTests()
        {
            herotest = new HeroModel(21, "Hero Name", "Content", "Img", reviews, 6);
            heroRepo = Substitute.For<IRepository<HeroModel>>();
            underTest = new HeroController(heroRepo);

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

        [Fact]
        public void Details_Passes_A_Hero_To_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Details_Passes_Single_Heros()
        {
            var expectedHero = new HeroModel();
            heroRepo.GetByID(1).Returns(expectedHero);
            var result = underTest.Details(1);
            Assert.Equal(expectedHero, result.Model);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.HeroIndex();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_All_Heros_To_View()
        {
            var expectedHero = new List<HeroModel>();
            heroRepo.GetAll().Returns(expectedHero);
            var result = underTest.HeroIndex();
            Assert.Equal(expectedHero, result.Model);
        }
    }
}
