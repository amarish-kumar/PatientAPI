﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Dto
{
    public class StayDto
    {
        public int StayId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Room { get; set; }
        public string Department { get; set; }
        public int PatientId { get; set; }
    }
}
