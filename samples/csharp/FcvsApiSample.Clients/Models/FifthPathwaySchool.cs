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
    [Description("Fifth Pathway school information")]
    public class FifthPathwaySchool
    {
        [Required(AllowEmptyStrings = false)]
        [Description("School name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Affiliated institution")]
        public string AffiliatedInstitution { get; set; }
        
        [Description("City")]
        public string City { get; set; }

        [Description("State/province")]
        public Region StateOrProvince { get; set; }
    }
}
