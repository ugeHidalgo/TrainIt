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
using System.Data.SqlClient;

namespace TrainIt
{
    public partial class FSessions : Form
    {
        string connString = Utilities.GetConnString();
        Int64 userIDWorking = Global.userIDWorking;
        Boolean onEdition = false;
        Int64 sessionIDToUpdate = -1;

        public FSessions()
        {
            InitializeComponent();
            tslConnString.Text = connString;
            tslUser.Text = "Usuario=(" + Global.userIDWorking + ")" + Global.userNameWorking;

            setNormalMode();
        }

        public void setModForMatOptions()
        {   //Set the Enabled property for the buttons to delete materials used in session
            if (onEdition)
            {
                if (dgvMats.RowCount == 0)
                {
                    btnDelMat.Enabled = false;
                    btnDelAllMat.Enabled = false;
                    cms1Del.Enabled = false;
                    cms1DelAll.Enabled = false;
                }
                else
                {
                    btnDelMat.Enabled = true;
                    btnDelAllMat.Enabled = true;
                    cms1Del.Enabled = true;
                    cms1DelAll.Enabled = true;
                }
            }
        }

        private void setNormalMode()
        {
            onEdition = false;

            tsBtnFirst.Enabled = true;
            tsBtnPrevious.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnLast.Enabled = true;
            tsBtnNew.Enabled = true;
            tsBtnEdit.Enabled = true;
            tsBtnCancel.Enabled = false;
            tsBtnSave.Enabled = false;
            tsBtnDelSession.Enabled = true;

            btnFindSportType.Enabled = false;
            btnFindTrain.Enabled = false;
            btnFindMaterial.Enabled = false;
            btnDelMat.Enabled = false;
            btnDelAllMat.Enabled = false;

            dgvSessions.Enabled = true;
            dgvMats.Enabled = false;
            
            dtpDate.Enabled = false;
            txtDist.ReadOnly = true;
            txtTime.ReadOnly = true;            
            txtMedHR.ReadOnly = true;
            txtMaxHR.ReadOnly = true;
            txtValue.ReadOnly = true;
            txtMemo.ReadOnly = true;
            chbxComp.Enabled = false;
        }

        private void setEditMode()
        {
            onEdition = true;

            tsBtnFirst.Enabled = false;
            tsBtnPrevious.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnLast.Enabled = false;
            tsBtnNew.Enabled = false;
            tsBtnEdit.Enabled = false;
            tsBtnCancel.Enabled = true;
            tsBtnSave.Enabled = true;
            tsBtnDelSession.Enabled = false;

            btnFindSportType.Enabled = true;
            btnFindTrain.Enabled = true;
            btnFindMaterial.Enabled = true;

            setModForMatOptions();

            dgvSessions.Enabled = false;
            dgvMats.Enabled = true;

            dtpDate.Enabled = true;
            txtDist.ReadOnly = false;
            txtTime.ReadOnly = false;
            txtMedHR.ReadOnly = false;
            txtMaxHR.ReadOnly = false;
            txtValue.ReadOnly = false;
            txtMemo.ReadOnly = false;
            chbxComp.Enabled = true;
        }

        private void LoadData()
        {
            bool sigue = false;
            Int64 aTrainID = -1;
            Int64 aSessionID = -1;
            Int64 aSportTypeID = -1;

            // Loads data for sessions for the user
            this.sessionsTableAdapter.FillBy(this.trainITDataSet.Sessions, userIDWorking);

            try
            {
                aSportTypeID = Convert.ToInt64(txtSportTypeID.Text);
                sigue = true;
            }
            catch
            {
                sigue = false;
            }

            if (sigue)
            {
                try
                {
                    aTrainID = Convert.ToInt64(txtTrainID.Text);
                    sigue = true;
                }
                catch
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                try
                {
                    aSessionID = Convert.ToInt64(txtSessionID.Text);
                    sigue = true;
                }
                catch
                {
                    sigue = false;
                }
            }

            if (sigue)
            {
                // Loads data for Sport Types
                this.sportTypesTableAdapter.FillByID(this.trainITDataSet.SportTypes, aSportTypeID);
                // Loads data for Trainings
                this.trainingsTableAdapter.FillByID(this.trainITDataSet.Trainings, aTrainID);

                //Loads data for Materials used in the session
                LoadDataForSessionMaterial(aSessionID);

                //calculate speed and Rithm
                if ((txtDist.Text != "") && (txtTime.Text != ""))
                {
                    txtSpeed.Text = Utilities.calculateSpeed(txtDist.Text, txtTime.Text);
                    txtPace.Text = Utilities.calculatePace(txtDist.Text, txtTime.Text, txtDistForPace.Text);
                }
            }
        }

