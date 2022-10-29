using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISikayetEtkiService
    {
        IDataResult<List<SikayetEtki>> GetAll();

        IResult Delete(SikayetEtki sikayetEtki);

        IResult Update(SikayetEtki sikayetEtki);

        IResult Add(SikayetEtki sikayetEtki);

        IDataResult<List<SikayetEtki>> GetByEtkiforBitkis(int etkiid);
            
    }
}
