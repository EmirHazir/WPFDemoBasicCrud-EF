using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo_001.Models
{
    public class Personel
    {
        public int Id { get; set; }
        [MaxLength(11,ErrorMessage ="11 karakter olmalı")]
        public string TCKN { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


        //public Person(int id, string adi, string soyadi)
        //{
        //    this.Id = id;
        //    this.Adi = adi;
        //    this.Soyadi = soyadi;
        //}
    }
    
}
