/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    /// <summary>Represents the UCs for an institution or program.</summary>
    [Description("Unusual circumstances")]
    public class UnusualCircumstances
    {
        [Description("Has an interruption")]
        public bool HasInterruptions { get; set; }

        [Description("Interruption description")]
        public string InterruptionsDescription { get; set; }

        [Description("Interruption start month")]
        public int? InterruptionStartMonth { get; set; }

        [Description("Interruption start year")]
        public int? InterruptionStartYear { get; set; }

        [Description("Interruption end month")]
        public int? InterruptionEndMonth { get; set; }

        [Description("Interruption end year")]
        public int? InterruptionEndYear { get; set; }

        [Description("Has a probation")]
        public bool HasProbation { get; set; }

        [Description("Probation description")]
        public string ProbationDescription { get; set; }

        [Description("Has an investigation")]
        public bool HasInvestigation { get; set; }

        [Description("Investigation description")]
        public string InvestigationDescription { get; set; }

        [Description("Has negative behavior")]
        public bool HasBehavior { get; set; }

        [Description("Behavior description")]
        public string BehaviorDescription { get; set; }

        [Description("Has special requirements")]
        public bool HasRequirements { get; set; }

        [Description("Special requirements description")]
        public string RequirementsDescription { get; set; }
    }
}
