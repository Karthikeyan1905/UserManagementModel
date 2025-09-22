using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    [Serializable]
    public class Experience
    {
        public int experienceID { get; set; }              
        public long userID { get; set; }
        public string companyName { get; set; }
        public string companyAddress { get; set; }
        public int workingExperienceInMonths { get; set; }

        public string contactPersonName { get; set; }
        public string contactPersonDesignation { get; set; }
        public long? contactPersonPhone { get; set; }
        public string contactPersonEmail { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }
    }  
}
