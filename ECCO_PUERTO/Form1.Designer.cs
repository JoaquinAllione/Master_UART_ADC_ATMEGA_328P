namespace ECCO_PUERTO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_ayuda = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_titulo_ayuda = new System.Windows.Forms.Label();
            this.ayuda = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.chart_ADC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView_ADC = new System.Windows.Forms.DataGridView();
            this.Muestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_ADC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtADC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_instruccion = new System.Windows.Forms.Button();
            this.panel_controles = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.cbxPuertos = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.timer_env_datos = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_conectado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ADC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADC)).BeginInit();
            this.panel_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_conectado);
            this.panel1.Controls.Add(this.panel_ayuda);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btn_detener);
            this.panel1.Controls.Add(this.chart_ADC);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dataGridView_ADC);
            this.panel1.Controls.Add(this.txtADC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_instruccion);
            this.panel1.Controls.Add(this.panel_controles);
            this.panel1.Controls.Add(this.cbxPuertos);
            this.panel1.Controls.Add(this.cbxBaudRate);
            this.panel1.Controls.Add(this.txtDatosRecibidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDesconectar);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 377);
            this.panel1.TabIndex = 24;
            // 
            // panel_ayuda
            // 
            this.panel_ayuda.Controls.Add(this.textBox2);
            this.panel_ayuda.Controls.Add(this.textBox1);
            this.panel_ayuda.Controls.Add(this.label_titulo_ayuda);
            this.panel_ayuda.Controls.Add(this.ayuda);
            this.panel_ayuda.Location = new System.Drawing.Point(596, 199);
            this.panel_ayuda.Name = "panel_ayuda";
            this.panel_ayuda.Size = new System.Drawing.Size(238, 178);
            this.panel_ayuda.TabIndex = 50;
            this.panel_ayuda.MouseLeave += new System.EventHandler(this.panel_ayuda_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(16, 88);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 70);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Las conversiones se realizan cada T mSeg, siendo dicho tiempo (por defecto) de 10" +
    "0mSeg.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(16, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 70);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Permite establecer una conexión serie con un microcontrolador a fín de obtener lo" +
    "s valores de una conversión ADC de 10 bits.";
            // 
            // label_titulo_ayuda
            // 
            this.label_titulo_ayuda.AutoSize = true;
            this.label_titulo_ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_ayuda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_titulo_ayuda.Location = new System.Drawing.Point(93, 4);
            this.label_titulo_ayuda.Name = "label_titulo_ayuda";
            this.label_titulo_ayuda.Size = new System.Drawing.Size(60, 16);
            this.label_titulo_ayuda.TabIndex = 1;
            this.label_titulo_ayuda.Text = "AYUDA";
            // 
            // ayuda
            // 
            this.ayuda.Image = ((System.Drawing.Image)(resources.GetObject("ayuda.Image")));
            this.ayuda.Location = new System.Drawing.Point(3, 3);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(15, 17);
            this.ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ayuda.TabIndex = 0;
            this.ayuda.TabStop = false;
            this.ayuda.Click += new System.EventHandler(this.ayuda_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.Location = new System.Drawing.Point(319, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_detener.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_detener.FlatAppearance.BorderSize = 0;
            this.btn_detener.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_detener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_detener.Location = new System.Drawing.Point(126, 324);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(88, 23);
            this.btn_detener.TabIndex = 48;
            this.btn_detener.Text = "DETENER";
            this.btn_detener.UseVisualStyleBackColor = false;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // chart_ADC
            // 
            this.chart_ADC.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.Title = "Muestras";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 1024D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisY.Title = "Valor ADC";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart_ADC.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_ADC.Legends.Add(legend1);
            this.chart_ADC.Location = new System.Drawing.Point(413, 33);
            this.chart_ADC.Name = "chart_ADC";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.Legend = "Legend1";
            series1.Name = "VALOR_ADC";
            this.chart_ADC.Series.Add(series1);
            this.chart_ADC.Size = new System.Drawing.Size(409, 327);
            this.chart_ADC.TabIndex = 47;
            this.chart_ADC.Text = "chart_ADC";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.Location = new System.Drawing.Point(222, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView_ADC
            // 
            this.dataGridView_ADC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ADC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ADC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ADC.ColumnHeadersHeight = 25;
            this.dataGridView_ADC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ADC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Muestra,
            this.Valor_ADC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ADC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ADC.EnableHeadersVisualStyles = false;
            this.dataGridView_ADC.Location = new System.Drawing.Point(29, 199);
            this.dataGridView_ADC.Name = "dataGridView_ADC";
            this.dataGridView_ADC.RowHeadersVisible = false;
            this.dataGridView_ADC.Size = new System.Drawing.Size(378, 114);
            this.dataGridView_ADC.TabIndex = 44;
            // 
            // Muestra
            // 
            this.Muestra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Muestra.HeaderText = "Muesta";
            this.Muestra.Name = "Muestra";
            this.Muestra.ReadOnly = true;
            // 
            // Valor_ADC
            // 
            this.Valor_ADC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor_ADC.HeaderText = "Valor ADC";
            this.Valor_ADC.Name = "Valor_ADC";
            this.Valor_ADC.ReadOnly = true;
            // 
            // txtADC
            // 
            this.txtADC.BackColor = System.Drawing.Color.White;
            this.txtADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtADC.Location = new System.Drawing.Point(157, 158);
            this.txtADC.Name = "txtADC";
            this.txtADC.ReadOnly = true;
            this.txtADC.Size = new System.Drawing.Size(250, 22);
            this.txtADC.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Valor ADC leido:";
            // 
            // btn_instruccion
            // 
            this.btn_instruccion.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_instruccion.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_instruccion.FlatAppearance.BorderSize = 0;
            this.btn_instruccion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_instruccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_instruccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instruccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_instruccion.Location = new System.Drawing.Point(29, 324);
            this.btn_instruccion.Name = "btn_instruccion";
            this.btn_instruccion.Size = new System.Drawing.Size(88, 23);
            this.btn_instruccion.TabIndex = 37;
            this.btn_instruccion.Text = "INICIAR";
            this.btn_instruccion.UseVisualStyleBackColor = false;
            this.btn_instruccion.Click += new System.EventHandler(this.btn_instruccion_Click);
            // 
            // panel_controles
            // 
            this.panel_controles.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_controles.Controls.Add(this.label5);
            this.panel_controles.Controls.Add(this.button_minimizar);
            this.panel_controles.Controls.Add(this.button_cerrar);
            this.panel_controles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controles.Location = new System.Drawing.Point(0, 0);
            this.panel_controles.Name = "panel_controles";
            this.panel_controles.Size = new System.Drawing.Size(834, 32);
            this.panel_controles.TabIndex = 36;
            this.panel_controles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_controles_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(335, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "COMUNICACION SERIE";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // button_minimizar
            // 
            this.button_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimizar.FlatAppearance.BorderSize = 0;
            this.button_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("button_minimizar.Image")));
            this.button_minimizar.Location = new System.Drawing.Point(770, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(32, 32);
            this.button_minimizar.TabIndex = 37;
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cerrar.FlatAppearance.BorderSize = 0;
            this.button_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("button_cerrar.Image")));
            this.button_cerrar.Location = new System.Drawing.Point(802, 0);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(32, 32);
            this.button_cerrar.TabIndex = 37;
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // cbxPuertos
            // 
            this.cbxPuertos.BackColor = System.Drawing.Color.White;
            this.cbxPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPuertos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxPuertos.FormattingEnabled = true;
            this.cbxPuertos.Location = new System.Drawing.Point(121, 51);
            this.cbxPuertos.Name = "cbxPuertos";
            this.cbxPuertos.Size = new System.Drawing.Size(121, 24);
            this.cbxPuertos.TabIndex = 34;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.BackColor = System.Drawing.Color.White;
            this.cbxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBaudRate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(121, 86);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbxBaudRate.TabIndex = 33;
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.BackColor = System.Drawing.Color.White;
            this.txtDatosRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosRecibidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDatosRecibidos.Location = new System.Drawing.Point(157, 124);
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.ReadOnly = true;
            this.txtDatosRecibidos.Size = new System.Drawing.Size(250, 22);
            this.txtDatosRecibidos.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Datos Recibidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Puerto:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDesconectar.Location = new System.Drawing.Point(251, 86);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(156, 23);
            this.btnDesconectar.TabIndex = 25;
            this.btnDesconectar.Text = "DESCONECTAR";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click_1);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConectar.Location = new System.Drawing.Point(251, 52);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(156, 23);
            this.btnConectar.TabIndex = 24;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // timer_env_datos
            // 
            this.timer_env_datos.Tick += new System.EventHandler(this.timer_env_datos_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.UseAnimation = false;
            // 
            // label_conectado
            // 
            this.label_conectado.AutoSize = true;
            this.label_conectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conectado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_conectado.Location = new System.Drawing.Point(26, 353);
            this.label_conectado.Name = "label_conectado";
            this.label_conectado.Size = new System.Drawing.Size(101, 13);
            this.label_conectado.TabIndex = 51;
            this.label_conectado.Text = "label_conectado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 377);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Eco Puerto Serie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ayuda.ResumeLayout(false);
            this.panel_ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ADC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADC)).EndInit();
            this.panel_controles.ResumeLayout(false);
            this.panel_controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_controles;
        private System.Windows.Forms.ComboBox cbxPuertos;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_instruccion;
        private System.Windows.Forms.Timer timer_env_datos;
        private System.Windows.Forms.TextBox txtADC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView_ADC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ADC;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_ADC;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel_ayuda;
        private System.Windows.Forms.PictureBox ayuda;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_titulo_ayuda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_conectado;
    }
}

