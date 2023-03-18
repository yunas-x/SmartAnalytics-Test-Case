using System.Collections.Generic;

namespace Smart_Analytics_TestCase
{
    partial class DbEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewTableNames = new System.Windows.Forms.TreeView();
            this.Tables = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.fields2 = new Smart_Analytics_TestCase.Fields();
            this.fields1 = new Smart_Analytics_TestCase.Fields();
            this.fields4 = new Smart_Analytics_TestCase.Fields();
            this.fields6 = new Smart_Analytics_TestCase.Fields();
            this.fields3 = new Smart_Analytics_TestCase.Fields();
            this.fields5 = new Smart_Analytics_TestCase.Fields();
            this.fields8 = new Smart_Analytics_TestCase.Fields();
            this.fields10 = new Smart_Analytics_TestCase.Fields();
            this.fields7 = new Smart_Analytics_TestCase.Fields();
            this.fields9 = new Smart_Analytics_TestCase.Fields();
            this.fields12 = new Smart_Analytics_TestCase.Fields();
            this.fields16 = new Smart_Analytics_TestCase.Fields();
            this.fields11 = new Smart_Analytics_TestCase.Fields();
            this.fields14 = new Smart_Analytics_TestCase.Fields();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.treeViewTableNames);
            this.splitContainer1.Panel1.Controls.Add(this.Tables);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRename);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tableNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fields2);
            this.splitContainer1.Panel2.Controls.Add(this.fields1);
            this.splitContainer1.Panel2.Controls.Add(this.fields4);
            this.splitContainer1.Panel2.Controls.Add(this.fields6);
            this.splitContainer1.Panel2.Controls.Add(this.fields3);
            this.splitContainer1.Panel2.Controls.Add(this.fields5);
            this.splitContainer1.Panel2.Controls.Add(this.fields8);
            this.splitContainer1.Panel2.Controls.Add(this.fields10);
            this.splitContainer1.Panel2.Controls.Add(this.fields7);
            this.splitContainer1.Panel2.Controls.Add(this.fields9);
            this.splitContainer1.Panel2.Controls.Add(this.fields12);
            this.splitContainer1.Panel2.Controls.Add(this.fields16);
            this.splitContainer1.Panel2.Controls.Add(this.fields11);
            this.splitContainer1.Panel2.Controls.Add(this.fields14);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreate);
            this.splitContainer1.Size = new System.Drawing.Size(872, 453);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewTableNames
            // 
            this.treeViewTableNames.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewTableNames.Location = new System.Drawing.Point(12, 68);
            this.treeViewTableNames.Name = "treeViewTableNames";
            this.treeViewTableNames.Size = new System.Drawing.Size(242, 370);
            this.treeViewTableNames.TabIndex = 1;
            this.treeViewTableNames.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTableNames_AfterSelect);
            // 
            // Tables
            // 
            this.Tables.AutoSize = true;
            this.Tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tables.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tables.Location = new System.Drawing.Point(80, 12);
            this.Tables.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(104, 38);
            this.Tables.TabIndex = 0;
            this.Tables.Text = "Tables";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(573, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete column";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(292, 419);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(284, 34);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add column...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRename.Location = new System.Drawing.Point(0, 383);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(284, 30);
            this.buttonRename.TabIndex = 26;
            this.buttonRename.Text = "Rename this table";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(292, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(284, 30);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete this table";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableNameLabel.Location = new System.Drawing.Point(3, 12);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(0, 38);
            this.tableNameLabel.TabIndex = 20;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(0, 419);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(284, 34);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create new table...";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // fields2
            // 
            this.fields2.Location = new System.Drawing.Point(285, 87);
            this.fields2.Name = "fields2";
            this.fields2.Row = null;
            this.fields2.Size = new System.Drawing.Size(274, 28);
            this.fields2.TabIndex = 19;
            // 
            // fields1
            // 
            this.fields1.Location = new System.Drawing.Point(10, 87);
            this.fields1.Name = "fields1";
            this.fields1.Row = null;
            this.fields1.Size = new System.Drawing.Size(274, 28);
            this.fields1.TabIndex = 17;
            // 
            // fields4
            // 
            this.fields4.Location = new System.Drawing.Point(285, 122);
            this.fields4.Name = "fields4";
            this.fields4.Row = null;
            this.fields4.Size = new System.Drawing.Size(274, 28);
            this.fields4.TabIndex = 16;
            // 
            // fields6
            // 
            this.fields6.Location = new System.Drawing.Point(285, 156);
            this.fields6.Name = "fields6";
            this.fields6.Row = null;
            this.fields6.Size = new System.Drawing.Size(274, 28);
            this.fields6.TabIndex = 15;
            // 
            // fields3
            // 
            this.fields3.Location = new System.Drawing.Point(10, 122);
            this.fields3.Name = "fields3";
            this.fields3.Row = null;
            this.fields3.Size = new System.Drawing.Size(274, 28);
            this.fields3.TabIndex = 14;
            // 
            // fields5
            // 
            this.fields5.Location = new System.Drawing.Point(10, 156);
            this.fields5.Name = "fields5";
            this.fields5.Row = null;
            this.fields5.Size = new System.Drawing.Size(274, 28);
            this.fields5.TabIndex = 13;
            // 
            // fields8
            // 
            this.fields8.Location = new System.Drawing.Point(285, 192);
            this.fields8.Name = "fields8";
            this.fields8.Row = null;
            this.fields8.Size = new System.Drawing.Size(274, 28);
            this.fields8.TabIndex = 12;
            // 
            // fields10
            // 
            this.fields10.Location = new System.Drawing.Point(285, 226);
            this.fields10.Name = "fields10";
            this.fields10.Row = null;
            this.fields10.Size = new System.Drawing.Size(274, 28);
            this.fields10.TabIndex = 11;
            // 
            // fields7
            // 
            this.fields7.Location = new System.Drawing.Point(10, 192);
            this.fields7.Name = "fields7";
            this.fields7.Row = null;
            this.fields7.Size = new System.Drawing.Size(274, 28);
            this.fields7.TabIndex = 10;
            // 
            // fields9
            // 
            this.fields9.Location = new System.Drawing.Point(10, 226);
            this.fields9.Name = "fields9";
            this.fields9.Row = null;
            this.fields9.Size = new System.Drawing.Size(274, 28);
            this.fields9.TabIndex = 9;
            // 
            // fields12
            // 
            this.fields12.Location = new System.Drawing.Point(285, 260);
            this.fields12.Name = "fields12";
            this.fields12.Row = null;
            this.fields12.Size = new System.Drawing.Size(274, 28);
            this.fields12.TabIndex = 8;
            // 
            // fields16
            // 
            this.fields16.Location = new System.Drawing.Point(285, 294);
            this.fields16.Name = "fields16";
            this.fields16.Row = null;
            this.fields16.Size = new System.Drawing.Size(274, 28);
            this.fields16.TabIndex = 7;
            // 
            // fields11
            // 
            this.fields11.Location = new System.Drawing.Point(10, 260);
            this.fields11.Name = "fields11";
            this.fields11.Row = null;
            this.fields11.Size = new System.Drawing.Size(274, 28);
            this.fields11.TabIndex = 6;
            // 
            // fields14
            // 
            this.fields14.Location = new System.Drawing.Point(10, 294);
            this.fields14.Name = "fields14";
            this.fields14.Row = null;
            this.fields14.Size = new System.Drawing.Size(274, 28);
            this.fields14.TabIndex = 5;
            // 
            // DbEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(890, 500);
            this.MinimumSize = new System.Drawing.Size(890, 500);
            this.Name = "DbEditor";
            this.Text = "DB Editor";
            this.Load += new System.EventHandler(this.DbEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Tables;
        private System.Windows.Forms.TreeView treeViewTableNames;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tableNameLabel;
        private Fields fields2;
        private Fields fields1;
        private Fields fields4;
        private Fields fields6;
        private Fields fields3;
        private Fields fields5;
        private Fields fields8;
        private Fields fields10;
        private Fields fields7;
        private Fields fields9;
        private Fields fields12;
        private Fields fields16;
        private Fields fields11;
        private Fields fields14;

        private Dictionary<int, Fields> allFields;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
    }
}

