
namespace SqlViewer
{
    partial class SqlManagerForm
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
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scQuery = new System.Windows.Forms.SplitContainer();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.tcResultMessage = new System.Windows.Forms.TabControl();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.tpMessage = new System.Windows.Forms.TabPage();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbViews = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProceduresParameters = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbProcedures = new System.Windows.Forms.ListBox();
            this.btnStartQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scQuery)).BeginInit();
            this.scQuery.Panel1.SuspendLayout();
            this.scQuery.Panel2.SuspendLayout();
            this.scQuery.SuspendLayout();
            this.tcResultMessage.SuspendLayout();
            this.tpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(96, 13);
            this.CbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(188, 24);
            this.CbDatabases.TabIndex = 3;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Databases:";
            // 
            // scQuery
            // 
            this.scQuery.Location = new System.Drawing.Point(459, 12);
            this.scQuery.Name = "scQuery";
            this.scQuery.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scQuery.Panel1
            // 
            this.scQuery.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.scQuery.Panel1.Controls.Add(this.tbQuery);
            this.scQuery.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // scQuery.Panel2
            // 
            this.scQuery.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.scQuery.Panel2.Controls.Add(this.tcResultMessage);
            this.scQuery.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scQuery.Size = new System.Drawing.Size(875, 574);
            this.scQuery.SplitterDistance = 274;
            this.scQuery.TabIndex = 4;
            this.scQuery.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.scQuery_SplitterMoved);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(3, 2);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbQuery.Size = new System.Drawing.Size(872, 269);
            this.tbQuery.TabIndex = 0;
            this.tbQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuery_KeyDown);
            // 
            // tcResultMessage
            // 
            this.tcResultMessage.Controls.Add(this.tpResult);
            this.tcResultMessage.Controls.Add(this.tpMessage);
            this.tcResultMessage.Location = new System.Drawing.Point(3, 3);
            this.tcResultMessage.Name = "tcResultMessage";
            this.tcResultMessage.SelectedIndex = 0;
            this.tcResultMessage.Size = new System.Drawing.Size(869, 290);
            this.tcResultMessage.TabIndex = 0;
            // 
            // tpResult
            // 
            this.tpResult.Location = new System.Drawing.Point(4, 25);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tpResult.Size = new System.Drawing.Size(861, 261);
            this.tpResult.TabIndex = 0;
            this.tpResult.Text = "Results";
            this.tpResult.UseVisualStyleBackColor = true;
            this.tpResult.SizeChanged += new System.EventHandler(this.tpResult_SizeChanged);
            // 
            // tpMessage
            // 
            this.tpMessage.Controls.Add(this.lblMessages);
            this.tpMessage.Location = new System.Drawing.Point(4, 25);
            this.tpMessage.Name = "tpMessage";
            this.tpMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessage.Size = new System.Drawing.Size(861, 261);
            this.tpMessage.TabIndex = 1;
            this.tpMessage.Text = "Messages";
            this.tpMessage.UseVisualStyleBackColor = true;
            // 
            // lblMessages
            // 
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMessages.Location = new System.Drawing.Point(7, 7);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(848, 251);
            this.lblMessages.TabIndex = 0;
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.ItemHeight = 16;
            this.lbTables.Location = new System.Drawing.Point(96, 82);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(188, 132);
            this.lbTables.TabIndex = 5;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tables:";
            // 
            // lbTableColumns
            // 
            this.lbTableColumns.FormattingEnabled = true;
            this.lbTableColumns.ItemHeight = 16;
            this.lbTableColumns.Location = new System.Drawing.Point(321, 82);
            this.lbTableColumns.Name = "lbTableColumns";
            this.lbTableColumns.Size = new System.Drawing.Size(120, 132);
            this.lbTableColumns.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(317, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columns:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(317, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Columns:";
            // 
            // lbViewColumns
            // 
            this.lbViewColumns.FormattingEnabled = true;
            this.lbViewColumns.ItemHeight = 16;
            this.lbViewColumns.Location = new System.Drawing.Point(321, 254);
            this.lbViewColumns.Name = "lbViewColumns";
            this.lbViewColumns.Size = new System.Drawing.Size(120, 132);
            this.lbViewColumns.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Views:";
            // 
            // lbViews
            // 
            this.lbViews.FormattingEnabled = true;
            this.lbViews.ItemHeight = 16;
            this.lbViews.Location = new System.Drawing.Point(96, 254);
            this.lbViews.Name = "lbViews";
            this.lbViews.Size = new System.Drawing.Size(188, 132);
            this.lbViews.TabIndex = 9;
            this.lbViews.SelectedIndexChanged += new System.EventHandler(this.lbViews_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(317, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Parameteres:";
            // 
            // lbProceduresParameters
            // 
            this.lbProceduresParameters.FormattingEnabled = true;
            this.lbProceduresParameters.ItemHeight = 16;
            this.lbProceduresParameters.Location = new System.Drawing.Point(321, 428);
            this.lbProceduresParameters.Name = "lbProceduresParameters";
            this.lbProceduresParameters.Size = new System.Drawing.Size(120, 132);
            this.lbProceduresParameters.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Procedures:";
            // 
            // lbProcedures
            // 
            this.lbProcedures.FormattingEnabled = true;
            this.lbProcedures.ItemHeight = 16;
            this.lbProcedures.Location = new System.Drawing.Point(96, 428);
            this.lbProcedures.Name = "lbProcedures";
            this.lbProcedures.Size = new System.Drawing.Size(188, 132);
            this.lbProcedures.TabIndex = 13;
            this.lbProcedures.SelectedIndexChanged += new System.EventHandler(this.lbProcedured_SelectedIndexChanged);
            // 
            // btnStartQuery
            // 
            this.btnStartQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartQuery.Location = new System.Drawing.Point(318, 16);
            this.btnStartQuery.Name = "btnStartQuery";
            this.btnStartQuery.Size = new System.Drawing.Size(120, 36);
            this.btnStartQuery.TabIndex = 17;
            this.btnStartQuery.Text = "Start query";
            this.btnStartQuery.UseVisualStyleBackColor = true;
            this.btnStartQuery.Click += new System.EventHandler(this.btnStartQuery_Click);
            // 
            // SqlManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 598);
            this.Controls.Add(this.btnStartQuery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbProceduresParameters);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbProcedures);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTableColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.scQuery);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1364, 645);
            this.MinimumSize = new System.Drawing.Size(1364, 645);
            this.Name = "SqlManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markic SQL Server Management Studio 21";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SqlManagerForm_FormClosed);
            this.scQuery.Panel1.ResumeLayout(false);
            this.scQuery.Panel1.PerformLayout();
            this.scQuery.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scQuery)).EndInit();
            this.scQuery.ResumeLayout(false);
            this.tcResultMessage.ResumeLayout(false);
            this.tpMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer scQuery;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.TabControl tcResultMessage;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.TabPage tpMessage;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbViews;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbProceduresParameters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbProcedures;
        private System.Windows.Forms.Button btnStartQuery;
        private System.Windows.Forms.Label lblMessages;
    }
}