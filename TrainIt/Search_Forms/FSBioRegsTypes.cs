using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainItLibrary;

namespace TrainIt.Search_Forms
{
    public partial class FSBioRegsTypes : Form
    {
        Int64 userIDWorking = Global.userIDWorking;

        public FSBioRegsTypes()
        {
            InitializeComponent();
        }

        private void bioRegTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bioRegTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainITDataSet);        
        }

        private void FSBioRegsTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainITDataSet.BioRegTypes' table. You can move, or remove it, as needed.
            this.bioRegTypesTableAdapter.FillBy(this.trainITDataSet.BioRegTypes, userIDWorking);
        }

        private void bioRegTypesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBioRegType[0, dgvBioRegType.CurrentRow.Index].Value != null)
                Global.bioRegTypeIDSelected = Convert.ToInt64(dgvBioRegType[0, dgvBioRegType.CurrentRow.Index].Value);
            else
                Global.bioRegTypeIDSelected = 0;
            this.Close();
        }


    }
}
