/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Email address")]
    public class EmailAddress
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Email address")]
        public string Email { get; set; }
    }
}
