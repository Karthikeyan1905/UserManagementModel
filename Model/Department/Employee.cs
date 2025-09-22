using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UserManagement.Model.User;
using UserManagementModel.Model;

namespace UserManagement.Model.Department
{
    [Serializable]
    public class Employee 
    {
        
        public long deptID { get; set; }
        public long designationID { get; set; }
        public long employeeID { get; set; }
        public long userID { get; set; }
   
        public Department department { get; set; }
       
        public Designation designation { get; set; }
       
        public UserInfo user { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public long createdBy { get; set; }
        public long updatedBy { get; set; }

    }
}
