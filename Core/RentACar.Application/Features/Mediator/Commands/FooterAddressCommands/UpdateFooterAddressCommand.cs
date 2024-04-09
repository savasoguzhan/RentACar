using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int FooterAdressId { get; set; }
        public string Description { get; set; }

        public string Adress { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
