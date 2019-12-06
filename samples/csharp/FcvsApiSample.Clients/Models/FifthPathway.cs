/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Fifth Pathway information")]
    public class FifthPathway
    {
        [Required]
        [Description("School")]
        public FifthPathwaySchool School { get; set; }

        [Required]
        [Description("Start date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Description("End date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Description("Certification date")]
        public DateTime CertificateDate { get; set; }
    }
}
