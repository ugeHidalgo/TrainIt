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
    public partial class FMaterial : Form
    {
        string connString = TrainItLibrary.Utilities.GetConnString();

        public FMaterial()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking+")"+TrainItLibrary.Global.userNameWorking;
        }

        private void FMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
