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
    [Description("Medical school education")]
    public class MedicalEducation
    {
        [Required]
        [Description("Medical school")]
        public School School { get; set; }

        [Description("Start date")]
        public DateTime BeginDate { get; set; }

        [Description("End date")]
        public DateTime EndDate { get; set; }

        [Description("Degree information")]
        public CodedDescription Degree { get; set; }

        [Description("Graduation date")]
        public DateTime? GraduationDate { get; set; }

        [Required]
        [Description("Unusual circumstances")]
        public UnusualCircumstances UnusualCircumstances { get; set; }
    }
}
