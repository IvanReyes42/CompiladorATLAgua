using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;

namespace Manejador
{
    public class Traductor
    {
        string Variable = "";
        string Tipo = "";
        public string Traducir(DataGridView Tabla, int Alarma, int AF, int AA)
        {
            
            string r = "",v = "" ,c ="";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                //Para los Comentarios
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Comentarios"))
                    c += Tabla.Rows[i].Cells[1].Value.ToString() + "\r\n";
                //Inicio
                else if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("inicio"))
                {
                    v += "//Inicio programa \r\n" +
                        "int alarma = "+Alarma+";\r\n" +
                        "int x = 1;\r\n";
                }
                //Fin
                else if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Fin") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("fin"))
                    r += "}\r\n" +
                        "//FinDelPrograma";
                //Llenado
                else if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Llenado") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("llenado"))
                {
                    r += "void setup() { \r\n" +
                        "pinMode(alarma,OUTPUT);\r\n" +
                        "pinMode(agua, OUTPUT);\r\n" +
                        "}\r\n " +
                        "void loop() {\r\n" +
                        "if (x == 1) " +
                        "{ \r\n" +
                        "digitalWrite(agua, 1); \r\n" +
                        "delay(re); \r\n" +
                        "digitalWrite(agua, 0); \r\n" +
                        "delay(1000); \r\n" +
                        "digitalWrite(alarma, 1); \r\n" +
                        "delay(t); \r\n" +
                        "digitalWrite(alarma, 0);\r\n" +
                        "x++; \r\n}\r\n";
                }
                //Instrucciones
                else if(Tabla.Rows[i].Cells[2].Value.ToString().Equals("Instruccion"))
                {
                    if(Tabla.Rows[i].Cells[1].Value.ToString().Equals("Recipiente") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("recipiente"))
                    {
                        string Parametro = ObtenerParametro(Tabla.Rows[i + 1].Cells[1].Value.ToString());
                        if (ValidarRecipiente(Tabla.Rows[i + 1].Cells[1].Value.ToString()).Equals("Numero"))
                        {
                            v += "int re = " + Parametro + "000;\r\n";
                        }
                        else if(ValidarRecipiente(Tabla.Rows[i + 1].Cells[1].Value.ToString()).Equals("Palabra"))
                        {
                           if(BuscarVariable(Parametro, Tabla).Equals("Parametro"))
                            {
                                if (Parametro.Equals("Taza") || Parametro.Equals("taza"))
                                    v += "int re = 10000;\r\n";
                                else if (Parametro.Equals("Vaso") || Parametro.Equals("vaso"))
                                    v += "int re = 7000;\r\n";
                            }
                           else if(BuscarVariable(Parametro, Tabla).Equals("Variable"))
                            {
                                if(Tipo.Equals("Valor de Asignación Entero"))
                                {
                                    Variable = Variable.Substring(0, Variable.Length - 1);
                                    v += "int re = " + Variable + "000;\r\n";
                                }
                                else if(Tipo.Equals("Valor de Asignacion de Tipo Cadena"))
                                {
                                    Variable = Variable.Substring(1, Variable.Length - 3);
                                    if (Variable.Equals("Taza") || Variable.Equals("taza"))
                                        v += "int re = 10000;\r\n";
                                    else if (Variable.Equals("Vaso") || Variable.Equals("vaso"))
                                        r += "int re = 7000;\r\n";
                                }
                            }

                        }
                    }
                    else if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Alarma") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("alarma"))
                    {
                        if(ValidarAlarma(Tabla.Rows[i+1].Cells[1].Value.ToString()).Equals("Parametro"))
                        {
                            v += "int t = " + ObtenerParametro(Tabla.Rows[i + 1].Cells[1].Value.ToString()) + "*1000;\r\n";
                        }
                        else if(ValidarAlarma(Tabla.Rows[i + 1].Cells[1].Value.ToString()).Equals("Variable"))
                        {
                            string f = BuscarVariable(ObtenerParametro(Tabla.Rows[i + 1].Cells[1].Value.ToString()), Tabla);
                            Variable = Variable.Substring(0, Variable.Length - 1);
                            v += "int t =" + Variable + "*1000;\r\n";
                        }
                    }
                    else if(Tabla.Rows[i].Cells[1].Value.ToString().Equals("Liquido") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("liquido"))
                    {
                        string Parametro = ObtenerParametro(Tabla.Rows[i + 1].Cells[1].Value.ToString());
                        if (BuscarVariable(Parametro, Tabla).Equals("Parametro"))
                        {
                            if (Parametro.Equals("AguaCaliente") || Parametro.Equals("aguacaliente"))
                                v += "int agua = "+AA+";\r\n";
                            else if (Parametro.Equals("AguaFria") || Parametro.Equals("aguafria"))
                                v += "int agua = "+AF+";\r\n";
                        }
                        else if (BuscarVariable(Parametro, Tabla).Equals("Variable"))
                        {
                            Variable = Variable.Substring(1, Variable.Length - 3);
                            if(Variable.Equals("AguaCaliente") || Variable.Equals("AguaCaliente"))
                                v += "int agua  = " + AA + ";\r\n";
                            else if(Variable.Equals("AguaFria") || Variable.Equals("aguafria"))
                                v += "int agua  = " + AF + ";\r\n";

                        }
                    }
                }

            }

            return c+v+r;
        }
        public string ValidarAlarma(string Parametro)
        {
            try
            {
                double d = double.Parse(ObtenerParametro(Parametro));
                return "Parametro";
            }
            catch (Exception)
            {
                return "Variable";
            }
          
        }
        public string ValidarRecipiente(string Parametro)
        {
            string r = "";
           try
           {
                double d = double.Parse(ObtenerParametro(Parametro));
                r = "Numero";
           }
           catch (Exception)
           {
                r = "Palabra";
          }
            
            return r;
        }
        public string ObtenerParametro(string Parametro)
        {
            string[] r;
            r = Parametro.Split('(', ')');
            return r[1];
        }
        public string BuscarVariable(string Parametro,DataGridView Tabla)
        {
            string r = "";
            string[] x;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                
                x = Tabla.Rows[i].Cells[1].Value.ToString().Split('=');
                if (x[0].Equals(Parametro))
                {
                    r = "Variable";
                    Variable = x[1];
                    Tipo = Tabla.Rows[i].Cells[2].Value.ToString();
                    i = Tabla.RowCount;
                }
                else
                {
                    r = "Parametro";
                }
            }
                return r;
        }
        public string DatoVariable(string Parametro, DataGridView Tabla)
        {
            string r = "";
            for (int i = 0; i < Tabla.RowCount; i++)
            {

            }
                return r;
        }

    }
}
