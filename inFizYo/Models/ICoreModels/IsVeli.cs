using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace InFizYo.Models.ICoreModels
{
    public class IsVeli
    {
        [Key]
        public int YID { get; set; } 
        public int YIDParent { get; set; } //Level [daha sonra belirlenecek] seviye veli. Velinin Velisi, bir veli (de) başka pekçok kompozitin bileşeni olabilir. Bu veli hangi kompozite ait? bilgisi.
        public string Veli { get; set; }
        public string Velet { get; set; }
        public double Miktar { get; set; }
        public string Birim { get; set; }
        public DateTime Tarih { get; set; }
        public string Formül { get; set; } // İhzarat ölçümü farklı yapılıyorsa, sözleşme ölçüsüne dönüştürmek için kullanılan formül
        public double Carpan { get; set; } //Sözlesme ölçüsüne dönüştürmek için kullanılan katsayı
        public bool Onay { get; set; }
        public bool Ilave { get; set; }
    }
}
