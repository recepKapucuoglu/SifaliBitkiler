using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EtkiBitkiDto:IDto
    {
        public int BitkiId { get; set; }
        
        public string BitkiName { get; set; }

        public string BitkiAciklama { get; set; }

        public string BitkiResimUrl { get; set; }
        public int SikayetEtkiId { get; set; }

        public string SikayetEtkiName { get; set; }
    }
}
