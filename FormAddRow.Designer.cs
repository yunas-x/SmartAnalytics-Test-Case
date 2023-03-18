
namespace Smart_Analytics_TestCase
{
    partial class FormAddRow
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
            this.fields1 = new Smart_Analytics_TestCase.Fields();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fields1
            // 
            this.fields1.Location = new System.Drawing.Point(12, 36);
            this.fields1.Name = "fields1";
            this.fields1.Row = null;
            this.fields1.Size = new System.Drawing.Size(281, 28);
            this.fields1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 83);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(267, 47);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAddRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 153);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.fields1);
            this.MaximumSize = new System.Drawing.Size(320, 200);
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "FormAddRow";
            this.Text = "FormAddRow";
            this.ResumeLayout(false);

        }

        #endregion

        private Fields fields1;
        private System.Windows.Forms.Button buttonOk;
    }
}