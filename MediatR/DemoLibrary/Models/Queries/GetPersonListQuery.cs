using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Queries
{
    //record approach, just has additional syntax
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    //class approach
    //public record GetPersonListQuery : IRequest<List<PersonalModel>>
    //{
    //}

}
