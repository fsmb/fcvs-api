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

namespace Fsmb.Apis.Fcvs.Clients
{
    [Description("License information")]
    public class License
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of license")]
        public string LicenseType { get; set; }        

        [Description("Entity issuing license")]
        public CodedDescription LicensingEntity { get; set; }

        [Description("License status")]
        public string Status { get; set; }

        [Description("Practitioner type")]
        public CodedDescription PractitionerType { get; set; }

        [Description("License number")]
        public string LicenseNumber { get; set; }

        [Description("Issue date")]
        public DateTime? IssueDate { get; set; }

        [Description("Expiration date")]
        public DateTime? ExpirationDate { get; set; }
    }
}
