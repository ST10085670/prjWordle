using Microsoft.AspNetCore.Mvc;
using prjWordleAPI.Factory;

namespace prjWordleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordleController : Controller
    {
        [HttpGet("GetSingle")]
        public String GetSingle(String lang)
        {
            wordFactory langFactory = new wordFactory();
            iWord langInstance = langFactory.GetLang(lang);
            word w = word.getInstance();
            return w.Single(langInstance.getName());
        }
    }
}
