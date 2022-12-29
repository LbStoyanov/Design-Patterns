using DemoLibrary.Models;
using DemoLibrary.Models.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace MediatRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PersonalModel>> Get()
        {
            //We do not think about the implementation for this method in our UI.Mediator JUST CALL THIS QUERY!!!
            return await _mediator.Send(new GetPersonListQuery());
        }

        
        [HttpGet("{id}")]
        public async Task<PersonalModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
