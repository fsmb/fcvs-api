/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("ECFMG information")]
    public class Ecfmg
    {
        [Required(AllowEmptyStrings = false)]
        [Description("ECFMG number")]
        public string EcfmgNumber { get; set; }

        [Description("Issue date")]
        public DateTime? IssueDate { get; set; }
    }
}
