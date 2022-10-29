using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SikayetEtkiController : ControllerBase
    {
        ISikayetEtkiService _sikayetEtkiService;

        public SikayetEtkiController(ISikayetEtkiService sikayetEtkiService)
        {
            _sikayetEtkiService = sikayetEtkiService;
        }

        [HttpGet("listele")]

        public IActionResult GetAll()
        {
            var result = _sikayetEtkiService.GetAll();
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
        public IActionResult Add(SikayetEtki sikayetEtki)
        {
            var result = _sikayetEtkiService.Add(sikayetEtki);
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
        public IActionResult Delete(SikayetEtki sikayetEtki)
        {
            var result = _sikayetEtkiService.Delete(sikayetEtki);
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
        public IActionResult Update(SikayetEtki sikayetEtki)
        {
            var result = _sikayetEtkiService.Update(sikayetEtki);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("ByIdlistele")]

        public IActionResult GetByEtkiId(int etkiid)
        {
            var result = _sikayetEtkiService.GetByEtkiforBitkis(etkiid);
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
