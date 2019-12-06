/*
 * Copyright © 2017 Federation of State Medical Boards
 * All Rights Reserved
 */
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Apis.FCVS.Clients.Models
{
    [Description("Exam")]
    public class Exam
    {
        [Required(AllowEmptyStrings = false)]
        [Description("Type of exam")]
        public string ExamType { get; set; }

        [Description("State board code and description (for state exams)")]
        public CodedDescription StateBoardDetail { get; set; }

        [Description("Exam date")]
        public DateTime ExamDate { get; set; }

        [Description("Number of attempts")]
        public int NumberOfAttempts { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Description("Pass/fail status (Pass, Fail, Unknown)")]
        public string PassFail { get; set; }
    }
}
