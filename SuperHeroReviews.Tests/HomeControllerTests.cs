using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Controllers;

namespace SuperHeroReviews.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}