using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class TestController : Controller //TestController adında bir sınıf tanımlar ve bu sınıf, ASP.NET Core MVC framework'ünde kullanılan Controller sınıfından türetilir. Bu sayede, TestController sınıfı, MVC yapısında bir denetleyici olarak işlev görür ve HTTP isteklerini işleyebilir.
    {
        private readonly ResumeContext _context;//ResumeContext sınıfından bir nesne oluşturur ve bu nesneyi _context değişkenine atar

        public TestController(ResumeContext context)//TestController sınıfının yapıcı metodudur. Bu metod, ResumeContext türünde bir parametre alır ve bu parametreyi _context değişkenine atar. Bu sayede, TestController sınıfı içinde ResumeContext nesnesine erişebilir ve veritabanı işlemlerini gerçekleştirebilir.
        {
            _context = context;//Yapıcı metodun parametresi olarak alınan context nesnesi, _context değişkenine atanır. Bu sayede, TestController sınıfı içinde ResumeContext nesnesine erişebilir ve veritabanı işlemlerini gerçekleştirebilir.
        }

        public IActionResult Index()
        {
            ViewBag.v1=_context.Messages.Count();//Message tablosundaki kayıt sayısını v1 değişkenine atar
            ViewBag.v2 = _context.Messages.Where(x => x.IsRead == true).Count();//Message tablosundaki IsRead değeri true olan kayıtların sayısını v2 değişkenine atar
            ViewBag.v3 = _context.Messages.Where(x => x.IsRead == false).Count();//Message tablosundaki IsRead değeri false olan kayıtların sayısını v3 değişkenine atar
            ViewBag.v4 = _context.Messages.Where(x => x.MessageId == 1).Select(y => y.NameSurname).FirstOrDefault();//Message tablosundaki MessageId değeri 1 olan kaydın NameSurname değerini v4 değişkenine atar. Eğer böyle bir kayıt yoksa, v4 değişkeni null olur.
            return View();
        }
    }
}
