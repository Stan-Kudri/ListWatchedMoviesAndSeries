namespace ListWatchedMoviesAndSeries
{
    partial class AddCinemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAddCinema = new System.Windows.Forms.TextBox();
            this.cinemaModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberSeaquel = new System.Windows.Forms.Label();
            this.btnAddCinema = new System.Windows.Forms.Button();
            this.btnClearTxtCinema = new System.Windows.Forms.Button();
            this.btnBackFormCinema = new System.Windows.Forms.Button();
            this.numericSeaquel = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerCinema = new System.Windows.Forms.DateTimePicker();
            this.numericGradeCinema = new System.Windows.Forms.NumericUpDown();
            this.labelGrade = new System.Windows.Forms.Label();
            this.watchDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeaquel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradeCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddCinema
            // 
            this.txtAddCinema.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemaModelsBindingSource, "Name", true));
            this.txtAddCinema.Location = new System.Drawing.Point(10, 10);
            this.txtAddCinema.Name = "txtAddCinema";
            this.txtAddCinema.Size = new System.Drawing.Size(352, 23);
            this.txtAddCinema.TabIndex = 1;
            // 
            // cinemaModelsBindingSource
            // 
            this.cinemaModelsBindingSource.DataSource = typeof(ListWatchedMoviesAndSeries.Models.CinemaModel);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Location = new System.Drawing.Point(365, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelNumberSeaquel
            // 
            this.labelNumberSeaquel.AutoSize = true;
            this.labelNumberSeaquel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNumberSeaquel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberSeaquel.Location = new System.Drawing.Point(365, 40);
            this.labelNumberSeaquel.Name = "labelNumberSeaquel";
            this.labelNumberSeaquel.Size = new System.Drawing.Size(56, 19);
            this.labelNumberSeaquel.TabIndex = 6;
            this.labelNumberSeaquel.Text = "Seaquel";
            // 
            // btnAddCinema
            // 
            this.btnAddCinema.AutoEllipsis = true;
            this.btnAddCinema.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCinema.Location = new System.Drawing.Point(215, 70);
            this.btnAddCinema.Name = "btnAddCinema";
            this.btnAddCinema.Size = new System.Drawing.Size(60, 30);
            this.btnAddCinema.TabIndex = 8;
            this.btnAddCinema.Text = "Add";
            this.btnAddCinema.UseVisualStyleBackColor = false;
            this.btnAddCinema.Click += new System.EventHandler(this.BtnAddCinema_Click);
            // 
            // btnClearTxtCinema
            // 
            this.btnClearTxtCinema.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClearTxtCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTxtCinema.Location = new System.Drawing.Point(285, 70);
            this.btnClearTxtCinema.Name = "btnClearTxtCinema";
            this.btnClearTxtCinema.Size = new System.Drawing.Size(60, 30);
            this.btnClearTxtCinema.TabIndex = 9;
            this.btnClearTxtCinema.Text = "Clear";
            this.btnClearTxtCinema.UseVisualStyleBackColor = false;
            this.btnClearTxtCinema.Click += new System.EventHandler(this.BtnClearTxtCinema_Click);
            // 
            // btnBackFormCinema
            // 
            this.btnBackFormCinema.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackFormCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFormCinema.Location = new System.Drawing.Point(355, 70);
            this.btnBackFormCinema.Name = "btnBackFormCinema";
            this.btnBackFormCinema.Size = new System.Drawing.Size(60, 30);
            this.btnBackFormCinema.TabIndex = 10;
            this.btnBackFormCinema.Text = "Close";
            this.btnBackFormCinema.UseVisualStyleBackColor = false;
            this.btnBackFormCinema.Click += new System.EventHandler(this.BtnBackFormCinema_Click);
            // 
            // numericSeaquel
            // 
            this.numericSeaquel.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cinemaModelsBindingSource, "NumberSequel", true));
            this.numericSeaquel.Location = new System.Drawing.Point(215, 40);
            this.numericSeaquel.Name = "numericSeaquel";
            this.numericSeaquel.Size = new System.Drawing.Size(145, 23);
            this.numericSeaquel.TabIndex = 11;
            // 
            // dateTimePickerCinema
            // 
            this.dateTimePickerCinema.CustomFormat = "\"dd.MM.yyyy\"";
            this.dateTimePickerCinema.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.watchDetailBindingSource, "DateWatch", true));
            this.dateTimePickerCinema.Location = new System.Drawing.Point(9, 70);
            this.dateTimePickerCinema.MaxDate = new System.DateTime(2022, 9, 7, 0, 0, 0, 0);
            this.dateTimePickerCinema.MinDate = new System.DateTime(1949, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCinema.Name = "dateTimePickerCinema";
            this.dateTimePickerCinema.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerCinema.TabIndex = 13;
            this.dateTimePickerCinema.Value = new System.DateTime(2022, 8, 7, 0, 0, 0, 0);
            this.dateTimePickerCinema.ValueChanged += new System.EventHandler(this.DateTimePickerCinema_ValueChanged);
            // 
            // numericGradeCinema
            // 
            this.numericGradeCinema.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.watchDetailBindingSource, "Grade", true));
            this.numericGradeCinema.Enabled = false;
            this.numericGradeCinema.InterceptArrowKeys = false;
            this.numericGradeCinema.Location = new System.Drawing.Point(9, 40);
            this.numericGradeCinema.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericGradeCinema.Name = "numericGradeCinema";
            this.numericGradeCinema.ReadOnly = true;
            this.numericGradeCinema.Size = new System.Drawing.Size(101, 23);
            this.numericGradeCinema.TabIndex = 17;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrade.Location = new System.Drawing.Point(115, 40);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(46, 19);
            this.labelGrade.TabIndex = 18;
            this.labelGrade.Text = "Grade";
            // 
            // watchDetailBindingSource
            // 
            this.watchDetailBindingSource.DataSource = typeof(ListWatchedMoviesAndSeries.Models.Item.WatchDetail);
            // 
            // AddCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(419, 111);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.numericGradeCinema);
            this.Controls.Add(this.dateTimePickerCinema);
            this.Controls.Add(this.numericSeaquel);
            this.Controls.Add(this.btnBackFormCinema);
            this.Controls.Add(this.btnClearTxtCinema);
            this.Controls.Add(this.btnAddCinema);
            this.Controls.Add(this.labelNumberSeaquel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtAddCinema);
            this.MaximumSize = new System.Drawing.Size(435, 150);
            this.MinimumSize = new System.Drawing.Size(435, 150);
            this.Name = "AddCinemaForm";
            this.Text = "Series";
            ((System.ComponentModel.ISupportInitialize)(this.cinemaModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeaquel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGradeCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelName;
        private Label labelNumberSeaquel;
        private Button btnClearTxtCinema;
        private Button btnBackFormCinema;
        private Button btnAddCinema;
        private TextBox txtAddCinema;
        private NumericUpDown numericSeaquel;
        private DateTimePicker dateTimePickerCinema;
        private NumericUpDown numericGradeCinema;
        private Label labelGrade;
        private BindingSource cinemaModelsBindingSource;
        private BindingSource watchDetailBindingSource;
    }
}
