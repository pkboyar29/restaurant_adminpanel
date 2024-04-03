namespace kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStatusFilter = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.labelNameClient = new System.Windows.Forms.Label();
            this.labelPhoneClient = new System.Windows.Forms.Label();
            this.textBoxPhoneClient = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelNumberGuests = new System.Windows.Forms.Label();
            this.textBoxNumberGuests = new System.Windows.Forms.TextBox();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.comboBoxTableNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
            this.labelDayFilter = new System.Windows.Forms.Label();
            this.dateTimePickerFilterDay = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelDate = new System.Windows.Forms.Button();
            this.labelInsert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatusInsert = new System.Windows.Forms.ComboBox();
            this.comboBoxTableNumberInsert = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberGuestsInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCommentInsert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerInsert = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhoneInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameInsert = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelAccountName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 542);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelStatusFilter
            // 
            this.labelStatusFilter.AutoSize = true;
            this.labelStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusFilter.Location = new System.Drawing.Point(12, 19);
            this.labelStatusFilter.Name = "labelStatusFilter";
            this.labelStatusFilter.Size = new System.Drawing.Size(168, 16);
            this.labelStatusFilter.TabIndex = 1;
            this.labelStatusFilter.Text = "Фильтровать по статусу";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdate.Location = new System.Drawing.Point(753, 51);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(159, 20);
            this.labelUpdate.TabIndex = 2;
            this.labelUpdate.Text = "Обновление записи";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(934, 267);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 28);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Обновить запись";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameClient.Location = new System.Drawing.Point(757, 101);
            this.textBoxNameClient.MaxLength = 30;
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.ReadOnly = true;
            this.textBoxNameClient.Size = new System.Drawing.Size(135, 22);
            this.textBoxNameClient.TabIndex = 4;
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameClient.Location = new System.Drawing.Point(754, 82);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(90, 16);
            this.labelNameClient.TabIndex = 5;
            this.labelNameClient.Text = "Имя клиента";
            // 
            // labelPhoneClient
            // 
            this.labelPhoneClient.AutoSize = true;
            this.labelPhoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneClient.Location = new System.Drawing.Point(931, 82);
            this.labelPhoneClient.Name = "labelPhoneClient";
            this.labelPhoneClient.Size = new System.Drawing.Size(124, 16);
            this.labelPhoneClient.TabIndex = 6;
            this.labelPhoneClient.Text = "Телефон клиента";
            // 
            // textBoxPhoneClient
            // 
            this.textBoxPhoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneClient.Location = new System.Drawing.Point(934, 101);
            this.textBoxPhoneClient.MaxLength = 12;
            this.textBoxPhoneClient.Name = "textBoxPhoneClient";
            this.textBoxPhoneClient.ReadOnly = true;
            this.textBoxPhoneClient.Size = new System.Drawing.Size(135, 22);
            this.textBoxPhoneClient.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(757, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateStart.Location = new System.Drawing.Point(754, 140);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(133, 16);
            this.labelDateStart.TabIndex = 9;
            this.labelDateStart.Text = "Дата начала брони";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComment.Location = new System.Drawing.Point(934, 159);
            this.textBoxComment.MaxLength = 100;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(135, 22);
            this.textBoxComment.TabIndex = 10;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComment.Location = new System.Drawing.Point(931, 140);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(96, 16);
            this.labelComment.TabIndex = 11;
            this.labelComment.Text = "Комментарий";
            // 
            // labelNumberGuests
            // 
            this.labelNumberGuests.AutoSize = true;
            this.labelNumberGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberGuests.Location = new System.Drawing.Point(754, 194);
            this.labelNumberGuests.Name = "labelNumberGuests";
            this.labelNumberGuests.Size = new System.Drawing.Size(132, 16);
            this.labelNumberGuests.TabIndex = 12;
            this.labelNumberGuests.Text = "Количество гостей";
            // 
            // textBoxNumberGuests
            // 
            this.textBoxNumberGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberGuests.Location = new System.Drawing.Point(757, 213);
            this.textBoxNumberGuests.MaxLength = 2;
            this.textBoxNumberGuests.Name = "textBoxNumberGuests";
            this.textBoxNumberGuests.Size = new System.Drawing.Size(135, 22);
            this.textBoxNumberGuests.TabIndex = 13;
            this.textBoxNumberGuests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberGuests_KeyPress);
            this.textBoxNumberGuests.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberGuests_Validating);
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableNumber.Location = new System.Drawing.Point(931, 194);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(106, 16);
            this.labelTableNumber.TabIndex = 14;
            this.labelTableNumber.Text = "Номер столика";
            // 
            // comboBoxTableNumber
            // 
            this.comboBoxTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTableNumber.FormattingEnabled = true;
            this.comboBoxTableNumber.Location = new System.Drawing.Point(934, 212);
            this.comboBoxTableNumber.Name = "comboBoxTableNumber";
            this.comboBoxTableNumber.Size = new System.Drawing.Size(135, 24);
            this.comboBoxTableNumber.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(757, 269);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(135, 24);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(754, 250);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 16);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Статус";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdateTable.BackgroundImage")));
            this.buttonUpdateTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateTable.Location = new System.Drawing.Point(12, 599);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdateTable.TabIndex = 19;
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // comboBoxStatusFilter
            // 
            this.comboBoxStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatusFilter.FormattingEnabled = true;
            this.comboBoxStatusFilter.Location = new System.Drawing.Point(186, 16);
            this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            this.comboBoxStatusFilter.Size = new System.Drawing.Size(135, 24);
            this.comboBoxStatusFilter.TabIndex = 20;
            this.comboBoxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusFilter_SelectedIndexChanged);
            // 
            // labelDayFilter
            // 
            this.labelDayFilter.AutoSize = true;
            this.labelDayFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayFilter.Location = new System.Drawing.Point(327, 20);
            this.labelDayFilter.Name = "labelDayFilter";
            this.labelDayFilter.Size = new System.Drawing.Size(142, 16);
            this.labelDayFilter.TabIndex = 21;
            this.labelDayFilter.Text = "Фильтровать по дню";
            // 
            // dateTimePickerFilterDay
            // 
            this.dateTimePickerFilterDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFilterDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFilterDay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePickerFilterDay.Location = new System.Drawing.Point(475, 16);
            this.dateTimePickerFilterDay.Name = "dateTimePickerFilterDay";
            this.dateTimePickerFilterDay.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerFilterDay.TabIndex = 22;
            this.dateTimePickerFilterDay.ValueChanged += new System.EventHandler(this.dateTimePickerFilterDay_ValueChanged);
            // 
            // buttonCancelDate
            // 
            this.buttonCancelDate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelDate.BackgroundImage")));
            this.buttonCancelDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelDate.Location = new System.Drawing.Point(616, 16);
            this.buttonCancelDate.Name = "buttonCancelDate";
            this.buttonCancelDate.Size = new System.Drawing.Size(24, 24);
            this.buttonCancelDate.TabIndex = 23;
            this.buttonCancelDate.UseVisualStyleBackColor = false;
            this.buttonCancelDate.Click += new System.EventHandler(this.buttonCancelDate_Click);
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInsert.Location = new System.Drawing.Point(753, 345);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(159, 20);
            this.labelInsert.TabIndex = 24;
            this.labelInsert.Text = "Добавление записи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(754, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Статус";
            // 
            // comboBoxStatusInsert
            // 
            this.comboBoxStatusInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatusInsert.FormattingEnabled = true;
            this.comboBoxStatusInsert.Location = new System.Drawing.Point(757, 567);
            this.comboBoxStatusInsert.Name = "comboBoxStatusInsert";
            this.comboBoxStatusInsert.Size = new System.Drawing.Size(135, 24);
            this.comboBoxStatusInsert.TabIndex = 38;
            // 
            // comboBoxTableNumberInsert
            // 
            this.comboBoxTableNumberInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTableNumberInsert.FormattingEnabled = true;
            this.comboBoxTableNumberInsert.Location = new System.Drawing.Point(934, 510);
            this.comboBoxTableNumberInsert.Name = "comboBoxTableNumberInsert";
            this.comboBoxTableNumberInsert.Size = new System.Drawing.Size(135, 24);
            this.comboBoxTableNumberInsert.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(931, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Номер столика";
            // 
            // textBoxNumberGuestsInsert
            // 
            this.textBoxNumberGuestsInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberGuestsInsert.Location = new System.Drawing.Point(757, 511);
            this.textBoxNumberGuestsInsert.MaxLength = 2;
            this.textBoxNumberGuestsInsert.Name = "textBoxNumberGuestsInsert";
            this.textBoxNumberGuestsInsert.Size = new System.Drawing.Size(135, 22);
            this.textBoxNumberGuestsInsert.TabIndex = 35;
            this.textBoxNumberGuestsInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberGuestsInsert_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(754, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Количество гостей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(931, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Комментарий";
            // 
            // textBoxCommentInsert
            // 
            this.textBoxCommentInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCommentInsert.Location = new System.Drawing.Point(934, 457);
            this.textBoxCommentInsert.MaxLength = 100;
            this.textBoxCommentInsert.Name = "textBoxCommentInsert";
            this.textBoxCommentInsert.Size = new System.Drawing.Size(135, 22);
            this.textBoxCommentInsert.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(754, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Дата начала брони";
            // 
            // dateTimePickerInsert
            // 
            this.dateTimePickerInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerInsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInsert.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePickerInsert.Location = new System.Drawing.Point(757, 457);
            this.dateTimePickerInsert.Name = "dateTimePickerInsert";
            this.dateTimePickerInsert.Size = new System.Drawing.Size(135, 22);
            this.dateTimePickerInsert.TabIndex = 30;
            // 
            // textBoxPhoneInsert
            // 
            this.textBoxPhoneInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneInsert.Location = new System.Drawing.Point(934, 399);
            this.textBoxPhoneInsert.MaxLength = 12;
            this.textBoxPhoneInsert.Name = "textBoxPhoneInsert";
            this.textBoxPhoneInsert.Size = new System.Drawing.Size(135, 22);
            this.textBoxPhoneInsert.TabIndex = 29;
            this.textBoxPhoneInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneInsert_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(931, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Телефон клиента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(754, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Имя клиента";
            // 
            // textBoxNameInsert
            // 
            this.textBoxNameInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameInsert.Location = new System.Drawing.Point(757, 399);
            this.textBoxNameInsert.MaxLength = 30;
            this.textBoxNameInsert.Name = "textBoxNameInsert";
            this.textBoxNameInsert.Size = new System.Drawing.Size(135, 22);
            this.textBoxNameInsert.TabIndex = 26;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(934, 565);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(150, 28);
            this.buttonInsert.TabIndex = 25;
            this.buttonInsert.Text = "Добавить запись";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(1106, 16);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(66, 34);
            this.buttonLogout.TabIndex = 40;
            this.buttonLogout.Text = "Выйти";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccountName.Location = new System.Drawing.Point(1027, 23);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(0, 20);
            this.labelAccountName.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatusInsert);
            this.Controls.Add(this.comboBoxTableNumberInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumberGuestsInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCommentInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerInsert);
            this.Controls.Add(this.textBoxPhoneInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNameInsert);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.buttonCancelDate);
            this.Controls.Add(this.dateTimePickerFilterDay);
            this.Controls.Add(this.labelDayFilter);
            this.Controls.Add(this.comboBoxStatusFilter);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxTableNumber);
            this.Controls.Add(this.labelTableNumber);
            this.Controls.Add(this.textBoxNumberGuests);
            this.Controls.Add(this.labelNumberGuests);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPhoneClient);
            this.Controls.Add(this.labelPhoneClient);
            this.Controls.Add(this.labelNameClient);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelStatusFilter);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD приложение для базы данных \"Ресторан\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStatusFilter;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.Label labelPhoneClient;
        private System.Windows.Forms.TextBox textBoxPhoneClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelNumberGuests;
        private System.Windows.Forms.TextBox textBoxNumberGuests;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.ComboBox comboBoxTableNumber;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.Label labelDayFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDay;
        private System.Windows.Forms.Button buttonCancelDate;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatusInsert;
        private System.Windows.Forms.ComboBox comboBoxTableNumberInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberGuestsInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCommentInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerInsert;
        private System.Windows.Forms.TextBox textBoxPhoneInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelAccountName;
    }
}

