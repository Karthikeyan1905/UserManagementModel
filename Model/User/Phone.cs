using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    [Serializable]
    public class Phone
    {
        public int phoneID { get; set; }            
        public long userID { get; set; }
        public long phoneNumber {  get; set; }
        public string? phoneType { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }
    }
}
