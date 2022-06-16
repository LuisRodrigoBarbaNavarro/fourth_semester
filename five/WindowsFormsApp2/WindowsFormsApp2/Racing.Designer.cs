
namespace WindowsFormsApp2
{
    partial class Racing
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.model_a = new System.Windows.Forms.PictureBox();
            this.model_b = new System.Windows.Forms.PictureBox();
            this.model_c = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.model_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_c)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // model_a
            // 
            this.model_a.BackColor = System.Drawing.Color.Transparent;
            this.model_a.Image = global::WindowsFormsApp2.Properties.Resources.car_1;
            this.model_a.Location = new System.Drawing.Point(1, 79);
            this.model_a.Name = "model_a";
            this.model_a.Size = new System.Drawing.Size(128, 40);
            this.model_a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.model_a.TabIndex = 4;
            this.model_a.TabStop = false;
            // 
            // model_b
            // 
            this.model_b.BackColor = System.Drawing.Color.Transparent;
            this.model_b.Image = global::WindowsFormsApp2.Properties.Resources.car_2;
            this.model_b.Location = new System.Drawing.Point(1, 206);
            this.model_b.Name = "model_b";
            this.model_b.Size = new System.Drawing.Size(128, 40);
            this.model_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.model_b.TabIndex = 5;
            this.model_b.TabStop = false;
            // 
            // model_c
            // 
            this.model_c.BackColor = System.Drawing.Color.Transparent;
            this.model_c.Image = global::WindowsFormsApp2.Properties.Resources.car_3;
            this.model_c.Location = new System.Drawing.Point(1, 332);
            this.model_c.Name = "model_c";
            this.model_c.Size = new System.Drawing.Size(128, 40);
            this.model_c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.model_c.TabIndex = 6;
            this.model_c.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carrera (Demostración visual de Threads)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modelo B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modelo C";
            // 
            // Racing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.racing_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 445);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.model_c);
            this.Controls.Add(this.model_b);
            this.Controls.Add(this.model_a);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Racing";
            this.Text = "Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CarVector_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.model_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox model_a;
        private System.Windows.Forms.PictureBox model_b;
        private System.Windows.Forms.PictureBox model_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

