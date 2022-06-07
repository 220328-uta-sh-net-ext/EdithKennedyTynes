using Microsoft.AspNetCore.Mvc;
using SigniSightBL;
using Microsoft.AspNetCore.Cors;
//using System.Web.Http.Cors;

namespace SigniSightAPI.Controllers
{
    
    [ApiController]
    [EnableCors]
    //[EnableCors("signiSightPolicy")]
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TranslatorController : ControllerBase
    {
        private readonly ILogger<TranslatorController> _logger;

        public TranslatorController(ILogger<TranslatorController> logger)
        {
            this._logger = logger;
        }
        //[Authorize]
        //[EnableCors("signiSightPolicy")]
        [HttpPost("Translate")]
        public async Task<ActionResult<string>> TranslateText(string textToTranslate, string endLanguageCode)
        {
            _logger.LogInformation("Translating");
            endLanguageCode = endLanguageCode.Trim();
            var result = await TranslateProcessor.TranslateText(textToTranslate, endLanguageCode);
            return Ok(result);
        }
    }  
}
