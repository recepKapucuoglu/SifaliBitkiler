using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBitkiDal:IEntityRepository<Bitki>
    {
        List<Bitki> GetAllBitkiEtkileri(Expression<Func<Bitki, bool>> filter = null);

       
    }
}
