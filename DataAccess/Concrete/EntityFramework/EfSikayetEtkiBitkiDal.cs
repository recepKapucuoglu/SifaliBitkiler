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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSikayetEtkiBitkiDal : EfEntityRepositoryBase<SikayetEtkiBitki, SifaliBitkilerContext>, ISikayetEtkiBitkiDal
    {
        public List<EtkiBitkiDto> GetAllListDto(Expression<Func<EtkiBitkiDto, bool>> filter = null)
        {
            using(var context =new SifaliBitkilerContext())
            {
                var result = from seb in context.SikayetEtkiBitki
                             join b in context.Bitkis
                             on seb.BitkiId equals b.Id
                             join se in context.SikayetEtkis
                             on seb.SikayetEtkiId equals se.Id
                             select new EtkiBitkiDto
                             {
                                 BitkiId = b.Id,
                                 BitkiName = b.Name,
                                 BitkiResimUrl = b.ResimUrl,
                                 BitkiAciklama =b.Acıklaması,
                                 SikayetEtkiId=se.Id,
                                 SikayetEtkiName=se.Etkisi,


                             };

                return filter == null
                                ? result.ToList()
                                   : result.Where(filter).ToList();


            }
        }

   

        public List<SikayetEtkiBitki> GetSikayetBitki(Expression<Func<SikayetEtkiBitki, bool>> filter = null)
        {

            using (var context = new SifaliBitkilerContext())
            {

                var result = context.SikayetEtkiBitki
                   
                   .Include(p => p.Bitki);

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }


   
    }
}
