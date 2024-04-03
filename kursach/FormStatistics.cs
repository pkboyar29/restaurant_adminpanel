using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace kursach
{
    public partial class FormStatistics : Form
    {
        DataBase dataBase = new DataBase();
        public FormStatistics()
        {
            InitializeComponent();

            labelAccountName.Text = DataBase.User;
        }

        private void FormStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            ComboBoxSetStyles();

            LoadFirstDiagram();
            LoadSecondDiagram();
        }

        private void ComboBoxSetStyles()
        {
            // ДЛЯ comboBoxMonth
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] monthNamesArray = { "Декабрь", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Май", "Сентябрь", "Октябрь", "Ноябрь" };
            int[] monthValuesArray = { 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            DataTable monthDataTable = new DataTable();
            monthDataTable.Columns.Add("MonthName", typeof(string));
            monthDataTable.Columns.Add("MonthValue", typeof(int));

            for (int i = 0; i < monthNamesArray.Length; i++)
            {
                monthDataTable.Rows.Add(monthNamesArray[i], monthValuesArray[i]);
            }

            comboBoxMonth.DataSource = monthDataTable;
            comboBoxMonth.DisplayMember = "MonthName";
            comboBoxMonth.ValueMember = "MonthValue";

            // ДЛЯ comboBoxYear
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            // Заполнение годами
            int minYear = 2000;
            int maxYear = 2100;
            DataTable yearDataTable = new DataTable();
            yearDataTable.Columns.Add("YearValue", typeof(int));

            for (int year = minYear; year <= maxYear; year++)
            {
                yearDataTable.Rows.Add(year);
            }

            comboBoxYear.DataSource = yearDataTable;
            comboBoxYear.DisplayMember = "YearValue";
            comboBoxYear.ValueMember = "YearValue";
            comboBoxYear.SelectedValue = 2023;

            // ДЛЯ comboBoxYearRevenue
            comboBoxYearRevenue.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable yearRevenueDataTable = new DataTable();
            yearRevenueDataTable.Columns.Add("YearValue", typeof(int));
            for (int year = minYear; year <= maxYear; year++)
            {
                yearRevenueDataTable.Rows.Add(year);
            }
            comboBoxYearRevenue.DataSource = yearRevenueDataTable;
            comboBoxYearRevenue.DisplayMember = "YearValue";
            comboBoxYearRevenue.ValueMember = "YearValue";
            comboBoxYearRevenue.SelectedValue = 2024;
        }

        private void LoadFirstDiagram()
        {
            try
            {
                dataBase.openConnection();

                int selectedYear = (int)comboBoxYear.SelectedValue;
                int selectedMonth = (int)comboBoxMonth.SelectedValue;
                string monthYearParameter = $"{selectedYear}-{selectedMonth}";


                using (SqlCommand command = new SqlCommand("ShowReservationCountByTable", dataBase.getConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MonthYear", monthYearParameter));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable source = new DataTable();
                        adapter.Fill(source);

                        if (source.Rows.Count == 0)
                        {
                            chart1.Series.Clear();
                            chart1.Titles.Add("Нету данных для отображения на графике");
                            return; // Прерываем выполнение метода, так как нет данных
                        }

                        chart1.Series.Clear();
                        chart1.Titles.Clear();

                        // Создание новой серии
                        Series series = new Series("ShowReservationCountByTable");
                        //series.LegendText = "Количество бронирований указанного столика";

                        series.ChartType = SeriesChartType.Pie; // Устанавливаем тип круговой диаграммы

                        // Привязка данных к серии
                        series.Points.DataBind(source.DefaultView, "TableNumber", "ReservationCount", "");

                        series.IsValueShownAsLabel = true;

                        chart1.Series.Add(series);

                        chart1.Titles.Add("Количество бронирований каждого столика за указанный месяц");

                        chart1.Legends[0].Font = new Font("Arial", 10);
                        chart1.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                        chart1.Invalidate();
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

        private void LoadSecondDiagram()
        {
            try
            {
                dataBase.openConnection();

                int selectedYear = (int)comboBoxYearRevenue.SelectedValue;

                using (SqlCommand command = new SqlCommand("CalculateTakeawayRevenueByYear", dataBase.getConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Year", selectedYear));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable source = new DataTable();
                        adapter.Fill(source);

                        if (source.Rows.Count == 0)
                        {
                            chart2.Series.Clear();
                            chart2.Titles.Add("Нету данных для отображения на графике");
                            return; // Прерываем выполнение метода, так как нет данных
                        }

                        // Очистка
                        chart2.Series.Clear();
                        chart2.Titles.Clear();

                        Series series = new Series("Выручка");
                        series.ChartType = SeriesChartType.Column;

                        // Привязка данных к серии
                        series.Points.DataBind(source.DefaultView, "Month", "TotalRevenue", "");

                        // Добавление серии на график
                        chart2.Series.Add(series);

                        // Настройка внешнего вида графика (опционально)
                        chart2.Titles.Add("Выручка по месяцам " + selectedYear.ToString());

                        chart2.Legends[0].Font = new Font("Arial", 10);
                        chart2.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                        // Перерисовка графика
                        chart2.Invalidate();
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

        private void buttonApply_Click(object sender, EventArgs e)
        {
            LoadFirstDiagram();
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

        private void buttonApplySecond_Click(object sender, EventArgs e)
        {
            LoadSecondDiagram();
        }
    }
}
