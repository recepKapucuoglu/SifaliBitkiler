using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISikayetEtkiDal:IEntityRepository<SikayetEtki>
    {
        List<SikayetEtki> GetByEtkiforBitkis(Expression<Func<SikayetEtki, bool>> filter = null);


    }
}
