using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.History
{
    [Serializable]
    public class LoginHistory 
    {
        public long loginID { get; set; } 
        public long userID { get; set; }  
        public string status { get; set; } = "Active";
        public DateTime loginTime { get; set; } = DateTime.Now;
        public DateTime? loginOut { get; set; }
        
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }

    }
}
