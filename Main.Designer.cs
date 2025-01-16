namespace TestesDeMatematica
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.NumericUpDown();
            this.plusLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.subRightLabel = new System.Windows.Forms.Label();
            this.subLeftLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.multi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.multiRightLabel = new System.Windows.Forms.Label();
            this.multiLeftLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.soma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(272, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(192, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel
            // 
            this.equalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel.Location = new System.Drawing.Point(242, 75);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(60, 50);
            this.equalLabel.TabIndex = 4;
            this.equalLabel.Text = "=";
            this.equalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(308, 84);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(100, 35);
            this.soma.TabIndex = 1;
            this.soma.Click += new System.EventHandler(this.answer_Enter);
            this.soma.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(116, 75);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLabel.TabIndex = 6;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLabel
            // 
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(116, 154);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(60, 50);
            this.subLabel.TabIndex = 11;
            this.subLabel.Text = "-";
            this.subLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(308, 163);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 35);
            this.sub.TabIndex = 2;
            this.sub.Click += new System.EventHandler(this.answer_Enter);
            this.sub.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subRightLabel
            // 
            this.subRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRightLabel.Location = new System.Drawing.Point(192, 154);
            this.subRightLabel.Name = "subRightLabel";
            this.subRightLabel.Size = new System.Drawing.Size(60, 50);
            this.subRightLabel.TabIndex = 8;
            this.subRightLabel.Text = "?";
            this.subRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLeftLabel
            // 
            this.subLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLeftLabel.Location = new System.Drawing.Point(50, 154);
            this.subLeftLabel.Name = "subLeftLabel";
            this.subLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.subLeftLabel.TabIndex = 7;
            this.subLeftLabel.Text = "?";
            this.subLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 16;
            this.label6.Text = "x";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(308, 228);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(100, 35);
            this.multi.TabIndex = 3;
            this.multi.Click += new System.EventHandler(this.answer_Enter);
            this.multi.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiRightLabel
            // 
            this.multiRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiRightLabel.Location = new System.Drawing.Point(192, 219);
            this.multiRightLabel.Name = "multiRightLabel";
            this.multiRightLabel.Size = new System.Drawing.Size(60, 50);
            this.multiRightLabel.TabIndex = 13;
            this.multiRightLabel.Text = "?";
            this.multiRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiLeftLabel
            // 
            this.multiLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLeftLabel.Location = new System.Drawing.Point(50, 219);
            this.multiLeftLabel.Name = "multiLeftLabel";
            this.multiLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.multiLeftLabel.TabIndex = 12;
            this.multiLeftLabel.Text = "?";
            this.multiLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 21;
            this.label10.Text = "÷";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(308, 296);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(100, 35);
            this.div.TabIndex = 4;
            this.div.Click += new System.EventHandler(this.answer_Enter);
            this.div.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRightLabel
            // 
            this.divRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRightLabel.Location = new System.Drawing.Point(192, 287);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divRightLabel.TabIndex = 18;
            this.divRightLabel.Text = "?";
            this.divRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeftLabel.Location = new System.Drawing.Point(50, 287);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divLeftLabel.TabIndex = 17;
            this.divLeftLabel.Text = "?";
            this.divLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(170, 385);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 39);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.div);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.multiRightLabel);
            this.Controls.Add(this.multiLeftLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subRightLabel);
            this.Controls.Add(this.subLeftLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Name = "Main";
            this.Text = "Teste de matemática";
            ((System.ComponentModel.ISupportInitialize)(this.soma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.NumericUpDown soma;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.NumericUpDown sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subRightLabel;
        private System.Windows.Forms.Label subLeftLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown multi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label multiRightLabel;
        private System.Windows.Forms.Label multiLeftLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

