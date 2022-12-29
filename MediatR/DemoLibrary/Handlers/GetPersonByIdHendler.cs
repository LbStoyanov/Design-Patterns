using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Models.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHendler : IRequestHandler<GetPersonByIdQuery, PersonalModel>
    {
        private readonly IMediator _mediator;

        public GetPersonByIdHendler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<PersonalModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetPersonListQuery());
            var output = results.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}
