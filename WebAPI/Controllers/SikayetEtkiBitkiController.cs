using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SikayetEtkiBitkiController : ControllerBase
    {
        ISikayetEtkiBitkiService _sikayetEtkiBitkiService;
        public SikayetEtkiBitkiController(ISikayetEtkiBitkiService sikayetEtkiBitkiService)
        {
            _sikayetEtkiBitkiService = sikayetEtkiBitkiService;
        }
     

   
        [HttpGet("listele")]

        public IActionResult GetAll()
        {
            var result = _sikayetEtkiBitkiService.GetAllBitkisEtkis();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("listeleetkiyegöre")]

        public IActionResult GetByEtkiIdBitkis(int sikayetEtkiId)
        {
            var result = _sikayetEtkiBitkiService.GetByEtkiIdBitkis(sikayetEtkiId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("listelebitkiyegöre")]

        public IActionResult GetByBitkiIdEtkis(int bitkiId)
        {
            var result = _sikayetEtkiBitkiService.GetByBitkiIdEtkis(1);
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
