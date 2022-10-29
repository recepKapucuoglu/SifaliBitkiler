using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic; 
using System.Text;

namespace Business.Abstract
{
    public interface ISikayetEtkiBitkiService
    {
        IDataResult<List<EtkiBitkiDto>> GetByEtkiIdBitkis(int sikayetEtkiId);

        IDataResult<List<EtkiBitkiDto>> GetByBitkiIdEtkis(int etkiId);


        IDataResult<List<EtkiBitkiDto>> GetAllBitkisEtkis();
      

    }
}
