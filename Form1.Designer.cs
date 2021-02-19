
namespace ooplab41
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
            this.ShowB = new System.Windows.Forms.Button();
            this.DeleteCB = new System.Windows.Forms.Button();
            this.ClearSB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.PanelD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowB
            // 
            this.ShowB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowB.Location = new System.Drawing.Point(9, 30);
            this.ShowB.Margin = new System.Windows.Forms.Padding(4);
            this.ShowB.Name = "ShowB";
            this.ShowB.Size = new System.Drawing.Size(281, 92);
            this.ShowB.TabIndex = 0;
            this.ShowB.Text = "Отобразить все объекты";
            this.ShowB.UseVisualStyleBackColor = false;
            this.ShowB.Click += new System.EventHandler(this.ShowB_Click);
            // 
            // DeleteCB
            // 
            this.DeleteCB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCB.Location = new System.Drawing.Point(9, 330);
            this.DeleteCB.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCB.Name = "DeleteCB";
            this.DeleteCB.Size = new System.Drawing.Size(281, 92);
            this.DeleteCB.TabIndex = 1;
            this.DeleteCB.Text = "Удалить выделенные элементы";
            this.DeleteCB.UseVisualStyleBackColor = false;
            this.DeleteCB.Click += new System.EventHandler(this.DeleteCB_Click);
            // 
            // ClearSB
            // 
            this.ClearSB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearSB.Location = new System.Drawing.Point(9, 230);
            this.ClearSB.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSB.Name = "ClearSB";
            this.ClearSB.Size = new System.Drawing.Size(281, 92);
            this.ClearSB.TabIndex = 2;
            this.ClearSB.Text = "Очистить хранилище";
            this.ClearSB.UseVisualStyleBackColor = false;
            this.ClearSB.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearB.Location = new System.Drawing.Point(9, 130);
            this.ClearB.Margin = new System.Windows.Forms.Padding(4);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(281, 92);
            this.ClearB.TabIndex = 3;
            this.ClearB.Text = "Скрыть объекты на панели";
            this.ClearB.UseVisualStyleBackColor = false;
            this.ClearB.Click += new System.EventHandler(this.Clear_Click);
            // 
            // PanelD
            // 
            this.PanelD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelD.Location = new System.Drawing.Point(298, 30);
            this.PanelD.Margin = new System.Windows.Forms.Padding(4);
            this.PanelD.Name = "PanelD";
            this.PanelD.Size = new System.Drawing.Size(756, 507);
            this.PanelD.TabIndex = 4;
            this.PanelD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelD_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полотно";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelD);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ClearSB);
            this.Controls.Add(this.DeleteCB);
            this.Controls.Add(this.ShowB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowB;
        private System.Windows.Forms.Button DeleteCB;
        private System.Windows.Forms.Button ClearSB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Panel PanelD;
        private System.Windows.Forms.Label label1;
    }
}

