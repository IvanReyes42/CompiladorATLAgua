using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class Sintactico
    {
        public string Comparador(DataGridView Tabla)
        {
            string r = "Sin Errores Sintacticos";

            for (int i = 0; i < 11; i++)
            {
                switch (i)
                {
                    case 0:
                        
                        if (!DatosString(Tabla).Equals("Correcto"))
                        {
                            r = DatosString(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 1:
                        
                        if (!DatosEntero(Tabla).Equals("Correcto"))
                        {
                            r = DatosEntero(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 2:
                        if (!DatosDecimal(Tabla).Equals("Correcto"))
                        {
                            r = DatosDecimal(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 4:
                        if (!DatosCaracter(Tabla).Equals("Correcto"))
                        {
                            r = DatosCaracter(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 5:
                        if (!MetodoLlenado(Tabla).Equals("Correcto"))
                        {
                            r = MetodoLlenado(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 6:
                        if (!MetodoAlarma(Tabla).Equals("Correcto"))
                        {
                            r = MetodoAlarma(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 7:
                        if (!MetodoRecipiente(Tabla).Equals("Correcto"))
                        {
                            r = MetodoRecipiente(Tabla);
                            i = 11;
                        }
                        ; break;
                    case 8:
                        if (!MetodoLiquido(Tabla).Equals("Correcto"))
                        {
                            r = MetodoLiquido(Tabla);
                            i = 11;
                        }
                        ; break;
                    /*case 9:
                        if (!Condicionales(Tabla).Equals("Correcto"))
                        {
                            r = Condicionales(Tabla);
                            i = 11;
                        }
                        ; break;*/
                    case 10:
                        if (!Metodos(Tabla).Equals("Correcto"))
                        {
                            r = Metodos(Tabla);
                            i = 11;
                        }
                        ; break;
                }
            }

            return r;
        }

        public string DatosString(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("string") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("String"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Valor de Asignacion de Tipo Cadena"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un valor de asignacion de tipo Cadena en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un valor de asignacion de tipo Cadena en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string DatosEntero(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Int") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("int"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Valor de Asignación Entero"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un valor de asignacion de tipo Entero en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un valor de asignacion de tipo Entero en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string DatosDecimal(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Double") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("double"))
                {
                    if (i != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Valor de Asignación Decimal"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un valor de asignacion de tipo Decimal en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un valor de asignacion de tipo Decimal en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string DatosCaracter(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Char") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("char"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Valor de Asignacion de Tipo Caracter"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un valor de asignacion de tipo Caracter en la Linea " + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                }
            }
            return r;
        }

        public string MetodoLlenado(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Llenado") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("llenado"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Parametro Vacio"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un parametro vacio en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un parametro vacio en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string MetodoLiquido(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Liquido") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("liquido"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Parametro"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string MetodoAlarma(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Alarma") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("alarma"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Parametro"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

        public string MetodoRecipiente(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("Recipiente") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("recipiente"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Parametro"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un parametro en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }

      /*  public string Condicionales(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {
                if (Tabla.Rows[i].Cells[1].Value.ToString().Equals("If") || Tabla.Rows[i].Cells[1].Value.ToString().Equals("if"))
                {
                    if (i+1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Valor de Comprobación"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba un valor de comprobación en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                        if (Tabla.Rows[i + 2].Cells[2].Value.ToString().Equals("Llave de Inicio"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba una llave de inicio en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba un valor de comprobación en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return r;
        }*/

        public string Metodos(DataGridView Tabla)
        {
            string r = "Correcto";
            for (int i = 0; i < Tabla.RowCount; i++)
            {

                if (Tabla.Rows[i].Cells[2].Value.ToString().Equals("Metodo"))
                {
                    if (i + 1 != Tabla.RowCount)
                    {
                        if (Tabla.Rows[i + 1].Cells[2].Value.ToString().Equals("Llave de Inicio"))
                            r = "Correcto";
                        else
                        {
                            r = "Error se esperaba una llave de inicio en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                            break;
                        }
                    }
                    else
                    {
                        r = "Error se esperaba una llave de inicio en la Linea" + Tabla.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }

            }
            return r;
        }
    }
}
