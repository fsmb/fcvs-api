/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Non-accredited postgraduate training")]
    public class OtherTraining
    {        
        [Required]
        [Description("Program")]
        public Program Program { get; set; }

        [Required]
        [Description("Specialty")]
        public Specialty Specialty { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        [Description("Program type")]
        public string ProgramType { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Training status")]
        public string TrainingStatus { get; set; }

        [Description("Start date")]
        public DateTime BeginDate { get; set; }

        [Description("End date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Description("Unusual circumstances")]
        public UnusualCircumstances UnusualCircumstances { get; set; }
    }
}
