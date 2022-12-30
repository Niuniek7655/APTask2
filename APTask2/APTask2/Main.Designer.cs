namespace APTask2
{
    partial class Main
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
            this.labelInventLocation = new System.Windows.Forms.Label();
            this.dataGridViewInventLocation = new System.Windows.Forms.DataGridView();
            this.labelInventDim = new System.Windows.Forms.Label();
            this.dataGridViewInventDim = new System.Windows.Forms.DataGridView();
            this.labelNumberOfInventDimForInventLocationId = new System.Windows.Forms.Label();
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId = new System.Windows.Forms.Label();
            this.buttonAddOrUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventDim)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventLocation
            // 
            this.labelInventLocation.AutoSize = true;
            this.labelInventLocation.Location = new System.Drawing.Point(12, 9);
            this.labelInventLocation.Name = "labelInventLocation";
            this.labelInventLocation.Size = new System.Drawing.Size(78, 13);
            this.labelInventLocation.TabIndex = 0;
            this.labelInventLocation.Text = "InventLocation";
            // 
            // dataGridViewInventLocation
            // 
            this.dataGridViewInventLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventLocation.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewInventLocation.Name = "dataGridViewInventLocation";
            this.dataGridViewInventLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventLocation.Size = new System.Drawing.Size(2330, 200);
            this.dataGridViewInventLocation.TabIndex = 1;
            this.dataGridViewInventLocation.SelectionChanged += new System.EventHandler(this.dataGridViewInventLocation_SelectionChanged);
            // 
            // labelInventDim
            // 
            this.labelInventDim.AutoSize = true;
            this.labelInventDim.Location = new System.Drawing.Point(9, 244);
            this.labelInventDim.Name = "labelInventDim";
            this.labelInventDim.Size = new System.Drawing.Size(55, 13);
            this.labelInventDim.TabIndex = 2;
            this.labelInventDim.Text = "InventDim";
            // 
            // dataGridViewInventDim
            // 
            this.dataGridViewInventDim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventDim.Location = new System.Drawing.Point(12, 260);
            this.dataGridViewInventDim.Name = "dataGridViewInventDim";
            this.dataGridViewInventDim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventDim.Size = new System.Drawing.Size(2330, 436);
            this.dataGridViewInventDim.TabIndex = 3;
            // 
            // labelNumberOfInventDimForInventLocationId
            // 
            this.labelNumberOfInventDimForInventLocationId.AutoSize = true;
            this.labelNumberOfInventDimForInventLocationId.Location = new System.Drawing.Point(191, 244);
            this.labelNumberOfInventDimForInventLocationId.Name = "labelNumberOfInventDimForInventLocationId";
            this.labelNumberOfInventDimForInventLocationId.Size = new System.Drawing.Size(211, 13);
            this.labelNumberOfInventDimForInventLocationId.TabIndex = 4;
            this.labelNumberOfInventDimForInventLocationId.Text = "Number of InventDim for InventLocationId :";
            this.labelNumberOfInventDimForInventLocationId.Visible = false;
            // 
            // labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId
            // 
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.AutoSize = true;
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Location = new System.Drawing.Point(568, 244);
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Name = "labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId";
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Size = new System.Drawing.Size(337, 13);
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.TabIndex = 5;
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Text = "Number of unique WMSLocationId in InventDim for InventLocationId: ";
            this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId.Visible = false;
            // 
            // buttonAddOrUpdate
            // 
            this.buttonAddOrUpdate.Location = new System.Drawing.Point(96, 12);
            this.buttonAddOrUpdate.Name = "buttonAddOrUpdate";
            this.buttonAddOrUpdate.Size = new System.Drawing.Size(153, 23);
            this.buttonAddOrUpdate.TabIndex = 6;
            this.buttonAddOrUpdate.Text = "Add or Update";
            this.buttonAddOrUpdate.UseVisualStyleBackColor = true;
            this.buttonAddOrUpdate.Click += new System.EventHandler(this.buttonAddOrUpdate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2338, 698);
            this.Controls.Add(this.buttonAddOrUpdate);
            this.Controls.Add(this.labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId);
            this.Controls.Add(this.labelNumberOfInventDimForInventLocationId);
            this.Controls.Add(this.dataGridViewInventDim);
            this.Controls.Add(this.labelInventDim);
            this.Controls.Add(this.dataGridViewInventLocation);
            this.Controls.Add(this.labelInventLocation);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventDim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInventLocation;
        private System.Windows.Forms.DataGridView dataGridViewInventLocation;
        private System.Windows.Forms.Label labelInventDim;
        private System.Windows.Forms.DataGridView dataGridViewInventDim;
        private System.Windows.Forms.Label labelNumberOfInventDimForInventLocationId;
        private System.Windows.Forms.Label labelNumberOfUniqueWMSLocationIdInInventDimForInventLocationId;
        private System.Windows.Forms.Button buttonAddOrUpdate;
    }
}

