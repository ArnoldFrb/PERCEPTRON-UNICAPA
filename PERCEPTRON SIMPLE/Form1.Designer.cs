namespace PERCEPTRON_SIMPLE
{
    partial class frmPerceptronUnicapa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btEntrenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPesos = new System.Windows.Forms.DataGridView();
            this.lbPesos = new System.Windows.Forms.Label();
            this.lbUmbral = new System.Windows.Forms.Label();
            this.dgvUmbral = new System.Windows.Forms.DataGridView();
            this.chGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvErrorPatron = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUmbralHistorico = new System.Windows.Forms.DataGridView();
            this.lbUmbralHistorico = new System.Windows.Forms.Label();
            this.lbPesosHistorico = new System.Windows.Forms.Label();
            this.dgvPesosHistorico = new System.Windows.Forms.DataGridView();
            this.tbEntradas = new System.Windows.Forms.TextBox();
            this.tbSalidas = new System.Windows.Forms.TextBox();
            this.tbPatrones = new System.Windows.Forms.TextBox();
            this.tbErrorMaximoPermitido = new System.Windows.Forms.TextBox();
            this.tbRataAprendizaje = new System.Windows.Forms.TextBox();
            this.tbNumInteraciones = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.tbUmbral = new System.Windows.Forms.TextBox();
            this.tbPesos = new System.Windows.Forms.TextBox();
            this.tbMatrix = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lbIntera = new System.Windows.Forms.Label();
            this.lbErrorInteracion = new System.Windows.Forms.Label();
            this.btMatriz = new System.Windows.Forms.Button();
            this.btPesos = new System.Windows.Forms.Button();
            this.btUmbral = new System.Windows.Forms.Button();
            this.btLimpiarTodo = new System.Windows.Forms.Button();
            this.btLimpiarSalidas = new System.Windows.Forms.Button();
            this.btLimpiarMatriz = new System.Windows.Forms.Button();
            this.btProbarRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmbral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorPatron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmbralHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesosHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(18, 134);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(830, 176);
            this.dgvMatriz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "MATRIZ";
            // 
            // btEntrenar
            // 
            this.btEntrenar.Location = new System.Drawing.Point(323, 319);
            this.btEntrenar.Name = "btEntrenar";
            this.btEntrenar.Size = new System.Drawing.Size(89, 35);
            this.btEntrenar.TabIndex = 2;
            this.btEntrenar.Text = "ENTRENAR";
            this.btEntrenar.UseVisualStyleBackColor = true;
            this.btEntrenar.Click += new System.EventHandler(this.Entrenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTRADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SALIDAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "PATRONES";
            // 
            // dgvPesos
            // 
            this.dgvPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Location = new System.Drawing.Point(23, 376);
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.Size = new System.Drawing.Size(283, 65);
            this.dgvPesos.TabIndex = 6;
            // 
            // lbPesos
            // 
            this.lbPesos.AutoSize = true;
            this.lbPesos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesos.Location = new System.Drawing.Point(26, 353);
            this.lbPesos.Name = "lbPesos";
            this.lbPesos.Size = new System.Drawing.Size(31, 16);
            this.lbPesos.TabIndex = 7;
            this.lbPesos.Text = "W[]";
            // 
            // lbUmbral
            // 
            this.lbUmbral.AutoSize = true;
            this.lbUmbral.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUmbral.Location = new System.Drawing.Point(326, 353);
            this.lbUmbral.Name = "lbUmbral";
            this.lbUmbral.Size = new System.Drawing.Size(27, 16);
            this.lbUmbral.TabIndex = 8;
            this.lbUmbral.Text = "U[]";
            // 
            // dgvUmbral
            // 
            this.dgvUmbral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUmbral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUmbral.Location = new System.Drawing.Point(323, 376);
            this.dgvUmbral.Name = "dgvUmbral";
            this.dgvUmbral.Size = new System.Drawing.Size(283, 65);
            this.dgvUmbral.TabIndex = 9;
            // 
            // chGrafica
            // 
            chartArea1.Name = "ChartArea1";
            this.chGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGrafica.Legends.Add(legend1);
            this.chGrafica.Location = new System.Drawing.Point(622, 313);
            this.chGrafica.Name = "chGrafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SalidaEntre";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend1";
            series2.Name = "SalidaPrueba";
            series2.YValuesPerPoint = 2;
            this.chGrafica.Series.Add(series1);
            this.chGrafica.Series.Add(series2);
            this.chGrafica.Size = new System.Drawing.Size(447, 300);
            this.chGrafica.TabIndex = 10;
            this.chGrafica.Text = "GRAFICA";
            // 
            // dgvErrorPatron
            // 
            this.dgvErrorPatron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorPatron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorPatron.Location = new System.Drawing.Point(859, 134);
            this.dgvErrorPatron.Name = "dgvErrorPatron";
            this.dgvErrorPatron.Size = new System.Drawing.Size(210, 176);
            this.dgvErrorPatron.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ERROR MAXIMO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "RATA DE APRENDIZAJE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(686, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "N° DE INTERACCIONES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "ENTRADAS Y SALIDAS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(898, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "ERROR DEL PATRON";
            // 
            // dgvUmbralHistorico
            // 
            this.dgvUmbralHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUmbralHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUmbralHistorico.Location = new System.Drawing.Point(323, 464);
            this.dgvUmbralHistorico.Name = "dgvUmbralHistorico";
            this.dgvUmbralHistorico.Size = new System.Drawing.Size(283, 151);
            this.dgvUmbralHistorico.TabIndex = 22;
            // 
            // lbUmbralHistorico
            // 
            this.lbUmbralHistorico.AutoSize = true;
            this.lbUmbralHistorico.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUmbralHistorico.Location = new System.Drawing.Point(326, 446);
            this.lbUmbralHistorico.Name = "lbUmbralHistorico";
            this.lbUmbralHistorico.Size = new System.Drawing.Size(102, 16);
            this.lbUmbralHistorico.TabIndex = 21;
            this.lbUmbralHistorico.Text = "HISTORICO U[]";
            // 
            // lbPesosHistorico
            // 
            this.lbPesosHistorico.AutoSize = true;
            this.lbPesosHistorico.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesosHistorico.Location = new System.Drawing.Point(26, 446);
            this.lbPesosHistorico.Name = "lbPesosHistorico";
            this.lbPesosHistorico.Size = new System.Drawing.Size(106, 16);
            this.lbPesosHistorico.TabIndex = 20;
            this.lbPesosHistorico.Text = "HISTORICO W[]";
            // 
            // dgvPesosHistorico
            // 
            this.dgvPesosHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesosHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesosHistorico.Location = new System.Drawing.Point(23, 464);
            this.dgvPesosHistorico.Name = "dgvPesosHistorico";
            this.dgvPesosHistorico.Size = new System.Drawing.Size(283, 151);
            this.dgvPesosHistorico.TabIndex = 19;
            // 
            // tbEntradas
            // 
            this.tbEntradas.Location = new System.Drawing.Point(488, 26);
            this.tbEntradas.Name = "tbEntradas";
            this.tbEntradas.Size = new System.Drawing.Size(35, 20);
            this.tbEntradas.TabIndex = 23;
            this.tbEntradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEntradas_KeyPress);
            // 
            // tbSalidas
            // 
            this.tbSalidas.Location = new System.Drawing.Point(488, 50);
            this.tbSalidas.Name = "tbSalidas";
            this.tbSalidas.Size = new System.Drawing.Size(35, 20);
            this.tbSalidas.TabIndex = 24;
            this.tbSalidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalidas_KeyPress);
            // 
            // tbPatrones
            // 
            this.tbPatrones.Location = new System.Drawing.Point(488, 74);
            this.tbPatrones.Name = "tbPatrones";
            this.tbPatrones.Size = new System.Drawing.Size(35, 20);
            this.tbPatrones.TabIndex = 25;
            this.tbPatrones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPatrones_KeyPress);
            // 
            // tbErrorMaximoPermitido
            // 
            this.tbErrorMaximoPermitido.Location = new System.Drawing.Point(636, 74);
            this.tbErrorMaximoPermitido.Name = "tbErrorMaximoPermitido";
            this.tbErrorMaximoPermitido.Size = new System.Drawing.Size(35, 20);
            this.tbErrorMaximoPermitido.TabIndex = 28;
            this.tbErrorMaximoPermitido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbErrorMaximoPermitido_KeyPress);
            // 
            // tbRataAprendizaje
            // 
            this.tbRataAprendizaje.Location = new System.Drawing.Point(636, 50);
            this.tbRataAprendizaje.Name = "tbRataAprendizaje";
            this.tbRataAprendizaje.Size = new System.Drawing.Size(35, 20);
            this.tbRataAprendizaje.TabIndex = 27;
            this.tbRataAprendizaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRataAprendizaje_KeyPress);
            // 
            // tbNumInteraciones
            // 
            this.tbNumInteraciones.Location = new System.Drawing.Point(636, 26);
            this.tbNumInteraciones.Name = "tbNumInteraciones";
            this.tbNumInteraciones.Size = new System.Drawing.Size(35, 20);
            this.tbNumInteraciones.TabIndex = 26;
            this.tbNumInteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumInteraciones_KeyPress);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(23, 27);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(117, 43);
            this.btnImportar.TabIndex = 29;
            this.btnImportar.Text = "IMPORTAR EXCEL";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // tbUmbral
            // 
            this.tbUmbral.Location = new System.Drawing.Point(235, 74);
            this.tbUmbral.Name = "tbUmbral";
            this.tbUmbral.Size = new System.Drawing.Size(85, 20);
            this.tbUmbral.TabIndex = 35;
            // 
            // tbPesos
            // 
            this.tbPesos.Location = new System.Drawing.Point(235, 50);
            this.tbPesos.Name = "tbPesos";
            this.tbPesos.Size = new System.Drawing.Size(85, 20);
            this.tbPesos.TabIndex = 34;
            // 
            // tbMatrix
            // 
            this.tbMatrix.Location = new System.Drawing.Point(235, 26);
            this.tbMatrix.Name = "tbMatrix";
            this.tbMatrix.Size = new System.Drawing.Size(85, 20);
            this.tbMatrix.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(339, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "HOJA DEL UMBRAL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(339, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "HOJA DE PESOS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(339, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "HOJA DE LA MATRIZ";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(859, 27);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(89, 35);
            this.btCargar.TabIndex = 36;
            this.btCargar.Text = "CARGAR";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(856, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "* INICIALIZAR VARIABLES Y ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(856, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "PARÁMETROS DE ENTRENAMIENTO ";
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(23, 619);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(1046, 63);
            this.dgvResult.TabIndex = 39;
            // 
            // lbIntera
            // 
            this.lbIntera.AutoSize = true;
            this.lbIntera.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntera.Location = new System.Drawing.Point(18, 320);
            this.lbIntera.Name = "lbIntera";
            this.lbIntera.Size = new System.Drawing.Size(0, 16);
            this.lbIntera.TabIndex = 40;
            // 
            // lbErrorInteracion
            // 
            this.lbErrorInteracion.AutoSize = true;
            this.lbErrorInteracion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorInteracion.Location = new System.Drawing.Point(18, 336);
            this.lbErrorInteracion.Name = "lbErrorInteracion";
            this.lbErrorInteracion.Size = new System.Drawing.Size(0, 16);
            this.lbErrorInteracion.TabIndex = 41;
            // 
            // btMatriz
            // 
            this.btMatriz.Location = new System.Drawing.Point(148, 25);
            this.btMatriz.Name = "btMatriz";
            this.btMatriz.Size = new System.Drawing.Size(76, 23);
            this.btMatriz.TabIndex = 42;
            this.btMatriz.Text = "IMP. HOJA";
            this.btMatriz.UseVisualStyleBackColor = true;
            this.btMatriz.Click += new System.EventHandler(this.btMatriz_Click);
            // 
            // btPesos
            // 
            this.btPesos.Location = new System.Drawing.Point(148, 49);
            this.btPesos.Name = "btPesos";
            this.btPesos.Size = new System.Drawing.Size(76, 23);
            this.btPesos.TabIndex = 43;
            this.btPesos.Text = "IMP. HOJA";
            this.btPesos.UseVisualStyleBackColor = true;
            this.btPesos.Click += new System.EventHandler(this.btPesos_Click);
            // 
            // btUmbral
            // 
            this.btUmbral.Location = new System.Drawing.Point(148, 73);
            this.btUmbral.Name = "btUmbral";
            this.btUmbral.Size = new System.Drawing.Size(76, 23);
            this.btUmbral.TabIndex = 44;
            this.btUmbral.Text = "IMP. HOJA";
            this.btUmbral.UseVisualStyleBackColor = true;
            this.btUmbral.Click += new System.EventHandler(this.btUmbral_Click);
            // 
            // btLimpiarTodo
            // 
            this.btLimpiarTodo.Location = new System.Drawing.Point(518, 343);
            this.btLimpiarTodo.Name = "btLimpiarTodo";
            this.btLimpiarTodo.Size = new System.Drawing.Size(89, 25);
            this.btLimpiarTodo.TabIndex = 45;
            this.btLimpiarTodo.Text = "LIMPIAR TO.";
            this.btLimpiarTodo.UseVisualStyleBackColor = true;
            this.btLimpiarTodo.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btLimpiarSalidas
            // 
            this.btLimpiarSalidas.Location = new System.Drawing.Point(518, 317);
            this.btLimpiarSalidas.Name = "btLimpiarSalidas";
            this.btLimpiarSalidas.Size = new System.Drawing.Size(89, 25);
            this.btLimpiarSalidas.TabIndex = 46;
            this.btLimpiarSalidas.Text = "LIMPIAR SL.";
            this.btLimpiarSalidas.UseVisualStyleBackColor = true;
            this.btLimpiarSalidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLimpiarMatriz
            // 
            this.btLimpiarMatriz.Location = new System.Drawing.Point(718, 108);
            this.btLimpiarMatriz.Name = "btLimpiarMatriz";
            this.btLimpiarMatriz.Size = new System.Drawing.Size(130, 23);
            this.btLimpiarMatriz.TabIndex = 47;
            this.btLimpiarMatriz.Text = "LIMPIAR MATRIZ";
            this.btLimpiarMatriz.UseVisualStyleBackColor = true;
            this.btLimpiarMatriz.Click += new System.EventHandler(this.btLimpiarMatriz_Click);
            // 
            // btProbarRed
            // 
            this.btProbarRed.Location = new System.Drawing.Point(420, 319);
            this.btProbarRed.Name = "btProbarRed";
            this.btProbarRed.Size = new System.Drawing.Size(89, 35);
            this.btProbarRed.TabIndex = 48;
            this.btProbarRed.Text = "PROBAR RED";
            this.btProbarRed.UseVisualStyleBackColor = true;
            this.btProbarRed.Click += new System.EventHandler(this.btProbarRed_Click);
            // 
            // frmPerceptronUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 685);
            this.Controls.Add(this.btProbarRed);
            this.Controls.Add(this.btLimpiarMatriz);
            this.Controls.Add(this.btLimpiarSalidas);
            this.Controls.Add(this.btLimpiarTodo);
            this.Controls.Add(this.btUmbral);
            this.Controls.Add(this.btPesos);
            this.Controls.Add(this.btMatriz);
            this.Controls.Add(this.lbErrorInteracion);
            this.Controls.Add(this.lbIntera);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.tbUmbral);
            this.Controls.Add(this.tbPesos);
            this.Controls.Add(this.tbMatrix);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.tbErrorMaximoPermitido);
            this.Controls.Add(this.tbRataAprendizaje);
            this.Controls.Add(this.tbNumInteraciones);
            this.Controls.Add(this.tbPatrones);
            this.Controls.Add(this.tbSalidas);
            this.Controls.Add(this.tbEntradas);
            this.Controls.Add(this.dgvUmbralHistorico);
            this.Controls.Add(this.lbUmbralHistorico);
            this.Controls.Add(this.lbPesosHistorico);
            this.Controls.Add(this.dgvPesosHistorico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvErrorPatron);
            this.Controls.Add(this.chGrafica);
            this.Controls.Add(this.dgvUmbral);
            this.Controls.Add(this.lbUmbral);
            this.Controls.Add(this.lbPesos);
            this.Controls.Add(this.dgvPesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEntrenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "frmPerceptronUnicapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERCEPTRÓN UNICAPA ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmbral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorPatron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmbralHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesosHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEntrenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPesos;
        private System.Windows.Forms.Label lbPesos;
        private System.Windows.Forms.Label lbUmbral;
        private System.Windows.Forms.DataGridView dgvUmbral;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafica;
        private System.Windows.Forms.DataGridView dgvErrorPatron;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUmbralHistorico;
        private System.Windows.Forms.Label lbUmbralHistorico;
        private System.Windows.Forms.Label lbPesosHistorico;
        private System.Windows.Forms.DataGridView dgvPesosHistorico;
        private System.Windows.Forms.TextBox tbEntradas;
        private System.Windows.Forms.TextBox tbSalidas;
        private System.Windows.Forms.TextBox tbPatrones;
        private System.Windows.Forms.TextBox tbErrorMaximoPermitido;
        private System.Windows.Forms.TextBox tbRataAprendizaje;
        private System.Windows.Forms.TextBox tbNumInteraciones;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox tbUmbral;
        private System.Windows.Forms.TextBox tbPesos;
        private System.Windows.Forms.TextBox tbMatrix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lbIntera;
        private System.Windows.Forms.Label lbErrorInteracion;
        private System.Windows.Forms.Button btMatriz;
        private System.Windows.Forms.Button btPesos;
        private System.Windows.Forms.Button btUmbral;
        private System.Windows.Forms.Button btLimpiarTodo;
        private System.Windows.Forms.Button btLimpiarSalidas;
        private System.Windows.Forms.Button btLimpiarMatriz;
        private System.Windows.Forms.Button btProbarRed;
    }
}

