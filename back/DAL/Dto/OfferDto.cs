using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dto
{
    public class OfferDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FileContentResult Photo { get; set; }
    }
}
