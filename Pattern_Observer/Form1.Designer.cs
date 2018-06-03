namespace Pattern_Observer
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
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Up.Location = new System.Drawing.Point(369, 372);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 0;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Down.Location = new System.Drawing.Point(369, 415);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 23);
            this.Down.TabIndex = 1;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Left.Location = new System.Drawing.Point(288, 392);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(75, 23);
            this.Left.TabIndex = 2;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Right.Location = new System.Drawing.Point(450, 392);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 23);
            this.Right.TabIndex = 3;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
    }
}

