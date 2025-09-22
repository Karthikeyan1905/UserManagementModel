using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Model.Department;
using UserManagementModel.Model;

namespace UserManagement.Model.Team
{
    [Serializable]
    public class TeamUser
    {
        public int userid { get; set; }
        public int teamID { get; set; }
        public int employeeID { get; set; }
        public int teamuserID { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }

    }
}
