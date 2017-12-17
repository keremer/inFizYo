using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace inFizYon.CIQModels
{
    public partial class PartyPassport //: IEnumerable<PartyPassport>, IList<PartyPassport>
    {
        [Display(Name = "PasaportID", Prompt = "Pasaport Veritabanı Kayıt No")]
        [Key]
        public int CIQPartyPasID { get; set; }

        public int CIQPrID { get; set; }
       
        [Display(Name = "Pasaport No", Prompt = "Pasaport No")]
        public string CIQPartyPasno { get; set; }

        [Display(Name = "Veriliş Tarihi", Prompt = "Pasaport veriliş tarihi")]
        public System.DateTime CIQPartyPasvert { get; set; }

        [Display(Name = "Geçerlilik Tarihi", Prompt = "Pasaport aşağıdaki tarihe kadar geçerlidir")]
        public System.DateTime CIQPartyPasgec { get; set; }

        [Display(Name = "Verildiği Yer", Prompt = "Pasaportu veren yer")]
        public string CIQPartyPasvery { get; set; }

        [Display(Name = "Taranmış Pasaport Görüntüsü", Prompt = "Pasaportun taranmış sayfaları")]
        public byte[] CIQPartyPasimg { get; set; }

        public virtual PartyReal PassportOwner { get; set; }
        public virtual ICollection<PartyVisa> PartyVisas { get; set; }

    }
}