using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSikayetEtkiDal : EfEntityRepositoryBase<SikayetEtki, SifaliBitkilerContext>, ISikayetEtkiDal
    {
        public List<SikayetEtki> GetByEtkiforBitkis(Expression<Func<SikayetEtki, bool>> filter = null)
        {
            using(var context =new SifaliBitkilerContext())
            {
                var result = context.SikayetEtkis
                    .Include(p => p.Bitkis)
                    .ThenInclude(s => s.Bitki);
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
           
        }
    }
}
