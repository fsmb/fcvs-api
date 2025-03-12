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
    /// <summary>Mailing address</summary>
    public class Address
    {
        /// <summary>Type of address (e.g. Business, Home)</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string AddressType { get; set; }

        /// <summary>Address lines</summary>    
        [StringLength(100)]
        public IEnumerable<string> Lines { get; set; } = Enumerable.Empty<string>();

        /// <summary>City</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>State/province</summary>
        [Required]
        public StateOrProvince StateOrProvince { get; set; }

        /// <summary>Postal code</summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(9)]
        public string PostalCode { get; set; }
    }
}