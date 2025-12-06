namespace POS_Project
{
    partial class LogIn
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(49, 425);
            button1.Name = "button1";
            button1.Size = new Size(525, 51);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.DarkGray;
            linkLabel1.Location = new Point(50, 375);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(50, 313);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(524, 27);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(50, 227);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 27);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 37.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 98);
            label1.Name = "label1";
            label1.Size = new Size(203, 85);
            label1.TabIndex = 9;
            label1.Text = "Login";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Semibold", 9.9F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.Location = new Point(339, 499);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(102, 23);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign In here";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.9F, FontStyle.Bold);
            label5.Location = new Point(156, 499);
            label5.Name = "label5";
            label5.Size = new Size(190, 23);
            label5.TabIndex = 17;
            label5.Text = "Don't have an account?";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 762);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Label label5;
    }
}