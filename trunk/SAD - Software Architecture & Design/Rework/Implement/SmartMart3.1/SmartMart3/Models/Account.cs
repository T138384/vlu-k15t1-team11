using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;

namespace SmartMart3.Models
{
    public class Account
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string strUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string strPassword { get; set; }

        //public int StoreId { get; set; }
    }
}