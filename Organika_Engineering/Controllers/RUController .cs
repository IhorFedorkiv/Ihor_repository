using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using organika_engineering.Models;
using organika_engineering.Controllers;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace organika_engineering.Controllers
{
    public class RUController : Controller
    {
        public ActionResult AboutUS()
        {
            return View();
        }
        public ActionResult Barda()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Fricont()
        {
            return View();
        }
        public ActionResult Home(string URL)
        {
            if (URL != null)
            {
                if (URL.Contains("AlcoholIndustry"))
                    Response.Redirect("AlcoholIndustry");
                else if (URL.Contains("StarchyPatchIndustry"))
                    Response.Redirect("StarchyPatchIndustry");
                else if (URL.Contains("WaterTreatment"))
                    Response.Redirect("WaterTreatment");
                else if (URL.Contains("Membrane"))
                    Response.Redirect("Membrane");
                else if (URL.Contains("Аutomation"))
                    Response.Redirect("Аutomation");
                else if (URL.Contains("Soft"))
                    Response.Redirect("Soft");
                else if (URL.Contains("ERP"))
                    Response.Redirect("ERP");
                else if (URL.Contains("Project"))
                    Response.Redirect("Project");
                else if (URL.Contains("Fricont"))
                    Response.Redirect("Fricont");
                else if (URL.Contains("Barda"))
                    Response.Redirect("Barda");
                else if (URL.Contains("AboutUS"))
                    Response.Redirect("AboutUS");
                else if (URL.Contains("Contact"))
                    Response.Redirect("Contact");
            }
            return View();
        }
        public ActionResult AlcoholIndustry()
        {
            return View();
        }
        public ActionResult ERP()
        {
            return View();
        }
        public ActionResult Membrane()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Soft()
        {
            return View();
        }
        public ActionResult StarchyPatchIndustry()
        {
            return View();
        }
        public ActionResult WaterTreatment()
        {
            return View();
        }
        public ActionResult Аutomation()
        {
            return View();
        }
        public ActionResult email_send(string nameClient, string emailClient, string messageClient)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("orgengin@gmail.com", nameClient);
                // кому отправляем
                MailAddress to = new MailAddress("ifedorkiv@gmail.com");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Повідомлення з сайту Органіка-Iнжинірінг";
                // текст письма
                m.Body = messageClient + " Користувач вказав свою адресу як:" + emailClient;
                // письмо представляет код html
                // m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                // SmtpClient smtp = new SmtpClient("173.194.73.109", 25);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("orgengin@gmail.com", "org64390");
                smtp.EnableSsl = true;
                smtp.TargetName = "STARTTLS/smtp.gmail.com";
                smtp.Send(m);
                ViewBag.Result = "Your message has been successfully sent.";
            }
            catch (SmtpException ex)
            {
                //ViewBag.Result_1 = "Ваше повідомлення не надіслано. Технічна помилка";
                ViewBag.Result_1 = ex;
            }
            return View();
        }
    }
}
