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
    [Description("License information")]
    public class License
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of license")]
        public string LicenseType { get; set; }        

        [Description("Entity issuing license")]
        public CodedDescription LicensingEntity { get; set; }

        [Description("License status")]
        public string Status { get; set; }

        [Description("Practitioner type")]
        public CodedDescription PractitionerType { get; set; }

        [Description("License number")]
        public string LicenseNumber { get; set; }

        [Description("Issue date")]
        public DateTime? IssueDate { get; set; }

        [Description("Expiration date")]
        public DateTime? ExpirationDate { get; set; }
    }
}
