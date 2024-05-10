namespace FEnd
{
    partial class Detector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HistoryGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryGrid
            // 
            this.HistoryGrid.AllowUserToAddRows = false;
            this.HistoryGrid.AllowUserToDeleteRows = false;
            this.HistoryGrid.AllowUserToResizeColumns = false;
            this.HistoryGrid.AllowUserToResizeRows = false;
            this.HistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.HistoryGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryGrid.GridColor = System.Drawing.Color.Coral;
            this.HistoryGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HistoryGrid.Location = new System.Drawing.Point(524, 0);
            this.HistoryGrid.Name = "HistoryGrid";
            this.HistoryGrid.ReadOnly = true;
            this.HistoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.HistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.HistoryGrid.Size = new System.Drawing.Size(304, 532);
            this.HistoryGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Detector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HistoryGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Detector";
            this.Size = new System.Drawing.Size(828, 532);
            this.Load += new System.EventHandler(this.Detector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryGrid;
        private System.Windows.Forms.Button button1;
    }
}
