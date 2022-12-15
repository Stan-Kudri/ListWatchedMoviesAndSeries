namespace ListWatchedMoviesAndSeries.EditorForm
{
    partial class EditorItemCinemaForm
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
            this.labelGradeCinema = new System.Windows.Forms.Label();
            this.numericEditGradeCinema = new System.Windows.Forms.NumericUpDown();
            this.dateTPCinema = new System.Windows.Forms.DateTimePicker();
            this.numericEditSequel = new System.Windows.Forms.NumericUpDown();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.btnReturnDataCinema = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.labelNumberSequel = new System.Windows.Forms.Label();
            this.labelNameCinema = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.cinemaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditGradeCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditSequel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGradeCinema
            // 
            this.labelGradeCinema.AutoSize = true;
            this.labelGradeCinema.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGradeCinema.Location = new System.Drawing.Point(117, 42);
            this.labelGradeCinema.Name = "labelGradeCinema";
            this.labelGradeCinema.Size = new System.Drawing.Size(46, 19);
            this.labelGradeCinema.TabIndex = 28;
            this.labelGradeCinema.Text = "Grade";
            // 
            // numericEditGradeCinema
            // 
            this.numericEditGradeCinema.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.watchDetailBindingSource, "Grade", true));
            this.numericEditGradeCinema.Enabled = false;
            this.numericEditGradeCinema.InterceptArrowKeys = false;
            this.numericEditGradeCinema.Location = new System.Drawing.Point(11, 42);
            this.numericEditGradeCinema.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEditGradeCinema.Name = "numericEditGradeCinema";
            this.numericEditGradeCinema.ReadOnly = true;
            this.numericEditGradeCinema.Size = new System.Drawing.Size(101, 23);
            this.numericEditGradeCinema.TabIndex = 27;
            // 
            // dateTPCinema
            // 
            this.dateTPCinema.CustomFormat = "\"dd.MM.yyyy\"";
            this.dateTPCinema.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.watchDetailBindingSource, "DateWatch", true));
            this.dateTPCinema.Location = new System.Drawing.Point(11, 72);
            this.dateTPCinema.MaxDate = new System.DateTime(2022, 8, 29, 0, 0, 0, 0);
            this.dateTPCinema.MinDate = new System.DateTime(1949, 12, 31, 0, 0, 0, 0);
            this.dateTPCinema.Name = "dateTPCinema";
            this.dateTPCinema.Size = new System.Drawing.Size(200, 23);
            this.dateTPCinema.TabIndex = 26;
            this.dateTPCinema.Value = new System.DateTime(2022, 8, 7, 0, 0, 0, 0);
            this.dateTPCinema.ValueChanged += new System.EventHandler(this.DateTimePickerCinema_ValueChanged);
            // 
            // numericEditSequel
            // 
            this.numericEditSequel.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cinemaModelBindingSource, "NumberSequel", true));
            this.numericEditSequel.Location = new System.Drawing.Point(217, 42);
            this.numericEditSequel.Name = "numericEditSequel";
            this.numericEditSequel.Size = new System.Drawing.Size(145, 23);
            this.numericEditSequel.TabIndex = 25;
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCloseEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEdit.Location = new System.Drawing.Point(357, 72);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(60, 30);
            this.btnCloseEdit.TabIndex = 24;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.UseVisualStyleBackColor = false;
            this.btnCloseEdit.Click += new System.EventHandler(this.BtnCloseEdit_Click);
            // 
            // btnReturnDataCinema
            // 
            this.btnReturnDataCinema.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturnDataCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnDataCinema.Location = new System.Drawing.Point(287, 72);
            this.btnReturnDataCinema.Name = "btnReturnDataCinema";
            this.btnReturnDataCinema.Size = new System.Drawing.Size(60, 30);
            this.btnReturnDataCinema.TabIndex = 23;
            this.btnReturnDataCinema.Text = "Return";
            this.btnReturnDataCinema.UseVisualStyleBackColor = false;
            this.btnReturnDataCinema.Click += new System.EventHandler(this.BtnReturnDataCinema_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.AutoEllipsis = true;
            this.btnSaveEdit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Location = new System.Drawing.Point(217, 72);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(60, 30);
            this.btnSaveEdit.TabIndex = 22;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.BtnSaveEdit_Click);
            // 
            // labelNumberSequel
            // 
            this.labelNumberSequel.AutoSize = true;
            this.labelNumberSequel.BackColor = System.Drawing.SystemColors.Info;
            this.labelNumberSequel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberSequel.Location = new System.Drawing.Point(367, 42);
            this.labelNumberSequel.Name = "labelNumberSequel";
            this.labelNumberSequel.Size = new System.Drawing.Size(49, 19);
            this.labelNumberSequel.TabIndex = 21;
            this.labelNumberSequel.Text = "Sequel";
            // 
            // labelNameCinema
            // 
            this.labelNameCinema.AutoSize = true;
            this.labelNameCinema.BackColor = System.Drawing.SystemColors.Info;
            this.labelNameCinema.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameCinema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNameCinema.Location = new System.Drawing.Point(367, 12);
            this.labelNameCinema.Name = "labelNameCinema";
            this.labelNameCinema.Size = new System.Drawing.Size(45, 19);
            this.labelNameCinema.TabIndex = 20;
            this.labelNameCinema.Text = "Name";
            // 
            // txtEditName
            // 
            this.txtEditName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemaModelBindingSource, "Name", true));
            this.txtEditName.Location = new System.Drawing.Point(12, 12);
            this.txtEditName.Multiline = true;
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(352, 23);
            this.txtEditName.TabIndex = 19;
            // 
            // cinemaModelBindingSource
            // 
            this.cinemaModelBindingSource.DataSource = typeof(ListWatchedMoviesAndSeries.Models.CinemaModel);
            // 
            // watchDetailBindingSource
            // 
            this.watchDetailBindingSource.DataSource = typeof(ListWatchedMoviesAndSeries.Models.Item.WatchDetail);
            // 
            // EditorItemCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(419, 111);
            this.Controls.Add(this.labelGradeCinema);
            this.Controls.Add(this.numericEditGradeCinema);
            this.Controls.Add(this.dateTPCinema);
            this.Controls.Add(this.numericEditSequel);
            this.Controls.Add(this.btnCloseEdit);
            this.Controls.Add(this.btnReturnDataCinema);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.labelNumberSequel);
            this.Controls.Add(this.labelNameCinema);
            this.Controls.Add(this.txtEditName);
            this.Location = new System.Drawing.Point(435, 150);
            this.MaximumSize = new System.Drawing.Size(435, 150);
            this.Name = "EditorItemCinemaForm";
            this.Text = "EditorItemCinemaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericEditGradeCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditSequel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGradeCinema;
        private Button btnCloseEdit;
        private Button btnReturnDataCinema;
        private Button btnSaveEdit;
        private Label labelNumberSequel;
        private Label labelNameCinema;
        private TextBox txtEditName;
        protected NumericUpDown numericEditGradeCinema;
        protected DateTimePicker dateTPCinema;
        protected NumericUpDown numericEditSequel;
        private BindingSource watchDetailBindingSource;
        private BindingSource cinemaModelBindingSource;
    }
}