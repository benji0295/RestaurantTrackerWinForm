namespace RestaurantTrackerWinForm
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuisine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaveEaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 100;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantName,
            this.Cuisine,
            this.Location,
            this.HaveEaten,
            this.Rating});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1617, 1019);
            this.dataGridView1.TabIndex = 0;
            // 
            // RestaurantName
            // 
            this.RestaurantName.HeaderText = "Restaurant Name";
            this.RestaurantName.MinimumWidth = 10;
            this.RestaurantName.Name = "RestaurantName";
            this.RestaurantName.ReadOnly = true;
            this.RestaurantName.Width = 500;
            // 
            // Cuisine
            // 
            this.Cuisine.HeaderText = "Cuisine";
            this.Cuisine.MinimumWidth = 10;
            this.Cuisine.Name = "Cuisine";
            this.Cuisine.ReadOnly = true;
            this.Cuisine.Width = 200;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 10;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 200;
            // 
            // HaveEaten
            // 
            this.HaveEaten.HeaderText = "Been There";
            this.HaveEaten.MinimumWidth = 10;
            this.HaveEaten.Name = "HaveEaten";
            this.HaveEaten.ReadOnly = true;
            this.HaveEaten.Width = 200;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 10;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 1266);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuisine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaveEaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}

