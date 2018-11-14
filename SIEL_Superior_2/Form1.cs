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
            double norma2 = Math.Round(Accord.Math.Norm.Norm2(coeficientesSolos), 8);
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
            double[,] coef = obtenerCoeficientesYTerminosIndependientes();
            double[] solucion = cargarVectorInicial(); // En la primer iteración hace de vector inicial
            int cantidadColumnas = cantidadDeColumnas();
            int ultimaColumna = cantidadColumnas;
            double acumulador = 0;
            int cantidadDecimales = Convert.ToInt32(txtbxcantdecimales.Text);
            double precision = Convert.ToDouble(txtbxprecision.Text);
            double[] solucionAnt = new double[cantidadDeColumnas()];
            double[] vectorResta = new double[cantidadDeColumnas()];
            double normaInf = 0;

            // Verificamos que el vector inicial oincide con el orden del SEL ingresado
            if (verificacionVectorInicial(solucion) == true)
            { // Inicio verificación vector inicial

                mostrarEncabezado("Jacobi", precision, obtenerOrden());

                while (true)
                {   
                    // En fila 1 se calcula x_1, en fila 2 se calcula x_2, etc... 
                    for (int fila = 1; fila < cantidadColumnas; fila++) 
                    {
                        for (int columna = 1; columna < ultimaColumna; columna++)
                        {
                            if (fila != columna) // Para excluir el término de la DP
                                acumulador = acumulador + coef[fila, columna] * solucionAnt[columna];
                        } // fin for columnas

                        //Cuando termino de barrer todas las columnas, resto el valor acumulador al t.i. de la fila
                        solucion[fila] = coef[fila, ultimaColumna] - acumulador;

                        // Finalmente, divido el resultado de sol[fila] por el coeficiente de la variable
                        solucion[fila] = solucion[fila] / coef[fila, fila];

                        // Redondeamos la solución (redondeo simétrico) con los decimales pedidos
                        solucion = redondearVector(solucion, cantidadDecimales);

                        // Reinicio el acumulador 
                        acumulador = 0;

                    } // fin for filas

                    /*** Acá se termina la iteración actual ***/

                    // 1. Calculo la resta entre el vector solucion actual y el anterior
                    vectorResta = restaEntreVectores(solucion, solucionAnt);

                    // 2. Calculo su norma infinito vectorial
                    normaInf = Math.Round(normaInfinitoVectorial(vectorResta), cantidadDecimales);

                    // 3. Muestro por pantalla el vector solución actual (recordar que sol[0] no lo usamos)
                    mostrarVector(solucion, normaInf);

                    // 4. Actualizo el vector solucionAnt con los datos del vector solucion actual para la siguiente iteración
                    Array.Copy(solucion, 0, solucionAnt, 0, solucion.Length);

                    // 5. Comparo si es menor que la precisión para ver si sigo iterando o no
                    if (normaInf < precision)
                    {
                        break; // Dejo de iterar
                    }

                } // fin while(true)   
            }
            else
            {
                // Fin verificación vector inicial
            }

        } // FIN btnJacobi_Click 

        private void btnGS_Click(object sender, EventArgs e)
        {
            double[,] coef = obtenerCoeficientesYTerminosIndependientes();
            double[] solucion = cargarVectorInicial(); // En la primer iteración hace de vector inicial
            int cantidadColumnas = cantidadDeColumnas();
            int ultimaColumna = cantidadColumnas;
            double acumulador = 0;
            int cantidadDecimales = Convert.ToInt32(txtbxcantdecimales.Text);
            double precision = Convert.ToDouble(txtbxprecision.Text);
            double[] solucionAnt = new double[cantidadDeColumnas()]; 
            double[] vectorResta = new double[cantidadDeColumnas()];
            double normaInf = 0;
            
            // Verificamos que el vector inicial oincide con el orden del SEL ingresado
            if (verificacionVectorInicial(solucion) == true)
            { // Inicio verificación vector inicial

                mostrarEncabezado("Gauss Seidel", precision, obtenerOrden());

                while (true)
                {
                    for (int fila = 1; fila < cantidadColumnas; fila++)
                    {
                        for (int columna = 1; columna < ultimaColumna; columna++)
                        {
                            if (fila != columna) // Para excluir el término de la DP
                                acumulador = acumulador + coef[fila, columna] * solucion[columna];
                        } // fin for columnas

                        //Cuando termino de barrer todas las columnas, resto el valor acumulador al t.i. de la fila
                        solucion[fila] = coef[fila, ultimaColumna] - acumulador;

                        // Finalmente, divido el resultado de sol[fila] por el coeficiente de la variable
                        solucion[fila] = solucion[fila] / coef[fila, fila];

                        // Redondeamos la solución (redondeo simétrico) con los decimales pedidos
                        solucion = redondearVector(solucion, cantidadDecimales);

                        // Reinicio el acumulador 
                        acumulador = 0;

                    } // fin for filas

                    /*** Acá se termina la iteración actual ***/

                    // 1. Calculo la resta entre el vector solucion actual y el anterior
                    vectorResta = restaEntreVectores(solucion, solucionAnt);

                    // 2. Calculo su norma infinito vectorial
                    normaInf = Math.Round(normaInfinitoVectorial(vectorResta), cantidadDecimales);

                    // 3. Muestro por pantalla el vector solución actual (recordar que sol[0] no lo usamos)
                    mostrarVector(solucion, normaInf);

                    /* 4. Me guardo el vector solucion actual en una variable auxiliar para poder restarlo 
                     * con el vector de la siguiente iteración*/
                    Array.Copy(solucion, 0, solucionAnt, 0, solucion.Length);

                    // 5. Comparo si es menor que la precisión para ver si sigo iterando o no
                    if (normaInf < precision)
                    {
                        break; // Dejo de iterar
                    }

                } // fin while(true)   
            }
            else
            {
                // Fin verificación vector inicial
            }
        } // FIN btnGS_Click    

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

        private int cantidadDeColumnas()
        {
            /* El orden de un sistema de nxn es n, tiene n filas, pero tiene n+1 columnas, ya que tenemos 
             * que considerar la columna de términos independientes. 
            */ 
            return obtenerOrden() + 1; 
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

        private double[] cargarVectorInicial()
        {
            string vectorInicialTexto = txtbxvinicial.Text;
            string[] arrayVectorInicial = vectorInicialTexto.Split(';');
            int cantidadComponentes = arrayVectorInicial.Length;
            double[] vectorInicial = new double[cantidadComponentes + 1]; // + 1 del 0 en la 1º componente
            vectorInicial[0] = 0; // Ponemos un 0 en la posición 0 (para iniciar en el índice 1) 
            for(int nroComponente = 1; nroComponente <= cantidadComponentes; nroComponente++)
            {
                vectorInicial[nroComponente] = Convert.ToDouble(arrayVectorInicial[nroComponente - 1]);
            }

            return vectorInicial;
        }

        private bool verificacionVectorInicial(double[] vectorInicial)
        {
            // Chequeamos que el vector inicial tenga el mismo tamaño que el orden del SEL ingresado
            int cantidadComponentesVInicial = obtenerOrden() + 1; // + 1 por el 0 de ajuste 
            if (vectorInicial.Length != cantidadComponentesVInicial)
            {
                DialogResult msgebox = MessageBox.Show("El tamaño del vector inicial no concuerda con el orden del SEL ingresado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private double[] restaEntreVectores(double[] vectorA, double[] vectorB)
        {
            return vectorA.Zip(vectorB, (vA, vB) => vA - vB).ToArray<double>();
        }

        private double normaInfinitoVectorial(double[] unVector)
        {
            // Primero obtener el módulo de cada elemento del vector
            double[] resultado = unVector.Select(e => Math.Abs(e)).ToArray<double>();

            // Retornamos el máximo elemento del vector 
            return resultado.Max();
        }

        private void mostrarEncabezado(String metodoElegido, double precision, int cantidadVariables)
        {
            string nl = System.Environment.NewLine;
            string espacio = "             ";
            string s1 = "SIEL - TP 2C 2018 - Método elegido: " + metodoElegido + nl;
            string s2 = "Criterio de paro: ||X_n+1 - X_n||_inf < " + precision + nl;
            txtbxoutput.Text = s1 + s2;
            string variables = "";
            for (int i = 1; i <= cantidadVariables; i++)
            {
                variables = variables + "x_" + i + espacio;
            }
            variables = variables + "Error" + nl;
            txtbxoutput.AppendText(variables);

        }

        private void mostrarVector(double[] unVector, double error)
        {
            int longitud = unVector.Length;
            string espacio = "   ";
            string ln = System.Environment.NewLine;
            for(int i=1; i < longitud; i++) // No usamos la posición 0 de los vectores
            {   
                txtbxoutput.AppendText(unVector[i].ToString());
                txtbxoutput.AppendText(espacio);
            }
            
            // En la última columna mostramos el error 
            txtbxoutput.AppendText(error.ToString());

            // Insertamos un salto de línea al terminar de mostrar el vector
            txtbxoutput.AppendText(ln); 
        }

        private double[] redondearVector(double[] unVector, int cantidadDecimales)
        {   
            // Redondeamos cada componente o elemento del vector
            return unVector.Select(e => Math.Round(e, cantidadDecimales)).ToArray<double>();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            DialogResult msgbox = MessageBox.Show("SEL - TP 2C 2018 Matemática Superior - Alumnos: Patronelli, Nicolás; Rodrigues, Tomas; Asorey, Christian", "Acerca de SIEL",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    } // FIN public partial class Form 1

}
