using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BitkiDto:IDto
    {
        public string Etkisi { get; set; }

        public string ResimUrl { get; set; }

        public string Acıklaması { get; set; }

        public string Name { get; set; }
    }
}
