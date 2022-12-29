using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace DemoLibrary.Models.Queries
{
    //Shorter syntax
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

    //Class approach

    //public class GetPersonByIdQuery : IRequest<PersonalModel>
    //{
    //    public GetPersonByIdQuery(int id) 
    //    {
    //        Id = id;
    //    }
    //    public int Id { get; set; }
    //}
}
