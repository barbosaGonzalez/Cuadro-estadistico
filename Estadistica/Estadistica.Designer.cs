namespace Estadistica
{
    partial class frmSecundario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtMediana = new System.Windows.Forms.TextBox();
            this.txtModa = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.lsbDesordenada = new System.Windows.Forms.ListBox();
            this.lblDesordenada = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvCuadro_Estadistico = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblOrdenada = new System.Windows.Forms.Label();
            this.lsbOrdenada = new System.Windows.Forms.ListBox();
            this.lblSumatoria = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.txtSumatoria = new System.Windows.Forms.TextBox();
            this.GraficaHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficaPasteles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficaPoligonal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.txtCoeficiente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesviacionMedia = new System.Windows.Forms.TextBox();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadro_Estadistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPasteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPoligonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(242, 535);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(178, 18);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Media Aritmetica:";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediana.Location = new System.Drawing.Point(242, 559);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(88, 18);
            this.lblMediana.TabIndex = 3;
            this.lblMediana.Text = "Mediana:";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(549, 662);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(58, 18);
            this.lblModa.TabIndex = 4;
            this.lblModa.Text = "Moda:";
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacion.Location = new System.Drawing.Point(539, 563);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(188, 18);
            this.lblDesviacion.TabIndex = 6;
            this.lblDesviacion.Text = "Desviacion Tipica:";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.Location = new System.Drawing.Point(539, 537);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(98, 18);
            this.lblVarianza.TabIndex = 5;
            this.lblVarianza.Text = "Varianza:";
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(436, 529);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 26);
            this.txtMedia.TabIndex = 7;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMediana
            // 
            this.txtMediana.Enabled = false;
            this.txtMediana.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediana.Location = new System.Drawing.Point(436, 555);
            this.txtMediana.Name = "txtMediana";
            this.txtMediana.Size = new System.Drawing.Size(100, 26);
            this.txtMediana.TabIndex = 8;
            this.txtMediana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtModa
            // 
            this.txtModa.Enabled = false;
            this.txtModa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModa.Location = new System.Drawing.Point(733, 659);
            this.txtModa.Name = "txtModa";
            this.txtModa.Size = new System.Drawing.Size(154, 26);
            this.txtModa.TabIndex = 9;
            // 
            // txtVarianza
            // 
            this.txtVarianza.Enabled = false;
            this.txtVarianza.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarianza.Location = new System.Drawing.Point(733, 529);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.Size = new System.Drawing.Size(100, 26);
            this.txtVarianza.TabIndex = 10;
            this.txtVarianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Enabled = false;
            this.txtDesviacion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacion.Location = new System.Drawing.Point(733, 555);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(100, 26);
            this.txtDesviacion.TabIndex = 11;
            this.txtDesviacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lsbDesordenada
            // 
            this.lsbDesordenada.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDesordenada.FormattingEnabled = true;
            this.lsbDesordenada.ItemHeight = 18;
            this.lsbDesordenada.Location = new System.Drawing.Point(15, 46);
            this.lsbDesordenada.Name = "lsbDesordenada";
            this.lsbDesordenada.Size = new System.Drawing.Size(92, 634);
            this.lsbDesordenada.TabIndex = 12;
            // 
            // lblDesordenada
            // 
            this.lblDesordenada.AutoSize = true;
            this.lblDesordenada.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesordenada.Location = new System.Drawing.Point(12, 9);
            this.lblDesordenada.Name = "lblDesordenada";
            this.lblDesordenada.Size = new System.Drawing.Size(128, 36);
            this.lblDesordenada.TabIndex = 13;
            this.lblDesordenada.Text = "Lista\r\nDesordenada:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(354, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(148, 18);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Agregar Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(509, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 15;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // dgvCuadro_Estadistico
            // 
            this.dgvCuadro_Estadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuadro_Estadistico.Enabled = false;
            this.dgvCuadro_Estadistico.Location = new System.Drawing.Point(334, 36);
            this.dgvCuadro_Estadistico.Name = "dgvCuadro_Estadistico";
            this.dgvCuadro_Estadistico.Size = new System.Drawing.Size(844, 267);
            this.dgvCuadro_Estadistico.TabIndex = 18;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(670, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(128, 18);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "Hora y Fecha";
            // 
            // lblOrdenada
            // 
            this.lblOrdenada.AutoSize = true;
            this.lblOrdenada.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenada.Location = new System.Drawing.Point(164, 9);
            this.lblOrdenada.Name = "lblOrdenada";
            this.lblOrdenada.Size = new System.Drawing.Size(88, 36);
            this.lblOrdenada.TabIndex = 20;
            this.lblOrdenada.Text = "Lista\r\nOrdenada";
            // 
            // lsbOrdenada
            // 
            this.lsbOrdenada.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOrdenada.FormattingEnabled = true;
            this.lsbOrdenada.ItemHeight = 18;
            this.lsbOrdenada.Location = new System.Drawing.Point(146, 43);
            this.lsbOrdenada.Name = "lsbOrdenada";
            this.lsbOrdenada.Size = new System.Drawing.Size(92, 634);
            this.lsbOrdenada.TabIndex = 21;
            // 
            // lblSumatoria
            // 
            this.lblSumatoria.AutoSize = true;
            this.lblSumatoria.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumatoria.Location = new System.Drawing.Point(242, 611);
            this.lblSumatoria.Name = "lblSumatoria";
            this.lblSumatoria.Size = new System.Drawing.Size(108, 18);
            this.lblSumatoria.TabIndex = 22;
            this.lblSumatoria.Text = "Sumatoria:";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.Location = new System.Drawing.Point(539, 589);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(68, 18);
            this.lblRango.TabIndex = 23;
            this.lblRango.Text = "Rango:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(539, 615);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(178, 18);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total de Muestra:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1213, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1213, 154);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 31);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMuestra
            // 
            this.txtMuestra.Enabled = false;
            this.txtMuestra.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuestra.Location = new System.Drawing.Point(733, 607);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(100, 26);
            this.txtMuestra.TabIndex = 30;
            this.txtMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRango
            // 
            this.txtRango.Enabled = false;
            this.txtRango.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRango.Location = new System.Drawing.Point(733, 581);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(100, 26);
            this.txtRango.TabIndex = 31;
            this.txtRango.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumatoria
            // 
            this.txtSumatoria.Enabled = false;
            this.txtSumatoria.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumatoria.Location = new System.Drawing.Point(436, 607);
            this.txtSumatoria.Name = "txtSumatoria";
            this.txtSumatoria.Size = new System.Drawing.Size(100, 26);
            this.txtSumatoria.TabIndex = 32;
            this.txtSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GraficaHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficaHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaHistograma.Legends.Add(legend1);
            this.GraficaHistograma.Location = new System.Drawing.Point(1058, 309);
            this.GraficaHistograma.Name = "GraficaHistograma";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Frecuencia";
            this.GraficaHistograma.Series.Add(series1);
            this.GraficaHistograma.Size = new System.Drawing.Size(301, 376);
            this.GraficaHistograma.TabIndex = 35;
            this.GraficaHistograma.Text = "chart1";
            // 
            // GraficaPasteles
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficaPasteles.ChartAreas.Add(chartArea2);
            this.GraficaPasteles.Enabled = false;
            legend2.Name = "Legend1";
            this.GraficaPasteles.Legends.Add(legend2);
            this.GraficaPasteles.Location = new System.Drawing.Point(272, 309);
            this.GraficaPasteles.Name = "GraficaPasteles";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Grados";
            this.GraficaPasteles.Series.Add(series2);
            this.GraficaPasteles.Size = new System.Drawing.Size(284, 214);
            this.GraficaPasteles.TabIndex = 36;
            this.GraficaPasteles.Text = "chart1";
            // 
            // GraficaPoligonal
            // 
            chartArea3.Name = "ChartArea1";
            this.GraficaPoligonal.ChartAreas.Add(chartArea3);
            this.GraficaPoligonal.Enabled = false;
            legend3.Name = "Legend1";
            this.GraficaPoligonal.Legends.Add(legend3);
            this.GraficaPoligonal.Location = new System.Drawing.Point(562, 309);
            this.GraficaPoligonal.Name = "GraficaPoligonal";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Frecuencia";
            this.GraficaPoligonal.Series.Add(series3);
            this.GraficaPoligonal.Size = new System.Drawing.Size(490, 215);
            this.GraficaPoligonal.TabIndex = 37;
            this.GraficaPoligonal.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Intervalo de Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Coef. de Variación:";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Enabled = false;
            this.txtIntervalo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalo.Location = new System.Drawing.Point(436, 633);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(100, 26);
            this.txtIntervalo.TabIndex = 40;
            this.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCoeficiente
            // 
            this.txtCoeficiente.Enabled = false;
            this.txtCoeficiente.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoeficiente.Location = new System.Drawing.Point(733, 633);
            this.txtCoeficiente.Name = "txtCoeficiente";
            this.txtCoeficiente.Size = new System.Drawing.Size(100, 26);
            this.txtCoeficiente.TabIndex = 41;
            this.txtCoeficiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Desviacion Media:";
            // 
            // txtDesviacionMedia
            // 
            this.txtDesviacionMedia.Enabled = false;
            this.txtDesviacionMedia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacionMedia.Location = new System.Drawing.Point(436, 659);
            this.txtDesviacionMedia.Name = "txtDesviacionMedia";
            this.txtDesviacionMedia.Size = new System.Drawing.Size(100, 26);
            this.txtDesviacionMedia.TabIndex = 43;
            this.txtDesviacionMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Enabled = false;
            this.txtAlcance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlcance.Location = new System.Drawing.Point(436, 581);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(100, 26);
            this.txtAlcance.TabIndex = 44;
            this.txtAlcance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Alcance:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Enabled = false;
            this.txtMinimo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.Location = new System.Drawing.Point(952, 527);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 26);
            this.txtMinimo.TabIndex = 47;
            this.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Minimo:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(952, 553);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtMaximo.TabIndex = 49;
            this.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(839, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Maximo:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSecundario
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1338, 689);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.txtDesviacionMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoeficiente);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraficaPoligonal);
            this.Controls.Add(this.GraficaPasteles);
            this.Controls.Add(this.GraficaHistograma);
            this.Controls.Add(this.txtSumatoria);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblSumatoria);
            this.Controls.Add(this.lsbOrdenada);
            this.Controls.Add(this.lblOrdenada);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dgvCuadro_Estadistico);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDesordenada);
            this.Controls.Add(this.lsbDesordenada);
            this.Controls.Add(this.txtDesviacion);
            this.Controls.Add(this.txtVarianza);
            this.Controls.Add(this.txtModa);
            this.Controls.Add(this.txtMediana);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblDesviacion);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblMedia);
            this.Name = "frmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cuadro Estadistico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadro_Estadistico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPasteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPoligonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtMediana;
        private System.Windows.Forms.TextBox txtModa;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.ListBox lsbDesordenada;
        private System.Windows.Forms.Label lblDesordenada;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvCuadro_Estadistico;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblOrdenada;
        private System.Windows.Forms.ListBox lsbOrdenada;
        private System.Windows.Forms.Label lblSumatoria;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.TextBox txtSumatoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaPasteles;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaPoligonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.TextBox txtCoeficiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesviacionMedia;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;

    }
}

