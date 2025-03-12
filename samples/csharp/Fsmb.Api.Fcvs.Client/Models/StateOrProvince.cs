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
    /// <summary>State or province</summary>
    public class StateOrProvince
    {
        /// <summary>State or province code (e.g. `TX`, `MD`)</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(3)]
        public string Code { get; set; }

        /// <summary>State or province description</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Description { get; set; }

        /// <summary>ISO Country code (e.g. `US`, `CA`)</summary>
        [StringLength(2)]
        public string CountryCode { get; set; }

        /// <summary>Country description</summary>
        [StringLength(100)]
        public string CountryDescription { get; set; }
    }
}