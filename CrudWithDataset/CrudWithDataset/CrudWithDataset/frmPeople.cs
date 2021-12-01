using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWithDataset
{
    public partial class frmPeople : Form
    {
        private int? Id;

        public frmPeople(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        #region "Eventos"
        private void frmPeople_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                dsCrudTableAdapters.PeopleTableAdapter ta = new dsCrudTableAdapters.PeopleTableAdapter();
                dsCrud.PeopleDataTable dt = ta.GetDataById((int)Id);
                dsCrud.PeopleRow row = (dsCrud.PeopleRow)dt.Rows[0];
                txtName.Text = row.Name;
                numAge.Value = row.Age;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dsCrudTableAdapters.PeopleTableAdapter ta = new dsCrudTableAdapters.PeopleTableAdapter();

            if (Id == null)
                ta.AddPeople(txtName.Text, (int)numAge.Value);
            else
                ta.EditPeople(txtName.Text.Trim(), (int)numAge.Value, (int)Id);

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
