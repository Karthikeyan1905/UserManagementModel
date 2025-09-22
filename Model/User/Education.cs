using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    [Serializable]
    public class Education
    {
        public int educationID { get; set; }          
        public long userID { get; set; }
        public string? instituteName { set; get; }
        public string? instituteAddress { set; get; }
        public string? board {  set; get; }
        public string? courseName {  set; get; }
        public float percentage {  set; get; }
        public int startYear {  set; get; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public long createdBy { get; set; }
        public long updatedBy { get; set; }

    }
}
