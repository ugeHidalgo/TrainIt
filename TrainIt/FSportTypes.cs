using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainIt
{
    public partial class FSportTypes : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();

        public FSportTypes()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=" + TrainItLibrary.Global.usuario;
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
