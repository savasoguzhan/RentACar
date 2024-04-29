using Azure.Core.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.Features.Mediator.Commands.PricingCommands;
using RentACar.Application.Features.Mediator.Handlers.PricingHandlers;
using RentACar.Application.Features.Mediator.Queries.PricingQueries;

namespace RentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            var values = await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrice(int id)
        {
            var value = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrice(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing added");
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePrice(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Price Deleted");

        }
        [HttpPut]
        public async Task<IActionResult> UpdatePrice(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Price Updated");
        }
    }
}
