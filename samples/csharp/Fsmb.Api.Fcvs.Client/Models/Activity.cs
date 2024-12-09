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
    /// <summary>Activity information</summary>
    public class Activity
    {
        /// <summary>Type of activity</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Type { get; set; }

        /// <summary>Is in progress?</summary>
        public bool InProgress { get; set; }

        /// <summary>Start date</summary>
        public DateTime BeginDate { get; set; }

        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }

        /// <summary>Description</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Description { get; set; }

        //Ensure empty is returned instead of null
        /// <summary>Address lines</summary>
        [Required]
        [StringLength(100)]
        public IEnumerable<string> AddressLines { get; set; } = Enumerable.Empty<string>();

        /// <summary>City</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>State/province</summary>
        [Required]
        public StateOrProvince StateOrProvince { get; set; }

        /// <summary>Postal code</summary>
        [StringLength(9)]
        public string PostalCode { get; set; }

        /// <summary>Position</summary>
        [StringLength(100)]
        public string Position { get; set; }

        /// <summary>Department</summary>
        [StringLength(100)]
        public string Department { get; set; }

        /// <summary>Was employee?</summary>
        public bool WasEmployed { get; set; }

        /// <summary>Had staff privileges?</summary>
        public bool HadStaffPrivileges { get; set; }

        /// <summary>Was affiliated?</summary>
        public bool WasAffiliated { get; set; }

        /// <summary>% clinical</summary>
        public int PercentageClinical { get; set; }

        /// <summary>% administrative</summary>
        public int PercentageAdministrative { get; set; }
    }
}