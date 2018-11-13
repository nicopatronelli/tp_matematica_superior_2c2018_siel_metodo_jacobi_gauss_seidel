using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Math;

namespace SIEL_Superior_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormaInf_Click(object sender, EventArgs e)
        {
            double[,] coeficientes = obtenerCoeficientesYTerminosIndependientes();
            int orden = obtenerOrden();
            List<double> listaSumaFilas = new List<double>();

            for (int fila = 1; fila <= orden; fila++ )
            {
                // Una vez que estoy parado en una fila...
                double sumaFilaActual = 0;
                // Hago columna <= orden para NO considerar la columna de t.i.
                for (int columna = 1; columna <= orden; columna++ ) 
                {
                    sumaFilaActual = sumaFilaActual + Math.Abs(coeficientes[fila, columna]);
                }
                listaSumaFilas.Add(sumaFilaActual);
            }

            double normaInfinito = listaSumaFilas.Max();

            lblNorma.Text = normaInfinito.ToString();

        } // Fin btn_Click() 

        private void btnNorma1_Click(object sender, EventArgs e)
        {
            double[,] coeficientes = obtenerCoeficientesYTerminosIndependientes();
            int orden = obtenerOrden();
            List<double> listaSumaColumnas = new List<double>();

            // Hago columna <= orden para NO considerar la columna de t.i.
            for (int columna = 1; columna <= orden; columna++)
            {
                // Una vez que estoy parado en una columna...
                double sumaColumnaActual = 0;
                for (int fila = 1; fila <= orden; fila++)
                {
                    sumaColumnaActual = sumaColumnaActual + Math.Abs(coeficientes[fila, columna]);
                }
                listaSumaColumnas.Add(sumaColumnaActual);
            }

            double norma1 = listaSumaColumnas.Max();

            lblNorma.Text = norma1.ToString();
        }

        private void btnNorma2_Click(object sender, EventArgs e)
        {   
            double[,] coeficientesSolos = obtenerCoeficientesSolos();
            double norma2 = Accord.Math.Norm.Norm2(coeficientesSolos);
            lblNorma.Text = norma2.ToString();
        }

        private void btnMDD_Click(object sender, EventArgs e)
        {
            double[,] coeficientes = obtenerCoeficientesSolos();
            int orden = obtenerOrden();
            // Por cada fila
            int columnaDP = 0;
            double valorDP = 0;
            double sumaFila = 0;
            bool flagMDD = true; // Comenzamos suponiendo que la matriz es diagonalmente dominante
            bool flagED = true; // Comenzamos suponiendo que la matriz es estrictamente dominante
            for (int fila = 0; fila < orden; fila++)
            {   
                // Recorro todas las columnas
                for (int columna = 0; columna < orden; columna++)
                {
                    // Sumo todos los elementos de la fila actual
                    sumaFila = sumaFila + Math.Abs(coeficientes[fila, columna]); 
                }
                valorDP = Math.Abs(coeficientes[fila, columnaDP]);
                sumaFila = sumaFila - valorDP; // Como lo sume lo tengo que restar
                if (!(valorDP > sumaFila)) // estrictamente dominante 
                {
                    // La matriz ya no puede ser estrictamente dominante, pero puede ser
                    // diagonalmente dominante aún
                    flagED = false; 
                }
                if (!(valorDP >= sumaFila)) // diagonalmente dominante
                {
                    // La matriz ya no puede ser diagonalmente dominante 
                    flagMDD = false;
                    break;
                }
                columnaDP++;
                sumaFila = 0;
            } // Fin for filas 

            // Si llego a este punto significa que la matriz es diagonalmente dominante
            DialogResult msgbox;
            if (flagMDD == true && flagED == true)
            {
                msgbox = MessageBox.Show("La matriz de coeficientes asociada al SEL ingresada es estrictamente diagonal dominante", "SIEL", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flagMDD == true && flagED == false)
            {
                msgbox = MessageBox.Show("La matriz de coeficientes asociada al SEL ingresada es diagonalmente dominante", "SIEL",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msgbox = MessageBox.Show("La matriz de coeficientes asociada al SEL ingresado NO es diagonalmente dominante", "SIEL",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         } // Fin btnMDD_Click

        private void btnJacobi_Click(object sender, EventArgs e)
        {
            JacobiForm jacobForm = new JacobiForm();
            jacobForm.Show();




        }

        /*
         * MÉTODOS AUXILIARES  
        */

        private double[,] matrizTranspuesta(double[,] matriz)
        {
            int orden = obtenerOrden();
            double [,] resultado = new double[orden+1, orden+1];

            for (int fila = 1; fila <= orden; fila++ )
            {
                for (int columna = 1; columna <= orden; columna++)
                {
                    resultado[fila, columna] = matriz[columna, fila];
                }
            }

        return resultado;
        } // Fin matrizTranspuesta()

        private int obtenerOrden()
        {
            string[] ecuaciones = txtbxEcuaciones.Text.Split(new[] { "\n" },
                StringSplitOptions.None);

            return ecuaciones.Length; 
        }

        private double[,] obtenerCoeficientesYTerminosIndependientes()
        {
            string sistemaDeEcuaciones;
            sistemaDeEcuaciones = txtbxEcuaciones.Text;

            string[] ecuaciones = sistemaDeEcuaciones.Split(new[] { "\n" },
                StringSplitOptions.None);
            //string[] ecuaciones = sistemaDeEcuaciones.Split(';');
            int orden = obtenerOrden();

            // Reemplazo los x_nn por ; 
            for (int i = 0; i < orden; i++)
            {
                //ecuaciones[i] = ecuaciones[i].Replace(Regex., ";");
                ecuaciones[i] = Regex.Replace(ecuaciones[i], @"x_\d*", ";");
            }

            // Eliminamos los espacios en blanco y reemplazamos el = por ""
            for (int i = 0; i < orden; i++)
            {
                ecuaciones[i] = ecuaciones[i].Replace(" ", "");
                ecuaciones[i] = ecuaciones[i].Replace("=", "");
            }

            // En este punto tenemos en ecuaciones por ejemplo: 2;+3;5 
            double[,] coeficientes = new double[orden + 1, orden + 2];
            for (int i = 0; i < orden; i++)
            {
                string[] coef = ecuaciones[i].Split(';');
                for (int j = 0; j < orden + 1; j++) // orden + 1 por el t.i.
                {
                    coeficientes[i + 1, j + 1] = Convert.ToDouble(coef[j]);
                }
            }

            return coeficientes;

        } // Fin obtenerCoeficientes()

        private double[,] obtenerCoeficientesSolos()
        {
            string sistemaDeEcuaciones;
            sistemaDeEcuaciones = txtbxEcuaciones.Text;

            string[] ecuaciones = sistemaDeEcuaciones.Split(new[] { "\n" },
                StringSplitOptions.None);

            int orden = obtenerOrden();

            // Reemplazo los x_nn por ; 
            for (int i = 0; i < orden; i++)
            {
                //ecuaciones[i] = ecuaciones[i].Replace(Regex., ";");
                ecuaciones[i] = Regex.Replace(ecuaciones[i], @"x_\d*", ";");
            }

            // Eliminamos los espacios en blanco y reemplazamos el = por ""
            for (int i = 0; i < orden; i++)
            {
                ecuaciones[i] = ecuaciones[i].Replace(" ", "");
                ecuaciones[i] = ecuaciones[i].Replace("=", "");
            }

            // En este punto tenemos en ecuaciones por ejemplo: 2;+3;5 
            double[,] coeficientes = new double[orden, orden];
            for (int i = 0; i < orden; i++)
            {
                string[] coef = ecuaciones[i].Split(';');
                for (int j = 0; j < orden; j++) 
                {
                    coeficientes[i, j] = Convert.ToDouble(coef[j]);
                }
            }

            return coeficientes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNorma.Text = "";
            string txtInicEcu1 = "Ingrese aquí su sistema de ecuaciones respetando el siguiente formato: " + Environment.NewLine;
            string txtInicEcu2 = "a_11x_1 + a_12x_2 + ... + a_1nx_n = b_1" + Environment.NewLine;
            string txtInicEcu3 = "a_21x_1 + a_22x_2 + ... + a_2nx_n = b_2" + Environment.NewLine;
            string txtInicEcu4 = "  ... ... ... ... ... ... ... ... ... ... ... ... ... ... ... ..." + Environment.NewLine;
            string txtInicEcu5 = "a_n1x_1 + a_n2x_2 + ... + a_nnx_n = b_n" + Environment.NewLine;
            string txtInicEcu6 = "Donde a_ij y b_i son número reales.";

            txtbxEcuaciones.Text = txtInicEcu1 + Environment.NewLine + txtInicEcu2 + txtInicEcu3 + txtInicEcu4 + txtInicEcu5 + Environment.NewLine + txtInicEcu6;
        }

        private void btnGS_Click(object sender, EventArgs e)
        {

            double[,] coef = obtenerCoeficientesYTerminosIndependientes();
            double[] sol = { 0, 0, 0 }; // En la primer iteración hace de vector inicial
            int orden = obtenerOrden() + 1; //3
            int ultimaColumna = orden;
            double acumulador = 0;

            int flag = 3;
            while (flag > 0)
            {
                for (int fila = 1; fila < orden; fila++)
                {
                    for (int columna = 1; columna < ultimaColumna; columna++)
                    {
                        if (fila != columna) // Para excluir el término de la DP
                            acumulador = acumulador + coef[fila, columna] * sol[columna];
                    } // fin for columnas

                    //Cuando termino de barrer todas las columnas, resto el valor acumulador al t.i. de la fila
                    sol[fila] = coef[fila, ultimaColumna] - acumulador;

                    // Finalmente, divido el resultado de sol[fila] por el coeficiente de la variable
                    sol[fila] = sol[fila] / coef[fila, fila];
                    
                    // Reinicio el acumulador 
                    acumulador = 0; 
                } // fin for filas
                flag--;

            } // fin while   
            Console.WriteLine("La solución del sistema es: " + Math.Round(sol[1], 4) + " y " + Math.Round(sol[2], 4)); 

        } // FIN btnGS_Click

    } // FIN public partial class Form 1

}
