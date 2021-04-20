
namespace Practice
{
    partial class Form1
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
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.btnCrossItOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 16;
            this.lbTasks.Location = new System.Drawing.Point(43, 45);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(207, 324);
            this.lbTasks.TabIndex = 0;
            // 
            // btnCrossItOut
            // 
            this.btnCrossItOut.Location = new System.Drawing.Point(270, 45);
            this.btnCrossItOut.Name = "btnCrossItOut";
            this.btnCrossItOut.Size = new System.Drawing.Size(111, 73);
            this.btnCrossItOut.TabIndex = 1;
            this.btnCrossItOut.Text = "Cross It Out";
            this.btnCrossItOut.UseVisualStyleBackColor = true;
            this.btnCrossItOut.Click += new System.EventHandler(this.BtnCrossItOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 410);
            this.Controls.Add(this.btnCrossItOut);
            this.Controls.Add(this.lbTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Button btnCrossItOut;
    }
}

