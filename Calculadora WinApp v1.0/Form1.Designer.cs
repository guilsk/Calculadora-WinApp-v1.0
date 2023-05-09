namespace Calculadora_WinApp_v1._0
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
            lb_titulo = new Label();
            tf_conta = new TextBox();
            bt_7 = new Button();
            bt_8 = new Button();
            bt_9 = new Button();
            bt_dividir = new Button();
            bt_multiplicar = new Button();
            bt_6 = new Button();
            bt_5 = new Button();
            bt_4 = new Button();
            bt_subtrair = new Button();
            bt_3 = new Button();
            bt_2 = new Button();
            bt_1 = new Button();
            bt_somar = new Button();
            bt_0 = new Button();
            bt_igual = new Button();
            bt_clear = new Button();
            tf_resultado = new TextBox();
            SuspendLayout();
            // 
            // lb_titulo
            // 
            lb_titulo.AutoSize = true;
            lb_titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_titulo.Location = new Point(12, 9);
            lb_titulo.Name = "lb_titulo";
            lb_titulo.Size = new Size(341, 37);
            lb_titulo.TabIndex = 0;
            lb_titulo.Text = "Calculadora WinApp v1.0";
            lb_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tf_conta
            // 
            tf_conta.BackColor = SystemColors.Window;
            tf_conta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tf_conta.Location = new Point(12, 58);
            tf_conta.Name = "tf_conta";
            tf_conta.ReadOnly = true;
            tf_conta.Size = new Size(339, 33);
            tf_conta.TabIndex = 1;
            // 
            // bt_7
            // 
            bt_7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_7.Location = new Point(12, 136);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(75, 50);
            bt_7.TabIndex = 2;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = true;
            bt_7.Click += bt_7_Click;
            // 
            // bt_8
            // 
            bt_8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_8.Location = new Point(93, 136);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(75, 50);
            bt_8.TabIndex = 3;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = true;
            bt_8.Click += bt_8_Click;
            // 
            // bt_9
            // 
            bt_9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_9.Location = new Point(174, 136);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(75, 50);
            bt_9.TabIndex = 4;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = true;
            bt_9.Click += bt_9_Click;
            // 
            // bt_dividir
            // 
            bt_dividir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_dividir.Location = new Point(276, 136);
            bt_dividir.Name = "bt_dividir";
            bt_dividir.Size = new Size(75, 50);
            bt_dividir.TabIndex = 5;
            bt_dividir.Text = "/";
            bt_dividir.UseVisualStyleBackColor = true;
            bt_dividir.Click += bt_dividir_Click;
            // 
            // bt_multiplicar
            // 
            bt_multiplicar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_multiplicar.Location = new Point(276, 192);
            bt_multiplicar.Name = "bt_multiplicar";
            bt_multiplicar.Size = new Size(75, 50);
            bt_multiplicar.TabIndex = 9;
            bt_multiplicar.Text = "x";
            bt_multiplicar.UseVisualStyleBackColor = true;
            bt_multiplicar.Click += bt_multiplicar_Click;
            // 
            // bt_6
            // 
            bt_6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_6.Location = new Point(174, 192);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(75, 50);
            bt_6.TabIndex = 8;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = true;
            bt_6.Click += bt_6_Click;
            // 
            // bt_5
            // 
            bt_5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_5.Location = new Point(93, 192);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(75, 50);
            bt_5.TabIndex = 7;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = true;
            bt_5.Click += bt_5_Click;
            // 
            // bt_4
            // 
            bt_4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_4.Location = new Point(12, 192);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(75, 50);
            bt_4.TabIndex = 6;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = true;
            bt_4.Click += bt_4_Click;
            // 
            // bt_subtrair
            // 
            bt_subtrair.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_subtrair.Location = new Point(276, 248);
            bt_subtrair.Name = "bt_subtrair";
            bt_subtrair.Size = new Size(75, 50);
            bt_subtrair.TabIndex = 13;
            bt_subtrair.Text = "-";
            bt_subtrair.UseVisualStyleBackColor = true;
            bt_subtrair.Click += bt_subtrair_Click;
            // 
            // bt_3
            // 
            bt_3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_3.Location = new Point(174, 248);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(75, 50);
            bt_3.TabIndex = 12;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = true;
            bt_3.Click += bt_3_Click;
            // 
            // bt_2
            // 
            bt_2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_2.Location = new Point(93, 248);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(75, 50);
            bt_2.TabIndex = 11;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = true;
            bt_2.Click += bt_2_Click;
            // 
            // bt_1
            // 
            bt_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_1.Location = new Point(12, 248);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(75, 50);
            bt_1.TabIndex = 10;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = true;
            bt_1.Click += bt_1_Click;
            // 
            // bt_somar
            // 
            bt_somar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_somar.Location = new Point(276, 304);
            bt_somar.Name = "bt_somar";
            bt_somar.Size = new Size(75, 50);
            bt_somar.TabIndex = 17;
            bt_somar.Text = "+";
            bt_somar.UseVisualStyleBackColor = true;
            bt_somar.Click += bt_somar_Click;
            // 
            // bt_0
            // 
            bt_0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_0.Location = new Point(12, 304);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(156, 50);
            bt_0.TabIndex = 21;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = true;
            bt_0.Click += bt_0_Click;
            // 
            // bt_igual
            // 
            bt_igual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_igual.Location = new Point(12, 360);
            bt_igual.Name = "bt_igual";
            bt_igual.Size = new Size(339, 50);
            bt_igual.TabIndex = 20;
            bt_igual.Text = "=";
            bt_igual.UseVisualStyleBackColor = true;
            bt_igual.Click += bt_igual_Click;
            // 
            // bt_clear
            // 
            bt_clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt_clear.Location = new Point(174, 304);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(75, 50);
            bt_clear.TabIndex = 22;
            bt_clear.Text = "C";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // tf_resultado
            // 
            tf_resultado.BackColor = SystemColors.Window;
            tf_resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tf_resultado.Location = new Point(12, 97);
            tf_resultado.Name = "tf_resultado";
            tf_resultado.ReadOnly = true;
            tf_resultado.Size = new Size(339, 33);
            tf_resultado.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 425);
            Controls.Add(tf_resultado);
            Controls.Add(bt_clear);
            Controls.Add(bt_0);
            Controls.Add(bt_igual);
            Controls.Add(bt_somar);
            Controls.Add(bt_subtrair);
            Controls.Add(bt_3);
            Controls.Add(bt_2);
            Controls.Add(bt_1);
            Controls.Add(bt_multiplicar);
            Controls.Add(bt_6);
            Controls.Add(bt_5);
            Controls.Add(bt_4);
            Controls.Add(bt_dividir);
            Controls.Add(bt_9);
            Controls.Add(bt_8);
            Controls.Add(bt_7);
            Controls.Add(tf_conta);
            Controls.Add(lb_titulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_titulo;
        private TextBox tf_conta;
        private Button bt_7;
        private Button bt_8;
        private Button bt_9;
        private Button bt_dividir;
        private Button bt_multiplicar;
        private Button bt_6;
        private Button bt_5;
        private Button bt_4;
        private Button bt_subtrair;
        private Button bt_3;
        private Button bt_2;
        private Button bt_1;
        private Button bt_somar;
        private Button bt_0;
        private Button bt_igual;
        private Button bt_clear;
        private TextBox tf_resultado;
    }
}