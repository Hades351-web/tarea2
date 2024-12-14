namespace Pantalladecarga
{
    partial class FormCarga
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEjer1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnEjer1
            // 
            btnEjer1.Location = new Point(85, 88);
            btnEjer1.Name = "btnEjer1";
            btnEjer1.Size = new Size(106, 35);
            btnEjer1.TabIndex = 0;
            btnEjer1.Text = "button1";
            btnEjer1.UseVisualStyleBackColor = true;
            btnEjer1.Click += btnEjer1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 88);
            button2.Name = "button2";
            button2.Size = new Size(106, 35);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(429, 88);
            button3.Name = "button3";
            button3.Size = new Size(106, 35);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(627, 369);
            button4.Name = "button4";
            button4.Size = new Size(106, 35);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnEjer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEjer1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
