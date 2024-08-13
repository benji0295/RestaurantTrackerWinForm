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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuisineComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.beenThereCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(714, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1453, 927);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Restaurant";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(277, 147);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(353, 31);
            this.nameTextBox.TabIndex = 2;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(277, 367);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(353, 31);
            this.cityTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name of Restaurant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(148, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuisine";
            // 
            // cuisineComboBox
            // 
            this.cuisineComboBox.FormattingEnabled = true;
            this.cuisineComboBox.Items.AddRange(new object[] {
            "American",
            "Breakfast",
            "Chinese",
            "Dessert",
            "Fine Dining",
            "Indian",
            "Italian",
            "Japanese",
            "Mediterranean",
            "Mexican",
            "Pizza",
            "Seafood",
            "Thai",
            "Other"});
            this.cuisineComboBox.Location = new System.Drawing.Point(277, 255);
            this.cuisineComboBox.Name = "cuisineComboBox";
            this.cuisineComboBox.Size = new System.Drawing.Size(334, 33);
            this.cuisineComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(200, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // stateComboBox
            // 
            this.stateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateComboBox.DropDownHeight = 100;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.IntegralHeight = false;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(277, 487);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(334, 33);
            this.stateComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(180, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(162, 710);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(89, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Been There";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(246, 824);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 77);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1208, 976);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(132, 77);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1609, 976);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 77);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ratingNumericUpDown);
            this.panel1.Controls.Add(this.beenThereCheckBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.stateComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cuisineComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 927);
            this.panel1.TabIndex = 20;
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Location = new System.Drawing.Point(277, 710);
            this.ratingNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(135, 31);
            this.ratingNumericUpDown.TabIndex = 20;
            // 
            // beenThereCheckBox
            // 
            this.beenThereCheckBox.AutoSize = true;
            this.beenThereCheckBox.Location = new System.Drawing.Point(277, 609);
            this.beenThereCheckBox.Name = "beenThereCheckBox";
            this.beenThereCheckBox.Size = new System.Drawing.Size(28, 27);
            this.beenThereCheckBox.TabIndex = 19;
            this.beenThereCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "Restaurant Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(0, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2179, 1092);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Restaurant Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cuisineComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox beenThereCheckBox;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}

