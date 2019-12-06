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
    [Description("Geographic region")]
    public class Region
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Region code")]
        public string Code { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Description")]
        public string Description { get; set; }

        [Description("ISO Country code")]
        public string CountryCode { get; set; }

        [Description("Country description")]
        public string CountryDescription { get; set; }
    }
}
