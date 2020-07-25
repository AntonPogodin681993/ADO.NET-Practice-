namespace CourseManager
{
    partial class OfficeAssignmentt
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
            this.officeGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officeGridView
            // 
            this.officeGridView.AllowUserToAddRows = false;
            this.officeGridView.AllowUserToDeleteRows = false;
            this.officeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeGridView.Location = new System.Drawing.Point(62, 12);
            this.officeGridView.Name = "officeGridView";
            this.officeGridView.RowHeadersWidth = 51;
            this.officeGridView.RowTemplate.Height = 24;
            this.officeGridView.Size = new System.Drawing.Size(278, 201);
            this.officeGridView.TabIndex = 0;
            this.officeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.officeGridView_CellContentClick);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(165, 284);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(132, 54);
            this.saveChanges.TabIndex = 1;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // OfficeAssignmentt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.officeGridView);
            this.Name = "OfficeAssignmentt";
            this.Text = "OfficeAssignment";
            this.Load += new System.EventHandler(this.OfficeAssignmentt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView officeGridView;
        private System.Windows.Forms.Button saveChanges;
    }
}