using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Defaults : System.Web.UI.Page
    {
        private MyEStoreDataContext _Database = new MyEStoreDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            dsNCC.DataSource = _Database.NhaCungCaps.ToList();
            dsNCC.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            dsNCC.DataSource = 
                _Database.NhaCungCaps.Where(item => item.TenCongTy.Contains(txtSearch.Text))
                .ToList();
            dsNCC.DataBind();
        }
    }
}