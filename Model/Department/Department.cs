﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.Department
{
    public class Department : Base
    {
        public int deptID {  get; set; }

        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
