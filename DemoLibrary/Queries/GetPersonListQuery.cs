using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Queries
{

    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

}
