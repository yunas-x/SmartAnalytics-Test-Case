
namespace Smart_Analytics_TestCase
{
    partial class Fields
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.isKey = new System.Windows.Forms.CheckBox();
            this.name = new System.Windows.Forms.TextBox();
            this.valtype = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // isKey
            // 
            this.isKey.AutoSize = true;
            this.isKey.Location = new System.Drawing.Point(219, 4);
            this.isKey.Name = "isKey";
            this.isKey.Size = new System.Drawing.Size(54, 21);
            this.isKey.TabIndex = 0;
            this.isKey.Text = "Key";
            this.isKey.UseVisualStyleBackColor = true;
            this.isKey.CheckedChanged += new System.EventHandler(this.isKey_CheckedChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(3, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(130, 22);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // valtype
            // 
            this.valtype.Location = new System.Drawing.Point(139, 3);
            this.valtype.Name = "valtype";
            this.valtype.Size = new System.Drawing.Size(74, 22);
            this.valtype.TabIndex = 2;
            this.valtype.TextChanged += new System.EventHandler(this.valtype_TextChanged);
            // 
            // type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valtype);
            this.Controls.Add(this.name);
            this.Controls.Add(this.isKey);
            this.Name = "type";
            this.Size = new System.Drawing.Size(281, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isKey;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox valtype;
    }
}
