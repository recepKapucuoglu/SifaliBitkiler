using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SikayetEtki : IEntity
    {
        public int Id { get; set; }

        public string Etkisi { get; set; }

        public virtual List<SikayetEtkiBitki> Bitkis { get; set; }

        public SikayetEtki()
        {
            Bitkis = new List<SikayetEtkiBitki>();
        }

    }
}
