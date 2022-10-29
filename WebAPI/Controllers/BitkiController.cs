using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitkiController : ControllerBase
    {
        IBitkiService _bitkiService;

        public BitkiController(IBitkiService bitkiService)
        {
            _bitkiService = bitkiService;
        }



        [HttpGet("listele")]

       public IActionResult GetAll()
        {
            var result = _bitkiService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }



        [HttpPost("ekle")]
        public IActionResult Add(EtkiBitkiDto etkiBitkiDto)
        {
            var result = _bitkiService.Add(etkiBitkiDto);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("degistir")]
        public IActionResult updatenew(int bitkiid, int[] etkiId)
        {
            var result = _bitkiService.AddAll(bitkiid, etkiId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyid")]
        public IActionResult GetByIdEtkis(int id)
        {
            var result = _bitkiService.GetByIdEtkis(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }



        [HttpPost("delete")]
        public IActionResult Delete(Bitki bitki)
        {
            var result = _bitkiService.Delete(bitki);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPut("Edit")]
        public IActionResult Update(Bitki bitki)
        {
            var result = _bitkiService.Update(bitki);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
       
    }
}
