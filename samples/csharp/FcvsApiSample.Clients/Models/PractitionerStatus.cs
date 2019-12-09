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
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    /// <summary>Provides the status of a practitioner.</summary>
    [Description("Represents the status of a practitioner.")]
    public class PractitionerStatus
    {
        /// <summary>The FID of the practitioner.</summary>
        [Required(AllowEmptyStrings = false)]
        [Description("The FID.")]
        public string Fid { get; set; }

        /// <summary>The name of the practitioner.</summary>
        [Required]
        [Description("The name.")]
        public Name Name { get; set; }

        /// <summary>Gets or sets the ID of the practitioner.</summary>
        [Description("The ID of the last profile.")]
        public long LastProfileId { get; set; }

        /// <summary>Gets or sets the status of the last profile.</summary>
        [Description("The status of the last profile.")]
        public string LastProfileStatus { get; set; }

        /// <summary>Gets or sets the last submit date, in UTC.</summary>
        [Description("The date/time the last profile was submitted, in UTC.")]
        public DateTime LastProfileSubmitDateUtc { get; set; }

        /// <summary>Gets or sets the last sent date, in UTC.</summary>
        [Description("The date/time the last profile was sent, in UTC.")]
        public DateTime? LastProfileSentDateUtc { get; set; }
    }
}
