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
    /// <summary>Summary information about a profile</summary>
    public class ProfileSummary
    {
        /// <summary>Profile ID</summary>
        public long Id { get; set; }

        /// <summary>FID of the physician</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(9)]
        public string Fid { get; set; }

        /// <summary>Names</summary>
        [Required]
        public Name Name { get; set; }

        /// <summary>Date/time the profile was sent to the board</summary>
        public DateTime? SentDate { get; set; }

        /// <summary>Date/time the profile was submitted</summary>
        public DateTime SubmitDate { get; set; }

        /// <summary>Status of the profile</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Status { get; set; }
    }
}