using DataAccessLayer.Concrete;
using System.Linq;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics

        Context context = new Context();
        public ActionResult Index()
        {
            var category = context.Categories.Count();
            var headingcount = context.Headings.Count(x => x.Category.CategoryID == 2);
            var writerscount = context.Writers.Count(x => x.WriterName.Contains("a"));
            var headingsmax = context.Headings.Max(x => x.Category.CategoryName);
            var categorytrue = context.Categories.Count(x => x.CategoryStatus == true);
            var categoryfalse = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = category;
            ViewBag.Heading = headingcount;
            ViewBag.Writer = writerscount;
            ViewBag.HeadingMax = headingsmax;
            ViewBag.StatusFark = (categorytrue - categoryfalse);
            return View();
        }
    }
}