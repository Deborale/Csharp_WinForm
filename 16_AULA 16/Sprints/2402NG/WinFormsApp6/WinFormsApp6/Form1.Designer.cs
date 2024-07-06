namespace WinFormsApp6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resultado = new Label();
            btn_IMC = new Button();
            btn_resetar = new Button();
            btn_fechar = new Button();
            textBoxDados = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultado.Location = new Point(53, 155);
            resultado.Name = "resultado";
            resultado.Size = new Size(91, 19);
            resultado.TabIndex = 2;
            resultado.Text = "Resultado:";
            // 
            // btn_IMC
            // 
            btn_IMC.Location = new Point(138, 254);
            btn_IMC.Name = "btn_IMC";
            btn_IMC.Size = new Size(80, 51);
            btn_IMC.TabIndex = 3;
            btn_IMC.Text = "Calcular IMC";
            btn_IMC.UseVisualStyleBackColor = true;
            btn_IMC.Click += btn_IMC_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(231, 254);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(80, 51);
            btn_resetar.TabIndex = 4;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.Firebrick;
            btn_fechar.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fechar.Location = new Point(387, 12);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.RightToLeft = RightToLeft.Yes;
            btn_fechar.Size = new Size(46, 32);
            btn_fechar.TabIndex = 5;
            btn_fechar.Text = "X";
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // textBoxDados
            // 
            textBoxDados.Location = new Point(138, 115);
            textBoxDados.Name = "textBoxDados";
            textBoxDados.Size = new Size(173, 23);
            textBoxDados.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Heiti Std R", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 80);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 9;
            label2.Text = "Insira o Peso e Altura ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(445, 397);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBoxDados);
            Controls.Add(btn_fechar);
            Controls.Add(btn_resetar);
            Controls.Add(btn_IMC);
            Controls.Add(resultado);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultado;
        private Button btn_IMC;
        private Button btn_resetar;
        private Button btn_fechar;
        private TextBox textBoxDados;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
