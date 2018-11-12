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
            if (flagMDD == true && flagED == true)
            {
                lblMDD.Text = "La matriz de coeficientes asociada al SEL ingresada es estrictamente diagonal dominante";
            }
            else if (flagMDD == true && flagED == false)
            {
                lblMDD.Text = "La matriz de coeficientes asociada al SEL ingresada es diagonalmente dominante";
            }
            else
            {
                lblMDD.Text = "La matriz de coeficientes asociada al SEL ingresado NO es diagonalmente dominante";
            }
         } // Fin btnMDD_Click

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
            string[] ecuaciones = txtbx1.Text.Split(new[] { "\n" },
                StringSplitOptions.None);

            return ecuaciones.Length; 
        }

        private double[,] obtenerCoeficientesYTerminosIndependientes()
        {
            string sistemaDeEcuaciones;
            sistemaDeEcuaciones = txtbx1.Text;

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
            sistemaDeEcuaciones = txtbx1.Text;

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
        }

    } // Fin public partial class Form 1

}
