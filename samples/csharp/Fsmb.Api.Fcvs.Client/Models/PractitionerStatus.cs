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
    /// <summary>Status of a practitioner</summary>
    public class PractitionerStatus
    {
        /// <summary>FID of the practitioner</summary>
        [Required(AllowEmptyStrings = false)]        
        [StringLength(9)]
        public string Fid { get; set; }

        /// <summary>Name of the practitioner</summary>
        [Required]
        public Name Name { get; set; }

        /// <summary>ID of the last profile</summary>
        public long LastProfileId { get; set; }

        /// <summary>Status of the last profile</summary>
        [StringLength(50)]
        public string LastProfileStatus { get; set; }

        /// <summary>Date/time the last profile was submitted, in UTC</summary>
        public DateTime LastProfileSubmitDateUtc { get; set; }

        /// <summary>Date/time the last profile was sent, in UTC, if any</summary>
        public DateTime? LastProfileSentDateUtc { get; set; }
    }
}