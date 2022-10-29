using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SikayetEtkiManager : ISikayetEtkiService
    {
        ISikayetEtkiDal _sikayetEtkiDal;

        public SikayetEtkiManager(ISikayetEtkiDal sikayetEtkiDal)
        {
            _sikayetEtkiDal = sikayetEtkiDal;
        }

        public IResult Add(SikayetEtki sikayetEtki)
        {
            _sikayetEtkiDal.Add(sikayetEtki);

            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(SikayetEtki sikayetEtki)
        {
            _sikayetEtkiDal.Delete(sikayetEtki);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<SikayetEtki>> GetAll()
        {
            var result = _sikayetEtkiDal.GetAll();
            return new SuccessDataResult<List<SikayetEtki>>(result, Messages.Listing);
        }

        public IDataResult<List<SikayetEtki>> GetByEtkiforBitkis(int etkiid)
        {
            var result = _sikayetEtkiDal.GetByEtkiforBitkis(p=>p.Id==etkiid);
            return new SuccessDataResult<List<SikayetEtki>>(result, Messages.Listing);

        }

        public IResult Update(SikayetEtki sikayetEtki)
        {
            _sikayetEtkiDal.Update(sikayetEtki);
            return new SuccessResult(Messages.Updated);
        }
    }
}
