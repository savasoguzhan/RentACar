using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Commands.BrandCommands;
using RentACar.Application.Features.Handlers.BrandHandlers;

namespace RentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;

        public BrandController(CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler, GetBrandQueryHandler getBrandQueryHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler)
        {
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Brand(int id)
        {
            var value = await _getBrandByIdQueryHandler.Handle(new Application.Features.Queries.BrandQueries.GetBrandByIdQuery(id));
            return Ok(value);   

        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok("new brand added");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand (UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Brand Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return Ok("Brand Deleted");
        }
    }
}
