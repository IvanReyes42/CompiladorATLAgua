using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using Manejador;
using Entidades;
using System.Diagnostics;


namespace Presentacion
{
    public partial class Principal : Form
    {
        string[] puertos;
        Lexico ml;
        Sintactico sint;
        Semantico sen;
        FrmMensaje fm;
        Traductor tr;
        string Mensaje = "";
        List<EntidadLexico> t;
        Stopwatch mt = new Stopwatch();
        string traduccion = "";
        string nombre="";
        int x = 0;
        public Principal()
        {
            InitializeComponent();
            puertos = SerialPort.GetPortNames();
            ml = new Lexico();
            sint = new Sintactico();
            sen = new Semantico();
            tr = new Traductor();

            t = new List<EntidadLexico>();
            for (int i = 0; i < puertos.Length; i++)
            {
                cmbPuertos.Items.Add(puertos[i]);
            }
            cmbAlarma.SelectedIndex = 0;
            cmbFria.SelectedIndex = 1;
            CmbCaliente.SelectedIndex = 2;
            cmbPlaca.SelectedIndex = 0;
            try
            {
                cmbPuertos.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de puerto por favor conecte su placa arduino");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            TxtCodigo.Clear();
            TxtCodigo.Focus();
            btnSeparar.Enabled = false;
           

            dtgTokens.DataSource = null;
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            if (AnalizadorLexico())
            {
                if (AnalizadorSintactico())
                {
                    AnalizadorSematico();
                    if (Mensaje.Equals(""))
                    {
                        fm = new FrmMensaje("Sin Errores", "Sin Errores", 2);
                        fm.ShowDialog();
                        Traducir();
                        GenerarArchivo();
                    }
                    else
                    {
                        //MessageBox.Show(Mensaje, "Error Semantico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fm = new FrmMensaje("Error Semantico", Mensaje, 1);
                        fm.ShowDialog();
                    }
                }
                else
                {
                    // MessageBox.Show(Mensaje,"Error Sintactico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fm = new FrmMensaje("Error Sintactico", Mensaje, 1);
                    fm.ShowDialog();
                }
            }
            else
            {
                //MessageBox.Show(Mensaje,"Error Lexico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                fm = new FrmMensaje("Error Lexico", Mensaje, 4);
                fm.ShowDialog();
            }
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btnSeparar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnSeparar.Enabled = true;
            btnGuardar.Enabled = true;
           
        }
        public bool AnalizadorLexico()
        {
            bool m = true;
            mt.Start();
            t = ml.Separar(TxtCodigo.Text, TxtCodigo);
            mt.Stop();
           // MessageBox.Show(mt.ElapsedMilliseconds.ToString());
            dtgTokens.DataSource = t.ToList();
            if (dtgTokens.RowCount > 0)
            {
                for (int i = 0; i < dtgTokens.RowCount; i++)
                {
                    if (dtgTokens.Rows[i].Cells[2].Value.ToString().Equals("Valor No identificado"))
                    {
                        Mensaje = "Error, Se detectaron valores no identificados \"" + dtgTokens.Rows[i].Cells[1].Value.ToString() + "\"";
                        i = dtgTokens.RowCount;
                        m = false;
                    }
                }
                return m;
            }
            else
            {
                Mensaje = "Sin Lexico";
                return false;
            }
        }
        public bool AnalizadorSintactico()
        {
            string r = sint.Comparador(dtgTokens);
            if (r.Equals("Sin Errores Sintacticos"))
                return true;
            else
            {
                Mensaje = r;
                return false;
            }
        }
        public void AnalizadorSematico()
        {
            string r = sen.AnalisSemantico(dtgTokens);
            if (r.Length > 0)
            {
                Mensaje = r;
            }
            else
                Mensaje = "";
        }

        

        public void GenerarArchivo()
        {
            try
            {

                int index = cmbPlaca.SelectedIndex + 1;
                string puerto = cmbPuertos.SelectedItem.ToString();
                if (index != 0 && !puerto.Equals(""))
                {

                    TextWriter text = new StreamWriter("MiCodigo.ino");
                    text.Close();
                    StreamWriter Agregar = File.AppendText("MiCodigo.ino");
                    Agregar.WriteLine(traduccion);
                    Agregar.Close();


                    TextWriter battxt = new StreamWriter("Codigo.bat");
                    battxt.Close();
                    StreamWriter batagregar = File.AppendText("Codigo.bat");
                    batagregar.WriteLine("@echo off");
                    batagregar.WriteLine("ArduinoUploader MiCodigo.ino " + index + " " + puerto);
                    batagregar.Close();
                }
                else
                {
                    MessageBox.Show("Error la seleccionar el puerto o la placa arduino");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de archivo");
            }
            try
            {
                System.Diagnostics.Process.Start("Codigo.bat");
            }
            catch (Exception)
            {
                MessageBox.Show("Error de archivo");
            }
        }


        public void Traducir()
        {
            if (!ValidarVacio(cmbAlarma.Text))
            {
                if (!ValidarVacio(CmbCaliente.Text))
                {
                    if (!ValidarVacio(cmbFria.Text))
                    {
                        if ((cmbFria.Text != cmbAlarma.Text) && (cmbAlarma.Text != CmbCaliente.Text))
                        {
                            string r = tr.Traducir(dtgTokens, int.Parse(cmbAlarma.Text), int.Parse(cmbFria.Text), int.Parse(CmbCaliente.Text));
                            traduccion = r;
                            //MessageBox.Show(traduccion);
                        }
                        else
                        {
                            fm = new FrmMensaje("Error de Puertos", "Error No puedes asignar puertos iguales\r\n" +
                            "Para Agua caliente, Agua fria o Alamar", 1);
                            fm.ShowDialog();
                            cmbAlarma.Text = "";
                            cmbFria.Text = "";
                            CmbCaliente.Text = "";
                            cmbAlarma.Focus();
                        }
                    }
                    else
                    {
                        fm = new FrmMensaje("Error de Puerto", "El puerto para Agua Fria no puede estar vacio", 1);
                        fm.ShowDialog();
                    }
                }
                else
                {
                    fm = new FrmMensaje("Error de Puerto", "El puerto para Agua Caliente no puede estar vacio", 1);
                    fm.ShowDialog();
                }
            }
            else
            {
                fm = new FrmMensaje("Error de Puerto", "El puerto para Alarma no puede estar vacio", 1);
                fm.ShowDialog();
            }
        }
        public bool ValidarVacio(string caja)
        {
            if (caja == null || caja.Length == 0)
                return true;
            else
                return false;
        }

       
        public void Abrir()
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Title = "Busca tu archivo del codigo";
            save.ShowDialog();
            string nombre = save.FileName;
            if (File.Exists(save.FileName))
            {

                TextReader leer = new StreamReader(nombre);
                TxtCodigo.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        
        public void Guardar()
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                x++;
                nombre = save.FileName;
                TextWriter text = new StreamWriter(nombre + ".txt");
                text.Close();
                StreamWriter Agregar = File.AppendText(nombre + ".txt");
                Agregar.WriteLine(TxtCodigo.Text);
                Agregar.Close();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
