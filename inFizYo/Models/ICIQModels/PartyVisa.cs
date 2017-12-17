using System.ComponentModel.DataAnnotations;

namespace inFizYon.CIQModels
{
    public class PartyVisa //: IEnumerable<PartyVisa>, IList<PartyVisa>
    {
        [Display(Name = "Vize ID", Prompt = "Vize ID")]
        [Key]
        public int CIQPartyVisaID { get; set; }

        [Display(Name = "Vize Türü", Prompt = "Vize Tipi")]
        public string CIQPartyVizetipi { get; set; }

        [Display(Name = "Vize Başlangıcı", Prompt = "Vize başlangıç tarihi")]
        public System.DateTime CIQPartyVizebas { get; set; }

        [Display(Name = "Vize Bitişi", Prompt = "Vize bitiş tarihi")]
        public System.DateTime CIQPartyVizeson { get; set; }

        [Display(Name = "Ülke", Prompt = "Vize hangi ülke için alındı?")]
        public string CIQPartyVizecnt { get; set; }

        [Display(Name = "Vize No", Prompt = "Vize No")]
        public string CIQPartyVizeno { get; set; }

        [Display(Name = "G/Ç Sayısı", Prompt = "Vizece izin verilen; ülkeye giriş çıkış sayısı")]
        public string CIQPartyVizeEnt { get; set; }

        [Display(Name = "Vize Görüntüsü", Prompt = "Vizenin taranmış görüntüsü")]
        public byte[] CIQPartyVizeimg { get; set; }

        //public int CIQPartyPasID { get; set; }
        //[ForeignKey("CIQPartyPasID")]
        //public virtual PartyPassport partyPassport { get; set; }

        //public int CIQPrID { get; set; }
        //[ForeignKey("CIQPrID")]
        //public virtual PartyReal partyReal { get; set; }
      
    }
}