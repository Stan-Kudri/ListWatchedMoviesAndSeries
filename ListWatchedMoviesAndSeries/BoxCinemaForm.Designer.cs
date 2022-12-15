
namespace ListWatchedMoviesAndSeries
{
    partial class BoxCinemaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFormMovie = new System.Windows.Forms.Button();
            this.btnDeliteMovie = new System.Windows.Forms.Button();
            this.btnFormSeries = new System.Windows.Forms.Button();
            this.cinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditCinema = new System.Windows.Forms.Button();
            this.btnReplaceData = new System.Windows.Forms.Button();
            this.btnFormAnime = new System.Windows.Forms.Button();
            this.btnFormCartoon = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvCinema = new System.Windows.Forms.DataGridView();
            this.NameCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WatchedCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataWatchedCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.cmbFilterWatch = new System.Windows.Forms.ComboBox();
            this.btnUseFilter = new System.Windows.Forms.Button();
            this.btnCancleFilter = new System.Windows.Forms.Button();
            this.filterModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormMovie
            // 
            this.btnFormMovie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFormMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormMovie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormMovie.Location = new System.Drawing.Point(10, 300);
            this.btnFormMovie.Name = "btnFormMovie";
            this.btnFormMovie.Size = new System.Drawing.Size(85, 30);
            this.btnFormMovie.TabIndex = 1;
            this.btnFormMovie.Text = "Add Movie";
            this.btnFormMovie.UseVisualStyleBackColor = false;
            this.btnFormMovie.Click += new System.EventHandler(this.BtnFormMovie_Click);
            // 
            // btnDeliteMovie
            // 
            this.btnDeliteMovie.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeliteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliteMovie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeliteMovie.Location = new System.Drawing.Point(190, 340);
            this.btnDeliteMovie.Name = "btnDeliteMovie";
            this.btnDeliteMovie.Size = new System.Drawing.Size(175, 30);
            this.btnDeliteMovie.TabIndex = 2;
            this.btnDeliteMovie.Text = "Delite";
            this.btnDeliteMovie.UseVisualStyleBackColor = false;
            this.btnDeliteMovie.Click += new System.EventHandler(this.BtnDeliteMovie_Click);
            // 
            // btnFormSeries
            // 
            this.btnFormSeries.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFormSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormSeries.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormSeries.Location = new System.Drawing.Point(100, 300);
            this.btnFormSeries.Name = "btnFormSeries";
            this.btnFormSeries.Size = new System.Drawing.Size(85, 30);
            this.btnFormSeries.TabIndex = 9;
            this.btnFormSeries.Text = "Add Series";
            this.btnFormSeries.UseVisualStyleBackColor = false;
            this.btnFormSeries.Click += new System.EventHandler(this.BtnFormSeries_Click);
            // 
            // btnEditCinema
            // 
            this.btnEditCinema.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEditCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCinema.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditCinema.Location = new System.Drawing.Point(10, 340);
            this.btnEditCinema.Name = "btnEditCinema";
            this.btnEditCinema.Size = new System.Drawing.Size(175, 30);
            this.btnEditCinema.TabIndex = 11;
            this.btnEditCinema.Text = "Edit";
            this.btnEditCinema.UseVisualStyleBackColor = false;
            this.btnEditCinema.Click += new System.EventHandler(this.BtnEditRow_Click);
            // 
            // btnReplaceData
            // 
            this.btnReplaceData.BackColor = System.Drawing.Color.Azure;
            this.btnReplaceData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReplaceData.Location = new System.Drawing.Point(385, 300);
            this.btnReplaceData.Name = "btnReplaceData";
            this.btnReplaceData.Size = new System.Drawing.Size(180, 70);
            this.btnReplaceData.TabIndex = 13;
            this.btnReplaceData.Text = "Replace data from file ";
            this.btnReplaceData.UseVisualStyleBackColor = false;
            this.btnReplaceData.Click += new System.EventHandler(this.BtnReplaceFile_Click);
            // 
            // btnFormAnime
            // 
            this.btnFormAnime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFormAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormAnime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormAnime.Location = new System.Drawing.Point(190, 300);
            this.btnFormAnime.Name = "btnFormAnime";
            this.btnFormAnime.Size = new System.Drawing.Size(85, 30);
            this.btnFormAnime.TabIndex = 14;
            this.btnFormAnime.Text = "Add Anime";
            this.btnFormAnime.UseVisualStyleBackColor = false;
            this.btnFormAnime.Click += new System.EventHandler(this.BtnFormAnime_Click);
            // 
            // btnFormCartoon
            // 
            this.btnFormCartoon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFormCartoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormCartoon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormCartoon.Location = new System.Drawing.Point(280, 300);
            this.btnFormCartoon.Name = "btnFormCartoon";
            this.btnFormCartoon.Size = new System.Drawing.Size(85, 30);
            this.btnFormCartoon.TabIndex = 15;
            this.btnFormCartoon.Text = "Add Cartoon";
            this.btnFormCartoon.UseVisualStyleBackColor = false;
            this.btnFormCartoon.Click += new System.EventHandler(this.BtnFormCartoon_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "ReplaceDataFromFile ";
            // 
            // dgvCinema
            // 
            this.dgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCinema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCinema,
            this.NumberCinema,
            this.WatchedCinema,
            this.DataWatchedCinema,
            this.GradeCinema,
            this.IdCinema,
            this.Cinema});
            this.dgvCinema.Location = new System.Drawing.Point(10, 12);
            this.dgvCinema.MaximumSize = new System.Drawing.Size(555, 270);
            this.dgvCinema.MinimumSize = new System.Drawing.Size(555, 270);
            this.dgvCinema.Name = "dgvCinema";
            this.dgvCinema.ReadOnly = true;
            this.dgvCinema.RowTemplate.Height = 25;
            this.dgvCinema.Size = new System.Drawing.Size(555, 270);
            this.dgvCinema.TabIndex = 16;
            this.dgvCinema.Tag = "Cinema";
            // 
            // NameCinema
            // 
            this.NameCinema.FillWeight = 111F;
            this.NameCinema.HeaderText = "Title";
            this.NameCinema.Name = "NameCinema";
            this.NameCinema.ReadOnly = true;
            this.NameCinema.Width = 111;
            // 
            // NumberCinema
            // 
            this.NumberCinema.HeaderText = "Season/Part";
            this.NumberCinema.Name = "NumberCinema";
            this.NumberCinema.ReadOnly = true;
            // 
            // WatchedCinema
            // 
            this.WatchedCinema.HeaderText = "The Watched Cinema";
            this.WatchedCinema.Name = "WatchedCinema";
            this.WatchedCinema.ReadOnly = true;
            // 
            // DataWatchedCinema
            // 
            this.DataWatchedCinema.HeaderText = "Data";
            this.DataWatchedCinema.Name = "DataWatchedCinema";
            this.DataWatchedCinema.ReadOnly = true;
            // 
            // GradeCinema
            // 
            this.GradeCinema.HeaderText = "Grade";
            this.GradeCinema.Name = "GradeCinema";
            this.GradeCinema.ReadOnly = true;
            // 
            // IdCinema
            // 
            this.IdCinema.HeaderText = "ID";
            this.IdCinema.Name = "IdCinema";
            this.IdCinema.ReadOnly = true;
            this.IdCinema.Visible = false;
            // 
            // Cinema
            // 
            this.Cinema.HeaderText = "Type";
            this.Cinema.Name = "Cinema";
            this.Cinema.ReadOnly = true;
            this.Cinema.Visible = false;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.filterModelBindingSource, "Type", true));
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(10, 380);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(175, 23);
            this.cmbFilterType.TabIndex = 17;
            // 
            // cmbFilterWatch
            // 
            this.cmbFilterWatch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.filterModelBindingSource, "Watch", true));
            this.cmbFilterWatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterWatch.FormattingEnabled = true;
            this.cmbFilterWatch.Location = new System.Drawing.Point(191, 380);
            this.cmbFilterWatch.Name = "cmbFilterWatch";
            this.cmbFilterWatch.Size = new System.Drawing.Size(175, 23);
            this.cmbFilterWatch.TabIndex = 18;
            // 
            // btnUseFilter
            // 
            this.btnUseFilter.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUseFilter.Location = new System.Drawing.Point(385, 375);
            this.btnUseFilter.Name = "btnUseFilter";
            this.btnUseFilter.Size = new System.Drawing.Size(85, 30);
            this.btnUseFilter.TabIndex = 21;
            this.btnUseFilter.Text = "Use Filter";
            this.btnUseFilter.UseVisualStyleBackColor = false;
            this.btnUseFilter.Click += new System.EventHandler(this.BtnUseFilter_Click);
            // 
            // btnCancleFilter
            // 
            this.btnCancleFilter.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancleFilter.Location = new System.Drawing.Point(480, 375);
            this.btnCancleFilter.Name = "btnCancleFilter";
            this.btnCancleFilter.Size = new System.Drawing.Size(85, 30);
            this.btnCancleFilter.TabIndex = 22;
            this.btnCancleFilter.Text = "Cancle Filter";
            this.btnCancleFilter.UseVisualStyleBackColor = false;
            this.btnCancleFilter.Click += new System.EventHandler(this.BtnCancleFilter_Click);
            // 
            // filterModelBindingSource
            // 
            this.filterModelBindingSource.DataSource = typeof(ListWatchedMoviesAndSeries.Model.FilterModel);
            // 
            // BoxCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(574, 411);
            this.Controls.Add(this.btnCancleFilter);
            this.Controls.Add(this.btnUseFilter);
            this.Controls.Add(this.cmbFilterWatch);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.dgvCinema);
            this.Controls.Add(this.btnFormCartoon);
            this.Controls.Add(this.btnFormAnime);
            this.Controls.Add(this.btnReplaceData);
            this.Controls.Add(this.btnEditCinema);
            this.Controls.Add(this.btnFormSeries);
            this.Controls.Add(this.btnDeliteMovie);
            this.Controls.Add(this.btnFormMovie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(620, 450);
            this.MinimumSize = new System.Drawing.Size(590, 450);
            this.Name = "BoxCinemaForm";
            this.Text = "BoxCinema";
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFormMovie;
        private Button btnDeliteMovie;
        private Button btnFormSeries;
        private BindingSource cinemaBindingSource;
        private Button btnEditCinema;
        private Button btnReplaceData;
        private Button btnFormAnime;
        private Button btnFormCartoon;
        private OpenFileDialog openFileDialog;
        private DataGridView dgvCinema;
        private DataGridViewTextBoxColumn NameCinema;
        private DataGridViewTextBoxColumn NumberCinema;
        private DataGridViewTextBoxColumn WatchedCinema;
        private DataGridViewTextBoxColumn DataWatchedCinema;
        private DataGridViewTextBoxColumn GradeCinema;
        private DataGridViewTextBoxColumn IdCinema;
        private DataGridViewTextBoxColumn Cinema;
        private ComboBox cmbFilterType;
        private ComboBox cmbFilterWatch;
        private Button btnUseFilter;
        private Button btnCancleFilter;
        private BindingSource filterModelBindingSource;
    }
}