        private void LoadDataForSessionMaterial(Int64 aSessionID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = String.Format(
                    @"DELETE FROM TempMaterial;
                      SELECT MaterialSession.MatID, Materials.MatName, Materials.MatModel, Materials.MatBrand, Materials.MatImage, MaterialSession.SessionID
                      FROM MaterialSession INNER JOIN Materials ON MaterialSession.MatID = Materials.MatID
                      WHERE MaterialSession.SessionID=@sessionID");
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sessionID", SqlDbType.BigInt));
                    cmd.Parameters["@sessionID"].Value = aSessionID;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();                        
                        while (reader.Read())
                        {
                            // Create a buffer to hold the bytes, and then
                            long len = reader.GetBytes(4, 0, null, 0, 0);
                            Byte[] image = new Byte[len];
                            // read the bytes from the DataTableReader.                            
                            reader.GetBytes(4, 0, image, 0, (int)len);
                            updateTempMaterial(connString, reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), image, reader.GetInt64(5));
                        }
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        Exception anError = new Exception("A problem with the User SQL Connection occurs while querying data abut material for a session");
                        throw;
                    }
                }
            }

            // Loads data into the 'trainITDataSet.TempMaterial' table. 
            this.tempMaterialTableAdapter.Fill(this.trainITDataSet.TempMaterial);

            //Enable or disable the button to delete object from the tempMaterial.
            setModForMatOptions();
        }

        private void updateTempMaterial(string connString, Int64 theMatID, String theMatName, String theMatModel, String theMatBrand, Byte[] theImage, Int64 theSessionID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string pass = userPass;
                string query = null;

                query = @"INSERT INTO TempMaterial VALUES (@aMatID, @matName, @matModel, 
                              @matBrand, @matImage , @sessionID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@aMatID", SqlDbType.BigInt));
                    cmd.Parameters["@aMatID"].Value = theMatID;

                    cmd.Parameters.Add(new SqlParameter("@matName", SqlDbType.VarChar));
                    cmd.Parameters["@matName"].Value = theMatName;                    

                    cmd.Parameters.Add(new SqlParameter("@matModel", SqlDbType.VarChar));
                    cmd.Parameters["@matModel"].Value = theMatModel;

                    cmd.Parameters.Add(new SqlParameter("@matBrand", SqlDbType.VarChar));
                    cmd.Parameters["@matBrand"].Value = theMatBrand;

                    cmd.Parameters.Add(new SqlParameter("@matImage", SqlDbType.Binary));
                    cmd.Parameters["@matImage"].Value = theImage;

                    cmd.Parameters.Add(new SqlParameter("@sessionID", SqlDbType.BigInt));
                    cmd.Parameters["@sessionID"].Value = theSessionID;

                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                }
            }     
        }

        private void FSessions_Load(object sender, EventArgs e)
        {           
            LoadData();      
        }

        private void FSessions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onEdition)
            {
                MessageBox.Show("Grabe o cancele la edición ántes de cerrar la ventana actual.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        private void txtTrainID_TextChanged(object sender, EventArgs e)
        {
            try 
	        {
                Int64 aTrainID = Convert.ToInt64(txtTrainID.Text);
                // Loads data for trainings
                this.trainingsTableAdapter.FillByID(this.trainITDataSet.Trainings, aTrainID);   
        	}
	        catch (Exception)
	        {
                txtTrainID.Text = "";
                txtTrainName.Text = "";
	        }                                    
        }

        private void txtSportTypeID_TextChanged(object sender, EventArgs e)
        {
            double paceDist=1;
            try
            {
                Int64 aSportTypeID = Convert.ToInt64(txtSportTypeID.Text);

                // TODO: This line of code loads data into the 'trainITDataSet.SportTypes' table. You can move, or remove it, as needed.
                this.sportTypesTableAdapter.FillByID(this.trainITDataSet.SportTypes, aSportTypeID);

                paceDist = SportTypes.paceDistance(connString, aSportTypeID);
                txtDistForPace.Text = paceDist.ToString();
            }
            catch (Exception)
            {
                txtSportTypeID.Text = "";
                txtSportTypeName.Text = "";               
            }
        }

        private void txtMatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindTrain_Click(object sender, EventArgs e)
        {
            FTrainings fTrainings = new FTrainings();
            fTrainings.OnSearchMode=true;
            fTrainings.ShowDialog();

            if (fTrainings.OnSearchMode)
            {
                txtTrainID.Text = Global.trainingUsed.TrainID.ToString();
                fTrainings.OnSearchMode = false;
            }
            
        }
        
        private void btnFindSportType_Click(object sender, EventArgs e)
        {            
            FSportTypes fSportTypes = new FSportTypes();
            fSportTypes.OnSearchMode = true;
            fSportTypes.ShowDialog();

            if (fSportTypes.OnSearchMode)
            {
                txtSportTypeID.Text = Global.sportTypeUsed.SportTypeID.ToString();
                fSportTypes.OnSearchMode = false;
            }
        }

        private void btnFindMaterial_Click(object sender, EventArgs e)
        {
            FMaterial fMaterial = new FMaterial();
            fMaterial.OnSearchMode = true;
            fMaterial.ShowDialog();

            if (fMaterial.OnSearchMode)
            {
                //Check if material exists on tempMaterial.
                bool finded = false;
                finded = Global.materialUsed.checkIfMaterialIsInTempTable(connString);

                if (!finded)
                {
                    //Search for the image associated with the material used.
                    Byte[] image = Global.materialUsed.loadImageForMatID(connString, Global.materialUsed.MatID);
                    //Update value into data set.
                    updateTempMaterial(connString, Global.materialUsed.MatID, Global.materialUsed.MatName, Global.materialUsed.MatModel, Global.materialUsed.MatBrand, image, -1);
                    // Loads data into the 'trainITDataSet.TempMaterial' table. 
                    this.tempMaterialTableAdapter.Fill(this.trainITDataSet.TempMaterial);

                    //Enable or disable the button to delete object from the tempMaterial.
                    setModForMatOptions();

                    fMaterial.OnSearchMode = false;
                }
                else
                {
                    MessageBox.Show("El material '" + Global.materialUsed.MatName + "' ya está incluido en la lista de materiales usados en la sesión.");
                }
            }
            
        }

        private void btnDelMat_Click(object sender, EventArgs e)
        {
            Int64 aMatID = -1;
            String aMatName = null;
            bool sigue = true;
            try
            {
                aMatID = Convert.ToInt64(dgvMats[4, dgvMats.CurrentRow.Index].Value);
                aMatName = dgvMats[1, dgvMats.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Haga click antes sobre el material a borrar.");
                sigue = false;
            }

            if (sigue)
	        {
                String aMessage="¿Desea eliminar el artículo '"+aMatName+"' de la lista de material usado en la sesión?";
                DialogResult result = MessageBox.Show(aMessage, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    //1º Delete form temp table: TempMaterial
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        // using (SqlTransaction tr = conn.BeginTransaction())
                        // {
                        string query = null;
                        query = @"DELETE FROM TempMaterial WHERE MatID=@matID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@MatID", SqlDbType.BigInt));
                            cmd.Parameters["@MatID"].Value = aMatID;

                            conn.Open();
                            cmd.ExecuteScalar();
                        }
                    }
                    //2º Delete from datagridview
                    dgvMats.Rows.Remove(dgvMats.CurrentRow);

                    //Enable or disable the button to delete object from the tempMaterial.
                    setModForMatOptions();
                }
            }
        }

        private void btnDelAllMat_Click(object sender, EventArgs e)
        {
            DialogResult doIt = MessageBox.Show("¿Desea borrar todos los materiales usados en la sessión?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (doIt == DialogResult.OK)
            {
                //delete all materials in temp table
                Global.materialUsed.delTempMaterial(connString);
                // Loads data into the 'trainITDataSet.TempMaterial' table. 
                this.tempMaterialTableAdapter.Fill(this.trainITDataSet.TempMaterial);

                //Enable or disable the button to delete object from the tempMaterial.
                setModForMatOptions();
            }
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            setEditMode();
            txtSpeed.Text = "";
            chbxComp.Checked = false;
            btnFindTrain.Focus();
            sessionIDToUpdate = -1;
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
            btnFindTrain.Focus();
            sessionIDToUpdate = Convert.ToInt64(txtSessionID.Text);
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar la edición de sesión?.\n Los cambios realizados se perderán.";
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.sessionsBindingSource.CancelEdit();
                setNormalMode();
                try
                {
                    LoadDataForSessionMaterial(Convert.ToInt64(txtSessionID.Text));
                    //calculate Speed
                    if ((txtDist.Text != "") && (txtTime.Text != ""))
                        txtSpeed.Text = Utilities.calculateSpeed(txtDist.Text, txtTime.Text);
                }
                catch
                {
                }

            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            bool newTraining = false;
            //Check if user chooses a SportType, if not give a warning error                      
            if (txtSportTypeID.Text != "")
            {
                string mensaje = "¿Desea guardar la sesión creada?";
                DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (delMat == DialogResult.OK)
                {
                    //Check if user chooses a Train ID, if not create new traininig
                    if (txtTrainID.Text == "")
                    {
                        newTraining = true;
                        Global.trainingUsed.UserID = userIDWorking;
                        Global.trainingUsed.TrainDate = dtpDate.Value;
                        Global.trainingUsed.TrainName = "Sin Nombre";
                        txtTrainID.Text = Global.trainingUsed.TrainID.ToString();
                    }
                    txtUserID.Text = userIDWorking.ToString();

                    //Gets position in de data grid before save.
                    int position = dgvSessions.CurrentRow.Index;
                    
                    //this.Validate();
                    //this.sessionsBindingSource.EndEdit();                    
                    if (sessionIDToUpdate == -1)
                    {
                        position = 0;
                        saveSessionData(connString, newTraining);
                    }
                    else                    
                        updateSessionData(connString);                    
                    setNormalMode();
                    LoadData();

                    //Sets position in grid
                    dgvSessions.CurrentCell = dgvSessions[1, position];
                    MessageBox.Show("Sesión guardada corectamente.");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el deporte realizado en la sesión.");
                btnFindSportType.Focus();
            }
        }

        private void saveSessionData(string connString, bool newTraining)
        {            
            using (SqlConnection conn = new SqlConnection(connString))
            {
               // using (SqlTransaction tr = conn.BeginTransaction())
               // {
                    string query = null;
                    if (newTraining)
                    {  //1º Update training data obtaining 
                        query = @"INSERT INTO Trainings(UserID, TrainDate, TrainName)
                                                 VALUES(@userID,@trainDate,@trainName)
                                  SELECT SCOPE_IDENTITY()";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                            cmd.Parameters["@userID"].Value = Global.trainingUsed.UserID;

                            cmd.Parameters.Add(new SqlParameter("@trainDate", SqlDbType.Date));
                            cmd.Parameters["@trainDate"].Value = Global.trainingUsed.TrainDate;

                            cmd.Parameters.Add(new SqlParameter("@trainName", SqlDbType.VarChar));
                            cmd.Parameters["@trainName"].Value = Global.trainingUsed.TrainName;

                            conn.Open();
                            //returns the first column which is the TrainID
                            Int64 res = Convert.ToInt64(cmd.ExecuteScalar());

                            //Assign the TraindID created when insert.                        
                            if (res >= 0)
                                Global.trainingUsed.TrainID = res;
                        }
                    } //New Trainig saved.

                    //2º Save session data 
                    conn.Close();
                    Int64 aSessionID = -1;  
                    query = @"INSERT INTO Sessions(TrainID, UserID, SportTypeID, Competition, Distance, Time, MedHR, MaxHR, Value, Memo, Date)
                                            VALUES(@trainID, @userID, @sportTypeID, @competition, @distance, @time, @medHR, @maxHR, @value, @memo, @date)
                              SELECT SCOPE_IDENTITY()";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@trainID", SqlDbType.BigInt));
                        cmd.Parameters["@trainID"].Value = Global.trainingUsed.TrainID;

                        cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                        cmd.Parameters["@userID"].Value = Convert.ToInt64(txtUserID.Text);

                        cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                        cmd.Parameters["@sportTypeID"].Value = Convert.ToInt64(txtSportTypeID.Text);

                        cmd.Parameters.Add(new SqlParameter("@competition", SqlDbType.Bit));
                        cmd.Parameters["@competition"].Value = chbxComp.Checked;

                        double aDist = 0;
                        if (txtDist.Text != "")
                            aDist = Convert.ToDouble(txtDist.Text);
                        cmd.Parameters.Add(new SqlParameter("@distance", SqlDbType.Float));
                        cmd.Parameters["@distance"].Value = aDist;

                        DateTime aTime = new DateTime();
                        if (txtTime.Text == "")
                            aTime = Convert.ToDateTime("01/01/1900 00:00:00");
                        else
                            aTime = Convert.ToDateTime("01/01/1900 " + txtTime.Text);
                        cmd.Parameters.Add(new SqlParameter("@time", SqlDbType.DateTime));
                        cmd.Parameters["@time"].Value = aTime;

                        int aMedHR = 0;
                        if (txtMedHR.Text != "")
                            aMedHR = Convert.ToInt16(txtMedHR.Text);
                        cmd.Parameters.Add(new SqlParameter("@medHR", SqlDbType.SmallInt));
                        cmd.Parameters["@medHR"].Value = aMedHR;

                        int aMaxHR = 0;
                        if (txtMaxHR.Text != "")
                            aMaxHR = Convert.ToInt16(txtMaxHR.Text);
                        cmd.Parameters.Add(new SqlParameter("@maxHR", SqlDbType.SmallInt));
                        cmd.Parameters["@maxHR"].Value = aMaxHR;

                        int aVal = 0;
                        if (txtValue.Text != "")
                            aVal = Convert.ToInt16(txtValue.Text);
                        cmd.Parameters.Add(new SqlParameter("@value", SqlDbType.SmallInt));
                        cmd.Parameters["@value"].Value = aVal;

                        cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                        cmd.Parameters["@memo"].Value = txtMemo.Text;

                                                                     
                        cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                        cmd.Parameters["@date"].Value = dtpDate.Value;

                        conn.Open();
                        //returns the first column which is the TrainID
                        aSessionID = Convert.ToInt64(cmd.ExecuteScalar());
                    }// New session saved

                    //3º Save material in TempMaterial to matSessions
                    conn.Close();
                    query = @"INSERT INTO MaterialSession (MatID,SessionID) 
                              SELECT matID,@sessionID  FROM dbo.TempMaterial;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@sessionID", SqlDbType.BigInt));
                        cmd.Parameters["@sessionID"].Value = aSessionID;
                        
                        conn.Open();
                       cmd.ExecuteScalar();
                    }// Ssession materials saved

              //      tr.Commit();
              //  }//Transaction end
            }
        }

        private void updateSessionData(string connString)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // using (SqlTransaction tr = conn.BeginTransaction())
                // {
                string query = null;
                //1º Save session data 
                //2º Delete materials for the session into table: matSessions
                //4º Save material in TempMaterial to matSessions
                conn.Close();
                query = @"UPDATE Sessions SET TrainID=@trainID, UserID=@userID, SportTypeID=@sportTypeID, Competition=@competition, 
                                              Distance=@distance, Time=@time, MedHR=@medHR, MaxHR=@maxHR, Value=@value, Memo=@memo, Date=@date
                          WHERE SessionID=@sessionID;
                          DELETE FROM MaterialSession WHERE SessionID=@sessionID;
                          INSERT INTO MaterialSession (MatID,SessionID) 
                              SELECT matID,@sessionID  FROM TempMaterial;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@sessionID", SqlDbType.BigInt));
                    cmd.Parameters["@sessionID"].Value = sessionIDToUpdate;

                    cmd.Parameters.Add(new SqlParameter("@trainID", SqlDbType.BigInt));
                    cmd.Parameters["@trainID"].Value = Convert.ToInt64(txtTrainID.Text);

                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.BigInt));
                    cmd.Parameters["@userID"].Value = Convert.ToInt64(txtUserID.Text);

                    cmd.Parameters.Add(new SqlParameter("@sportTypeID", SqlDbType.BigInt));
                    cmd.Parameters["@sportTypeID"].Value = Convert.ToInt64(txtSportTypeID.Text);

                    cmd.Parameters.Add(new SqlParameter("@competition", SqlDbType.Bit));
                    cmd.Parameters["@competition"].Value = chbxComp.Checked;

                    double aDist = 0;
                    if (txtDist.Text != "")
                        aDist = Convert.ToDouble(txtDist.Text);
                    cmd.Parameters.Add(new SqlParameter("@distance", SqlDbType.Float));
                    cmd.Parameters["@distance"].Value = aDist;

                    DateTime aTime = new DateTime();
                    if (txtTime.Text == "")
                        aTime = Convert.ToDateTime("01/01/1900 00:00:00");
                    else
                        aTime = Convert.ToDateTime("01/01/1900 "+txtTime.Text);
                    cmd.Parameters.Add(new SqlParameter("@time", SqlDbType.DateTime));
                    cmd.Parameters["@time"].Value = aTime;

                    int aMedHR = 0;
                    if (txtMedHR.Text != "")
                        aMedHR = Convert.ToInt16(txtMedHR.Text);
                    cmd.Parameters.Add(new SqlParameter("@medHR", SqlDbType.SmallInt));
                    cmd.Parameters["@medHR"].Value = aMedHR;

                    int aMaxHR = 0;
                    if (txtMaxHR.Text != "")
                        aMaxHR = Convert.ToInt16(txtMaxHR.Text);
                    cmd.Parameters.Add(new SqlParameter("@maxHR", SqlDbType.SmallInt));
                    cmd.Parameters["@maxHR"].Value = aMaxHR;

                    int aVal = 0;
                    if (txtValue.Text != "")
                        aVal = Convert.ToInt16(txtValue.Text);
                    cmd.Parameters.Add(new SqlParameter("@value", SqlDbType.SmallInt));
                    cmd.Parameters["@value"].Value = aVal;

                    cmd.Parameters.Add(new SqlParameter("@memo", SqlDbType.VarChar));
                    cmd.Parameters["@memo"].Value = txtMemo.Text;


                    cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                    cmd.Parameters["@date"].Value = dtpDate.Value;

                    conn.Open();                    
                    cmd.ExecuteScalar();
                }// New session saved

              
                //      tr.Commit();
                //  }//Transaction end
            };
        }

        private void txtDist_Validating(object sender, CancelEventArgs e)
        {
            if (onEdition)
            {
                e.Cancel = false;
                if (txtDist.Text != "")
                {//Se permiten números con decimales o el campo vacío.
                    try
                    {
                        SqlDecimal temp = Convert.ToDecimal(txtDist.Text);
                        if ((temp < 1000) && (temp >= 0))
                            e.Cancel = false;
                        else
                            e.Cancel = true;
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                    }
                }
                else txtDist.Text = "0,000";
                if (e.Cancel)
                {
                    txtDist.BackColor = Color.Red;
                    MessageBox.Show("La distancia de sesión debe ser un número entre 0 y 999.\n Se permiten decimales.");
                }
                else
                {
                    txtDist.BackColor = SystemColors.Window;
                    //calculate speed and Rithm
                    if ((txtDist.Text != "") && (txtTime.Text != ""))
                    {
                        txtSpeed.Text = Utilities.calculateSpeed(txtDist.Text, txtTime.Text);
                        txtPace.Text = Utilities.calculatePace(txtDist.Text, txtTime.Text, txtDistForPace.Text);
                    }
                }
            }
        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
            if (onEdition)
            {
                e.Cancel = false;
                if (txtTime.Text != "")
                {
                    if (!Time.CheckTimeFormat(txtTime.Text, 999))
                        e.Cancel = true;
                    if (e.Cancel)
                    {//Format not correct
                        txtTime.BackColor = Color.Red;
                        string message = "El tiempode de sesión debe ser en formato: hh:mm:ss \n\n" +
                                         "      - Segundos entre 0 y 59. \n" +
                                         "      - Minutos entre 0 y 59.  \n" +
                                         "      - Horas entre 0 y 999.    ";
                        MessageBox.Show(message);
                    }
                    else
                    {//Format correct
                        txtTime.BackColor = SystemColors.Window;

                        //calculate speed and Rithm
                        if ((txtDist.Text != "") && (txtTime.Text != ""))
                        {
                            txtSpeed.Text = Utilities.calculateSpeed(txtDist.Text, txtTime.Text);
                            txtPace.Text = Utilities.calculatePace(txtDist.Text, txtTime.Text, txtDistForPace.Text);
                        }
                    }
                }
            }
        }

        private void txtMedHR_Validating(object sender, CancelEventArgs e)
        {
            if (onEdition)
            {
                e.Cancel = false;
                if (txtMedHR.Text != "")
                {//Se permiten números sin decimales o el campo vacío.
                    try
                    {
                        int temp = Convert.ToInt16(txtMedHR.Text);
                        if ((temp < 300) && (temp >= 0))
                            e.Cancel = false;
                        else
                            e.Cancel = true;
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                    }
                }
                else txtMedHR.Text = "0";
                if (e.Cancel)
                {
                    txtMedHR.BackColor = Color.Red;
                    MessageBox.Show("El pulso Medio debe ser un número entre 0 y 299.\n");
                }
                else
                    txtMedHR.BackColor = SystemColors.Window;
            }
        }

        private void txtMaxHR_Validating(object sender, CancelEventArgs e)
        {
            if (onEdition)
            {
                e.Cancel = false;
                if (txtMaxHR.Text != "")
                {//Se permiten números sin decimales o el campo vacío.
                    try
                    {
                        int temp = Convert.ToInt16(txtMaxHR.Text);
                        if ((temp < 300) && (temp >= 0))
                            e.Cancel = false;
                        else
                            e.Cancel = true;
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                    }
                }
                else txtMaxHR.Text = "0";
                if (e.Cancel)
                {
                    txtMaxHR.BackColor = Color.Red;
                    MessageBox.Show("El pulso Máximo debe ser un número entre 0 y 299.\n");
                }
                else
                    txtMaxHR.BackColor = SystemColors.Window;
            }
        }

        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            if (onEdition)
            {
                e.Cancel = false;
                if (txtValue.Text != "")
                {//Se permiten números sin decimales o el campo vacío.
                    try
                    {
                        int temp = Convert.ToInt16(txtValue.Text);
                        if ((temp < 11) && (temp >= 0))
                            e.Cancel = false;
                        else
                            e.Cancel = true;
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                    }
                }
                else txtValue.Text = "0";
                if (e.Cancel)
                {
                    txtValue.BackColor = Color.Red;
                    MessageBox.Show("La valoración de la sesión debe ser un número entre 0 y 10.\n");
                }
                else
                    txtValue.BackColor = SystemColors.Window;
            }
        }

        private void txtSessionID_TextChanged(object sender, EventArgs e)
        {
            //Loads data for materials used in the actual session
            bool sigue = false;            
            Int64 aSessionID = -1;            
           
            try
            {
                aSessionID = Convert.ToInt64(txtSessionID.Text);
                sigue = true;
            }
            catch
            {
                sigue = false;
            }
            
            if (sigue)
            {
                //Loads data for Materials used in the session
                LoadDataForSessionMaterial(aSessionID);
                //Set the enable property for materials buttons
                setModForMatOptions();
            }            
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (!onEdition)
            {
                //calculate speed and Rithm
                if ((txtDist.Text != "") && (txtTime.Text != ""))
                {
                    txtSpeed.Text = Utilities.calculateSpeed(txtDist.Text, txtTime.Text);
                    txtPace.Text = Utilities.calculatePace(txtDist.Text, txtTime.Text, txtDistForPace.Text);
                }
            }
        }

        private void tsBtnDelSession_Click(object sender, EventArgs e)
        {
            string mensaje = "Va a borrar la sesión (" + txtSessionID.Text + "/" + txtUserID.Text + "). ¿Esta seguro?";
            Int64 trainIDOfSession = Convert.ToInt64(txtTrainID.Text);
            DialogResult delMat = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (delMat == DialogResult.OK)
            {
                this.sessionsBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.trainITDataSet);                
                LoadData();

                //Delete all materials in temp table
                Global.materialUsed.delTempMaterial(connString);
                // Loads data into the 'trainITDataSet.TempMaterial' table. 
                this.tempMaterialTableAdapter.Fill(this.trainITDataSet.TempMaterial);

                MessageBox.Show("Sesión borrada corectamente");

                //If Training of Session does not have more sessions then delete it.
                if (Training.trainingHasSessions(connString,trainIDOfSession)==0)
                {
                    Training.deleteTraining(connString,trainIDOfSession);
                    MessageBox.Show("El entrenamiento al que pertenecía la sesión ha sido borrado al no tener más sesiones.\n"+
                                    "Entrenamiento número :"+trainIDOfSession.ToString());
                }

            } 
        }
    }
}
