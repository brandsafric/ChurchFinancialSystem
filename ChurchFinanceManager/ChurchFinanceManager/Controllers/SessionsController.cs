using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class SessionsController : Controller<Session>
    {
        public SessionsController()
        {
            tableName = "Sessions";
            idName = "sessionId";
        }

        public Session GetLastLoginByUser(User user)
        {
            DataTable dt = FinanceDbManager.CustomQuery(new QueryBuilder().
                SelectAll(tableName).Where("userId").EqualsTo("@userId").OrderBy("start",false).Limit(1),
                new Param("userId",user.id)
                );
            if (dt.Rows.Count > 0)
                return new Session(dt.Rows[0]);
            else
                return null;
        }
    }
}
