namespace MovieRentalApp
{
    partial class MovieListing
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
            this.dataGridViewMovieListing = new System.Windows.Forms.DataGridView();
            this.pictureBoxMovieListing = new System.Windows.Forms.PictureBox();
            this.buttonCloseMovieListing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovieListing)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovieListing
            // 
            this.dataGridViewMovieListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieListing.Location = new System.Drawing.Point(34, 265);
            this.dataGridViewMovieListing.Name = "dataGridViewMovieListing";
            this.dataGridViewMovieListing.RowHeadersWidth = 62;
            this.dataGridViewMovieListing.RowTemplate.Height = 28;
            this.dataGridViewMovieListing.Size = new System.Drawing.Size(688, 150);
            this.dataGridViewMovieListing.TabIndex = 0;
            // 
            // pictureBoxMovieListing
            // 
            this.pictureBoxMovieListing.Image = global::MovieRentalApp.Properties.Resources.movie;
            this.pictureBoxMovieListing.Location = new System.Drawing.Point(34, 12);
            this.pictureBoxMovieListing.Name = "pictureBoxMovieListing";
            this.pictureBoxMovieListing.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxMovieListing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMovieListing.TabIndex = 20;
            this.pictureBoxMovieListing.TabStop = false;
            // 
            // buttonCloseMovieListing
            // 
            this.buttonCloseMovieListing.Location = new System.Drawing.Point(680, 442);
            this.buttonCloseMovieListing.Name = "buttonCloseMovieListing";
            this.buttonCloseMovieListing.Size = new System.Drawing.Size(75, 29);
            this.buttonCloseMovieListing.TabIndex = 21;
            this.buttonCloseMovieListing.Text = "Close";
            this.buttonCloseMovieListing.UseVisualStyleBackColor = true;
            // 
            // MovieListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.buttonCloseMovieListing);
            this.Controls.Add(this.pictureBoxMovieListing);
            this.Controls.Add(this.dataGridViewMovieListing);
            this.Name = "MovieListing";
            this.Text = "Movie Listing (c) 2023, Movies-R-Us";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovieListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovieListing;
        private System.Windows.Forms.PictureBox pictureBoxMovieListing;
        private System.Windows.Forms.Button buttonCloseMovieListing;
    }
}