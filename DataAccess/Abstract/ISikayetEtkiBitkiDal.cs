using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISikayetEtkiBitkiDal:IEntityRepository<SikayetEtkiBitki>
    {
        List<SikayetEtkiBitki> GetSikayetBitki(Expression<Func<SikayetEtkiBitki, bool>> filter = null);

        List<EtkiBitkiDto> GetAllListDto(Expression<Func<EtkiBitkiDto, bool>> filter = null);

    }
}
