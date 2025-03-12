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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Api.Fcvs.Client.Models
{
    /// <summary>Practitioner profile for a board</summary>
    public class Profile
    {
        /// <summary>Profile ID</summary>
        [Range(0, Int64.MaxValue)]
        public long Id { get; set; }

        /// <summary>FID of practitioner</summary>
        [Required(AllowEmptyStrings = false)]        
        [StringLength(9)]
        [RegularExpression(@"\d{9}")]
        public string Fid { get; set; }

        /// <summary>Date the profile was submitted (UTC)</summary>
        public DateTime SubmitDateUtc { get; set; }

        /// <summary>Application information</summary>
        [Required]
        public Application Application { get; set; }

        /// <summary>Identity</summary>
        [Required]
        public Identification Identity { get; set; }

        /// <summary>Names</summary>
        [Required]
        public Names Names { get; set; }
        
        /// <summary>Mailing addresses</summary>
        [Required]
        public Addresses Addresses { get; set; }

        /// <summary>Email addresses</summary>
        [Required]
        public EmailAddresses EmailAddresses { get; set; }

        /// <summary>Phone numbers</summary>
        [Required]
        public Phones Phones { get; set; }

        /// <summary>Medical education</summary>
        [Required]
        public MedicalEducationTraining MedicalEducation { get; set; }

        /// <summary>Postgraduate training</summary>
        public PostGraduateTraining PostGraduateTraining { get; set; }

        /// <summary>Exams</summary>
        public IEnumerable<Exam> Exams { get; set; } = Enumerable.Empty<Exam>();

        /// <summary>Licensure</summary>
        public IEnumerable<License> Licenses { get; set; } = Enumerable.Empty<License>();

        /// <summary>Chronology of activity</summary>
        public IEnumerable<Activity> Activities { get; set; } = Enumerable.Empty<Activity>();
    }
}