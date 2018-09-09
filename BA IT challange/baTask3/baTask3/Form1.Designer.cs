namespace baTask3
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
            this.MinMaxTable = new System.Windows.Forms.DataGridView();
            this.SplitterListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MIN_CHILD_COUNT_LABEL = new System.Windows.Forms.Label();
            this.MAX_CHILD_COUNT_LABEL = new System.Windows.Forms.Label();
            this.LanguageDataGrid = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseFilePath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinMaxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MinMaxTable
            // 
            this.MinMaxTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MinMaxTable.Location = new System.Drawing.Point(12, 12);
            this.MinMaxTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinMaxTable.Name = "MinMaxTable";
            this.MinMaxTable.RowTemplate.Height = 24;
            this.MinMaxTable.Size = new System.Drawing.Size(829, 254);
            this.MinMaxTable.TabIndex = 0;
            this.MinMaxTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SplitterListBox
            // 
            this.SplitterListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitterListBox.FormattingEnabled = true;
            this.SplitterListBox.ItemHeight = 25;
            this.SplitterListBox.Location = new System.Drawing.Point(15, 361);
            this.SplitterListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitterListBox.Name = "SplitterListBox";
            this.SplitterListBox.Size = new System.Drawing.Size(328, 204);
            this.SplitterListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mažiausia reikšmė:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Didžiausia reikšmė:";
            // 
            // MIN_CHILD_COUNT_LABEL
            // 
            this.MIN_CHILD_COUNT_LABEL.AutoSize = true;
            this.MIN_CHILD_COUNT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN_CHILD_COUNT_LABEL.Location = new System.Drawing.Point(576, 271);
            this.MIN_CHILD_COUNT_LABEL.Name = "MIN_CHILD_COUNT_LABEL";
            this.MIN_CHILD_COUNT_LABEL.Size = new System.Drawing.Size(0, 25);
            this.MIN_CHILD_COUNT_LABEL.TabIndex = 4;
            // 
            // MAX_CHILD_COUNT_LABEL
            // 
            this.MAX_CHILD_COUNT_LABEL.AutoSize = true;
            this.MAX_CHILD_COUNT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAX_CHILD_COUNT_LABEL.Location = new System.Drawing.Point(576, 314);
            this.MAX_CHILD_COUNT_LABEL.Name = "MAX_CHILD_COUNT_LABEL";
            this.MAX_CHILD_COUNT_LABEL.Size = new System.Drawing.Size(0, 25);
            this.MAX_CHILD_COUNT_LABEL.TabIndex = 5;
            // 
            // LanguageDataGrid
            // 
            this.LanguageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LanguageDataGrid.Location = new System.Drawing.Point(349, 361);
            this.LanguageDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LanguageDataGrid.Name = "LanguageDataGrid";
            this.LanguageDataGrid.RowTemplate.Height = 24;
            this.LanguageDataGrid.Size = new System.Drawing.Size(469, 226);
            this.LanguageDataGrid.TabIndex = 6;
            // 
            // BrowseFilePath
            // 
            this.BrowseFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFilePath.Location = new System.Drawing.Point(1070, 474);
            this.BrowseFilePath.Name = "BrowseFilePath";
            this.BrowseFilePath.Size = new System.Drawing.Size(75, 27);
            this.BrowseFilePath.TabIndex = 7;
            this.BrowseFilePath.Text = "Browse";
            this.BrowseFilePath.UseVisualStyleBackColor = true;
            this.BrowseFilePath.Click += new System.EventHandler(this.BrowseFilePath_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(863, 474);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 601);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseFilePath);
            this.Controls.Add(this.LanguageDataGrid);
            this.Controls.Add(this.MAX_CHILD_COUNT_LABEL);
            this.Controls.Add(this.MIN_CHILD_COUNT_LABEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SplitterListBox);
            this.Controls.Add(this.MinMaxTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinMaxTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MinMaxTable;
        private System.Windows.Forms.ListBox SplitterListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MIN_CHILD_COUNT_LABEL;
        private System.Windows.Forms.Label MAX_CHILD_COUNT_LABEL;
        private System.Windows.Forms.DataGridView LanguageDataGrid;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BrowseFilePath;
        private System.Windows.Forms.TextBox textBox1;
    }
}

