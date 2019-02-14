using System.Threading.Tasks;
using XpTracker.Backend.Core.Service.Facades;
using XpTracker.Backend.RestApi.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace XpTracker.Backend.Tests.RestApi
{
    public class ExperienceControllerTests : BaseTest
    {
        private readonly ExperiencesController _controller;

        public ExperienceControllerTests()
        {
            _controller = new ExperiencesController(_serviceProvider.GetService(typeof(IFacadeExperienceService)) as IFacadeExperienceService, _logger);
        }

        [Fact]
        public void GetAllForCurrentUserAsync()
        {
            Task.Run(async () =>
            {
                // Prepare
                await _controller.Post(new Core.ViewModel.Experience.VmExperienceRequestPost() { Truc = "totototot" });

                // Act
                var result = await _controller.GetAllForCurrentUser();

                // Assert
                Assert.True(result != null);
                Assert.True(result.Value.Data.FirstOrDefault(f => f.Truc == "totototot") != null, "le framework 55 devrait etre dans la liste");
                //Cleanup
            }).GetAwaiter().GetResult();
        }
    }
}
