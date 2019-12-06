/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Medical school")]
    public class School
    {
        [Required(AllowEmptyStrings = false)]
        [Description("School name")]
        public string Name { get; set; }

        [Description("CIBIS code")]
        public string CibisCode { get; set; }

        [Required]
        [Description("Type of school")]
        public CodedDescription SchoolType { get; set; }

        [Description("City")]
        public string City { get; set; }

        [Description("State/province")]
        public Region StateOrProvince { get; set; }
    }
}
