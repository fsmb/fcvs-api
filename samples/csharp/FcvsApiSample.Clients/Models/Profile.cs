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
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Practitioner profile for a board")]
    public class Profile
    {
        [Description("Unique ID")]
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("FID of practitioner")]
        public string Fid { get; set; }

        [Description("Date the profile was submitted (UTC)")]
        public DateTime SubmitDateUtc { get; set; }

        [Required]
        [Description("Application information")]
        public Application Application { get; set; } = new Application();

        [Required]
        [Description("Identity")]
        public Identification Identity { get; set; } = new Identification();

        [Required]
        [Description("Names")]
        public Names Names { get; set; } = new Names();

        //Contacts
        [Required]
        [Description("Mailing addresses")]
        public Addresses Addresses { get; set; } = new Addresses();

        [Required]
        [Description("Email addresses")]
        public EmailAddresses EmailAddresses { get; set; } = new EmailAddresses();

        [Required]
        [Description("Phone numbers")]
        public Phones Phones { get; set; } = new Phones();

        [Required]
        [Description("Medical education")]
        public MedicalEducationTraining MedicalEducation { get; set; } = new MedicalEducationTraining();

        [Description("Postgraduate training")]
        public PostGraduateTraining PostGraduateTraining { get; set; }

        [Description("Exams")]
        public IEnumerable<Exam> Exams { get; set; } = Enumerable.Empty<Exam>();

        [Description("Licensure")]
        public IEnumerable<License> Licenses { get; set; } = Enumerable.Empty<License>();

        //Ensure arrays return empty if not set
        [Description("Chronology of activity")]
        public IEnumerable<Activity> Activities { get; set; } = Enumerable.Empty<Activity>();
    }
}
