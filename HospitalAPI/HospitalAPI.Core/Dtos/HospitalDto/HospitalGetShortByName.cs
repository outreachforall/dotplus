﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPI.Core.Dtos
{
    public class HospitalGetDtoShortByName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BranchId { get; set; }
    }
}
