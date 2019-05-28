using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    public class Session : Model
    {
        public User user;
        public DateTime start;
        public DateTime end;

        SessionsController sc = new SessionsController();
        public Session(DataRow r)
        {
            id = Convert.ToInt32(r["sessionId"]);
            user = new User(Convert.ToInt32(r["userId"]));
            start = r["start"] != DBNull.Value ? Convert.ToDateTime(r["start"]) : DateTime.MinValue;
            end = r["end"] != DBNull.Value ? Convert.ToDateTime(r["end"])  : DateTime.MinValue;
        }

        public Session(int id)
        {
            Session s = new SessionsController().Show(id);
            id = s.id;
            user = s.user;
            end = s.end;
        }

        public Session(User user)
        {
            sc.Add(
                new Param("userId", user.id),
                new Param("start", DateTime.Now)
                );
            Session s = sc.GetLastAdded();
            id = s.id;
            user = s.user;
            end = s.end;
        }

        public void EndSession()
        {
            sc.Update(id,
                new Param("end",DateTime.Now)
                );
        }

        public bool hasEndedProperly()
        {
            Console.WriteLine(start.ToString() + " to " + end.ToString());
            if (DateTime.Compare(start, end) >= 0) return false;
            else return true;
        }
    }
}
