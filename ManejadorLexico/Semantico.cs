using System.Windows.Forms;

namespace Manejador
{
    public class Semantico
    {
        string p = "";
        public string AnalisSemantico(DataGridView Tabla)
        {

            if (Tabla.RowCount > 0)
            {

                p = Regla1(Tabla);
                if (p.Length == 0)
                    p = Regla2(Tabla);
                if (p.Length == 0)
                    p = Regla3(Tabla);
                if (p.Length == 0)
                    p = Regla5(Tabla);
                if (p.Length == 0)
                    p = Regla6(Tabla);
                if (p.Length == 0)
                    p = Regla7(Tabla);
                if (p.Length == 0)
                    p = Regla8(Tabla);
                if (p.Length == 0)
                    p = Regla9(Tabla);
                if (p.Length == 0)
                    p = Regla10(Tabla);
                if (p.Length == 0)
                    p = Regla11(Tabla);
                if (p.Length == 0)
                    p = Regla12(Tabla);
                if (p.Length == 0)
                    p = Regla13(Tabla);
                if (p.Length == 0)
                    p = Regla14(Tabla);
                if (p.Length == 0)
                    p = Regla15(Tabla);
                if (p.Length == 0)
                    p = Regla16(Tabla);
                if (p.Length == 0)
                    p = Regla17(Tabla);
                if (p.Length == 0)
                    p = Regla18(Tabla);
                if (p.Length == 0)
                    p = Regla19(Tabla);
                if (p.Length == 0)
                    p = Regla20(Tabla);
                if (p.Length == 0)
                    p = Regla21(Tabla);


            }
            return p;
        }

