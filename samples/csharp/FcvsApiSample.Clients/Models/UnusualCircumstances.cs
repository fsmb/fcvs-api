/*
 * Copyright © 2019 Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
