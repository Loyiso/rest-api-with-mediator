using MediatR;

using Microsoft.AspNetCore.Mvc;

using UserAddress.API.Data.Handlers.Commands;
using UserAddress.API.Data.Handlers.Queries;
using UserAddress.API.Models.Vehicles;
using UserAddress.API.Services;

namespace UserAddress.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ApiBaseController
    {
        private readonly IMediator _mediator;
        private readonly ILoggingService _logging;

        public VehiclesController(IMediator mediator, ILoggingService logging)
        {
            _mediator = mediator;
            _logging = logging;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _mediator.Send(new GetAllVehicleRecordQuery()));
            }
            catch (Exception ex)
            {
                _logging.LogError(ex.ToString());
                return Error();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("id is request.");
            }

            try
            {
                return Ok(await _mediator.Send(new GetVehicleRecordQuery(id)));
            }
            catch (Exception ex)
            {
                _logging.LogError(ex.ToString());
                return Error();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVehicleViewModel model)
        {
            if (model == null)
            {
                return BadRequest("model is request.");
            }

            try
            {
                var command = new CreateVehicleRecordCommand
                {
                    Make = model.Make,
                    Model = model.Model,
                    Year = model.Year,
                    LicencePlateNumber = model.LicencePlateNumber,
                    Mileage = model.Mileage
                };

                await _mediator.Send(command);

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogError(ex.ToString());
                return Error();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateVehicleViewModel model)
        {
            if (model == null)
            {
                return BadRequest("model is request.");
            }

            try
            {
                var command = new UpdateVehicleRecordCommand(
                    model.Id,
                    model.Make,
                    model.Model,
                    model.Year,
                    model.LicencePlateNumber,
                    model.Mileage
                );

                var updatedRecord = await _mediator.Send(command);
                if (updatedRecord == Guid.Empty)
                {
                    return NotFound($"Record with Id {command.Id} was not found.");
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogError(ex.ToString());
                return Error();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("id is request.");
            }

            try
            {
                var deletedRecord = await _mediator.Send(new DeleteVehicleRecordCommand(id));
                if (deletedRecord == Guid.Empty)
                {
                    return NotFound($"Record with Id {id} was not found.");
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logging.LogError(ex.ToString());
                return Error();
            }
        }
    }
}
