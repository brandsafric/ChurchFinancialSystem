using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingsController : IController<Giving>
    {
        private protected string tableName = "Givings";
        private protected string idName = "givingId";

        public List<Giving> ShowAll(params Param[] @params)
        {
            List<Giving> giving = new List<Giving>();
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ALL,tableName);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    giving.Add(new Giving(r));
                }

            }

            return giving;
        }

        public Giving Show(int id)
        {
            Giving giving = null;
            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName,id));
            if (dt.Rows.Count > 0)
            {
                giving = new Giving(dt.Rows[0]);
            }

            return giving;
        }

        public void Add(params Param[] @params)
        {
            Member m = new MembersController().Show(Convert.ToInt32(@params[0].value));
            if (m == null)
            {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.CREATE, tableName, null, null, @params);

        }

        public Giving Update(int id, params Param[] @params)
        {
            Member m = new MembersController().Show(Convert.ToInt32(@params[0].value));
            if (m == null)
            {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.UPDATE, tableName, new Param(idName, id), null, @params);

            DataTable dt = FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.SELECT_ONE, tableName, new Param(idName, id));
            Giving giving = null;
            if (dt.Rows.Count > 0)
                giving = new Giving(dt.Rows[0]);

            return giving;
        }
    

        public void Delete(int id)
        {
            FinanceDbManager.BasicQuery(FinanceDbManager.QueryMode.DELETE, tableName, new Param(idName, id));
        }
    }
}
