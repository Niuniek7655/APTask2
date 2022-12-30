namespace APTask2
{
    partial class AddOrUpdateInventLocation
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
            this.labelDirectInventLocationId = new System.Windows.Forms.Label();
            this.textBoxDirectInventLocationId = new System.Windows.Forms.TextBox();
            this.textBoxFromWMSLocationId = new System.Windows.Forms.TextBox();
            this.labelFromWMSLocationId = new System.Windows.Forms.Label();
            this.textBoxToWMSLocationId = new System.Windows.Forms.TextBox();
            this.labelToWMSLocationId = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDirectInventLocationId
            // 
            this.labelDirectInventLocationId.AutoSize = true;
            this.labelDirectInventLocationId.Location = new System.Drawing.Point(12, 9);
            this.labelDirectInventLocationId.Name = "labelDirectInventLocationId";
            this.labelDirectInventLocationId.Size = new System.Drawing.Size(118, 13);
            this.labelDirectInventLocationId.TabIndex = 0;
            this.labelDirectInventLocationId.Text = "Direct InventLocationId";
            // 
            // textBoxDirectInventLocationId
            // 
            this.textBoxDirectInventLocationId.Location = new System.Drawing.Point(136, 6);
            this.textBoxDirectInventLocationId.Name = "textBoxDirectInventLocationId";
            this.textBoxDirectInventLocationId.Size = new System.Drawing.Size(289, 20);
            this.textBoxDirectInventLocationId.TabIndex = 1;
            // 
            // textBoxFromWMSLocationId
            // 
            this.textBoxFromWMSLocationId.Location = new System.Drawing.Point(136, 32);
            this.textBoxFromWMSLocationId.Name = "textBoxFromWMSLocationId";
            this.textBoxFromWMSLocationId.Size = new System.Drawing.Size(289, 20);
            this.textBoxFromWMSLocationId.TabIndex = 3;
            // 
            // labelFromWMSLocationId
            // 
            this.labelFromWMSLocationId.AutoSize = true;
            this.labelFromWMSLocationId.Location = new System.Drawing.Point(12, 35);
            this.labelFromWMSLocationId.Name = "labelFromWMSLocationId";
            this.labelFromWMSLocationId.Size = new System.Drawing.Size(110, 13);
            this.labelFromWMSLocationId.TabIndex = 2;
            this.labelFromWMSLocationId.Text = "From WMSLocationId";
            // 
            // textBoxToWMSLocationId
            // 
            this.textBoxToWMSLocationId.Location = new System.Drawing.Point(136, 58);
            this.textBoxToWMSLocationId.Name = "textBoxToWMSLocationId";
            this.textBoxToWMSLocationId.Size = new System.Drawing.Size(289, 20);
            this.textBoxToWMSLocationId.TabIndex = 5;
            // 
            // labelToWMSLocationId
            // 
            this.labelToWMSLocationId.AutoSize = true;
            this.labelToWMSLocationId.Location = new System.Drawing.Point(12, 61);
            this.labelToWMSLocationId.Name = "labelToWMSLocationId";
            this.labelToWMSLocationId.Size = new System.Drawing.Size(100, 13);
            this.labelToWMSLocationId.TabIndex = 4;
            this.labelToWMSLocationId.Text = "To WMSLocationId";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(350, 84);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AddOrUpdateInventLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 118);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxToWMSLocationId);
            this.Controls.Add(this.labelToWMSLocationId);
            this.Controls.Add(this.textBoxFromWMSLocationId);
            this.Controls.Add(this.labelFromWMSLocationId);
            this.Controls.Add(this.textBoxDirectInventLocationId);
            this.Controls.Add(this.labelDirectInventLocationId);
            this.Name = "AddOrUpdateInventLocation";
            this.Text = "AddOrUpdateInventLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDirectInventLocationId;
        private System.Windows.Forms.TextBox textBoxDirectInventLocationId;
        private System.Windows.Forms.TextBox textBoxFromWMSLocationId;
        private System.Windows.Forms.Label labelFromWMSLocationId;
        private System.Windows.Forms.TextBox textBoxToWMSLocationId;
        private System.Windows.Forms.Label labelToWMSLocationId;
        private System.Windows.Forms.Button buttonOk;
    }
}