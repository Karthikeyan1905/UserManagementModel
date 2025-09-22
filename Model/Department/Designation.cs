using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.Department
{
    [Serializable]
    public class Designation
    {
        public int designationID { get; set; }
        public string? designationName { get; set; }
        public string? designationShortName { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }
    }
}