        public string Regla1(DataGridView Tabla)
        {
            string r = "";
            int c = 0, f = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].ToString().Equals("inicio"))
                    c++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Fin") || Tabla.Rows[i].ToString().Equals("fin"))
                    f++;
            }
            if (c == 0)
                r = "Error, Debe de existir un Inicio";
            if (f == 0)
                r = "Error, Debe de existir un Fin";
            return r;

        }

        public string Regla2(DataGridView Tabla)
        {
            string r = "";
            int c = 0, f = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].ToString().Equals("inicio"))
                    c++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Fin") || Tabla.Rows[i].ToString().Equals("fin"))
                    f++;
            }
            if (c > 1)
                r = "Error, Solo debe de existir un Inicio";
            if (f > 1)
                r = "Error, Solo debe de existir un Fin";
            return r;

        }
        public string Regla3(DataGridView Tabla)
        {
            string r = "";
            if (Tabla.Rows[Tabla.RowCount - 1].Cells[1].Value.ToString().Equals("Fin"))
                r = "";
            else
                r = "Error, La última Linea debe ser Fin";
            return r;
        }

        public string Regla5(DataGridView Tabla)
        {
            string r = ""; int m = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Metodo"))
                {
                    m++;
                    if (m > 1)
                    {
                        r = "Error el programa solo acepta un solo metodo";
                        i = Tabla.RowCount;
                    }
                }
            }
            if (m == 0)
                r = "Erro, el programa debe de contener un metodo";
            return r;
        }
        public string Regla6(DataGridView Tabla)
        {
            string r = "";
            int li = 0, Lf = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("{"))
                    li++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("}"))
                    Lf++;
            }
            if (li != Lf)
            {
                if (li > Lf)
                    r = string.Format("Error faltan '{0}' Llaves de cierre", li - Lf);
                if (Lf > li)
                    r = string.Format("Error faltan '{0}' Llaves de inicio", Lf - li);
            }
            return r;
        }

        public string Regla7(DataGridView Tabla)
        {
            string r = "";
            int l = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Llenado") || Tabla.Rows[i].ToString().Equals("llenado"))
                    l++;
            }
            if (l > 1)
                r = "Error Solo debe de existir una instrucción de Llenado";
            if (l == 0)
                r = "Error debe de existir una instrucción de Llenado";
            return r;
        }
        public string Regla8(DataGridView Tabla)
        {
            string r = "";
            int a = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Alarma") || Tabla.Rows[i].ToString().Equals("alarma"))
                    a++;
            }
            if (a > 1)
                r = "Error Solo debe de existir una instrucción de Alarma";
            if (a == 0)
                r = "Error debe de existir una instrucción de Alarma";
            return r;
        }
        public string Regla9(DataGridView Tabla)
        {
            string r = "";
            int re = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Recipiente") || Tabla.Rows[i].ToString().Equals("recipiente"))
                    re++;
            }
            if (re > 1)
                r = "Error Solo debe de existir una instrucción de Recipiente";
            if (re == 0)
                r = "Error debe de existir una instrucción de Recipiente";
            return r;
        }
        public string Regla10(DataGridView Tabla)
        {
            string r = "";
            int l = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Liquido") || Tabla.Rows[i].ToString().Equals("liquido"))
                    l++;
            }
            if (l > 1)
                r = "Error Solo debe de existir una instrucción de Liquido";
            if (l == 0)
                r = "Error debe de existir una instrucción de Liquido";
            return r;
        }

        public string Regla11(DataGridView Tabla)
        {
            string r = "", Ins = "";
            int c = 0, n = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                c++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].ToString().Equals("inicio"))
                {
                    i = Tabla.RowCount;
                }
            }
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                n++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Instruccion"))
                {
                    Ins = Tabla.Rows[i].Cells[1].Value.ToString();
                    i = Tabla.RowCount;
                }
            }
            if (n < c)
                r = "Error, No puede existir la instrucción " + Ins + " Fuera de Inicio";
            return r;
        }
        public string Regla12(DataGridView Tabla)
        {
            string r = "";
            int c = 0, d = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                c++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].ToString().Equals("inicio"))
                {
                    i = Tabla.RowCount;
                }
            }
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                d++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Tipo de Dato"))
                {
                    i = Tabla.RowCount;
                }
            }
            if (d < c)
                r = "Error, No pueden existir declaraciones de variables Fuera de Inicio";
            return r;
        }
        public string Regla13(DataGridView Tabla)
        {
            string r = "", Metodo = "";
            int c = 0, m = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                c++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Inicio") || Tabla.Rows[i].ToString().Equals("inicio"))
                {
                    i = Tabla.RowCount;
                }
            }
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                m++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Metodo"))
                {
                    Metodo = Tabla.Rows[i].Cells[1].Value.ToString();
                    i = Tabla.RowCount;
                }
            }
            if (m < c)
                r = "Error, No puede existir el Metodo " + Metodo + " Fuera de Inicio";
            return r;
        }
        public string Regla14(DataGridView Tabla)
        {
            string r = "", Ins = "";
            int c = 0, n = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                c++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Metodo"))
                {
                    i = Tabla.RowCount;
                }
            }
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                n++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Instruccion"))
                {
                    Ins = Tabla.Rows[i].Cells[1].Value.ToString();
                    i = Tabla.RowCount;
                }
            }

            if (c > n)
                r = "Error, No puede existir la instrucción " + Ins + " fuera de un metodo";
            return r;
        }

        public string Regla15(DataGridView Tabla)
        {
            string r = "";
            int l = 0, lf = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                l++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Llenado") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("llenado"))
                {
                    i = Tabla.RowCount;
                }
            }
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                lf++;
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("}"))
                {

                    i = Tabla.RowCount;
                }
            }

            if (lf < l)
                r = "Error, No puede existir la instrucción Llenado fuera de un metodo";
            return r;
        }

        public string Regla16(DataGridView Tabla)
        {
            string r = ""; int s = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Instruccion"))
                {
                    s++;

                }
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Llenado") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("llenado"))
                {
                    if (s == 4)
                    {
                        r = "";
                    }
                    else
                        r = "Error la ultima instruccion en ser declara es Llenado";
                }
            }

            return r;
        }

        public string Regla17(DataGridView Tabla)
        {
            string r = "";
            int m = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                m++;
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Metodo"))
                    i = Tabla.RowCount;
            }
            for (int i = m; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Tipo de Dato"))
                {
                    string[] variable = Tabla.Rows[i + 1].Cells[1].Value.ToString().Split('=');
                    r = "Error la variable " + variable[0] + " \n" +
                        "Se debe declarar antes del metodo";
                }
            }
            return r;
        }

        public string Regla18(DataGridView Tabla)
        {
            string r = "", instruccion = "";
            int vIns = 0;
            string[] sIns;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.Equals("Liquido") || Tabla.Rows[i].Cells[1].Value.Equals("liquido"))
                {
                    {
                        sIns = Tabla.Rows[i + 1].Cells[1].Value.ToString().Split('(', ')');
                        instruccion = Tabla.Rows[i].Cells[1].Value.ToString();
                        try
                        {
                            vIns = int.Parse(sIns[1]);
                            r = "Error esta instruccion No acepta valores numericos como parametros";
                        }
                        catch (System.Exception)
                        {
                            r = BuscarVariables(Tabla, sIns[1], instruccion);
                            if (r.Equals("Existe"))
                            {
                                if (ValidarDatoString(Tabla, sIns[1]).Equals("AguaCaliente") || ValidarDatoString(Tabla, sIns[1]).Equals("AguaFria") || ValidarDatoString(Tabla, sIns[1]).Equals("aguacaliente") || ValidarDatoString(Tabla, sIns[1]).Equals("aguafria"))
                                    r = "";
                                else
                                    r = "Error las variables para la instruccion \"Liquido\" solamente acepta los datos: \n" +
                                        "AguaCaliente, AguaFria, aguacaliente o aguafria";
                            }
                            else
                            {
                                if (sIns[1].Equals("AguaCaliente") || sIns[1].Equals("AguaFria") || sIns[1].Equals("aguacaliente") || sIns[1].Equals("aguafria"))
                                    r = "";
                                else if (r == "")
                                    r = "Error, la variable " + sIns[1] + " \n" +
                                    "No existe en el contexto actual";
                            }
                        }
                    }
                }
            }
            return r;
        }

        public string Regla19(DataGridView Tabla)
        {
            string r = "", instruccion = "";
            int vIns = 0;
            string[] sIns;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.Equals("Recipiente") || Tabla.Rows[i].Cells[1].Value.Equals("recipiente"))
                {
                    {
                        sIns = Tabla.Rows[i + 1].Cells[1].Value.ToString().Split('(', ')');
                        instruccion = Tabla.Rows[i].Cells[1].Value.ToString();
                        try
                        {
                            vIns = int.Parse(sIns[1]);
                            r = "";
                        }
                        catch (System.Exception)
                        {
                            r = BuscarVariables(Tabla, sIns[1], instruccion);
                            if (r.Equals("Existe"))
                            {
                                if (ValidarDatoString(Tabla, sIns[1]).Equals("Taza") || ValidarDatoString(Tabla, sIns[1]).Equals("taza") || ValidarDatoString(Tabla, sIns[1]).Equals("Vaso") || ValidarDatoString(Tabla, sIns[1]).Equals("Vaso") || ValidarDatoString(Tabla, sIns[1]).Equals("Asignacion Entero"))
                                    r = "";
                                else
                                    r = "Error las variables para la instruccion \"Recipiente\" solamente acepta los datos: \n" +
                                        "Taza, taza, Vaso, vaso o algun valor Numerico Entero";
                            }
                            else
                            {
                                if (sIns[1].Equals("Vaso") || sIns[1].Equals("vaso") || sIns[1].Equals("Taza") || sIns[1].Equals("taza"))
                                    r = "";
                                else if (r == "")
                                    r = "Error, la variable " + sIns[1] + " \n" +
                                    "No existe en el contexto actual";
                            }

                        }
                    }
                }
            }
            return r;
        }

        public string Regla20(DataGridView Tabla)
        {
            string r = "", instruccion = "";
            double vIns = 0.0;
            string[] sIns;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.Equals("Alarma") || Tabla.Rows[i].Cells[1].Value.Equals("alarma"))
                {
                    {
                        sIns = Tabla.Rows[i + 1].Cells[1].Value.ToString().Split('(', ')');
                        instruccion = Tabla.Rows[i].Cells[1].Value.ToString();
                        try
                        {
                            vIns = double.Parse(sIns[1]);
                            r = "";
                        }
                        catch (System.Exception)
                        {
                            r = BuscarVariables(Tabla, sIns[1], instruccion);
                            if (r.Equals("Existe"))
                            {
                                if (ValidarDatoString(Tabla, sIns[1]).Equals("Asignacion Decimal") || ValidarDatoString(Tabla, sIns[1]).Equals("Asignacion Entero"))
                                    r = "";
                                else
                                    r = "Error las variables para la instruccion \"Alarma\" solamente acepta valores: \n" +
                                        "Numericos Enteros y Decimales";
                            }
                            else if (r == "")
                                r = "Error, la variable " + sIns[1] + " \n" +
                                    "No existe en el contexto actual";
                        }
                    }
                }
            }
            return r;
        }

        public string Regla21(DataGridView Tabla)
        {
            string r = "";
            string[] variable;
            string v = "";
            int e = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Tipo de Dato"))
                {
                    e = 0;
                    variable = Tabla.Rows[i + 1].Cells[1].Value.ToString().Split('=');
                    v = variable[0];
                    for (int f = i; f < Tabla.RowCount; f++)
                    {
                        if (Tabla.Rows[f].Cells[2].Value.ToString().Equals("Instruccion"))
                        {
                            string[] Parametro = Tabla.Rows[f + 1].Cells[1].Value.ToString().Split('(', ')');
                            //MessageBox.Show(Parametro[1] + " " + variable[0]);
                            if (Parametro[1] == variable[0])
                            {
                                //  MessageBox.Show("Entro");
                                e++;
                            }
                        }
                    }
                    if (e == 0)
                    {
                        i = Tabla.RowCount;
                        r = "Error, Variable " + v + " se declara \n" +
                            "Pero nunca se usa";
                    }

                }

            }
            return r;
        }




        public string BuscarVariables(DataGridView Tabla, string variable, string instruccion)
        {
            string r = ""; string[] asignacion; int f = 0;
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals(instruccion))
                {
                    f++;
                }
                asignacion = Tabla.Rows[i].Cells[1].Value.ToString().Split('=');
                if (asignacion[0].Equals(variable))
                {
                    r = "Existe";
                    if (f == 0)
                    {
                        r = "Existe";
                    }
                    else if (f > 0)
                        r = "Error La variable " + variable + " no puede estar asignada despues de la instruccion " + instruccion;
                    i = Tabla.RowCount;
                }


            }
            return r;
        }
        public string ValidarDatoString(DataGridView Tabla, string variable)
        {
            string r = "";
            string[] asignacionC;
            string[] asignacionS;
            string[] asignacion;

            for (int i = 0; i < Tabla.RowCount; i++)
            {
                asignacion = Tabla.Rows[i].Cells[1].Value.ToString().Split('=');
                if (asignacion[0].Equals(variable))
                {
                    if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Valor de Asignacion de Tipo Cadena"))
                    {
                        asignacionC = Tabla.Rows[i].Cells[1].Value.ToString().Split('=');
                        if (asignacionC.Length > 1)
                        {
                            asignacionS = asignacionC[1].Split('"');
                            r = asignacionS[1];

                            i = Tabla.RowCount;
                        }
                    }
                    else if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Valor de Asignación Decimal"))
                        r = "Asignacion Decimal";
                    else if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Valor de Asignación Entero"))
                        r = "Asignacion Entero";
                }
            }
            return r;
           }
    }
}
