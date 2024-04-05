using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Commands.ContactCommands
{
    public class RemoveContactCommand
    {
        public int Id { get; set; }
        public RemoveContactCommand(int id)
        {

            Id = id;

        }
    }
}
