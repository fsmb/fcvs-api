﻿/*
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
    [Description("Postgraduate training program")]
    public class Program
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Hospital name")]
        public string HospitalName { get; set; }

        [Description("Affiliated institution")]
        public string AffiliatedInstitution { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("City")]
        public string City { get; set; }

        [Required]
        [Description("State/province")]
        public Region StateOrProvince { get; set; }
    }
}
