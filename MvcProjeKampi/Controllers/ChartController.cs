using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using MvcProjeKampi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {     

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }
        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Seyehat",
                CategoryCount = 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Teknoloji",
                CategoryCount = 7
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 1
            });
            return ct;
        }
        public ActionResult HeadingChartIndex()
        {
            return View();
        }
        public ActionResult HeadingChart()
        {
            return Json(HeadingEntryList(), JsonRequestBehavior.AllowGet);
        }
        public List<HeadingClass> HeadingEntryList()
        {
            List<HeadingClass> headingClasses = new List<HeadingClass>();
            using (var Context = new Context())
            {
                headingClasses = Context.Headings.Select(x => new HeadingClass
                {
                    HeadingName = x.HeadingName,
                    ContentCount = x.Contents.Count()
                }).ToList();
            };
            return headingClasses;
        }        

        public ActionResult WriterHeadingIndex()
        {
            return View();
        }
        public ActionResult WriterHeadingChart()
        {
            return Json(WriterHeadingList(), JsonRequestBehavior.AllowGet);
        }
        public List<WriterHeadingCount> WriterHeadingList()
        {
            
            List<WriterHeadingCount> writerHeadingCounts = new List<WriterHeadingCount>();
            using (var Context = new Context())
            {
                writerHeadingCounts = Context.Writers.Select(x => new WriterHeadingCount
                {
                    WriterName = x.WriterName,
                    HeadingCount = x.Headings.Count()
                }).ToList();
            };
            return writerHeadingCounts;
        }
    }


}