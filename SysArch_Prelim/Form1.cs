using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SysArch_Prelim
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string connString = "server=localhost;database=CollegeDB;uid=root;pwd=root;";

// AGAW

// HELLO

//HAPPY BIRTHDAY

//HANNAH
//YOHOOO!

//MARVERICK

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
            LoadData();
        }

        void clear()
        {
            txtCollegeCode.Clear();
            txtCollegeID.Clear();
            //cbCollegeName.Items.Clear();
            cbActive.Checked = false;
        }
        void clearDept()
        {
            txtDepartmentCode.Clear();
           cmbDepartment.Items.Clear();
            cmbSelectedColl.Items.Clear();  
            cbDeptActive.Checked = false;
        }
        private void LoadDepartmentsByCollegeID(string collegeID)
        {
            try
            {
                conn.Open();
                string query = "SELECT DepartmentID, CollegeID, DepartmentName, DepartmentCode, IsActive FROM Department WHERE CollegeID = @collegeID";
                MySqlDataAdapter deptAdapter = new MySqlDataAdapter(query, conn);
                deptAdapter.SelectCommand.Parameters.AddWithValue("@collegeID", collegeID);

                DataTable dtDept = new DataTable();
                deptAdapter.Fill(dtDept);
                dataGridViewDepartment.DataSource = dtDept;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT CollegeID, CollegeName, CollegeCode, CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Not Active' END AS Status FROM College";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewCollege.DataSource = dt;

                string deptQuery = "SELECT DepartmentID, CollegeID, DepartmentName, DepartmentCode, CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Not Active' END AS Status FROM Department";
                MySqlDataAdapter deptAdapter = new MySqlDataAdapter(deptQuery, conn);
                DataTable dtDept = new DataTable();
                deptAdapter.Fill(dtDept);
                dataGridViewDepartment.DataSource = dtDept;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


       

        private void btnCreate_College_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO College (CollegeName, CollegeCode, IsActive) VALUES (@name, @code, @isActive)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", cbCollegeName.SelectedItem);
                cmd.Parameters.AddWithValue("@code", txtCollegeCode.Text);
                cmd.Parameters.AddWithValue("@isActive", cbActive.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUpdate_College_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE College SET CollegeName = @name, CollegeCode = @code, IsActive = @isActive WHERE CollegeID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtCollegeID.Text);
                cmd.Parameters.AddWithValue("@name", cbCollegeName.SelectedItem);
                cmd.Parameters.AddWithValue("@code", txtCollegeCode.Text);
                cmd.Parameters.AddWithValue("@isActive", cbActive.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      

        private void btnDelete_College_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCollegeID.Text))
                {
                    MessageBox.Show("Please select a college first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this college permanently?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string query = "DELETE FROM College WHERE CollegeID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtCollegeID.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadData();
                    MessageBox.Show("College deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnCreate_Department_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Department (CollegeID, DepartmentName, DepartmentCode, IsActive) VALUES (@collegeID, @name, @code, @isActive)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@collegeID", txtDepartmentCollegeID.Text);
                cmd.Parameters.AddWithValue("@name", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@code", txtDepartmentCode.Text);
                cmd.Parameters.AddWithValue("@isActive", cbDeptActive.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadDepartmentsByCollegeID(txtCollegeID.Text);
                LoadData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Department_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Department SET DepartmentName = @name, DepartmentCode = @code , IsActive = @isActive WHERE DepartmentID = @id";
              
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtDepartmentID.Text);
                cmd.Parameters.AddWithValue("@name", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@code", txtDepartmentCode.Text);
                cmd.Parameters.AddWithValue("@isActive", cbDeptActive.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                LoadData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Department_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if a department is selected before attempting to delete
                if (string.IsNullOrWhiteSpace(txtDepartmentID.Text))
                {
                    MessageBox.Show("Please select a department first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this department?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string query = "DELETE FROM Department WHERE DepartmentID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtDepartmentID.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the table to reflect changes
                        txtDepartmentID.Clear(); // Clear the input field after deletion
                    }
                    else
                    {
                        MessageBox.Show("No department found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }


        }

        private void dataGridViewCollege_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCollege.Rows[e.RowIndex];
                txtCollegeID.Text = row.Cells["CollegeID"].Value.ToString();
                cbCollegeName.SelectedItem = row.Cells["CollegeName"].Value.ToString();
                txtCollegeCode.Text = row.Cells["CollegeCode"].Value.ToString();


                LoadDepartmentsByCollegeID(txtCollegeID.Text);

            }
        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDepartment.Rows[e.RowIndex];
                txtDepartmentID.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDepartmentCollegeID.Text = row.Cells["CollegeID"].Value.ToString();
                cmbDepartment.Text = row.Cells["DepartmentName"].Value.ToString();
                txtDepartmentCode.Text = row.Cells["DepartmentCode"].Value.ToString();
            }
        }

        private void cbCollegeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCollegeName.SelectedItem != null)
            {
                string selectedCollege = cbCollegeName.SelectedItem.ToString();

                if (selectedCollege == "College of Engineering")
                    txtCollegeCode.Text = "COE";
                else if (selectedCollege == "College of Business & Finance")
                    txtCollegeCode.Text = "CBF";
                else if (selectedCollege == "College of Information Tech.")
                    txtCollegeCode.Text = "CIT";
                else if (selectedCollege == "College of Arts & Sciences")
                    txtCollegeCode.Text = "CAS";
                else if (selectedCollege == "College of Health Sciences")
                    txtCollegeCode.Text = "CHS";
               
            }
           
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCollegeName.Text))
            {
                MessageBox.Show("Please select a college first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Transfer data to the new selection
            txtDepartmentID.Text = "";
            txtDepartmentCollegeID.Text = txtCollegeID.Text;
            cmbSelectedColl.Text = cbCollegeName.Text;

            // Populate department list based on transferred college
            PopulateDepartments(cmbSelectedColl.Text);

            MessageBox.Show("Data transferred successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }
        private void PopulateDepartments(string selectedCollege) //Revise this code
        {
            cmbDepartment.Items.Clear(); // Clear previous data

            switch (selectedCollege)
            {
                case "College of Engineering":
                    cmbDepartment.Items.Add("Department of Civil Engineering");
                    cmbDepartment.Items.Add("Department of Mechanical Engineering");
                    cmbDepartment.Items.Add("Department of Electrical Engineering");
                    cmbDepartment.Items.Add("Department of Computer Engineering");
                    cmbDepartment.Items.Add("Department of Electronics Engineering");
                    break;

                case "College of Business & Finance":
                    cmbDepartment.Items.Add("Department of Accounting");
                    cmbDepartment.Items.Add("Department of Marketing");
                    cmbDepartment.Items.Add("Department of Management");
                    cmbDepartment.Items.Add("Department of Finance");
                    break;

                case "College of Information Tech.":
                    cmbDepartment.Items.Add("Department of Computer Science");
                    cmbDepartment.Items.Add("Department of Information Technology");
                    cmbDepartment.Items.Add("Department of Cybersecurity");
                    cmbDepartment.Items.Add("Department of Data Science");
                    break;

                case "College of Arts & Sciences":
                    cmbDepartment.Items.Add("Department of Psychology");
                    cmbDepartment.Items.Add("Department of English");
                    cmbDepartment.Items.Add("Department of Mathematics");
                    cmbDepartment.Items.Add("Department of Sociology");
                    break;

                case "College of Health Sciences":
                    cmbDepartment.Items.Add("Department of Nursing");
                    cmbDepartment.Items.Add("Department of Pharmacy");
                    cmbDepartment.Items.Add("Department of Medical Technology");
                    cmbDepartment.Items.Add("Department of Physical Therapy");
                    break;

                default:
                    MessageBox.Show("No departments available for the selected college.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            // Auto-select the first department if available
            if (cmbDepartment.Items.Count > 0)
            {
                cmbDepartment.SelectedIndex = 0;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedItem != null)
            {
                string selectedDepartment = cmbDepartment.SelectedItem.ToString();

                // Assign department code based on department name
                switch (selectedDepartment)
                {
                    case "Department of Civil Engineering": txtDepartmentCode.Text = "DCE"; break;
                    case "Department of Mechanical Engineering": txtDepartmentCode.Text = "DME"; break;
                    case "Department of Electrical Engineering": txtDepartmentCode.Text = "DEE"; break;
                    case "Department of Computer Engineering": txtDepartmentCode.Text = "DCOE"; break;
                    case "Department of Electronics Engineering": txtDepartmentCode.Text = "DEE"; break;

                    case "Department of Accounting": txtDepartmentCode.Text = "DAC"; break;
                    case "Department of Marketing": txtDepartmentCode.Text = "DMK"; break;
                    case "Department of Management": txtDepartmentCode.Text = "DMG"; break;
                    case "Department of Finance": txtDepartmentCode.Text = "DFN"; break;

                    case "Department of Computer Science": txtDepartmentCode.Text = "DCS"; break;
                    case "Department of Information Technology": txtDepartmentCode.Text = "DIT"; break;
                    case "Department of Cybersecurity": txtDepartmentCode.Text = "DCY"; break;
                    case "Department of Data Science": txtDepartmentCode.Text = "DDS"; break;

                    case "Department of Psychology": txtDepartmentCode.Text = "DPSY"; break;
                    case "Department of English": txtDepartmentCode.Text = "DEN"; break;
                    case "Department of Mathematics": txtDepartmentCode.Text = "DMS"; break;
                    case "Department of Sociology": txtDepartmentCode.Text = "DSOC"; break;

                    case "Department of Nursing": txtDepartmentCode.Text = "DNS"; break;
                    case "Department of Pharmacy": txtDepartmentCode.Text = "DPH"; break;
                    case "Department of Medical Technology": txtDepartmentCode.Text = "DMT"; break;
                    case "Department of Physical Therapy": txtDepartmentCode.Text = "DPT"; break;

                    default:
                        txtDepartmentCode.Clear();
                        break;
                }
            }
        }
        //add method for the features
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
