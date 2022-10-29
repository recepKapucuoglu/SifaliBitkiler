using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Concrete
{
    public class SikayetEtkiBitkiManager : ISikayetEtkiBitkiService
    {
        ISikayetEtkiBitkiDal _sikayetEtkiBitkiDal;

        public SikayetEtkiBitkiManager(ISikayetEtkiBitkiDal sikayetEtkiBitkiDal)
        {
            _sikayetEtkiBitkiDal = sikayetEtkiBitkiDal;
        }

        public IDataResult<List<EtkiBitkiDto>> GetAllBitkisEtkis()
        {
         var result =   _sikayetEtkiBitkiDal.GetAllListDto();
            return new SuccessDataResult<List<EtkiBitkiDto>>(result ,Messages.Listing);
        }

        public IDataResult<List<EtkiBitkiDto>> GetByBitkiIdEtkis(int BitkiId)  //seçilen bitkiye göre etkiler.
        {
            var result = _sikayetEtkiBitkiDal.GetAllListDto(p => p.BitkiId ==BitkiId);
            return new SuccessDataResult<List<EtkiBitkiDto>>(result, Messages.Listing);
        }

        public IDataResult<List<EtkiBitkiDto>> GetByEtkiIdBitkis(int sikayetEtkiId) //seçilen sikayete göre bitkiler
        {
           var result = _sikayetEtkiBitkiDal.GetAllListDto(p=>p.SikayetEtkiId==sikayetEtkiId);
            return new SuccessDataResult<List<EtkiBitkiDto>>(result, Messages.Listing);

        }

   
    }
}
