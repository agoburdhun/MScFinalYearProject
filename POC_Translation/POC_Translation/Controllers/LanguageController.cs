using System.Web.Mvc;
using POC_Translation.Models;
using POC_Translation.Services;

namespace POC_Translation.Controllers
{
    public class LanguageController : Controller
    {
        //
        // GET: /Language/
        private ILanguageService LanguageService{ get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Translate from English to Mauritian Creole";

            return View(new LanguageModel());
        }

        public ActionResult Translate(object[] english)
        {
            var TanslatedText = LanguageService.GetAllText(english);

            return View("Index");
        }

    }
}
