using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    public class Address :Base
    {
        public long userid { get; set; }
        public string? addressType {  get; set; } 
        public string? permDoorNo {  get; set; }
        public string? street { get; set; }
        public string? town{ get; set; }
        public string?  district{ get; set; }

        public string? state { get; set; }
        public string? country { get; set; }
        public long pincode { get; set; }
    }
}
