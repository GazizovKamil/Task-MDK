﻿namespace Task1_MDK
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name1 = new System.Windows.Forms.TextBox();
            this.tb_Name2 = new System.Windows.Forms.TextBox();
            this.tb_Name3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Value1 = new System.Windows.Forms.TextBox();
            this.tb_Value2 = new System.Windows.Forms.TextBox();
            this.tb_Value3 = new System.Windows.Forms.TextBox();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.btn_MaxName = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кто";
            // 
            // tb_Name1
            // 
            this.tb_Name1.Location = new System.Drawing.Point(122, 44);
            this.tb_Name1.Name = "tb_Name1";
            this.tb_Name1.Size = new System.Drawing.Size(137, 22);
            this.tb_Name1.TabIndex = 1;
            this.tb_Name1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name1_KeyPress);
            // 
            // tb_Name2
            // 
            this.tb_Name2.Location = new System.Drawing.Point(334, 44);
            this.tb_Name2.Name = "tb_Name2";
            this.tb_Name2.Size = new System.Drawing.Size(137, 22);
            this.tb_Name2.TabIndex = 2;
            this.tb_Name2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name2_KeyPress);
            // 
            // tb_Name3
            // 
            this.tb_Name3.Location = new System.Drawing.Point(548, 44);
            this.tb_Name3.Name = "tb_Name3";
            this.tb_Name3.Size = new System.Drawing.Size(137, 22);
            this.tb_Name3.TabIndex = 3;
            this.tb_Name3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сколько";
            // 
            // tb_Value1
            // 
            this.tb_Value1.Location = new System.Drawing.Point(122, 116);
            this.tb_Value1.Name = "tb_Value1";
            this.tb_Value1.Size = new System.Drawing.Size(137, 22);
            this.tb_Value1.TabIndex = 5;
            this.tb_Value1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Value1_KeyPress);
            // 
            // tb_Value2
            // 
            this.tb_Value2.Location = new System.Drawing.Point(334, 116);
            this.tb_Value2.Name = "tb_Value2";
            this.tb_Value2.Size = new System.Drawing.Size(137, 22);
            this.tb_Value2.TabIndex = 6;
            this.tb_Value2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Value2_KeyPress);
            // 
            // tb_Value3
            // 
            this.tb_Value3.Location = new System.Drawing.Point(548, 116);
            this.tb_Value3.Name = "tb_Value3";
            this.tb_Value3.Size = new System.Drawing.Size(137, 22);
            this.tb_Value3.TabIndex = 7;
            this.tb_Value3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Value3_KeyPress);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(163, 165);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(96, 23);
            this.btn_Sum.TabIndex = 8;
            this.btn_Sum.Text = "Сумма";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(163, 194);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(96, 23);
            this.btn_Max.TabIndex = 9;
            this.btn_Max.Text = "Максимум";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(309, 155);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.ReadOnly = true;
            this.tb_Message.Size = new System.Drawing.Size(376, 206);
            this.tb_Message.TabIndex = 10;
            // 
            // btn_MaxName
            // 
            this.btn_MaxName.Location = new System.Drawing.Point(163, 223);
            this.btn_MaxName.Name = "btn_MaxName";
            this.btn_MaxName.Size = new System.Drawing.Size(96, 53);
            this.btn_MaxName.TabIndex = 11;
            this.btn_MaxName.Text = "Кто больше собрал";
            this.btn_MaxName.UseVisualStyleBackColor = true;
            this.btn_MaxName.Click += new System.EventHandler(this.btn_MaxName_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(265, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(293, 39);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Я полюбил грибы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_MaxName);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.tb_Value3);
            this.Controls.Add(this.tb_Value2);
            this.Controls.Add(this.tb_Value1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name3);
            this.Controls.Add(this.tb_Name2);
            this.Controls.Add(this.tb_Name1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name1;
        private System.Windows.Forms.TextBox tb_Name2;
        private System.Windows.Forms.TextBox tb_Name3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Value1;
        private System.Windows.Forms.TextBox tb_Value2;
        private System.Windows.Forms.TextBox tb_Value3;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Button btn_MaxName;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

