/*
 * Copyright © 2018 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Medical education")]
    public class MedicalEducationTraining
    {
        [Required]
        [Description("Graduating school")]
        public MedicalEducation Graduating { get; set; }

        //Ensure arrays return empty if not set
        [Description("Other medical schools")]
        public IEnumerable<MedicalEducation> Other { get; set; } = Enumerable.Empty<MedicalEducation>();

        [Description("ECFMG information")]
        public Ecfmg Ecfmg { get; set; }

        [Description("5th Pathway information")]
        public FifthPathway FifthPathway { get; set; }
    }
}
