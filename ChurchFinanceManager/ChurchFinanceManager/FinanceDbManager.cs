using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchFinanceManager
{
    static class  FinanceDbManager
    {

        public enum QueryMode { SELECT_ALL, SELECT_ONE, CREATE, UPDATE, DELETE };
      
        #region Members
        public static DataTable MemberQuery(QueryMode mode,int memberId = 0, string firstName = "", string middleName = "", string lastName = "", string city = "", DateTime? birthday = null, bool isRegular = true)
        {
            birthday = birthday ?? DateTime.MinValue;
            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();

            switch(mode){
                case QueryMode.SELECT_ALL:
                    dt = sql.ExecQuery("SELECT * FROM Members");
                    break;
                case QueryMode.SELECT_ONE:
                    sql.AddParam("memberId",memberId);
                    dt = sql.ExecQuery("SELECT * FROM Members WHERE memberId = @memberId");
                    break;
                case QueryMode.CREATE:
                    sql.AddParam("firstName",firstName);
                    sql.AddParam("middleName",middleName);
                    sql.AddParam("lastName",lastName);
                    sql.AddParam("city",city);
                    sql.AddParam("birthday",birthday);
                    sql.AddParam("isRegular", isRegular);
                    sql.ExecQuery("INSERT INTO Members(firstName, middleName, lastName, city, birthday, isRegular) VALUES(@firstName, @middleName, @lastName, @city, @birthday, @isRegular)");
                    break;
                case QueryMode.UPDATE:
                    sql.AddParam("memberId", memberId);
                    sql.AddParam("firstName", firstName);
                    sql.AddParam("middleName", middleName);
                    sql.AddParam("lastName", lastName);
                    sql.AddParam("city", city);
                    sql.AddParam("birthday", birthday);
                    sql.AddParam("isRegular", isRegular);
                    sql.ExecQuery("UPDATE Members SET firstName = @firstName, middleName = @middleName, lastName = @lastName, city = @city, birthday = @birthday, isRegular = @isRegular WHERE memberId = @memberId");
                    break;
                case QueryMode.DELETE:
                    sql.AddParam("memberId", memberId);
                    sql.ExecQuery("DELETE FROM Members WHERE memberId = @memberId");
                    break;
            }

            if (sql.error != null)
                MessageBox.Show("An error occured \n \n Error: " + sql.error.Message.ToString(), "Member Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return dt;
                
        }

        public static Member DataRowToMember(DataRow r) {
            Member m = new Member(
                         Convert.ToInt32(r["memberId"]),
                         r["firstName"].ToString(),
                         r["middleName"].ToString(),
                         r["lastName"].ToString(),
                         Convert.ToDateTime(r["birthday"]).Date,
                         r["city"].ToString(),
                         Convert.ToBoolean(r["isRegular"]));
            return m;
        }
        #endregion

        #region GivingType
        //int givingTypeId, string title, bool isRegular, bool isActive
        public static DataTable GivingTypeQuery(QueryMode mode, int givingTypeId = 0, string title = "", bool isRegular = true, bool isActive = true)
        {
            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();

            switch (mode)
            {
                case QueryMode.SELECT_ALL:
                    dt = sql.ExecQuery("SELECT * FROM GivingTypes");
                    break;
                case QueryMode.SELECT_ONE:
                    sql.AddParam("givingTypeId", givingTypeId);
                    dt = sql.ExecQuery("SELECT * FROM GivingTypes WHERE givingTypeId = @givingTypeId");
                    break;
                case QueryMode.CREATE:
                    sql.AddParam("title", title);
                    sql.AddParam("isRegular", isRegular);
                    sql.AddParam("isActive", isActive);
                    sql.ExecQuery("INSERT INTO GivingTypes(title, isRegular, isActive) VALUES(@title, @isRegular, @isActive)");
                    break;
                case QueryMode.UPDATE:
                    sql.AddParam("givingTypeId", givingTypeId);
                    sql.AddParam("title", title);
                    sql.AddParam("isRegular", isRegular);
                    sql.AddParam("isActive", isActive);
                    sql.ExecQuery("UPDATE GivingTypes SET title = @title, isRegular = @isRegular, isActive = @isActive WHERE givingTypeId = @givingTypeId");
                    break;
                case QueryMode.DELETE:
                    sql.AddParam("givingTypeId", givingTypeId);
                    sql.ExecQuery("DELETE FROM GivingTypes WHERE givingTypeId = @givingTypeId");
                    break;
            }

            if (sql.error != null)
                MessageBox.Show("An error occured \n \n Error: " + sql.error.Message.ToString(), "Offering Types Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return dt;

        }

        public static GivingType DataRowToGivingType(DataRow r)
        {
           
            GivingType gt = new GivingType(
                         Convert.ToInt32(r["givingTypeId"]),
                         r["title"].ToString(),
                         Convert.ToBoolean(r["isRegular"]),
                         Convert.ToBoolean(r["isActive"])
                         );
            return gt;
        }
        #endregion
    }
}
