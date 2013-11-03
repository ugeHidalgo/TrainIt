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
using System.Data.SqlTypes;

namespace TrainIt
{
    public partial class FMaterial : Form
    {
        private static bool onSearchMode;
        string connString = TrainItLibrary.Utilities.GetConnString();
        Int64 userIDWorking = TrainItLibrary.Global.userIDWorking;
        bool onEdition = false;
        bool returnValue = false;

        public bool OnSearchMode
        {
            get { return onSearchMode; }
            set { onSearchMode = value; }
        }

        public FMaterial()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + TrainItLibrary.Global.userIDWorking+")"+TrainItLibrary.Global.userNameWorking;

            setNormalMode();
        }

        private void FMaterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
            else
            {

                Global.materialUsed = Global.materialUsed.LoadDataFromView(txtID.Text, txtName.Text, txtModel.Text, txtBrand.Text, txtSize.Text, mtxtWeight.Text, dtpBuyDate.Value.ToString(),
                                                     txtCost.Text, mtxtInitTime.Text, txtInitDist.Text, mtxtRecTime.Text, txtRecDist.Text, txtBuyMemo.Text, txtUserID.Text);
                e.Cancel = false;
                OnSearchMode = false;
                if (returnValue)
                    OnSearchMode = true;
            }
        }

        private void setEditMode()
        {
            onEdition = true;

            txtName.ReadOnly = false;
            txtModel.ReadOnly = false;
            txtBrand.ReadOnly = false;
            txtSize.ReadOnly = false;
            mtxtWeight.ReadOnly = false;
            dtpBuyDate.Enabled = true;
            txtCost.ReadOnly = false;
            txtBuyMemo.ReadOnly = false;
            mtxtInitTime.ReadOnly = false;
            txtInitDist.ReadOnly = false;
            txtRecDist.ReadOnly = false;
            mtxtRecTime.ReadOnly = false;

            dgvMat.Enabled = false;

            tsBtnFirst.Enabled = false;
            tsBtnPrevious.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnCancel.Enabled = true;
            tsBtnSave.Enabled = true;
            tsBtnDel.Enabled = false;

            btnLoadImage.Enabled = true;
            btnCancelImage.Enabled = true;

            btnChoose.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void setNormalMode()
        {
            onEdition = false;

            txtName.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtBrand.ReadOnly = true;
            txtSize.ReadOnly = true;
            mtxtWeight .ReadOnly = true;
            dtpBuyDate.Enabled = false;
            txtCost.ReadOnly = true;
            txtBuyMemo.ReadOnly = true;
            mtxtInitTime.ReadOnly = true;
            txtInitDist.ReadOnly = true;
            txtRecDist.ReadOnly = true;
            mtxtRecTime.ReadOnly = true;

            dgvMat.Enabled = true;

            tsBtnFirst.Enabled = true;
            tsBtnPrevious.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnCancel.Enabled = false;
            tsBtnSave.Enabled = false;
            tsBtnDel.Enabled = true;

            btnLoadImage.Enabled = false;
            btnCancelImage.Enabled = false;

            btnChoose.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void resetFields()
        {
            txtUserID.Text = userIDWorking.ToString();
            mtxtWeight.Text = "0,000";
            dtpBuyDate.Value = DateTime.Now;
            txtCost.Text = "0,00";
            txtInitDist.Text = "0";
            txtRecDist.Text = "0";
            txtUseDist.Text = "0";
            mtxtInitTime.Text = "00:00:00";
            mtxtRecTime.Text = "00:00:00";
            txtUseTime.Text = "00:00:00";
            txtTimeBar.Width = 0;
            txtDistBar.Width = 0;
        }

        private void FMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainITDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.trainITDataSet.Materials, userIDWorking);

            //Load data into object from bd
            TrainItLibrary.Global.materialUsed = LoadObject();

            //if this form is shomw in order to search, then enable buttons for search
            btnChoose.Visible = OnSearchMode;
            btnCancel.Visible = OnSearchMode;

            //Set the masks for text box
            mtxtWeight.ValidatingType = typeof(float);  
         
            //Set the values for the progress bars
            calculateDistBar(txtDistBar,txtBarsBack);
            calculateTimeBar(txtTimeBar, txtBarsBack);
        }

        private Material LoadObject()
        {//Loads the object in the screen into the model.
            Material aMat = new Material();
            aMat.MatID = Convert.ToInt64(txtID.Text);
            aMat.MatName = txtName.Text;
            aMat.MatModel = txtModel.Text;
            aMat.MatBrand = txtBrand.Text;
            aMat.MatSize = txtSize.Text;

            if (mtxtWeight.Text == "")
                aMat.MatWeight = 0.00M;
            else
            {
                try
                {
                    aMat.MatWeight = Convert.ToDecimal(mtxtWeight.Text);
                }
                catch (Exception)
                {
                    aMat.MatWeight = 0.00M;
                }
            }
            
            aMat.MatBuyDate = dtpBuyDate.Value;

            if (txtCost.Text=="")
                aMat.MatCost=(SqlMoney)0.00F;
            else 
            {
                try
                {                
                    aMat.MatCost = (SqlMoney)Convert.ToDouble(txtCost.Text);
                }
                catch (Exception)
                {
                    aMat.MatCost = (SqlMoney)0.00F;
                }
            }
            
            aMat.MatInitTime = mtxtInitTime.Text;

            if (txtInitDist.Text == "")
                aMat.MatInitDist = 0.000M;
            else
            {
                try
                {
                    aMat.MatInitDist = Convert.ToDecimal(txtInitDist.Text);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
            
            aMat.MatRecTime = mtxtRecTime.Text;

            if (txtRecDist.Text == "")
                aMat.MatRecDist = 0.000M;
            else
            {
                try
                {
                    aMat.MatRecDist = Convert.ToDecimal(txtRecDist.Text);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
            aMat.MatBuyMemo = txtBuyMemo.Text;
            aMat.MatID = userIDWorking; 
            return aMat;
        }

        private void calculateDistBar(TextBox barra, TextBox fondo)
        {
            //Distance progress bar
            Boolean applyValues = false;
            int maxWidth = fondo.Width-4;
            double maxValue = 100;
            double actualValue = 0;
            double position = 0;
            int W1 = (maxWidth * 60) / 100;
            int W2 = (maxWidth * 80) / 100;
            int W3 = (maxWidth * 90) / 100;
            

            try
            {
                actualValue = Convert.ToDouble(txtUseDist.Text);
                applyValues = true;
            }
            catch (Exception)
            {
                applyValues = false;
            }

            try
            {
                maxValue = Convert.ToDouble(txtRecDist.Text);
                applyValues = true;
            }
            catch (Exception)
            {
                applyValues = false;
            }

            if (actualValue > maxValue)
            {
                applyValues = false;
                position = fondo.Width-2;
            }

            if ((applyValues) && (maxValue != 0))
            {
                position = (actualValue * maxWidth) / maxValue;
            }

            //Set value
            barra.Width = (int)position;

            //Set color dependig value
            if (position < W1)
                barra.BackColor = Color.Green;
            if ((position >= W1) && (position < W2))
                barra.BackColor = Color.Yellow;
            if ((position >= W2) && (position < W3))
                barra.BackColor = Color.Orange;
            if (position >= W3)
                barra.BackColor = Color.Red;
        }

        private void calculateTimeBar(TextBox barra, TextBox fondo)
        {
            //Distance progress bar
            Boolean applyValues = false;
            int maxWidth = fondo.Width - 4;
            double maxValue = 100;
            double actualValue = 0;
            double position = 0;
            int W1 = (maxWidth * 60) / 100;
            int W2 = (maxWidth * 80) / 100;
            int W3 = (maxWidth * 90) / 100;


            try
            {
                actualValue = Time.ConvertStringTimeToLong(txtUseTime.Text);
                applyValues = true;
            }
            catch (Exception)
            {
                applyValues = false;
            }

            try
            {
                maxValue = Time.ConvertStringTimeToLong(mtxtRecTime.Text);
                applyValues = true;
            }
            catch (Exception)
            {
                applyValues = false;
            }

            if (actualValue > maxValue)
            {
                applyValues = false;
                position = fondo.Width-2;
            }

            if ((applyValues) && (maxValue != 0))
            {
                position = (actualValue * maxWidth) / maxValue;
            }

            //Set value
            barra.Width = (int)position;

            //Set color dependig value
            if (position < W1)
                barra.BackColor = Color.Green;
            if ((position >= W1) && (position < W2))
                barra.BackColor = Color.Yellow;
            if ((position >= W2) && (position < W3))
                barra.BackColor = Color.Orange;
            if (position >= W3)
                barra.BackColor = Color.Red;
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {            
            resetFields();
            setEditMode();
            txtName.Focus();
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
            txtName.Focus();
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            string mensaje="¿Desea cancelar la edición del artículo "+txtName.Text+"?\n Los cambios realizados se perderán.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.materialsBindingSource.CancelEdit();
                setNormalMode();
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea guardar la ficha creada?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                //Load data into model.
                Material aMat = new Material();
                aMat = LoadObject();

                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);

                MessageBox.Show("Ficha guardada corectamente");

                setNormalMode();

                calculateDistBar(txtDistBar, txtBarsBack);
                calculateTimeBar(txtTimeBar, txtBarsBack);
            }

        }

        private void tsBtnDel_Click(object sender, EventArgs e)
        {
            string mensaje="Va a borrar el artículo "+txtName.Text+". ¿Esta seguro?";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat==DialogResult.OK)
            {
                this.materialsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);
            }            
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!TrainItLibrary.Utilities.validateNotEmpty(sender))
            {
                txtName.BackColor = Color.Red;
                MessageBox.Show("El nombre no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                txtName.BackColor = SystemColors.Window;
            }
        }

        private void mTxtWeight_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (mtxtWeight.Text != "")
            {
                if (!e.IsValidInput)
                {                    
                    mtxtWeight.BackColor = Color.Red;
                    MessageBox.Show("El peso debe ser un número del 0 al 9999,99");
                    e.Cancel = true;
                }
                else
                {
                    SqlDecimal temp = Convert.ToDecimal(mtxtWeight.Text);
                    if ((temp < 10000) && (temp >= 0))
                    {
                        e.Cancel = false;
                        mtxtWeight.BackColor = SystemColors.Window;
                    }
                    else
                    {                        
                        mtxtWeight.BackColor = Color.Red;
                        MessageBox.Show("El peso debe ser un número del 0 al 9999,99");
                        e.Cancel = true;
                    }//else 2
                }//else 1
            }//if 1
            else
            {
                e.Cancel = false;
                mtxtWeight.BackColor = SystemColors.Window;
                mtxtWeight.Text = "0,000";
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtCost.Text != "")
            {//Se permiten números con decimales o el campo vacío.
                try
                {
                    SqlMoney temp = (SqlMoney)Convert.ToDecimal(txtCost.Text);
                    if ((temp < 1000000) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
                if (e.Cancel)
                {
                    txtCost.BackColor = Color.Red;
                    MessageBox.Show("El coste debe ser un número entre 0 y 1.000.000.\n Se permiten decimales.");
                }
                else
                    txtCost.BackColor = SystemColors.Window;                
            }
            else txtCost.Text = "0,00";
        }

        private void txtInitDist_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtInitDist.Text != "")
            {//Se permiten números con decimales o el campo vacío.
                try
                {
                    SqlDecimal temp = Convert.ToDecimal(txtInitDist.Text);
                    if ((temp < 1000000) && (temp >= 0))
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtInitDist.Text = "0,000";
            if (e.Cancel)
            {
                txtInitDist.BackColor = Color.Red;
                MessageBox.Show("La distancia de uso inicial debe ser un número entre 0 y 999999.999.\n Se permiten decimales.");                        
            }
            else
                txtInitDist.BackColor = SystemColors.Window;            
        }

        private void txtRecDist_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (txtRecDist.Text != "")
            {//Se permiten números con decimales o el campo vacío.
                try
                {
                    SqlDecimal temp = Convert.ToDecimal(txtRecDist.Text);
                    if ((temp < 1000000) && (temp >= 0))                    
                        e.Cancel = false;
                    else
                        e.Cancel = true;                    
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
            else txtRecDist.Text = "0,000";
            if (e.Cancel)
            {
                txtRecDist.BackColor = Color.Red;
                MessageBox.Show("La distancia de uso recomendada debe ser un número entre 0 y 999.999.\n Se permiten decimales.");                    
            }
            else
                txtRecDist.BackColor = SystemColors.Window;
        }

        private void mtxtInitTime_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (mtxtInitTime.Text != "")
            {
                if (!Time.CheckTimeFormat(mtxtInitTime.Text,999999))                
                    e.Cancel = true;
                if (e.Cancel)
                {//Format not correct
                    mtxtInitTime.BackColor = Color.Red;
                    string message="El tiempo inicial de uso debe ser en formato: hh:mm:ss \n\n"+
                                     "      - Segundos entre 0 y 59. \n"+
                                     "      - Minutos entre 0 y 59.  \n"+ 
                                     "      - Horas entre 0 y 999999.    ";
                    MessageBox.Show(message);
            }
                else
                {//Format correct
                    mtxtInitTime.BackColor = SystemColors.Window;
                }
            }
        }

        private void mtxtRecTime_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (mtxtRecTime .Text != "")
            {
                if (!Time.CheckTimeFormat(mtxtRecTime.Text,999999))
                    e.Cancel = true;
                if (e.Cancel)
                {//Format not correct
                    mtxtRecTime.BackColor = Color.Red;
                    string message = "El tiempo recomendado de uso debe ser en formato: hhhh:mm:ss \n\n" +
                                     "      - Segundos entre 0 y 59. \n" +
                                     "      - Minutos entre 0 y 59.  \n" +
                                     "      - Horas entre 0 y 999999.    ";
                    MessageBox.Show(message);
                }
                else
                {//Format correct
                    mtxtRecTime.BackColor = SystemColors.Window;
                }
            }
        }

        private void materialsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calculateDistBar(txtDistBar,txtBarsBack);
            calculateTimeBar(txtTimeBar, txtBarsBack);
        }

        private void btnCancelImage_Click(object sender, EventArgs e)
        {
            pbxImage.Image = null;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pbxImage.Load(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede abrir el fichero asignado");
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            returnValue = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
