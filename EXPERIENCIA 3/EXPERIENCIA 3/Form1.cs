using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPERIENCIA_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // los siguientes son los valores por defecto en las casillas correspondientes

                txt_v.Text = "220";         
                txt_frecuencia.Text = "50";
                txt_angulo.Text = "0";
                txt_resistencia.Text = "1000";
                txt_capacidad.Text = "10";
                txt_inductancia.Text = "100";
            ////**************************
            rdbutt_circuito_1.Checked = true; // para iniciar el boton cto 1
            pcrbox_cto_1.Visible = true; // elegiremos que parta mostrando la imagen cto 1
            pcrbox_cto_2.Visible = false; // desabilitamos la imagen del cto2
            pcrbox_cto_3.Visible = false; // desabilitamos la imagen del cto3
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            // Variables de entrada, salida y auxiliares para hacer calculos, en formato double
            double V, R, C, L, f, Angulo, w, pi, Z_real, Z_imag, Z_abs, Z_angl, I, angl_I, P, Q, S;
            // Variables de salida en formato string para los txtbox de resultado
            string Z_real_str, Z_imag_str, Z_abs_str, Z_angl_str, I_str, P_str, Q_str, S_str ;
            // Convertiremos todos los numeros ingresados a variable double
            V = Convert.ToDouble(txt_v.Text);
            f = Convert.ToDouble(txt_frecuencia.Text);
            Angulo = Convert.ToDouble(txt_angulo.Text);
            R = Convert.ToDouble(txt_resistencia.Text);
            C = Convert.ToDouble(txt_capacidad.Text)*0.000001;
            L = Convert.ToDouble(txt_inductancia.Text)*0.001;
            // guardo lo frecuencia angular para construir las impedancias reactivas en la formula            
            pi = Math.PI;
            w = 2 * pi * f;

            // el calculo de la impedancia real e imaginaria, se hizo con mathlab y se tradujeron las formulas al
            // lenguaje C#

            // si esta activada la casilla 1, hará los calculos de acuerdo al circuito 1
            if(rdbutt_circuito_1.Checked)
            { 
                
                // mediante matlab se verificaron las formulas de las impedancias

                Z_real = R / (Math.Pow(C,2)* Math.Pow(L,2) * Math.Pow(w,4) + Math.Pow(C,2) * Math.Pow(R,2) * Math.Pow(w,2) - 2 * C * L * Math.Pow(w,2) + 1);
                Z_imag = -((w * (C * Math.Pow(L, 2) * Math.Pow(w, 2) - L + C * Math.Pow(R, 2))) / ((Math.Pow(C, 2) * Math.Pow(L, 2) * Math.Pow(w, 4) + Math.Pow(C, 2) * Math.Pow(R, 2) * Math.Pow(w, 2) - 2 * C * L * Math.Pow(w, 2) + 1)));
                Z_abs = Math.Sqrt(Math.Pow(Z_real, 2) + Math.Pow(Z_imag, 2));
                Z_angl = (180 / pi) * Math.Atan(Z_imag / Z_real);
                I = V / Z_abs;
                angl_I = Angulo - Z_angl;
                P = V * I * Math.Abs(Math.Cos(angl_I * (pi / 180)));
                Q = V * I * Math.Abs(Math.Sin(angl_I * (pi/ 180)));
                S = V * I;


                // redondearemos a 2 decimales para mostrar resultados compactos

                Z_real = Math.Round(Z_real, 2);
                Z_imag = Math.Round(Z_imag, 2);
                Z_abs = Math.Round(Z_abs, 2);
                Z_angl = Math.Round(Z_angl, 2);
                I = Math.Round(I, 2);
                P = Math.Round(P, 2);
                Q = Math.Round(Q, 2);
                S = Math.Round(S, 2);

                // ahora converitiremos los valores de salida en string para poder colocarlos en los cuadros de texto

                Z_real_str = Convert.ToString(Z_real);
                Z_imag_str = Convert.ToString(Z_imag);
                Z_abs_str = Convert.ToString(Z_abs);
                Z_angl_str = Convert.ToString(Z_angl);
                I_str = Convert.ToString(I);
                P_str = Convert.ToString(P);
                Q_str = Convert.ToString(Q);
                S_str = Convert.ToString(S);

                // Enviaremos las respuestas a los cuadros de salida

                txt_impedancia_rec.Text = "" + Z_real_str + " + j" + Z_imag_str + "";
                txt_impedancia_pol.Text = "" + Z_abs_str + " / " + Z_angl_str + "°";
                txt_corriente.Text = "" + I_str + "";
                txt_potencia_act.Text = "" + P_str + "";
                txt_potencia_reac.Text = "" + Q_str + "";
                txt_potencia_apa.Text = "" + S_str + "";

            }
            
            //si está precionado el circuito 2 realizará los siguientes calculos
            
            if (rdbutt_circuito_2.Checked)
            {
                Z_real = R / (Math.Pow(C, 2) * Math.Pow(R, 2) * Math.Pow(w, 2)+ 1);
                Z_imag = w *( L *Math.Pow(C, 2) * Math.Pow(w, 2)* Math.Pow(R, 2) - C * Math.Pow(R, 2) + L) / (Math.Pow(C, 2) * Math.Pow(R, 2) * Math.Pow(w, 2) + 1);
                Z_abs = Math.Sqrt(Math.Pow(Z_real, 2) + Math.Pow(Z_imag, 2));
                Z_angl = (180 / pi) * Math.Atan(Z_imag / Z_real);
                I = V / Z_abs;
                angl_I = Angulo - Z_angl;
                P = V * I * Math.Abs(Math.Cos(angl_I * (pi / 180)));
                Q = V * I * Math.Abs(Math.Sin(angl_I * (pi / 180)));
                S = V * I;


                // redondearemos a 2 decimales para mostrar resultados compactos

                Z_real = Math.Round(Z_real, 2);
                Z_imag = Math.Round(Z_imag, 2);
                Z_abs = Math.Round(Z_abs, 2);
                Z_angl = Math.Round(Z_angl, 2);
                I = Math.Round(I, 2);
                P = Math.Round(P, 2);
                Q = Math.Round(Q, 2);
                S = Math.Round(S, 2);

                // ahora converitiremos los valores de salida en string para poder colocarlos en los cuadros de texto

                Z_real_str = Convert.ToString(Z_real);
                Z_imag_str = Convert.ToString(Z_imag);
                Z_abs_str = Convert.ToString(Z_abs);
                Z_angl_str = Convert.ToString(Z_angl);
                I_str = Convert.ToString(I);
                P_str = Convert.ToString(P);
                Q_str = Convert.ToString(Q);
                S_str = Convert.ToString(S);

                // Enviaremos las respuestas a los cuadros de salida

                txt_impedancia_rec.Text = "" + Z_real_str + " + j" + Z_imag_str + "";
                txt_impedancia_pol.Text = "" + Z_abs_str + " / " + Z_angl_str + "°";
                txt_corriente.Text = "" + I_str + "";
                txt_potencia_act.Text = "" + P_str + "";
                txt_potencia_reac.Text = "" + Q_str + "";
                txt_potencia_apa.Text = "" + S_str + "";
            }

            if (rdbutt_circuito_3.Checked)
            {
                Z_real = Math.Pow(L, 2) *R* Math.Pow(w, 2) / (Math.Pow(L, 2) * Math.Pow(w, 2)  + Math.Pow(R, 2));
                Z_imag = L* Math.Pow(R, 2)*w/(Math.Pow(L, 2)* Math.Pow(w, 2) + Math.Pow(R, 2)) - 1/(C*w);
                Z_abs = Math.Sqrt(Math.Pow(Z_real, 2) + Math.Pow(Z_imag, 2));
                Z_angl = (180 / pi) * Math.Atan(Z_imag / Z_real);
                I = V / Z_abs;
                angl_I = Angulo - Z_angl;
                P = V * I * Math.Abs(Math.Cos(angl_I * (pi / 180)));
                Q = V * I * Math.Abs(Math.Sin(angl_I * (pi / 180)));
                S = V * I;


                // redondearemos a 2 decimales para mostrar resultados compactos

                Z_real = Math.Round(Z_real, 2);
                Z_imag = Math.Round(Z_imag, 2);
                Z_abs = Math.Round(Z_abs, 2);
                Z_angl = Math.Round(Z_angl, 2);
                I = Math.Round(I, 2);
                P = Math.Round(P, 2);
                Q = Math.Round(Q, 2);
                S = Math.Round(S, 2);

                // ahora converitiremos los valores de salida en string para poder colocarlos en los cuadros de texto

                Z_real_str = Convert.ToString(Z_real);
                Z_imag_str = Convert.ToString(Z_imag);
                Z_abs_str = Convert.ToString(Z_abs);
                Z_angl_str = Convert.ToString(Z_angl);
                I_str = Convert.ToString(I);
                P_str = Convert.ToString(P);
                Q_str = Convert.ToString(Q);
                S_str = Convert.ToString(S);

                // Enviaremos las respuestas a los cuadros de salida

                txt_impedancia_rec.Text = "" + Z_real_str + " + j" + Z_imag_str + "";
                txt_impedancia_pol.Text = "" + Z_abs_str + " / " + Z_angl_str + "°";
                txt_corriente.Text = "" + I_str + "";
                txt_potencia_act.Text = "" + P_str + "";
                txt_potencia_reac.Text = "" + Q_str + "";
                txt_potencia_apa.Text = "" + S_str + "";
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_angulo_TextChanged(object sender, EventArgs e)
        {
            // verificamos que el angulo esté entr -180 y 180
            string angulo_str = txt_angulo.Text;

            // verifica que se escriba un numero para ejecutar la conversiona double
            bool result = double.TryParse(angulo_str, out _);   
            if(result)
            {
                double angulo;
                angulo = Convert.ToDouble(txt_angulo.Text);
                 if (-180 > angulo || angulo > 180)
                 {
                    MessageBox.Show("El angulo debe estar entre -180° y 180°");
                    txt_angulo.Text = "";
                 }
            }
        }

        private void txt_frecuencia_TextChanged(object sender, EventArgs e)
        {
            // verificamos que la frecuencia se positiva
            string freq_str = txt_frecuencia.Text;
            // verifica que se escriba un numero para ejecutar la conversion a double
            bool result = double.TryParse(freq_str, out _);
            if (result)
            {
                double freq;
                freq = Convert.ToDouble(txt_frecuencia.Text);
                if (freq < 0)
                {
                    MessageBox.Show("La frecuencia debe ser mayor que 0.");
                    txt_frecuencia.Text = "";
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_resistencia_TextChanged(object sender, EventArgs e)
        {
            // verificamos que la resistencia se positiva y que no sea 0 al mismo tiempo que L
            string resistencia_str = txt_resistencia.Text;
            // verifica que se escriba un numero para ejecutar la conversion a double
            bool result1 = double.TryParse(resistencia_str, out _);
            if (result1)
            {
                double resistencia;
                resistencia = Convert.ToDouble(txt_resistencia.Text);
                // verificamos que la resisencia no sea negativa
                if (resistencia < 0)
                {
                    MessageBox.Show("La resistencia debe ser mayor que 0.");
                    txt_resistencia.Text = "";
                }
                string inductancia_str = txt_inductancia.Text;
                // verifica que se escriba un numero para ejecutar la conversion a double
                bool result2 = double.TryParse(inductancia_str, out _);
                if (result2)
                {
                    double inductancia;
                    inductancia = Convert.ToDouble(txt_inductancia.Text);  
                    //verificaremos que inductancia y resistencia no sean 0 al mismo tiempo
                    if(inductancia == 0 && resistencia == 0)
                    {
                        MessageBox.Show("La resistencia y la inductancia no pueden ser 0 simultaneamente.");
                        txt_resistencia.Text = "";
                        
                    }
                }
            }
        }

        private void txt_inductancia_TextChanged(object sender, EventArgs e)
        {
            // verificamos que la inductancia sea positiva y que no sea 0 al mismo tiempo que R
            string inductancia_str = txt_inductancia.Text;
            // verifica que se escriba un numero para ejecutar la conversion a double
            bool result1 = double.TryParse(inductancia_str, out _);
            if (result1)
            {
                double inductancia;
                inductancia = Convert.ToDouble(txt_inductancia.Text);
                // verificamos que la resisencia no sea negativa
                if (inductancia < 0)
                {
                    MessageBox.Show("La inductancia debe ser mayor que 0.");
                    txt_inductancia.Text = "";
                }
                string resistencia_str = txt_resistencia.Text;
                // verifica que se escriba un numero para ejecutar la conversion a double
                bool result2 = double.TryParse(resistencia_str, out _);
                if (result2)
                {
                    double resistencia;
                    resistencia = Convert.ToDouble(txt_resistencia.Text);
                    //verificaremos que inductancia y resistencia no sean 0 al mismo tiempo
                    if (inductancia == 0 && resistencia == 0)
                    {
                        MessageBox.Show("La resistencia y la inductancia no pueden ser 0 simultaneamente.");
                        
                        txt_inductancia.Text = "";
                    }
                }
            }
        }

        private void txt_capacidad_TextChanged(object sender, EventArgs e)
        {
            // verificamos que la capacidad sea positiva y que no sea 0
            string capacidad_str = txt_capacidad.Text;
            // verifica que se escriba un numero para ejecutar la conversion a double
            bool result = double.TryParse(capacidad_str, out _);
            if (result)
            {
                double capacidad;
                capacidad = Convert.ToDouble(txt_capacidad.Text);
                // verificamos que la resisencia no sea negativa
                if (capacidad <= 0)
                {
                    MessageBox.Show("La capacidad debe ser mayor que 0.");
                    txt_capacidad.Text = "";
                }
                
                
            }

        }

        private void txt_v_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // vamos a hacer visible el cto 2, si no esta marcada la casilla se hace invisible
            if (rdbutt_circuito_2.Checked)
            {
                pcrbox_cto_2.Visible = true;
            }
            else
            {
                pcrbox_cto_2.Visible = false;
            }
        }

        private void circuito_1_CheckedChanged(object sender, EventArgs e)
        {
            // vamos a hacer visible el cto 1, si no esta marcada la casilla se hace invisible
            if (rdbutt_circuito_1.Checked)
            {
                pcrbox_cto_1.Visible = true;
            }
            else
            {
                pcrbox_cto_1.Visible = false;
            }
        }

        private void rdbutt_circuito_3_CheckedChanged(object sender, EventArgs e)
        {
            // vamos a hacer visible el cto 3, si no esta marcada la casilla se hace invisible
            if (rdbutt_circuito_3.Checked)
            {
                pcrbox_cto_3.Visible = true;
            }
            else
            {
                pcrbox_cto_3.Visible = false;
            }
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            // el boton reiniciar vuelve todos los valor a los predeterminados por defecto
            txt_v.Text = "220";
            txt_frecuencia.Text = "50";
            txt_angulo.Text = "0";
            txt_resistencia.Text = "1000";
            txt_capacidad.Text = "10";
            txt_inductancia.Text = "100";
            txt_impedancia_rec.Clear();
            txt_impedancia_pol.Clear();
            txt_corriente.Clear();
            txt_potencia_act.Clear();
            txt_potencia_reac.Clear();
            txt_potencia_apa.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
/*  Conclusiones
 *  ER: C# con IDE Visual estudio es una poderosa herramienta para hacer aplicaciones, mediante el formulario
 *   y el cuadro de herramientas se pueden agregar muchas funcionalidades y las ayudas que proporciona Visual van guiando
 *  al programador a corregir errores.
 *  
 *  RV: es necesario tener cuidado con la asignación de nombres previo a hacer doble click en una función o cuadro
 *  de texto puesto que puede generar confución en el codigo tener dos nombres distintos para una variable.
 *  
 *  LA: el entorno grafico de C# proporciona una idea más intuitiva de lo que puede ser la programación orientada
 *  a objetos, las distintas propiedades o atributos que tiene cada objeto, la posibilidad de llamarlos, y ejecutar
 *  por separado las partes del código genera muchas posibilidades de desarrollo.
 *  
 *  
*
**
**
**
**
**
**
**
*
**
**
**
**
**
*
*
*
*
*
*
*
*
*
*
*
*
*
*
*
*
*
*
*/
