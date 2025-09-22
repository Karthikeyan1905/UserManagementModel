using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UserManagementModel.Model;

namespace UserManagement.Model.User
{
    [Serializable]
    public class UserInfo
    {
        public int userRoleID { get; set; }
        public LoginCredential? loginCredential { get; set; }
        public int userID { set; get; }
        public string? email { set; get; }
        public string? userName { set; get; }
        public string? fatherName { set; get; }
        public string? motherName { set; get; }
        public long aadhaarNumber { set; get; }
        public string? panCardNo { set; get; }
        public string? panCardNumber
        {
            get => panCardNo;
            set
            {
                if (HasPanCard)
                    panCardNumber = value;
            }
        }
        public bool HasPanCard { set; get; }
        public string? passportNo { set; get; }
        public string? passportNumber
        {
            get => passportNo;
            set
            {
                if (HasPassport)
                    passportNumber = value;
            }
        }
        public bool HasPassport { get; set; }
       
        public List<Phone> phone { get; set; }
       
        public List<Education> educations { get; set; }
      
        public List<Address> addresses { get; set; }
        
        public bool HasExperience { get; set; }
     
        public List<Experience> experiance { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int createdBy { get; set; }
        public int updatedBy { get; set; }
        //public static List<UserInfo> RegisteredUsers { get; } = new();


    }
}
