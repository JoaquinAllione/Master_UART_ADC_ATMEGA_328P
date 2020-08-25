using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;

namespace ECCO_PUERTO
{
    public partial class Form1 : Form
    {
        int time = 0;

        private delegate void delegado(string accion);
        private string strBufferIn;
        private string strBufferOut;
        private bool estado_puerto;

        public Form1()
        {
            InitializeComponent();
        }

        char caracter_delimitador = ':';

        private void acceso_Form(string accion)
        {
            strBufferIn = accion;
            //----------- DATOS A PASAR -------------//
            txtDatosRecibidos.Text = strBufferIn;
            string[] cadena = strBufferIn.Split(caracter_delimitador);
            txtADC.Text = cadena[2];
            chart_ADC.Series["VALOR_ADC"].Points.AddY(Convert.ToInt16(cadena[2]));
            int n = dataGridView_ADC.Rows.Add();
            dataGridView_ADC.Rows[n].Cells[0].Value = time;
            dataGridView_ADC.Rows[n].Cells[1].Value = cadena[2];
            //---------------------------------------//
        }

        public void init_chart_ADC()
        {
            int x;
            int y;

            for(x = 0; x < 99; x++)
            {
                y = (int)(1024 * (1 - Math.Pow(2.7, -0.05 * x)));
                chart_ADC.Series["VALOR_ADC"].Points.AddY(Convert.ToInt16(y));
            }
        }

        public void restablecer()
        {
            chart_ADC.Series["VALOR_ADC"].Points.Clear();
            init_chart_ADC();
            txtDatosRecibidos.Text = "";
            txtADC.Text = "";
            time = 0;    
            dataGridView_ADC.Rows.Clear();
        }

        private void accesoInt(string accion)
        {
            delegado variable;
            variable = new delegado(acceso_Form);
            object[] arg = { accion };
            base.Invoke(variable, arg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            time = 0;
            btn_instruccion.Enabled = false;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = false;
            cbxBaudRate.SelectedIndex = 3;
            estado_puerto = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btn_detener.Enabled = false;
            init_chart_ADC();
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(ayuda, "¿Que mierda es esto?");
            panel_ayuda.Location = new Point(802, 343);
            panel_ayuda.Size = new Size(32, 34);
            label_conectado.Text = "Desconectado";
            this.Opacity = 1;
            string[] Puertos_disponibles = SerialPort.GetPortNames();

            foreach (string puerto in Puertos_disponibles)
            {
                cbxPuertos.Items.Add(puerto);
            }

            if (cbxPuertos.Items.Count > 0)
            {
                cbxPuertos.SelectedIndex = 0;
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se han encontrado puertos disponibles.");
                cbxPuertos.Items.Clear();
                cbxPuertos.Text = "                     ";
                strBufferIn = "";
                strBufferOut = "";
                btn_instruccion.Enabled = false;
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = false;
                cbxBaudRate.SelectedIndex = 9;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = Int32.Parse(cbxBaudRate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = cbxPuertos.Text;
                serialPort1.Open();
                estado_puerto = true;
                btnDesconectar.Enabled = true;
                btn_instruccion.Enabled = true;
                btnConectar.Enabled = false;
                label_conectado.Text = "Conectado a " + cbxPuertos.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado_puerto = false;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btn_instruccion.Enabled = false;
            btnConectar.Enabled = true;
            restablecer();
            estado_puerto = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /* string dataIn = serialPort1.ReadExisting();
             MessageBox.Show(dataIn);
             txtDatosRecibidos.Text = dataIn;
             NO SE PUEDE HACER ASI, SE TIENE QUE USAR DELEGADOS 
             YA QUE NO SE PUEDE MODIFICAR EL FORM DESDE UNA INTERRUPCION*/
            accesoInt(serialPort1.ReadLine());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(estado_puerto == true)
            {
                serialPort1.Close();
                estado_puerto = false;
            }
        }


        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            timer_env_datos.Stop();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posX = 0;
        int posY = 0;

        private void panel_controles_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            btnConectar_Click(sender, e);
        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            btnDesconectar_Click(sender, e);
            timer_env_datos.Stop();
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btn_detener.Enabled = false;
            btnDesconectar.Enabled = false;
            label_conectado.Text = "Desconectado";
        }

        private void btn_instruccion_Click(object sender, EventArgs e)
        {
            timer_env_datos.Enabled = true;
            timer_env_datos.Start();
            time = 0;
            dataGridView_ADC.Rows.Clear();
            chart_ADC.Series["VALOR_ADC"].Points.Clear();
            btn_detener.Enabled = true;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void timer_env_datos_Tick(object sender, EventArgs e)
        {
            time++;
            try
            {
                serialPort1.DiscardOutBuffer();
                strBufferOut = ":P01\n";
                serialPort1.Write(strBufferOut);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            panel_controles_MouseMove(sender, e);
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer_env_datos.Stop();
            btnLimpiar.Enabled = true;
            btnGuardar.Enabled = true;
            btn_detener.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            restablecer();
            btn_detener.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btn_instruccion.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btn_detener.Enabled = false;
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream s = File.Open(save.FileName, FileMode.CreateNew))
                    using (TextWriter sw = new StreamWriter(s))
                    {
                        for (int i = 0; i < dataGridView_ADC.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dataGridView_ADC.Columns.Count; j++)
                            {
                                sw.Write(" " + dataGridView_ADC.Rows[i].Cells[j].Value.ToString() + " ");
                            }
                            sw.WriteLine(" ");
                        }
                        sw.Close();
                    }
                    MessageBox.Show("Se han guardado los datos exitosamente.","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void ayuda_Click(object sender, EventArgs e)
        {
            /*
            panel_ayuda.Location = new Point(802, 343); //para reestablecer el tamaño del cuadro de ayuda.
            panel_ayuda.Size = new Size(32, 34);
            */
            panel_ayuda.Size = new Size(238, 178);
            panel_ayuda.Location = new Point(596, 199);
            panel_ayuda.BackColor = Color.LightGray;
        }

        private void panel_ayuda_MouseLeave(object sender, EventArgs e)
        {
            panel_ayuda.Location = new Point(802, 343); //para reestablecer el tamaño del cuadro de ayuda.
            panel_ayuda.Size = new Size(32, 34);
            panel_ayuda.BackColor = Color.White;
        }
    }
}
