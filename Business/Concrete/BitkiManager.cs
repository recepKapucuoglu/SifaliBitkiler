using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BitkiManager : IBitkiService
    {

        IBitkiDal _bitkiDal;

        public BitkiManager(IBitkiDal bitkiDal)
        {
            _bitkiDal = bitkiDal;
        }

        public IResult Add(EtkiBitkiDto etkiBitkiDto) 
        {
            

            Bitki bitki = new Bitki()
            {
              
                
                Acıklaması=etkiBitkiDto.BitkiAciklama,
                Name = etkiBitkiDto.BitkiName,
                ResimUrl = etkiBitkiDto.BitkiResimUrl,
                SikayetEtkis = new List<SikayetEtkiBitki>()
                { new SikayetEtkiBitki() { SikayetEtkiId = etkiBitkiDto.SikayetEtkiId }  }

            };

            _bitkiDal.Add(bitki);

            return new SuccessResult(Messages.Added);

        }

        public IResult AddAll(int bitkiid, int[] etkiId) //update --
        {
          

            using ( var context = new SifaliBitkilerContext())
            {   
                
                Bitki _bitki = context.Bitkis.Include(s => s.SikayetEtkis).First(i => i.Id == bitkiid);
                
                _bitki.SikayetEtkis = etkiId.Select(i => new SikayetEtkiBitki() { SikayetEtkiId = i, BitkiId = bitkiid}).ToList();
                context.SaveChanges();
            }

         return   new SuccessResult(Messages.Added);
        }

        public IResult Delete(Bitki bitki)
        {

            _bitkiDal.Delete(bitki);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Bitki>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Bitki>> GetAll()
        {
            var result = _bitkiDal.GetAllBitkiEtkileri();
            return new SuccessDataResult<List<Bitki>>(result, Messages.Listing);
        }

        public IDataResult<List<Bitki>> GetByIdEtkis(int id)
        {
           var result= _bitkiDal.GetAllBitkiEtkileri(p=>p.Id == id);
            return new SuccessDataResult<List<Bitki>>(result,Messages.Listing);
        }

        public IResult Update(Bitki bitki)
        {
                _bitkiDal.Update(bitki);
            return new SuccessResult(Messages.Updated);
        }
    }
}
