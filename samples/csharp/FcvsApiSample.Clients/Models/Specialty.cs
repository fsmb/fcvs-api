/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Training specialty")]
    public class Specialty
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Description")]
        public string Description { get; set; }
    }
}
