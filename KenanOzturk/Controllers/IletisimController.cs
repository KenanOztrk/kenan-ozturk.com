using KenanOzturk.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace KenanOzturk.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Iletisim(Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("example@gmail.com");
            mailim.From = new MailAddress("example@gmail.com");
            mailim.Subject = "Contact me sayfasından mesaj var." + model.Baslik;
            mailim.Body = "Sayın yetkili," + model.AdSoyad + "kişisinden mesaj aldınız. <br>" + model.Icerik;
            mailim.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("example@gmail.com", "your password");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailim);
                TempData["Message"] = "Mesajınız iletilmiştir. E n kısa zamanda dönüş sağlanacaktır.";

            }
            catch (Exception ex)
            {

                TempData["Message"] = "Mesaj gönderilememiştir hata nedeni:" + ex.Message;
            }


            return View();
        }
    }
}
