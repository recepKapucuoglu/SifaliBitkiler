using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBitkiService
    {
        IDataResult<List<Bitki>> GetAll();

        IDataResult<List<Bitki>> Get(int id);


        IDataResult<List<Bitki>> GetByIdEtkis(int id);
       

        IResult Add(EtkiBitkiDto etkiBitkiDto);

        IResult AddAll(int bitkiid, int[] etkiId);

        
        IResult Update(Bitki bitki);

        IResult Delete(Bitki bitki); 
    }
}
