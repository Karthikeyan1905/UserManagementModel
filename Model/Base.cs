namespace UserManagementModel.Model
{
    public class Base
    {
        
            public string status { get; set; }
            public DateTime CreatedOn { get; set; }
            public DateTime UpdatedOn { get; set; }

            public int createdBy { get; set; }
            public int updatedBy { get; set; }

        
    }
}
