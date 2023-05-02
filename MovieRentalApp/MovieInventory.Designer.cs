namespace MovieRentalApp
{
    partial class MovieInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homepageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taglineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDbDataSet = new MovieRentalApp.MovieDbDataSet();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter = new MovieRentalApp.MovieDbDataSetTableAdapters.MOVIETableAdapter();
            this.tableAdapterManager = new MovieRentalApp.MovieDbDataSetTableAdapters.TableAdapterManager();
            this.labelSearchTerm = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMovies = new System.Windows.Forms.ListView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.homepageDataGridViewTextBoxColumn,
            this.overviewDataGridViewTextBoxColumn,
            this.popularityDataGridViewTextBoxColumn,
            this.releasedateDataGridViewTextBoxColumn,
            this.revenueDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.moviestatusDataGridViewTextBoxColumn,
            this.taglineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mOVIEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "movie_id";
            this.movieidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            this.movieidDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 190;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "budget";
            this.budgetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.Width = 90;
            // 
            // homepageDataGridViewTextBoxColumn
            // 
            this.homepageDataGridViewTextBoxColumn.DataPropertyName = "homepage";
            this.homepageDataGridViewTextBoxColumn.HeaderText = "homepage";
            this.homepageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.homepageDataGridViewTextBoxColumn.Name = "homepageDataGridViewTextBoxColumn";
            this.homepageDataGridViewTextBoxColumn.Width = 190;
            // 
            // overviewDataGridViewTextBoxColumn
            // 
            this.overviewDataGridViewTextBoxColumn.DataPropertyName = "overview";
            this.overviewDataGridViewTextBoxColumn.HeaderText = "overview";
            this.overviewDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.overviewDataGridViewTextBoxColumn.Name = "overviewDataGridViewTextBoxColumn";
            this.overviewDataGridViewTextBoxColumn.Width = 190;
            // 
            // popularityDataGridViewTextBoxColumn
            // 
            this.popularityDataGridViewTextBoxColumn.DataPropertyName = "popularity";
            this.popularityDataGridViewTextBoxColumn.HeaderText = "popularity";
            this.popularityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.popularityDataGridViewTextBoxColumn.Name = "popularityDataGridViewTextBoxColumn";
            this.popularityDataGridViewTextBoxColumn.Width = 80;
            // 
            // releasedateDataGridViewTextBoxColumn
            // 
            this.releasedateDataGridViewTextBoxColumn.DataPropertyName = "release_date";
            this.releasedateDataGridViewTextBoxColumn.HeaderText = "release_date";
            this.releasedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releasedateDataGridViewTextBoxColumn.Name = "releasedateDataGridViewTextBoxColumn";
            this.releasedateDataGridViewTextBoxColumn.Width = 110;
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            this.revenueDataGridViewTextBoxColumn.DataPropertyName = "revenue";
            this.revenueDataGridViewTextBoxColumn.HeaderText = "revenue";
            this.revenueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            this.revenueDataGridViewTextBoxColumn.Width = 80;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            this.runtimeDataGridViewTextBoxColumn.DataPropertyName = "runtime";
            this.runtimeDataGridViewTextBoxColumn.HeaderText = "runtime";
            this.runtimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            this.runtimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // moviestatusDataGridViewTextBoxColumn
            // 
            this.moviestatusDataGridViewTextBoxColumn.DataPropertyName = "movie_status";
            this.moviestatusDataGridViewTextBoxColumn.HeaderText = "movie_status";
            this.moviestatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moviestatusDataGridViewTextBoxColumn.Name = "moviestatusDataGridViewTextBoxColumn";
            this.moviestatusDataGridViewTextBoxColumn.Width = 110;
            // 
            // taglineDataGridViewTextBoxColumn
            // 
            this.taglineDataGridViewTextBoxColumn.DataPropertyName = "tagline";
            this.taglineDataGridViewTextBoxColumn.HeaderText = "tagline";
            this.taglineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.taglineDataGridViewTextBoxColumn.Name = "taglineDataGridViewTextBoxColumn";
            this.taglineDataGridViewTextBoxColumn.Width = 190;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.movieDbDataSet;
            // 
            // movieDbDataSet
            // 
            this.movieDbDataSet.DataSetName = "MovieDbDataSet";
            this.movieDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(750, 25);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(67, 24);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchTerm
            // 
            this.textBoxSearchTerm.Location = new System.Drawing.Point(591, 25);
            this.textBoxSearchTerm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTerm.Name = "textBoxSearchTerm";
            this.textBoxSearchTerm.Size = new System.Drawing.Size(146, 22);
            this.textBoxSearchTerm.TabIndex = 3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.movieDbDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MOVIETableAdapter = this.mOVIETableAdapter;
            this.tableAdapterManager.UpdateOrder = MovieRentalApp.MovieDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // labelSearchTerm
            // 
            this.labelSearchTerm.AutoSize = true;
            this.labelSearchTerm.Location = new System.Drawing.Point(493, 30);
            this.labelSearchTerm.Name = "labelSearchTerm";
            this.labelSearchTerm.Size = new System.Drawing.Size(94, 17);
            this.labelSearchTerm.TabIndex = 4;
            this.labelSearchTerm.Text = "Search Term:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(886, 22);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(67, 28);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(46, 30);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(340, 36);
            this.labelSlogan.TabIndex = 7;
            this.labelSlogan.Text = "Ssh ... The Movie is About to Start!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstMovies
            // 
            this.lstMovies.HideSelection = false;
            this.lstMovies.Location = new System.Drawing.Point(197, 338);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(1051, 140);
            this.lstMovies.TabIndex = 10;
            this.lstMovies.UseCompatibleStateImageBehavior = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(338, 484);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 31);
            this.btnCheckout.TabIndex = 11;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(496, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // MovieInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSlogan);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelSearchTerm);
            this.Controls.Add(this.textBoxSearchTerm);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieInventory";
            this.Text = "Movie Rental - Movie Inventory (c) 2023, Movies-R-US";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private MovieDbDataSet movieDbDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private MovieDbDataSetTableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private MovieDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchTerm;
        private System.Windows.Forms.Label labelSearchTerm;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homepageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popularityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taglineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstMovies;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}

