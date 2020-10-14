using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PERCEPTRON_SIMPLE
{
    public partial class frmPerceptronUnicapa : Form
    {

        ///////////////////////////////////////////////////////////////////////////
        // DECLARACION DE VARIABLES
        ///////////////////////////////////////////////////////////////////////////

        //PATRON
        private int[] patronXi;
        private int[] patronYDi;

        //PESOS Y UMBRALES
        private double[,] historicoPesos;
        private double[] historicoUmbrales;
        private int N, M, patrones;

        //FUNCION SOMA
        private double[] salida;

        //ERROR LINEAL
        private int[] errorLineal;

        //ESCALON
        private int[] YR;

        //ERROR DE PATRON
        private double[] errorPatron;

        //PARAMETROS DE ENTRENAMIENTO
        private int numeroInteraciones, rataAprendizaje;
        private double errorMaximoPermitido, error_Interaccion = 0;

        private double[] graficarSAlida;

        ///////////////////////////////////////////////////////////////////////////
        // MAIN
        ///////////////////////////////////////////////////////////////////////////

        public frmPerceptronUnicapa()
        {
            InitializeComponent();

            //DESABILITAR BUTTON
            btCargar.Enabled = false;
            btEntrenar.Enabled = false;
            btProbarRed.Enabled = false;

            //NOMBRE DE LAS HOJAS EN EL EXCEL
            tbMatrix.Text = "MATRIX";
            tbPesos.Text = "PESOS";
            tbUmbral.Text = "UMBRAL";

            //TEMPORAL
            tbNumInteraciones.Text = "1";
            tbRataAprendizaje.Text = "1";
            tbErrorMaximoPermitido.Text = "0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        ///////////////////////////////////////////////////////////////////////////
        // CONFIGURACION TEXTBOX
        ///////////////////////////////////////////////////////////////////////////

        //TEXTBOX NUMERICO
        private void tbEntradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TEXTBOX NUMERICO
        private void tbSalidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TEXTBOX NUMERICO
        private void tbPatrones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TEXTBOX NUMERICO
        private void tbNumInteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TEXTBOX NUMERICO
        private void tbRataAprendizaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TEXTBOX DECIMAL
        private void tbErrorMaximoPermitido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        ///////////////////////////////////////////////////////////////////////////
        // LLENAR DATA GRID VIEW Y LIMPIAR
        ///////////////////////////////////////////////////////////////////////////

        //LLENAR DATAGRIDVIEWS A TRAVES DE EXCEL
        private void btnImportar_Click(object sender, EventArgs e)
        {
            //LLENAR DATAGRIDVIEWS MATRIZ
            new Import().ImportExcel(dgvMatriz, tbMatrix.Text);

            //LLENAR DATAGRIDVIEWS PESOS
            new Import().ImportExcel(dgvPesos, tbPesos.Text);

            //LLENAR DATAGRIDVIEWS UMBRAL
            new Import().ImportExcel(dgvUmbral, tbUmbral.Text);

            //INICIALIZAR ENTRADAS
            tbEntradas.Text = dgvPesos.ColumnCount.ToString();

            //INICIALIZAR SALIDAS
            tbSalidas.Text = (int.Parse(dgvPesos.RowCount.ToString()) - 1).ToString();

            //INICIALIZAR PATRONES
            tbPatrones.Text = (int.Parse(dgvMatriz.RowCount.ToString()) - 1).ToString();

            //HABILITAR BUTTON CARGAR
            btCargar.Enabled = true;
        }

        //LLENAR DATAGRIDVIEWS MATRIZ HOJA DE EXCEL
        private void btMatriz_Click(object sender, EventArgs e)
        {
            new Import().ImportExcel(dgvMatriz, tbMatrix.Text);

            //INICIALIZAR PATRONES
            tbPatrones.Text = (int.Parse(dgvMatriz.RowCount.ToString()) - 1).ToString();

            //HABILITAR BUTTON CARGAR
            btCargar.Enabled = true;
        }

        //LLENAR DATAGRIDVIEWS PESOS HOJA DE EXCEL
        private void btPesos_Click(object sender, EventArgs e)
        {
            new Import().ImportExcel(dgvPesos, tbPesos.Text);

            //HABILITAR BUTTON CARGAR
            btCargar.Enabled = true;
        }

        //LLENAR DATAGRIDVIEWS UMBRAL HOJA DE EXCEL
        private void btUmbral_Click(object sender, EventArgs e)
        {
            new Import().ImportExcel(dgvUmbral, tbUmbral.Text);

            //HABILITAR BUTTON CARGAR
            btCargar.Enabled = true;
        }

        // FUNCION PARA LLENAR DGV PESO
        private void llenar_dgvPesosH(int COL, int ROW, double[,] w)
        {
            dgvPesosHistorico.ColumnCount = COL;
            dgvPesosHistorico.RowCount = ROW;

            for (int I = 0; I < ROW; I++)
            {
                int Q = 1;
                for (int J = 0; J < COL; J++)
                {
                    dgvPesosHistorico.Rows[I].Cells[J].Value = w[I, J];
                    Q = Q + J;
                    dgvPesosHistorico.Columns[J].HeaderText = "W" + Q;
                }
            }
        }

        // FUNCION PARA LLENAR DGV UMBRAL
        private void llenar_dgvUmbralH(int COL, int ROW, double[] u)
        {
            dgvUmbralHistorico.ColumnCount = COL;
            dgvUmbralHistorico.RowCount = ROW;

            for (int I = 0; I < ROW; I++)
            {
                int Q = 1;
                for (int J = 0; J < COL; J++)
                {
                    dgvUmbralHistorico.Rows[I].Cells[J].Value = u[I];
                    Q = Q + J;
                    dgvUmbralHistorico.Columns[J].HeaderText = "U" + Q;
                }
            }
        }

        // FUNCION PARA LLENAR DGV ERROR DE PATRON
        private void llenar_dgvErrorPatron(int COL, int ROW, int[] ep)
        {
            dgvErrorPatron.ColumnCount = COL;
            dgvErrorPatron.RowCount = ROW;

            for (int I = 0; I < ROW; I++)
            {
                for (int J = 0; J < COL; J++)
                {
                    dgvErrorPatron.Rows[I].Cells[J].Value = ep[I];
                    dgvErrorPatron.Columns[J].HeaderText = "ERROR PATRON";
                }
            }
        }

        //LIMPIAR DATAGRIDVIEWS
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            dgvMatriz.DataSource = null;
            dgvPesos.DataSource = null;
            dgvUmbral.DataSource = null;
            dgvPesosHistorico.Rows.Clear();
            dgvUmbralHistorico.Rows.Clear();
            dgvErrorPatron.Rows.Clear();
            dgvResult.Rows.Clear();

        }

        //LIMPIAR DATAGRIDVIEWS DE SALIDAS 
        private void button1_Click(object sender, EventArgs e)
        {
            dgvPesosHistorico.Rows.Clear();
            dgvUmbralHistorico.Rows.Clear();
            dgvErrorPatron.Rows.Clear();
            dgvResult.Rows.Clear();
        }

        //LIMPIAR DATAGRIDVIEW MATRIZ
        private void btLimpiarMatriz_Click(object sender, EventArgs e)
        {
            dgvMatriz.DataSource = null;
        }

        ////////////////////////////////////////////////////////////////////////////
        // LLENAR INICALIZAR VARIABLES
        ///////////////////////////////////////////////////////////////////////////

        //INICIALIZAR VARIABLES Y PARÁMETROS DE ENTRENAMIENTO 
        private void btCargar_Click(object sender, EventArgs e)
        {
            //VALIDAR DATOS EN TAXTBOX ENTRADAS
            if (string.IsNullOrEmpty(tbEntradas.Text))
            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //VALIDAR DATOS EN TAXTBOX SALIDAS
            if (string.IsNullOrEmpty(tbSalidas.Text))
            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //VALIDAR DATOS EN TAXTBOX PATRONES
            if (string.IsNullOrEmpty(tbPatrones.Text))
            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //VALIDAR DATOS EN TAXTBOX NUMERO DE INTERACIONES
            if (string.IsNullOrEmpty(tbNumInteraciones.Text))

            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //VALIDAR DATOS EN TAXTBOX RATA DE APRENDIZAJE
            if (string.IsNullOrEmpty(tbRataAprendizaje.Text))
            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //VALIDAR DATOS EN TAXTBOX ERROR MAXIMO PERMITIDO
            if (string.IsNullOrEmpty(tbErrorMaximoPermitido.Text))
            {
                MessageBox.Show("LLENE TODOS LOS DATOS");

                return;
            }

            //CARGAR VARIABLES
            M = int.Parse(tbEntradas.Text);
            N = int.Parse(tbSalidas.Text);
            patrones = int.Parse(tbPatrones.Text);
            numeroInteraciones = int.Parse(tbNumInteraciones.Text);
            rataAprendizaje = int.Parse(tbRataAprendizaje.Text);
            errorMaximoPermitido = double.Parse(tbErrorMaximoPermitido.Text);

            //MOSTRAR EN LABELS PARA PESOS
            lbPesos.Text = "W[" + tbEntradas.Text + "," + tbSalidas.Text + "]";
            lbPesosHistorico.Text = "HISTORICO W[" + tbEntradas.Text + "," + tbSalidas.Text + "]";

            //MOSTRAR EN LABELS PARA UMBRAL
            lbUmbral.Text = "U[" + tbSalidas.Text + "]";
            lbUmbralHistorico.Text = "HISTORICO U[" + tbSalidas.Text + "]";

            //HABILITAR BUTTON ENTRENAR

            if (btEntrenar.Enabled == false && btProbarRed.Enabled == false)
            {
                btEntrenar.Enabled = true;
            }
            else
            {
                btEntrenar.Enabled = false;
                btProbarRed.Enabled = true;
            }
        }


        ////////////////////////////////////////////////////////////////////////////
        // FUNCINES PARA ENTRENAR LA NEURONA
        ////////////////////////////////////////////////////////////////////////////

        //FUNCION ESCALON
        private int escalon(double salidaE)
        {
            if (salidaE >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        // FUNCION SOMA
        private double funcion_Soma(double peso, int patronx)
        {
            return peso * patronx;
        }

        //FUNCION PARA CALCULAR EL ERROR LINIEL
        private int error_Lineal(int yd, int yr)
        {
            return yd - yr;
        }

        //FUNCION PARA CALCULAR LOS PESOS
        private double calcular_Pesos(double peso, double erLineal, int rataApren, int patronx)
        {
            return peso + (rataApren * erLineal * patronx);
        }

        //FUNCION PARA CALCULAR LAS SALIDAS
        private double Calcular_Salidas(double peso, double erLineal, int rataApren, int xo)
        {
            return peso + (rataApren * erLineal * xo);
        }


        ////////////////////////////////////////////////////////////////////////////
        // REGLA DELTA O ALGORITMO PARA ENTRENAR NEURONA
        ////////////////////////////////////////////////////////////////////////////

        //FUNCION DEL ENTRENAMIENTO PARA LA NEURONA O REGLA DELTA
        private void Entrenar_Click(object sender, EventArgs e)
        {
            //INICIALIZAR VARIABLES
            patronXi = new int[M];
            patronYDi = new int[N];
            errorPatron = new double[patrones];
            historicoPesos = new double[patrones, M];
            historicoUmbrales = new double[patrones];
            graficarSAlida = new double[patrones];

            for (int i = 0; i < patrones; i++)
            {
                errorPatron[i] = 0;
            }

            int interaciones = 0;

            do
            {
                //OPERACIONES PARA
                for (int i = 0; i < patrones; i++)
                {
                    //TOMAR PATRONES DE LA MATRIZ
                    int ii = 0;
                    for (int x = 0; x < M + N; x++)
                    {
                        if (x < M)
                        {
                            patronXi[x] = int.Parse(dgvMatriz.Rows[i].Cells[x].Value.ToString());
                        }
                        if (x >= M)
                        {
                            patronYDi[ii] = int.Parse(dgvMatriz.Rows[i].Cells[x].Value.ToString());
                            ii++;
                        }
                    }

                    //INICIALIZAMOS LA SALIDA EN CERO
                    salida = new double[N];

                    for (int k = 0; k < N; k++)
                    {
                        salida[k] = 0;
                    }

                    //CALCULAR SALIDA DE LA FUNCION SOMA
                    for (int k = 0; k < N; k++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            salida[k] = salida[k] + funcion_Soma(double.Parse(dgvPesos.Rows[k].Cells[j].Value.ToString()), patronXi[j]);
                        }
                        salida[k] = salida[k] - double.Parse(dgvUmbral.Rows[k].Cells[0].Value.ToString());
                        graficarSAlida[i] = salida[k];
                    }

                    //CALCULAMOS LA FUNCION ESCALON
                    YR = new int[N];

                    for (int k = 0; k < N; k++)
                    {
                        YR[k] = escalon(salida[k]);
                    }

                    //CALCULAMOS EL ERROR LINEAL
                    errorLineal = new int[N];

                    for (int k = 0; k < N; k++)
                    {
                        errorLineal[k] = patronYDi[k] - YR[k];
                    }

                    //CALCULAMOS EL ERROR DEL PATRON
                    for (int k = 0; k < N; k++)
                    {
                        errorPatron[i] = errorPatron[i] + Math.Abs(errorLineal[k]);
                    }

                    errorPatron[i] = errorPatron[i] / N;

                    //CARGAR PESOS HISTORICO
                    for (int k = 0; k < N; k++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            historicoPesos[i, j] = double.Parse(dgvPesos.Rows[k].Cells[j].Value.ToString());
                        }
                    }

                    //MODIFICA PESOS
                    for (int k = 0; k < N; k++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            dgvPesos.Rows[k].Cells[j].Value = calcular_Pesos(double.Parse(dgvPesos.Rows[k].Cells[j].Value.ToString()), errorLineal[k], rataAprendizaje, patronXi[j]);
                        }
                    }

                    //CARGAR UMBRAL HISTORICO
                    for (int k = 0; k < N; k++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            historicoUmbrales[i] = double.Parse(dgvUmbral.Rows[k].Cells[0].Value.ToString());
                        }
                    }


                    //MODIFICA UMBRAL
                    for (int k = 0; k < N; k++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            dgvUmbral.Rows[k].Cells[0].Value = Calcular_Salidas(double.Parse(dgvUmbral.Rows[k].Cells[0].Value.ToString()), errorLineal[k], rataAprendizaje, 1);
                        }
                    }
                }

                //GRAFICAR SALIDAS
                int[] graficarX = new int[patrones];
                int[] graficarY = new int[patrones];

                for (int i = 0; i < patrones; i++)
                {
                    for (int j = 0; j < M + N; j++)
                    {
                        graficarX[i] = int.Parse(dgvMatriz.Rows[i].Cells[0].Value.ToString());
                        graficarY[i] = int.Parse(dgvMatriz.Rows[i].Cells[1].Value.ToString());
                    }
                }

                for (int i = 0; i < patrones; i++) 
                {
                    chGrafica.Series["SalidaEntre"].Points.AddXY(graficarX[i], graficarY[i]);
                }

                //CALCULAR ERROR INTERACCION
                error_Interaccion = 0;

                for (int s = 0; s < patrones; s++)
                {
                    error_Interaccion = error_Interaccion + errorPatron[s];
                }

                error_Interaccion = error_Interaccion / patrones;

                //MOSTRAR ERROR DE INTERACCION EN LABEL
                lbErrorInteracion.Text = "ERROR INT: " + error_Interaccion.ToString();

                //MOSTRAR RESULTADOS EB DATARIDVIEW
                int cells = 4 + N + M;

                dgvResult.ColumnCount = cells;
                dgvResult.RowCount = N;

                int xi = 0, ydi = 0;
                for (int s = 0; s < cells; s++)
                {
                    if (s < M)
                    {
                        xi++;
                        dgvResult.Columns[s].HeaderText = "X" + xi;
                    }

                    if (s >= M && s < M+N)
                    {
                        ydi++;
                        dgvResult.Columns[s].HeaderText = "YD" + ydi;
                    }
                }

                dgvResult.Columns[N + M].HeaderText = "FSOMA";
                dgvResult.Columns[N + M + 1].HeaderText = "ESCALON";
                dgvResult.Columns[N + M + 2].HeaderText = "E_LINEAL";
                dgvResult.Columns[N + M + 3].HeaderText = "E_PATRON";
                int kx = 0, ky = 0;

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < cells; j++)
                    {
                        if (j < M)
                        {
                            dgvResult.Rows[i].Cells[j].Value = patronXi[kx];
                            kx++;
                        }

                        if (j >= M && j < M + N)
                        {
                            dgvResult.Rows[i].Cells[j].Value = patronYDi[ky];
                            ky++;
                        }

                        if (j ==  M + N )
                        {
                            dgvResult.Rows[i].Cells[j].Value = salida[i];
                        }

                        if (j == M + N + 1)
                        {
                            dgvResult.Rows[i].Cells[j].Value = YR[i];
                        }

                        if (j == M + N + 2)
                        {
                            dgvResult.Rows[i].Cells[j].Value = errorLineal[i];
                        }

                        if (j == M + N + 3)
                        {
                            dgvResult.Rows[i].Cells[j].Value = errorPatron[patrones - 1];
                        }
                    }
                }

                if ( N == 1 )
                {
                    //CARGAR DATAGRIDVIEW PESOS HISTORICOS
                    llenar_dgvPesosH(M, patrones, historicoPesos);

                    //CARGAR DATAGRIDVIEW UMBRALES HISTORICOS
                    llenar_dgvUmbralH(1, patrones, historicoUmbrales);
                }
                
                //CARGAR DATAGRIDVIEW ERROR PATRONES
                //llenar_dgvErrorPatron(1, patrones, errorPatron);

                //MOSTRAR INTERACCION EN LABEL
                lbIntera.Text = "INTERACCIONES: " + (interaciones + 1).ToString();

                interaciones++;

            } while (interaciones < numeroInteraciones);
        }

        //PROBAR NEURONAS
        private void btProbarRed_Click(object sender, EventArgs e)
        {
            patronXi = new int[M];
            YR = new int[patrones];

            for (int i = 0; i < patrones; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    patronXi[j] = int.Parse(dgvMatriz.Rows[i].Cells[j].Value.ToString());
                }

                //INICIALIZAMOS LA SALIDA EN CERO
                salida = new double[N];

                for (int k = 0; k < N; k++)
                {
                    salida[k] = 0;
                }

                //CALCULAR SALIDA DE LA FUNCION SOMA
                for (int k = 0; k < N; k++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        salida[k] = salida[k] + funcion_Soma(double.Parse(dgvPesos.Rows[k].Cells[j].Value.ToString()), patronXi[j]);
                    }
                    salida[k] = salida[k] - double.Parse(dgvUmbral.Rows[k].Cells[0].Value.ToString());
                    graficarSAlida[i] = salida[k];
                }

                //CALCULAMOS LA FUNCION ESCALON
                for (int k = 0; k < N; k++)
                {
                    YR[i] = escalon(salida[k]);
                }
            }

            //GRAFICAR PRUEBA
            for (int i = 0; i < patrones; i++)
            {
                chGrafica.Series["SalidaPrueba"].Points.AddXY(YR[i],YR[i]);
            }

            dgvErrorPatron.Rows.Clear();

            llenar_dgvErrorPatron(N, patrones, YR);
        }
    }
}
