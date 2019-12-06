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
    [Description("Name of a person")]
    public class Name
    {
        [Required(AllowEmptyStrings = false)]
        [Description("First name")]
        public string FirstName { get; set; }

        [Description("Middle name")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Last name")]
        public string LastName { get; set; }

        [Description("Suffix")]
        public string Suffix { get; set; }
    }
}
