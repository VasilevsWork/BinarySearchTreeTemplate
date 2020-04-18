namespace BinaryTree
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tb_Add = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_Show = new System.Windows.Forms.TextBox();
            this.lb_Output = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(12, 70);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Удалить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // tb_Add
            // 
            this.tb_Add.Location = new System.Drawing.Point(105, 14);
            this.tb_Add.Name = "tb_Add";
            this.tb_Add.Size = new System.Drawing.Size(100, 20);
            this.tb_Add.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // tb_Show
            // 
            this.tb_Show.Location = new System.Drawing.Point(105, 124);
            this.tb_Show.Name = "tb_Show";
            this.tb_Show.Size = new System.Drawing.Size(406, 20);
            this.tb_Show.TabIndex = 4;
            // 
            // lb_Output
            // 
            this.lb_Output.AutoSize = true;
            this.lb_Output.Location = new System.Drawing.Point(12, 127);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(40, 13);
            this.lb_Output.TabIndex = 5;
            this.lb_Output.Text = "Вывод";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(12, 41);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "Поиск";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 166);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.tb_Show);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_Add);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Бинарное дерево поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox tb_Add;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_Show;
        private System.Windows.Forms.Label lb_Output;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox textBox1;
    }
}

