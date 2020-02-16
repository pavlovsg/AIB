namespace ValidataProfiler
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PointsList = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.PointsDataGrid = new System.Windows.Forms.DataGridView();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PointsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1397, 549);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // PointsList
            // 
            this.PointsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsList.FormattingEnabled = true;
            this.PointsList.Location = new System.Drawing.Point(0, 0);
            this.PointsList.Name = "PointsList";
            this.PointsList.Size = new System.Drawing.Size(220, 549);
            this.PointsList.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PointsDataGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ResultText);
            this.splitContainer2.Size = new System.Drawing.Size(1173, 549);
            this.splitContainer2.SplitterDistance = 679;
            this.splitContainer2.TabIndex = 0;
            // 
            // ResultText
            // 
            this.ResultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultText.Location = new System.Drawing.Point(0, 0);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(490, 549);
            this.ResultText.TabIndex = 1;
            // 
            // PointsDataGrid
            // 
            this.PointsDataGrid.AllowUserToAddRows = false;
            this.PointsDataGrid.AllowUserToDeleteRows = false;
            this.PointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Point,
            this.PostIndex,
            this.KeyFile});
            this.PointsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.PointsDataGrid.Name = "PointsDataGrid";
            this.PointsDataGrid.Size = new System.Drawing.Size(679, 549);
            this.PointsDataGrid.TabIndex = 0;
            // 
            // Point
            // 
            this.Point.HeaderText = "Пункт";
            this.Point.Name = "Point";
            // 
            // PostIndex
            // 
            this.PostIndex.HeaderText = "Индекс";
            this.PostIndex.Name = "PostIndex";
            // 
            // KeyFile
            // 
            this.KeyFile.HeaderText = "Файл ключа";
            this.KeyFile.Name = "KeyFile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox PointsList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView PointsDataGrid;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyFile;
    }
}

