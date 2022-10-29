using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Entities.DTOs;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBitkiDal : EfEntityRepositoryBase<Bitki, SifaliBitkilerContext>, IBitkiDal
    {
        //public void AddNew(Bitki bitki, int[] etkiId)
        //{
        //    using(var context = new SifaliBitkilerContext())
        //    {
        //        Bitki _bitki = context.Bitkis.Include(s => s.SikayetEtkis).First(i => i.Id == bitki.Id);

        //        _bitki.SikayetEtkis = etkiId.Select(eid => new SikayetEtkiBitki { BitkiId=bitki.Id ,SikayetEtkiId==eid});

        //    }
        //}

        public List<Bitki> GetAllBitkiEtkileri(Expression<Func<Bitki, bool>> filter = null)
        {

            using (var context = new SifaliBitkilerContext())
            {

                var result = context.Bitkis

                   .Include(p => p.SikayetEtkis)
                   .ThenInclude(c => c.SikayetEtki);

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }


}
