using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SikayetEtkiBitki : IEntity
    {

        public int? BitkiId { get; set; }


        public int? SikayetEtkiId { get; set; }

        public virtual Bitki Bitki { get; set; }

        public virtual SikayetEtki SikayetEtki { get; set; }
    }

}
