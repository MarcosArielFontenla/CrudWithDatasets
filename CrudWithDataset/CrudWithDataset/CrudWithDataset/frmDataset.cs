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
    public partial class frmDataset : Form
    {
        public frmDataset()
        {
            InitializeComponent();
        }

        #region "Eventos"
        private void frmDataset_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPeople frmPeople = new frmPeople();
            frmPeople.ShowDialog();
            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                frmPeople frmPeople = new frmPeople(Id);
                frmPeople.ShowDialog();
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                dsCrudTableAdapters.PeopleTableAdapter ta = new dsCrudTableAdapters.PeopleTableAdapter();
                ta.DeletePeople((int)Id);
                Refresh();
            }
        }
        #endregion

        #region "Metodos"
        private void Refresh()
        {
            dsCrudTableAdapters.PeopleTableAdapter ta = new dsCrudTableAdapters.PeopleTableAdapter();
            dsCrud.PeopleDataTable dt = ta.GetData();
            dgvDataset.DataSource = dt;
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvDataset.Rows[dgvDataset.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
