using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    [Serializable]
    public class Address 
    {
        public long userid { get; set; }
        public long addressid { get; set; }

        public string? addressType {  get; set; } 
        public string? permDoorNo {  get; set; }
        public string? street { get; set; }
        public string? town{ get; set; }
        public string?  district{ get; set; }

        public string? state { get; set; }
        public string? country { get; set; }
        public long pincode { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }
    }
}
