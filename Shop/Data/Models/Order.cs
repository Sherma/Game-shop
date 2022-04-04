using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Введіть ім'я")]
        [StringLength(20)]
        [Required(ErrorMessage ="Довжина імені не може бути меншою ніж 3 символи")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина прізвища не може бути меншою ніж 3 символи")]
        public string surname { get; set; }

        [Display(Name = "Вкажіть адресу")]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина адреси не може бути меншою ніж 10 символів")]
        public string adress { get; set; }

        [Display(Name = "Вкажіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Номер телефону не може бути менше ніж 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Вкажіть e-mail адресу")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "e-mail не може бути менше ніж 10 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> ordesDetails { get; set; }
    }
}
