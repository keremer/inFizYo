using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using inFizYon.Ontology;

namespace inFizYon.CIQModels
{
    public class PartyPostalAdress

//ENTITY IfcPostalAddress
	
//  SUBTYPE OF ( 	IfcAddress);
	
//      InternalLocation    :  	OPTIONAL IfcLabel;
//      AddressLines 	    :  	OPTIONAL LIST [1:?] OF IfcLabel;
//      PostalBox 	        :  	OPTIONAL IfcLabel;
//      Town 	            :  	OPTIONAL IfcLabel;
//      Region 	            :  	OPTIONAL IfcLabel;
//      PostalCode 	        :  	OPTIONAL IfcLabel;
//      Country 	        :  	OPTIONAL IfcLabel;
//  WHERE
	
//      WR1 	            :  	EXISTS (InternalLocation) OR EXISTS (AddressLines) OR EXISTS (PostalBox) OR EXISTS (PostalCode) OR EXISTS (Town) OR EXISTS (Region) OR EXISTS (Country);
//END_ENTITY; 

    {
        [Display(Name = "adres ID", Prompt = "adres ID")]
        [Key]
        public int CIQAdresPID { get; set; }

        public string CIQadrtype { get; set; }
        public string CIQinternalLocation { get; set; }
        public string CIQadrline1 { get; set; }
        public string CIQadrline2 { get; set; }
        public string CIQpostalbox { get; set; }
        public string CIQtown { get; set; }
        public string CIQregion { get; set; }
        public string CIQZIP { get; set; }
        public string CIQcountry { get; set; }
        public DateTime CIQadrValidfrom { get; set; }
        public DateTime? CIQadrValidto { get; set; }
        public short CIQLocalizationIndex { get; set; }

        public virtual ICollection<PartyAdress> SendPostTo { get; set; }
    }
}