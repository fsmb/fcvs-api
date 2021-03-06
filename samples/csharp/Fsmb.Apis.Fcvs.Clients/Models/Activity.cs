﻿/*
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
    [Description("Activity information")]
    public class Activity
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of activity")]
        public string Type { get; set; }

        [Description("Is in progress?")]
        public bool InProgress { get; set; }

        [Description("Start date")]
        public DateTime BeginDate { get; set; }

        [Description("End date")]
        public DateTime? EndDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Description")]
        public string Description { get; set; }

        //Ensure empty is returned instead of null
        [Required]
        [Description("Address lines")]
        public IEnumerable<string> AddressLines { get; set; } = Enumerable.Empty<string>();

        [Required(AllowEmptyStrings = false)]
        [Description("City")]
        public string City { get; set; }

        [Required]
        [Description("State/province")]
        public Region StateOrProvince { get; set; }
        
        [Description("Postal code")]
        public string PostalCode { get; set; }

        [Description("Position")]
        public string Position { get; set; }

        [Description("Department")]
        public string Department { get; set; }

        [Description("Was employee?")]
        public bool WasEmployed { get; set; }

        [Description("Had staff privileges?")]
        public bool HadStaffPrivileges { get; set; }

        [Description("Was affiliated?")]
        public bool WasAffiliated { get; set; }
        
        [Description("% clinical")]
        public int PercentageClinical { get; set; }

        [Description("% administrative")]
        public int PercentageAdministrative { get; set; }
    }
}
