using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Commands.BannerCommands;
using RentACar.Application.Features.Handlers.BannerHandlers;

namespace RentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly UpdataBannerCommandHandler _updataBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;

        public BannerController(GetBannerQueryHandler getBannerQueryHandler,GetBannerByIdQueryHandler getBannerByIdQueryHandler,CreateBannerCommandHandler createBannerCommandHandler,UpdataBannerCommandHandler updataBannerCommandHandler,RemoveBannerCommandHandler removeBannerCommandHandler)
        {
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
            _createBannerCommandHandler = createBannerCommandHandler;
            _updataBannerCommandHandler = updataBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Banner(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new Application.Features.Queries.BannerQueries.GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _createBannerCommandHandler.Handle(command);
            return Ok("New About Added");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdataBannerCommand command)
        {
            await _updataBannerCommandHandler.Handle(command);
            return Ok("About  updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removeBannerCommandHandler.Handler(new RemoveBannerCommand(id));
            return Ok("About Removed");
        }

    }
}
