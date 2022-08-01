namespace EXPERIENCIA_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_frecuencia = new System.Windows.Forms.TextBox();
            this.txt_impedancia_pol = new System.Windows.Forms.TextBox();
            this.txt_inductancia = new System.Windows.Forms.TextBox();
            this.txt_resistencia = new System.Windows.Forms.TextBox();
            this.txt_angulo = new System.Windows.Forms.TextBox();
            this.txt_corriente = new System.Windows.Forms.TextBox();
            this.txt_potencia_act = new System.Windows.Forms.TextBox();
            this.txt_capacidad = new System.Windows.Forms.TextBox();
            this.txt_potencia_reac = new System.Windows.Forms.TextBox();
            this.txt_potencia_apa = new System.Windows.Forms.TextBox();
            this.txt_impedancia_rec = new System.Windows.Forms.TextBox();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calcular = new System.Windows.Forms.Button();
            this.pcrbox_cto_1 = new System.Windows.Forms.PictureBox();
            this.rdbutt_circuito_1 = new System.Windows.Forms.RadioButton();
            this.rdbutt_circuito_2 = new System.Windows.Forms.RadioButton();
            this.rdbutt_circuito_3 = new System.Windows.Forms.RadioButton();
            this.pcrbox_cto_2 = new System.Windows.Forms.PictureBox();
            this.pcrbox_cto_3 = new System.Windows.Forms.PictureBox();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_frecuencia
            // 
            this.txt_frecuencia.Location = new System.Drawing.Point(133, 46);
            this.txt_frecuencia.Name = "txt_frecuencia";
            this.txt_frecuencia.Size = new System.Drawing.Size(100, 22);
            this.txt_frecuencia.TabIndex = 11;
            this.txt_frecuencia.TextChanged += new System.EventHandler(this.txt_frecuencia_TextChanged);
            // 
            // txt_impedancia_pol
            // 
            this.txt_impedancia_pol.BackColor = System.Drawing.SystemColors.Window;
            this.txt_impedancia_pol.Location = new System.Drawing.Point(162, 63);
            this.txt_impedancia_pol.Name = "txt_impedancia_pol";
            this.txt_impedancia_pol.ReadOnly = true;
            this.txt_impedancia_pol.Size = new System.Drawing.Size(130, 22);
            this.txt_impedancia_pol.TabIndex = 1;
            this.txt_impedancia_pol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_inductancia
            // 
            this.txt_inductancia.Location = new System.Drawing.Point(108, 56);
            this.txt_inductancia.Name = "txt_inductancia";
            this.txt_inductancia.Size = new System.Drawing.Size(100, 22);
            this.txt_inductancia.TabIndex = 2;
            this.txt_inductancia.TextChanged += new System.EventHandler(this.txt_inductancia_TextChanged);
            // 
            // txt_resistencia
            // 
            this.txt_resistencia.Location = new System.Drawing.Point(108, 28);
            this.txt_resistencia.Name = "txt_resistencia";
            this.txt_resistencia.Size = new System.Drawing.Size(100, 22);
            this.txt_resistencia.TabIndex = 3;
            this.txt_resistencia.TextChanged += new System.EventHandler(this.txt_resistencia_TextChanged);
            // 
            // txt_angulo
            // 
            this.txt_angulo.Location = new System.Drawing.Point(133, 72);
            this.txt_angulo.Name = "txt_angulo";
            this.txt_angulo.Size = new System.Drawing.Size(100, 22);
            this.txt_angulo.TabIndex = 4;
            this.txt_angulo.TextChanged += new System.EventHandler(this.txt_angulo_TextChanged);
            // 
            // txt_corriente
            // 
            this.txt_corriente.BackColor = System.Drawing.SystemColors.Window;
            this.txt_corriente.Location = new System.Drawing.Point(162, 91);
            this.txt_corriente.Name = "txt_corriente";
            this.txt_corriente.ReadOnly = true;
            this.txt_corriente.Size = new System.Drawing.Size(130, 22);
            this.txt_corriente.TabIndex = 5;
            this.txt_corriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_potencia_act
            // 
            this.txt_potencia_act.BackColor = System.Drawing.SystemColors.Window;
            this.txt_potencia_act.Location = new System.Drawing.Point(162, 119);
            this.txt_potencia_act.Name = "txt_potencia_act";
            this.txt_potencia_act.ReadOnly = true;
            this.txt_potencia_act.Size = new System.Drawing.Size(130, 22);
            this.txt_potencia_act.TabIndex = 6;
            this.txt_potencia_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_capacidad
            // 
            this.txt_capacidad.Location = new System.Drawing.Point(108, 84);
            this.txt_capacidad.Name = "txt_capacidad";
            this.txt_capacidad.Size = new System.Drawing.Size(100, 22);
            this.txt_capacidad.TabIndex = 7;
            this.txt_capacidad.TextChanged += new System.EventHandler(this.txt_capacidad_TextChanged);
            // 
            // txt_potencia_reac
            // 
            this.txt_potencia_reac.BackColor = System.Drawing.SystemColors.Window;
            this.txt_potencia_reac.Location = new System.Drawing.Point(162, 147);
            this.txt_potencia_reac.Name = "txt_potencia_reac";
            this.txt_potencia_reac.ReadOnly = true;
            this.txt_potencia_reac.Size = new System.Drawing.Size(130, 22);
            this.txt_potencia_reac.TabIndex = 8;
            this.txt_potencia_reac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_potencia_reac.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txt_potencia_apa
            // 
            this.txt_potencia_apa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_potencia_apa.Location = new System.Drawing.Point(162, 172);
            this.txt_potencia_apa.Name = "txt_potencia_apa";
            this.txt_potencia_apa.ReadOnly = true;
            this.txt_potencia_apa.Size = new System.Drawing.Size(130, 22);
            this.txt_potencia_apa.TabIndex = 9;
            this.txt_potencia_apa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_impedancia_rec
            // 
            this.txt_impedancia_rec.BackColor = System.Drawing.SystemColors.Window;
            this.txt_impedancia_rec.Location = new System.Drawing.Point(162, 33);
            this.txt_impedancia_rec.Name = "txt_impedancia_rec";
            this.txt_impedancia_rec.ReadOnly = true;
            this.txt_impedancia_rec.Size = new System.Drawing.Size(130, 22);
            this.txt_impedancia_rec.TabIndex = 10;
            this.txt_impedancia_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(133, 18);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(100, 22);
            this.txt_v.TabIndex = 0;
            this.txt_v.TextChanged += new System.EventHandler(this.txt_v_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_v);
            this.groupBox1.Controls.Add(this.txt_angulo);
            this.groupBox1.Controls.Add(this.txt_frecuencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de Tensión";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Angulo [°]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Frecuencia [Hz]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tensión RMS [V]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = " R [Ohm]";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = " L [mH]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = " C [uC]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = " Z Rectangular [R + j*X]";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Z Polar [Z / A°]";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = " I [A]";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = " P [W]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = " Q [VAR]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = " S [VA]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_inductancia);
            this.groupBox2.Controls.Add(this.txt_resistencia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_capacidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 125);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Parámetros de la carga";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_potencia_act);
            this.groupBox3.Controls.Add(this.txt_impedancia_pol);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_corriente);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_potencia_reac);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_potencia_apa);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_impedancia_rec);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 208);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Resultados";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(29, 294);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(98, 33);
            this.calcular.TabIndex = 24;
            this.calcular.Text = " Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // pcrbox_cto_1
            // 
            this.pcrbox_cto_1.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox_cto_1.Image")));
            this.pcrbox_cto_1.Location = new System.Drawing.Point(368, 101);
            this.pcrbox_cto_1.Name = "pcrbox_cto_1";
            this.pcrbox_cto_1.Size = new System.Drawing.Size(442, 460);
            this.pcrbox_cto_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox_cto_1.TabIndex = 25;
            this.pcrbox_cto_1.TabStop = false;
            this.pcrbox_cto_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdbutt_circuito_1
            // 
            this.rdbutt_circuito_1.AutoSize = true;
            this.rdbutt_circuito_1.Location = new System.Drawing.Point(369, 29);
            this.rdbutt_circuito_1.Name = "rdbutt_circuito_1";
            this.rdbutt_circuito_1.Size = new System.Drawing.Size(82, 20);
            this.rdbutt_circuito_1.TabIndex = 26;
            this.rdbutt_circuito_1.Text = "Circuito 1";
            this.rdbutt_circuito_1.UseVisualStyleBackColor = true;
            this.rdbutt_circuito_1.CheckedChanged += new System.EventHandler(this.circuito_1_CheckedChanged);
            // 
            // rdbutt_circuito_2
            // 
            this.rdbutt_circuito_2.AutoSize = true;
            this.rdbutt_circuito_2.Location = new System.Drawing.Point(551, 28);
            this.rdbutt_circuito_2.Name = "rdbutt_circuito_2";
            this.rdbutt_circuito_2.Size = new System.Drawing.Size(82, 20);
            this.rdbutt_circuito_2.TabIndex = 27;
            this.rdbutt_circuito_2.TabStop = true;
            this.rdbutt_circuito_2.Text = "Circuito 2";
            this.rdbutt_circuito_2.UseVisualStyleBackColor = true;
            this.rdbutt_circuito_2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbutt_circuito_3
            // 
            this.rdbutt_circuito_3.AutoSize = true;
            this.rdbutt_circuito_3.Location = new System.Drawing.Point(711, 28);
            this.rdbutt_circuito_3.Name = "rdbutt_circuito_3";
            this.rdbutt_circuito_3.Size = new System.Drawing.Size(82, 20);
            this.rdbutt_circuito_3.TabIndex = 28;
            this.rdbutt_circuito_3.TabStop = true;
            this.rdbutt_circuito_3.Text = "Circuito 3";
            this.rdbutt_circuito_3.UseVisualStyleBackColor = true;
            this.rdbutt_circuito_3.CheckedChanged += new System.EventHandler(this.rdbutt_circuito_3_CheckedChanged);
            // 
            // pcrbox_cto_2
            // 
            this.pcrbox_cto_2.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox_cto_2.Image")));
            this.pcrbox_cto_2.Location = new System.Drawing.Point(368, 101);
            this.pcrbox_cto_2.Name = "pcrbox_cto_2";
            this.pcrbox_cto_2.Size = new System.Drawing.Size(442, 460);
            this.pcrbox_cto_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox_cto_2.TabIndex = 29;
            this.pcrbox_cto_2.TabStop = false;
            // 
            // pcrbox_cto_3
            // 
            this.pcrbox_cto_3.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox_cto_3.Image")));
            this.pcrbox_cto_3.Location = new System.Drawing.Point(368, 101);
            this.pcrbox_cto_3.Name = "pcrbox_cto_3";
            this.pcrbox_cto_3.Size = new System.Drawing.Size(442, 460);
            this.pcrbox_cto_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox_cto_3.TabIndex = 30;
            this.pcrbox_cto_3.TabStop = false;
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(172, 294);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(97, 33);
            this.Reiniciar.TabIndex = 31;
            this.Reiniciar.Text = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.pcrbox_cto_3);
            this.Controls.Add(this.pcrbox_cto_2);
            this.Controls.Add(this.rdbutt_circuito_3);
            this.Controls.Add(this.rdbutt_circuito_2);
            this.Controls.Add(this.rdbutt_circuito_1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcrbox_cto_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Circuito RLC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox_cto_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_frecuencia;
        private System.Windows.Forms.TextBox txt_impedancia_pol;
        private System.Windows.Forms.TextBox txt_inductancia;
        private System.Windows.Forms.TextBox txt_resistencia;
        private System.Windows.Forms.TextBox txt_angulo;
        private System.Windows.Forms.TextBox txt_corriente;
        private System.Windows.Forms.TextBox txt_potencia_act;
        private System.Windows.Forms.TextBox txt_capacidad;
        private System.Windows.Forms.TextBox txt_potencia_reac;
        private System.Windows.Forms.TextBox txt_potencia_apa;
        private System.Windows.Forms.TextBox txt_impedancia_rec;
        private System.Windows.Forms.TextBox txt_v;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.PictureBox pcrbox_cto_1;
        private System.Windows.Forms.RadioButton rdbutt_circuito_1;
        private System.Windows.Forms.RadioButton rdbutt_circuito_2;
        private System.Windows.Forms.RadioButton rdbutt_circuito_3;
        private System.Windows.Forms.PictureBox pcrbox_cto_2;
        private System.Windows.Forms.PictureBox pcrbox_cto_3;
        private System.Windows.Forms.Button Reiniciar;
    }
}

