/*
 * Copyright © Federation of State Medical Boards
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
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Api.Fcvs.Client.Models
{
    /// <summary>Accredited training information</summary>
    public class AccreditedTraining
    {
        /// <summary>The type of accreditation (e.g. ACGME, AOA)</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(5)]
        public string AccreditationType { get; set; }

        /// <summary>Program code</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(10)]
        public string ProgramCode { get; set; }

        /// <summary>Program</summary>
        [Required]
        public PostGraduateProgram Program { get; set; }

        /// <summary>Specialty</summary>
        [Required]
        public Specialty Specialty { get; set; }

        /// <summary>Program type</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string ProgramType { get; set; }

        /// <summary>Training status (e.g. `Active`, `Completed`)</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string TrainingStatus { get; set; }

        /// <summary>Start date</summary>
        public DateTime BeginDate { get; set; }

        /// <summary>End date</summary>
        public DateTime EndDate { get; set; }

        /// <summary>Unusual circumstances</summary>
        [Required]
        public UnusualCircumstances UnusualCircumstances { get; set; }
    }
}