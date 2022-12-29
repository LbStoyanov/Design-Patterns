using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    //public class InsertPersonCommand : IRequest<PersonalModel>
    //{
    //    public InsertPersonCommand(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //    }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}
}
