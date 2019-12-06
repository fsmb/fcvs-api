/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Mailing address")]
    public class Address
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of address (e.g. Business, Home)")]
        public string AddressType { get; set; }

        [Description("Address lines")]
        public IEnumerable<string> Lines { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("City")]
        public string City { get; set; }

        [Required]
        [Description("State/province")]
        public Region StateOrProvince { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Postal code")]
        public string PostalCode { get; set; }
    }
}
