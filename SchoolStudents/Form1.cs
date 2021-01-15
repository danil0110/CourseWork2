using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SchoolStudents
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        string connString = @"Server=localhost;Port=5433;User Id=school_user;Password=school;Database=school";
        string sql;
        NpgsqlCommand cmd;
        DataTable dt;
        int rowIndex;
        int totalPages = 1, pageSize, currentPage = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM students_select()";
                if (checkPagination.Checked)
                {
                    CalculateTotalPages(sql);
                    if (currentPage > totalPages)
                    {
                        txtCurrentPage.Text = Convert.ToString(--currentPage);
                    }
                    cmd = new NpgsqlCommand(sql + $" LIMIT {pageSize} OFFSET {pageSize * currentPage - pageSize}", conn);
                }
                else
                {
                    cmd = new NpgsqlCommand(sql, conn);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SelectFiltered()
        {
            try
            {
                conn.Open();
                switch (comboFilterBy.SelectedIndex)
                {
                    case 5:
                        sql = $"SELECT * FROM students WHERE \"EntryDate\" BETWEEN '{txtInput1.Text}' AND '{txtInput2.Text}' ORDER BY \"id\"";
                        break;
                    default:
                        sql = $"SELECT * FROM students WHERE \"{comboFilterBy.SelectedItem}\" = '{txtInput1.Text}' ORDER BY \"id\"";
                        break;
                }

                if (checkPagination.Checked)
                {
                    CalculateTotalPages(sql);
                    if (currentPage > totalPages)
                    {
                        txtCurrentPage.Text = Convert.ToString(--currentPage);
                    }
                    cmd = new NpgsqlCommand(sql + $" LIMIT {pageSize} OFFSET {pageSize * currentPage - pageSize}", conn);
                }
                else
                {
                    cmd = new NpgsqlCommand(sql, conn);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtFirstName.Text = dgvData.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvData.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtMiddleName.Text = dgvData.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
                switch (dgvData.Rows[e.RowIndex].Cells["Sex"].Value.ToString())
                {
                    case "m":
                        rbMale.Checked = true;
                        break;
                    case "f":
                        rbFemale.Checked = true;
                        break;
                }
                string[] date = dgvData.Rows[e.RowIndex].Cells["EntryDate"].Value.ToString().Split(' ');
                txtEntryDate.Text = date[0];
                txtClassID.Text = dgvData.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
                txtClubID.Text = dgvData.Rows[e.RowIndex].Cells["ClubID"].Value.ToString();
                txtPhone.Text = dgvData.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtMiddleName.Text = null;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtEntryDate.Text = null;
            txtClassID.Text = null;
            txtClubID.Text = null;
            txtPhone.Text = null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            ClearInputs();
            sideBar.Enabled = true;
            btnSave.Enabled = true;
            txtFirstName.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Please, choose student to update");
                return;
            }
            sideBar.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result;
            if (rowIndex < 0)
            {
                MessageBox.Show("Please, choose student to delete");
                return;
            }
            try
            {
                conn.Open();
                sql = @"SELECT * FROM students_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dgvData.Rows[rowIndex].Cells["id"].Value.ToString()));
                result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Deleted successfully");
                    rowIndex = -1;
                    if (checkFilter.Checked)
                    {
                        SelectFiltered();
                    }
                    else
                    {
                        Select();
                    }
                }
                else
                {
                    MessageBox.Show("Delete fail");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
            ClearInputs();
            sideBar.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result;
            if (rowIndex < 0) // insert new student
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM students_insert(:_firstname, :_lastname, :_middlename, :_sex, :_entrydate, :_classid, :_clubid, :_phone)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_firstname", NpgsqlTypes.NpgsqlDbType.Varchar, txtFirstName.Text.Length > 0 ? txtFirstName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_lastname", NpgsqlTypes.NpgsqlDbType.Varchar, txtLastName.Text.Length > 0 ? txtLastName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_middlename", NpgsqlTypes.NpgsqlDbType.Varchar, txtMiddleName.Text.Length > 0 ? txtMiddleName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_sex", NpgsqlTypes.NpgsqlDbType.Char, rbMale.Checked ? 'm' : rbFemale.Checked ? 'f' : DBNull.Value);
                    cmd.Parameters.AddWithValue("_entrydate", NpgsqlTypes.NpgsqlDbType.Date, txtEntryDate.Text.Length > 0 ? DateTime.Parse(txtEntryDate.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_classid", NpgsqlTypes.NpgsqlDbType.Integer, txtClassID.Text.Length > 0 ? int.Parse(txtClassID.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_clubid", NpgsqlTypes.NpgsqlDbType.Integer, txtClubID.Text.Length > 0 ? int.Parse(txtClubID.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_phone", NpgsqlTypes.NpgsqlDbType.Varchar, txtPhone.Text.Length > 0 ? txtPhone.Text : DBNull.Value);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserted successfully");
                        if (checkFilter.Checked)
                        {
                            SelectFiltered();
                        }
                        else
                        {
                            Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Insert error: " + ex.Message);
                }
            }
            else // update existing student
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM students_update(:_id, :_firstname, :_lastname, :_middlename, :_sex, :_entrydate, :_classid, :_clubid, :_phone)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dgvData.Rows[rowIndex].Cells["id"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_firstname", NpgsqlTypes.NpgsqlDbType.Varchar, txtFirstName.Text.Length > 0 ? txtFirstName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_lastname", NpgsqlTypes.NpgsqlDbType.Varchar, txtLastName.Text.Length > 0 ? txtLastName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_middlename", NpgsqlTypes.NpgsqlDbType.Varchar, txtMiddleName.Text.Length > 0 ? txtMiddleName.Text : DBNull.Value);
                    cmd.Parameters.AddWithValue("_sex", NpgsqlTypes.NpgsqlDbType.Char, rbMale.Checked ? 'm' : rbFemale.Checked ? 'f' : DBNull.Value);
                    cmd.Parameters.AddWithValue("_entrydate", NpgsqlTypes.NpgsqlDbType.Date, txtEntryDate.Text.Length > 0 ? DateTime.Parse(txtEntryDate.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_classid", NpgsqlTypes.NpgsqlDbType.Integer, txtClassID.Text.Length > 0 ? int.Parse(txtClassID.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_clubid", NpgsqlTypes.NpgsqlDbType.Integer, txtClubID.Text.Length > 0 ? int.Parse(txtClubID.Text) : DBNull.Value);
                    cmd.Parameters.AddWithValue("_phone", NpgsqlTypes.NpgsqlDbType.Varchar, txtPhone.Text.Length > 0 ? txtPhone.Text : DBNull.Value);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Updated successfully");
                        if (checkFilter.Checked)
                        {
                            SelectFiltered();
                        }
                        else
                        {
                            Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update fail");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Update error: " + ex.Message);
                }
            }
            ClearInputs();
            sideBar.Enabled = false;
            btnSave.Enabled = false;
        }

        private void checkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFilter.Checked)
            {
                comboFilterBy.Enabled = true;
                if (comboFilterBy.SelectedIndex >= 0) // Nothing selected
                {
                    txtInput1.Enabled = true;
                }

                if (comboFilterBy.SelectedIndex == 5) // EntryDate Range
                {
                    txtInput2.Text = null;
                    txtInput2.Visible = true;
                }
                else
                {
                    txtInput2.Visible = false;
                }
            }
            else
            {
                txtInput1.Enabled = false;
                txtInput2.Visible = false;
                comboFilterBy.Enabled = false;
            }
        }

        private void comboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput1.Enabled = true;
            txtInput1.Text = txtInput2.Text = null;
            if (comboFilterBy.SelectedIndex == 5) // EntryDate Range
            {
                txtInput2.Visible = true;
            }
            else
            {
                txtInput2.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            txtCurrentPage.Text = Convert.ToString(currentPage);
            if (!checkFilter.Checked)
            {
                Select();
            }
            else
            {
                if (comboFilterBy.SelectedIndex < 0)
                {
                    MessageBox.Show("Filter option isn't chosen");
                    return;
                }
                else
                {
                    if (comboFilterBy.SelectedIndex == 5)
                    {
                        if (txtInput1.Text.Length == 0 || txtInput2.Text.Length == 0)
                        {
                            MessageBox.Show("Please, fill the filter options");
                            return;
                        }
                        else
                        {
                            SelectFiltered();
                        }
                    }
                    else
                    {
                        if (txtInput1.Text.Length == 0)
                        {
                            MessageBox.Show("Please, fill the filter options");
                            return;
                        }
                        else
                        {
                            SelectFiltered();
                        }
                    }
                }
            }

            ClearInputs();
            sideBar.Enabled = false;
            rowIndex = -1;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                conn.Open();
                currentPage--;
                txtCurrentPage.Text = Convert.ToString(currentPage);
                cmd = new NpgsqlCommand(sql + $" LIMIT {pageSize} OFFSET {pageSize * currentPage - pageSize}", conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = dt;
                conn.Close();

                ClearInputs();
                sideBar.Enabled = false;
                rowIndex = -1;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                conn.Open();
                currentPage++;
                txtCurrentPage.Text = Convert.ToString(currentPage);
                cmd = new NpgsqlCommand(sql + $" LIMIT {pageSize} OFFSET {pageSize * currentPage - pageSize}", conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = dt;
                conn.Close();

                ClearInputs();
                sideBar.Enabled = false;
                rowIndex = -1;
            }
        }

        private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    currentPage = int.Parse(txtCurrentPage.Text);
                    if (currentPage > totalPages)
                    {
                        currentPage = totalPages;
                        txtCurrentPage.Text = Convert.ToString(currentPage);
                    }
                    else if (currentPage < 1)
                    {
                        currentPage = 1;
                        txtCurrentPage.Text = Convert.ToString(currentPage);
                    }
                    
                    if (checkFilter.Checked)
                    {
                        SelectFiltered();
                    }
                    else
                    {
                        Select();
                    }

                    ClearInputs();
                    sideBar.Enabled = false;
                    rowIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void checkPagination_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPagination.Checked)
            {
                btnPreviousPage.Enabled = true;
                btnNextPage.Enabled = true;
                txtCurrentPage.Enabled = true;
                labelTotalPageCount.Enabled = true;
                labelRecordsPerPage.Enabled = true;
                txtRecordsPerPage.Enabled = true;
            }
            else
            {
                btnPreviousPage.Enabled = false;
                btnNextPage.Enabled = false;
                txtCurrentPage.Enabled = false;
                labelTotalPageCount.Enabled = false;
                labelRecordsPerPage.Enabled = false;
                txtRecordsPerPage.Enabled = false;
            }
        }

        private void CalculateTotalPages(string sql)
        {
            //conn.Open();
            DataTable dt_rowCount = new DataTable();
            cmd = new NpgsqlCommand(sql, conn);
            dt_rowCount.Load(cmd.ExecuteReader());
            int rowCount = dt_rowCount.Rows.Count;
            if (rowCount == 0)
            {
                totalPages = 1;
            }
            else
            {
                if (txtRecordsPerPage.Text.Length > 0)
                {
                    pageSize = int.Parse(txtRecordsPerPage.Text);
                }
                else
                {
                    pageSize = rowCount;
                    txtRecordsPerPage.Text = Convert.ToString(pageSize);
                    currentPage = 1;
                    txtCurrentPage.Text = "1";
                }
                totalPages = rowCount / pageSize;
                if (rowCount % pageSize > 0)
                {
                    totalPages++;
                }

                if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                }
            }

            txtCurrentPage.Text = Convert.ToString(currentPage);
            labelTotalPageCount.Text = $"/{totalPages}";
        }
    }
}