namespace SystemCRUD
{
    partial class MainForm
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
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpDateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(40, 29);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(35, 15);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Code";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(40, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 125);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(102, 21);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(415, 23);
            this.CodeTextBox.TabIndex = 3;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(102, 117);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(415, 23);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(102, 67);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(415, 23);
            this.NameTextBox.TabIndex = 5;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(543, 21);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpDateButton
            // 
            this.UpDateButton.Location = new System.Drawing.Point(543, 67);
            this.UpDateButton.Name = "UpDateButton";
            this.UpDateButton.Size = new System.Drawing.Size(75, 23);
            this.UpDateButton.TabIndex = 7;
            this.UpDateButton.Text = "Update";
            this.UpDateButton.UseVisualStyleBackColor = true;
            this.UpDateButton.Click += new System.EventHandler(this.UpDateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(543, 117);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Location = new System.Drawing.Point(12, 164);
            this.ProductList.Name = "ProductList";
            this.ProductList.RowTemplate.Height = 25;
            this.ProductList.Size = new System.Drawing.Size(606, 150);
            this.ProductList.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 326);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpDateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label CodeLabel;
        private Label NameLabel;
        private Label DescriptionLabel;
        private TextBox CodeTextBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Button CreateButton;
        private Button UpDateButton;
        private Button DeleteButton;
        private DataGridView ProductList;
    }
}