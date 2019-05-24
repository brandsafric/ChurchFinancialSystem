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

        public enum QueryMode { SELECT_ALL, SELECT_PARAM, SELECT_ONE, CREATE, UPDATE, DELETE };
      
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
                    dt = sql.ExecQuery("SELECT * FROM @tableName WHERE memberId = @memberId");
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

        #region Giving
        //givingId ,memberId,givingDate DATE,entryDate DATE,
        public static DataTable GivingQuery(QueryMode mode,int givingId = 0, int memberId = 0, DateTime? givingDate = null)
        {
            givingDate = givingDate ?? DateTime.Now;
            
            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();

            switch (mode)
            {
                case QueryMode.SELECT_ALL:
                    dt = sql.ExecQuery("SELECT * FROM Givings");
                    break;
                case QueryMode.SELECT_ONE:
                    sql.AddParam("givingId", givingId);
                    dt = sql.ExecQuery("SELECT * FROM Givings WHERE givingId = @givingId");
                    break;
                case QueryMode.CREATE:
                    sql.AddParam("memberId", memberId);
                    sql.AddParam("givingDate", givingDate);
                    sql.AddParam("entryDate", DateTime.Now);
                    sql.ExecQuery("INSERT INTO Givings(memberId, givingDate, entryDate) VALUES(@memberId, @givingDate, @entryDate)");
                    break;
                case QueryMode.UPDATE:
                    sql.AddParam("givingId", givingId);
                    sql.AddParam("memberId", memberId);
                    sql.AddParam("givingDate", DateTime.Now);
                    sql.ExecQuery("UPDATE Givings SET memberId = @memberId, givingDate = @givingDate WHERE givingId = @givingId");
                    break;
                case QueryMode.DELETE:
                    sql.AddParam("givingId", givingId);
                    sql.ExecQuery("DELETE FROM Givings WHERE givingId = @givingId");
                    break;
            }

            if (sql.error != null)
                MessageBox.Show("An error occured \n \n Error: " + sql.error.Message.ToString(), "Offering Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return dt;

        }

        public static Giving DataRowToGiving(DataRow r)
        {
            Giving gt = new Giving(
                         Convert.ToInt32(r["givingId"]),
                         Convert.ToInt32(r["memberId"]),
                         Convert.ToDateTime(r["givingDate"]),
                         Convert.ToDateTime(r["entryDate"])
                         );
            return gt;
        }
        #endregion

        #region GivingItem
        //givingId ,memberId,givingDate DATE,entryDate DATE,
        public static DataTable GivingItemQuery(QueryMode mode, int givingItemId = 0, int givingId = 0, int givingTypeId = 0, double amount = 0.0)
        {

            DataTable dt = new DataTable();
            SQLManager sql = new SQLManager();

            switch (mode)
            {
                case QueryMode.SELECT_ALL:
                    sql.AddParam("givingId", givingId);
                    dt = sql.ExecQuery("SELECT * FROM GivingItems WHERE givingId = @givingId");
                    break;
                case QueryMode.SELECT_ONE:
                    sql.AddParam("givingItemId", givingItemId);
                    dt = sql.ExecQuery("SELECT * FROM GivingItems WHERE givingItemId = @givingItemId");
                    break;
                case QueryMode.CREATE:
                    sql.AddParam("givingId", givingId);
                    sql.AddParam("givingTypeId", givingTypeId);
                    sql.AddParam("amount", amount);
                    sql.ExecQuery("INSERT INTO GivingItems(givingId, givingTypeId, amount) VALUES(@givingId, @givingTypeId, @amount)");
                    break;
                case QueryMode.UPDATE:
                    sql.AddParam("givingItemId", givingItemId);
                    sql.AddParam("givingId", givingId);
                    sql.AddParam("givingTypeId", givingTypeId);
                    sql.AddParam("amount", amount);
                    sql.ExecQuery("UPDATE GivingItems SET givingId = @givingId, givingTypeId = @givingTypeId, amount = @amount WHERE givingItemId = @givingItemId");
                    break;
                case QueryMode.DELETE:
                    sql.AddParam("givingItemId", givingItemId);
                    sql.ExecQuery("DELETE FROM GivingItems WHERE givingItemId = @givingItemId");
                    break;
            }

            if (sql.error != null)
                MessageBox.Show("An error occured \n \n Error: " + sql.error.Message.ToString(), "Offering Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return dt;

        }

        public static GivingItem DataRowToGivingItem(DataRow r)
        {
            GivingsController gc = new GivingsController();
            GivingTypesController gtc = new GivingTypesController();
            GivingItem gt = new GivingItem(
                Convert.ToInt32(r["givingItemId"]),
                gc.ViewGiving(Convert.ToInt32(r["givingId"])),
                gtc.ViewGivingType(Convert.ToInt32(r["givingTypeId"])),
                Convert.ToDouble(r["amount"])
                         );
            return gt;
        }
        #endregion
    }
}
