/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Identification information")]
    public class Identification
    {
        [Description("Last 4 of the SSN")]
        public string SsnLast4 { get; set; }

        [Description("NPI")]
        public string Npi { get; set; }

        [Description("USMLE ID")]
        public string UsmleId { get; set; }        

        [Description("Date of birth")]
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("City of birth")]
        public string BirthCity { get; set; }

        [Required]
        [Description("State/province of birth")]
        public Region BirthStateOrProvince { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Gender")]
        public string Gender { get; set; }
    }
}
