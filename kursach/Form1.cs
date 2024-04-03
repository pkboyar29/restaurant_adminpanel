using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursach
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        private DataTable reservationsTable;
        private int activeReservationID;
        private DateTime selectedFilterDate = new DateTime(2000, 01, 01, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // или FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 8);

            ComboBoxSetStyles();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePickerInsert.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerInsert.CustomFormat = "dd.MM.yyyy HH:mm";

            labelAccountName.Text = DataBase.User;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadReservationsData("все", new DateTime(2000, 01, 01, 0, 0, 0));
        }

        private void ComboBoxSetStyles()
        {
            comboBoxTableNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTableNumberInsert.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusInsert.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] dataArray = { "обрабатывается", "подтверждено", "отменено" };
            comboBoxStatus.DataSource = dataArray;

            string[] statusFilterArray = { "все", "обрабатывается", "подтверждено", "отменено" };
            comboBoxStatusFilter.DataSource = statusFilterArray;

            SqlCommand commandTables = new SqlCommand("ShowTableNumbers", dataBase.getConnection());
            commandTables.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapterTables = new SqlDataAdapter(commandTables);
            DataTable tablesDataTable = new DataTable();
            DataTable tablesDataTableInsert = new DataTable();
            adapterTables.Fill(tablesDataTable);
            adapterTables.Fill(tablesDataTableInsert);

            tablesDataTable.Columns.Add("FormattedTableInfo", typeof(string), "TableNumber + ' - ' + NumberSeats + ' мест'");
            DataRow emptyRow = tablesDataTable.NewRow();
            emptyRow["TableNumber"] = DBNull.Value;
            tablesDataTable.Rows.InsertAt(emptyRow, 0);

            comboBoxTableNumber.DisplayMember = "FormattedTableInfo";
            comboBoxTableNumber.ValueMember = "TableNumber";
            comboBoxTableNumber.DataSource = tablesDataTable;


            string[] dataArrayInsert = { "обрабатывается", "подтверждено", "отменено" };
            comboBoxStatusInsert.DataSource = dataArrayInsert;

            tablesDataTableInsert.Columns.Add("FormattedTableInfo", typeof(string), "TableNumber + ' - ' + NumberSeats + ' мест'");
            DataRow emptyRowInsert = tablesDataTableInsert.NewRow();
            emptyRowInsert["TableNumber"] = DBNull.Value;
            tablesDataTableInsert.Rows.InsertAt(emptyRowInsert, 0);

            comboBoxTableNumberInsert.DisplayMember = "FormattedTableInfo";
            comboBoxTableNumberInsert.ValueMember = "TableNumber";
            comboBoxTableNumberInsert.DataSource = tablesDataTableInsert;
        }

        private void LoadReservationsData(string statusParam, DateTime datetimeParam)
        {
            try
            {
                dataBase.openConnection();

                using (SqlCommand command = new SqlCommand("ShowReservations", dataBase.getConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Status", statusParam));
                    command.Parameters.Add(new SqlParameter("@FilterDate", datetimeParam));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        reservationsTable = new DataTable();
                        adapter.Fill(reservationsTable);
                        dataGridView1.DataSource = reservationsTable;

                        dataGridView1.Columns["ReservationId"].Visible = false;
                        dataGridView1.Columns["DateTimeStart"].HeaderText = "Дата начала брони";
                        dataGridView1.Columns["NameClient"].HeaderText = "Имя клиента";
                        dataGridView1.Columns["PhoneClient"].HeaderText = "Телефон клиента";
                        dataGridView1.Columns["Comment"].HeaderText = "Комментарий";
                        dataGridView1.Columns["NumberGuests"].HeaderText = "Количество гостей";
                        dataGridView1.Columns["Status"].HeaderText = "Статус";
                        dataGridView1.Columns["TableNumber"].HeaderText = "Номер столика";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Получение данных из выбранной строки
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Получение значений из выбранной строки
                int idReservation = (int)selectedRow.Cells["ReservationId"].Value;

                string nameClient = selectedRow.Cells["NameClient"].Value.ToString();
                string phoneClient = selectedRow.Cells["PhoneClient"].Value.ToString();
                string startDate = selectedRow.Cells["DateTimeStart"].Value.ToString();
                string comment = selectedRow.Cells["Comment"].Value.ToString();
                string numberGuests = selectedRow.Cells["NumberGuests"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string tableNumber = selectedRow.Cells["TableNumber"].Value.ToString();

                // Передача данных в контролы формы обновления
                textBoxNameClient.Text = nameClient;
                textBoxPhoneClient.Text = phoneClient;
                dateTimePicker1.Value = DateTime.Parse(startDate);
                textBoxComment.Text = comment;
                textBoxNumberGuests.Text = numberGuests;
                comboBoxStatus.Text = status;
                
                if (tableNumber != DBNull.Value.ToString())
                    comboBoxTableNumber.SelectedValue = tableNumber;
                else
                    comboBoxTableNumber.SelectedIndex = 0;

                this.activeReservationID = idReservation;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.activeReservationID != 0)
            {
                try
                {
                    dataBase.openConnection();

                    SqlCommand command = new SqlCommand("UpdateReservation", dataBase.getConnection());
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ReservationId", this.activeReservationID));
                    command.Parameters.Add(new SqlParameter("@DateTimeStart", dateTimePicker1.Value));
                    command.Parameters.Add(new SqlParameter("@Comment", textBoxComment.Text));
                    command.Parameters.Add(new SqlParameter("@NumberGuests", int.Parse(textBoxNumberGuests.Text)));
                    command.Parameters.Add(new SqlParameter("@Status", comboBoxStatus.Text));

                    if (comboBoxTableNumber.SelectedValue.ToString() == DBNull.Value.ToString())
                        command.Parameters.Add(new SqlParameter("@TableNumber", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@TableNumber", comboBoxTableNumber.SelectedValue));

                    command.ExecuteNonQuery();

                    LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);

                    MessageBox.Show("Обновление записи произошло успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}");
                }
                finally
                {
                    dataBase.closeConnection();
                }
            }
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);
        }

        private void comboBoxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);
        }

        private void buttonCancelDate_Click(object sender, EventArgs e)
        {
            selectedFilterDate = new DateTime(2000, 01, 01, 0, 0, 0);
            LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);
        }

        private void dateTimePickerFilterDay_ValueChanged(object sender, EventArgs e)
        {
            selectedFilterDate = dateTimePickerFilterDay.Value;
            LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();

                SqlCommand command = new SqlCommand("AddReservation", dataBase.getConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@NameClient", textBoxNameInsert.Text));
                command.Parameters.Add(new SqlParameter("@PhoneClient", textBoxPhoneInsert.Text));
                command.Parameters.Add(new SqlParameter("@DateTimeStart", dateTimePickerInsert.Value));
                command.Parameters.Add(new SqlParameter("@Comment", textBoxCommentInsert.Text));
                command.Parameters.Add(new SqlParameter("@NumberGuests", int.Parse(textBoxNumberGuestsInsert.Text)));
                command.Parameters.Add(new SqlParameter("@Status", comboBoxStatusInsert.Text));

                if (comboBoxTableNumberInsert.SelectedValue.ToString() == DBNull.Value.ToString())
                    command.Parameters.Add(new SqlParameter("@TableNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableNumber", comboBoxTableNumberInsert.SelectedValue));

                command.ExecuteNonQuery();

                LoadReservationsData(comboBoxStatusFilter.SelectedItem.ToString(), selectedFilterDate);

                ClearInsertForm();

                MessageBox.Show("Добавление записи произошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}");
            }
            finally
            {
                dataBase.closeConnection();
            }

        }

        private void ClearInsertForm()
        {
            textBoxNameInsert.Text = string.Empty;
            textBoxPhoneInsert.Text = string.Empty;
            textBoxCommentInsert.Text = string.Empty;
            textBoxNumberGuestsInsert.Text = string.Empty;
            comboBoxTableNumberInsert.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            comboBoxStatusFilter.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход из аккаунта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                FormAuthorization form = new FormAuthorization();
                form.Show();
            }
        }

        private void textBoxNumberGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }

        private void textBoxNumberGuests_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (!int.TryParse(textBoxNumberGuests.Text, out int value) || value < 1 || value > 12)
            //{
            //    e.Cancel = true;
            //}
        }

        private void textBoxNumberGuestsInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }

        private void textBoxPhoneInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '+')
            {
                e.Handled = true; // Если не является, игнорируем ввод
            }
        }
    }
}
