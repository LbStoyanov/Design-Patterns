using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHendler : IRequestHandler<GetPersonListQuery, List<PersonalModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHendler(IDataAccess data)
        {
            _data= data;
        }
        public Task<List<PersonalModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
