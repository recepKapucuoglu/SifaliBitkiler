using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Bitki :IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Acıklaması { get; set; }

        public string ResimUrl { get; set; }

        public virtual List<SikayetEtkiBitki> SikayetEtkis { get; set; }

        public Bitki()
        {
            SikayetEtkis=new List<SikayetEtkiBitki>();
        }
    }







  

   
   

}
