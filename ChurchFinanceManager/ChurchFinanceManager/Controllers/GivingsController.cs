using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchFinanceManager
{
    class GivingsController : Controller<Giving>
    {
        public GivingsController()
        {
            tableName = "Givings";
            idName = "givingId";
        }

     
        public override void Add(params Param[] @params)
        {
            Member m = new MembersController().Show(Convert.ToInt32(@params[0].value));
            if (m == null)
            {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.Add(@params);

        }

        public override Giving Update(int id, params Param[] @params)
        {
            Member m = new MembersController().Show(Convert.ToInt32(@params[0].value));
            if (m == null)
            {
                MessageBox.Show("Member not found! Ensure that the member is registered!", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return base.Update(id,@params);
        }

    }
}
