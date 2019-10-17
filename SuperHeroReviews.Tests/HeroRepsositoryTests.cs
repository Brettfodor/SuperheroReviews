using SuperHeroReviews.Models;
using SuperHeroReviews.Repository;
using System;
using System.Linq;
using Xunit;
using SuperHeroReviews.Data;

namespace SuperHeroReviews.Tests
{
    public class HeroRepsositoryTests : IDisposable
    {
        private SuperContext db;
        private HeroRepository underTest;
        public HeroRepsositoryTests()
        {
            db = new SuperContext();
            db.Database.BeginTransaction();

            underTest = new HeroRepository(db);
        }
        

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_TwentyOne()
        {
            var count = underTest.Count();

            Assert.Equal(21, count);
        }

        //[Fact]
        //public void Create_Increases_Count()
        //{
        //    underTest.Create(new ReviewModel() { ID = 1 });

        //    var count = underTest.Count();
        //    Assert.Equal(43, count);
        //}

        //[Fact]
        //public void GetById_Returns_Created_Item()
        //{
        //    var expectedHeroModel = new HeroModel() { Name = "SpiderMan" };
        //    underTest.Create(expectedHeroModel);

        //    var result = underTest.GetByID(expectedHeroModel.ID);

        //    //Assert.Equal(expectedHeroModel.Name, result/*.Name*/);
        //}

        //[Fact]
        //public void Delete_Reduces_Count()
        //{
        //    var HeroModel = new HeroModel() { Name = "SpiderMan" };
        //    underTest.Create(HeroModel);

        //    underTest.Delete(HeroModel);
        //    var count = underTest.Count();

        //    Assert.Equal(0, count);
        //}

        //[Fact]
        //public void GetAll_Returns_All()
        //{
        //    underTest.Create(new HeroModel() { Name = "SpiderMan" });
        //    underTest.Create(new HeroModel() { Name = "IronMan" });

        //    var all = underTest.GetAll();

        //    Assert.Equal(2, all.Count());
        //}
    }
}
