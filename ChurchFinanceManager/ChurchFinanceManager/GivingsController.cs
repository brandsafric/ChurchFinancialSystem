using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingsController
    {
        public List<Giving> ViewGivings() {
            List<Giving> giving = new List<Giving>();
            DataTable dt = FinanceDbManager.GivingQuery(FinanceDbManager.QueryMode.SELECT_ALL);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    giving.Add(FinanceDbManager.DataRowToGiving(r));
                }

            }

            return giving;
        }

        public Giving ViewGiving(int givingId) {
            Giving giving = null;
            DataTable dt = FinanceDbManager.GivingQuery(FinanceDbManager.QueryMode.SELECT_ONE, givingId);
            if (dt.Rows.Count > 0)
            {
                giving = FinanceDbManager.DataRowToGiving(dt.Rows[0]);
            }

            return giving;
        }

        public void AddGiving(Member member, DateTime givingDate) {
            if (member == null) {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.GivingQuery(
                FinanceDbManager.QueryMode.CREATE, Int32.MinValue,
                member.memberId,
                givingDate);

        }

        public void UpdateGiving(int givingId, Member member, DateTime givingDate) {
            if (member == null)
            {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FinanceDbManager.GivingQuery(
                    FinanceDbManager.QueryMode.UPDATE, 
                    givingId,
                    member.memberId,
                    givingDate);
        }

        public void DeleteGiving(int givingId) {
            FinanceDbManager.GivingQuery(FinanceDbManager.QueryMode.DELETE, givingId);
        }
    }
}
