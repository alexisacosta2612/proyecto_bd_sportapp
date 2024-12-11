namespace proyecto__
{
    partial class Form2
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBoxcuenta = new TextBox();
            textBoxcontraseña = new TextBox();
            colorDialog1 = new ColorDialog();
            buttonlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(417, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 114);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "text ";
            // 
            // textBoxcuenta
            // 
            textBoxcuenta.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcuenta.Location = new Point(348, 190);
            textBoxcuenta.Name = "textBoxcuenta";
            textBoxcuenta.PlaceholderText = "Someone@gmail.com";
            textBoxcuenta.Size = new Size(240, 27);
            textBoxcuenta.TabIndex = 4;
            // 
            // textBoxcontraseña
            // 
            textBoxcontraseña.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcontraseña.Location = new Point(348, 232);
            textBoxcontraseña.Name = "textBoxcontraseña";
            textBoxcontraseña.PlaceholderText = "Contraseña";
            textBoxcontraseña.Size = new Size(240, 27);
            textBoxcontraseña.TabIndex = 5;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.IndianRed;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = SystemColors.ActiveCaptionText;
            buttonlogin.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonlogin.Location = new Point(348, 265);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(240, 47);
            buttonlogin.TabIndex = 7;
            buttonlogin.Text = "LOGIN";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 450);
            Controls.Add(buttonlogin);
            Controls.Add(textBoxcontraseña);
            Controls.Add(textBoxcuenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBoxcuenta;
        private TextBox textBoxcontraseña;
        private ColorDialog colorDialog1;
        private Button buttonlogin;
    }
}