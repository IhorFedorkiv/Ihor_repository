using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using organika_engineering.Controllers;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace organika_engineering.Models
{
    public class UserInformation
    {
        [Required(ErrorMessage = "Введіть ім'я!")]
        public string UserLogin { get; set; }

        [Required(ErrorMessage = "Введіть пароль!")]
        public string UserPassword { get; set; }
    }
}