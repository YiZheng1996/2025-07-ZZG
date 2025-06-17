using System.Data;

namespace MainUI.Model
{
    public class UserInfo : RW.Components.User.Model.UserInfo
    {
        /// <summary>
        /// 工作人员工号
        /// </summary>
        public string JobNumber { get; set; }


        public new void InitUser(DataRow row)
        {
            Username = row["username"].ToString();
            Password = row["Password"].ToString();
            Permission = row["Permission"].ToString();
            ID = Convert.ToInt32(row["ID"]);
            Sort = Convert.ToInt32(row["Sort"]);
            JobNumber = row["JobNumber"].ToString();
        }
    }
}
