/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Phone number")]
    public class Phone
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of phone (e.g. Business, Home, Mobile)")]
        public string PhoneType { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Phone number")]
        public string PhoneNumber { get; set; }

        [Description("Phone extension")]
        public string Extension { get; set; }
    }
}
