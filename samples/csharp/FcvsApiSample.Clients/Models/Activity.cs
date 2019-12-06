/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Fsmb.Apis.FCVS.Clients.Models
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
