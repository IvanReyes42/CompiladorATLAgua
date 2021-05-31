using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using System.Diagnostics;


namespace Manejador
{
    public class Lexico
    {
        //~```^^ º
        //Ecuacion Original 
        //4n+n^2*((19n)+L(n))+52n+2n+L(2n)= 58n+n^2*((19n)+L(n))+L(2n) = 
        //Ecuacion Optima
        //6n+3n+21n+9n+5n+6(5n)+4n+4n+3+7n = 92n

        Match m;
        TextBox caja;
        public List<EntidadLexico> Separar(string Texto,TextBox c) //4n+n^2((9(2n)+1(n))))+L(n) = 4n+n^2*((19n)+L(n))
        {
            //6n
            caja = c;   //n
            List<EntidadLexico> l = new List<EntidadLexico>();  //n
            string[] tokens = Texto.Split(' ','\n','\r');   //n

            tokens = tokens.Where(val => val != "").ToArray();  //n

            Ciclo1(1,12,0, tokens.Length, tokens, l);//n
            return l; //n
        }

        


        public void Ciclo1(int x, int valor2,int i, int valor1, string[] tokens, List<EntidadLexico> l)//N(N(n)+2n) = 3n
        {
            
            if(i<valor1)//N = 1
            {
                if (!tokens[i].Equals("") && !tokens[i].Equals(" "))    //N =1
                {
                    ciclo2(x,valor2,tokens,i,l);//n

                }
                i++;//n
                Ciclo1(x, valor2, i, valor1, tokens, l);//n
            }
            
        }

        public void ciclo2(int x, int valor2, string[] tokens,int i, List<EntidadLexico> l)//N(21n) = 1(21n) = 21n
        {
            if(x<valor2)//N=1
            {
                switch (x)   //9(2n) + 1(n) + 2n = 18n+1n+2n = 19n+2n = 21n 
                {
                    case 1:
                        if (!ComprobarAsignacion(tokens[i]).Equals("")) //N =1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarAsignacion(tokens[i]), Lineas(caja, tokens[i])));   //n
                          
                            x = 13; //n
                        }
                                 ; break;
                    case 2:
                        if (!ComprobarTipoDeDato(tokens[i]).Equals("")) //N =1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarTipoDeDato(tokens[i]), Lineas(caja, tokens[i]))); //n
                            
                            x = 13; //n
                        }
                                 ; break;
                    case 3:
                        if (!ComprobarComentarios(tokens[i]).Equals("")) //N =1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarComentarios(tokens[i]), Lineas(caja, tokens[i]))); //n
                          
                            x = 13;//n
                        }
                                 ; break;
                    case 4:
                        if (!ComprobarPalabrasReservadas(tokens[i]).Equals("")) //N =1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarPalabrasReservadas(tokens[i]), Lineas(caja, tokens[i])));//n
                           
                            x = 13;//n
                        }
                                 ; break;
                    case 5:
                        if (!ComprobarCadenas(tokens[i]).Equals("")) //N=1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarCadenas(tokens[i]), Lineas(caja, tokens[i]))); //n
                           
                            x = 13; //n
                        }
                                 ; break;
                    case 6:
                        if (!ComprobarMetodos(tokens[i]).Equals(""))    //N=1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], ComprobarMetodos(tokens[i]), Lineas(caja, tokens[i])));   //n
                            
                            x = 13; //n
                        }
                                 ; break;
                    case 7:
                        if (!Instrucciones(tokens[i]).Equals(""))   //N=1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], Instrucciones(tokens[i]), Lineas(caja, tokens[i])));  //n
                           
                            x = 13; //n
                        }
                                 ; break;
                    case 8:
                        if (!Llaves(tokens[i]).Equals(""))  //N=1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], Llaves(tokens[i]), Lineas(caja, tokens[i])));//n
                            
                            x = 13;//n
                        }
                                 ; break;
                    case 9:
                        if (!Parametros(tokens[i]).Equals(""))  //N1
                        {
                            l.Add(new EntidadLexico(i + 1, tokens[i], Parametros(tokens[i]), Lineas(caja, tokens[i]))); //n
                           
                            x = 13; //n
                        }
                                 ; break;
                    case 10:
                        l.Add(new EntidadLexico(i + 1, tokens[i], "Valor No identificado", Lineas(caja, tokens[i])));   //n
                        ; break;

                }
                x++;//n
                ciclo2(x, valor2, tokens, i, l);//n
            }
            

        }


        public string ComprobarAsignacion(string t) //4n+N(n+N(n)+n+N(N(n+n))) = 4n+1(n+1(n)+n+1(1(2n))) = 4n+(n+n+n+2n) = 4n+5n = 9n
        {
            
            string r = "";          //n
            string Patron = @"\b[A-Za-z]\w*\d*=[A-Za-z]\w*\d*|[A-Za-z]\w*\d*=[0-9]\d*\b";   //n
            m = Regex.Match(t, Patron);     //n
            if (m.Success)          //N=1
            {   
                r = "Valor de Asignación Entero";   //n
                if(t.Contains("."))         //N=1
                {
                    r = "Valor de Asignación Decimal";//n
                }
            }
            else
            {
                string[] cadena = t.Split('='); //n
                if (cadena.Length >1)  //N = 1
                {
                    if(ComprobarCadenas(cadena[1]).Equals("Cadena")) //N = 1
                    r = "Valor de Asignacion de Tipo Cadena";   //n
                    else if (ComprobarCaracter(cadena[1]).Equals("Caracter"))
                        r = "Valor de Asignacion de Tipo Caracter"; //n
                }

            }
           return r;    //n
        }

        public string ComprobarTipoDeDato(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = "";  //n 
            string Patron = @"\bint|Int|string|String|double|Double|char|Char\b";   //n
            m = Regex.Match(t, Patron); //n
            if(m.Success)   //N=1
            {
                r = "Tipo de Dato";//n
            }
            return r; //n 
        }

        public string ComprobarComentarios(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = "";  //n
            string Patron = @"/\*\w*\*/|//((?!\*/).)*"; //n
            m = Regex.Match(t, Patron); //n
            if (m.Success) //N=1
            {
                r = "Comentarios"; //n
            }
            return r; //n
        }

        public string ComprobarPalabrasReservadas(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = "";  //n
            string Patron = @"\bInicio|inicio|Fin|fin\b"; //n
            m = Regex.Match(t, Patron); //n
            if (m.Success) //N=1
            {
                r = "Palabra Reservada"; //n
            }
            return r;//n
        }

        public string ComprobarCadenas(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = "";  //n
            string Patron = "\\\"(.*?)\\\"";    //n
            m = Regex.Match(t, Patron); //n
            if (m.Success)  //N=1
            {
                r = "Cadena";   //n
            }
            return r;//n
        }
        public string ComprobarCaracter(string t) //4n+N(n) - 4n+1(n) = 5n
        {
            string r = ""; //n
            string Patron = "\\\'(.*?)\\\'"; //n
            m = Regex.Match(t, Patron); //n
            if (m.Success)  //N=1
            {
                r = "Caracter"; //n
            }
            return r;//n
        }

        public string ComprobarMetodos(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = ""; //n
            string Patron = @"[A-Za-z]\w*\([\w*\d*]*?\)";   //n
            m = Regex.Match(t, Patron);  //n
            if (m.Success)  //N=1
            {
                r = "Metodo"; //n
            }
            return r; //n
        }

        public string Instrucciones(string t) //4n+N(n) = 4n+1(n) = 5n
        {
            string r = "";  //n
            string Patron = @"\bLiquido|liquido|llenado|Llenado|Alarma|alarma|Recipiente|recipiente\b"; //n
            m = Regex.Match(t, Patron); //n
            if (m.Success)  //N=1
            {
                r = "Instruccion"; //n
            }
            return r; //n
        }
        public string Llaves(string t)  //2n+N(2n) = 2n+1(2n) = 2n+2n = 4n
        {
            string r = ""; //n
            if (t.Equals("{")) //N=1
                r = "Llave de Inicio"; //n
            else if (t.Equals("}"))
                r = "Llave de Cierre"; //n
            return r;//n
        }
        public string Parametros(string t)  //2n+N(2n) = 2n+1(2n) = 2n+2n = 4n
        {
            string r = "";  //n
            if(t.Substring(0,1).Equals("(") && t.Substring(t.Length-1,1).Equals(")")&& t.Length>2)  //N=1
            {
                r = "Parametro";    //n
            }
            else if(t.Equals("()"))
            {
                r = "Parametro Vacio";  //n
            }
            return r;   //n
        }
        public int Lineas(TextBox tex, string token)    //Original = 2n+L(N(2n)) = 2n+L(1(2n) = 2n+L(2n)
        {
            //Optimizada = 3n
            int l = 0;//n
            l = ciclo3(0, tex.Lines.Length, tex, token, l); //n
            return l;//n
        }

        public int ciclo3(int i,int valor,TextBox tex, string token,int l)//N(N(2n)+2n+3n) = N(N(2n)+5n) = 1(1(2n)+5n) = 7n
        {
            if (i < valor)//N = 1
            {
                if (tex.Lines[i].Contains(token))   // N = 1
                {
                    l = i + 1;  //n
                    i = tex.Lines.Length;   //n
                    
                }
                i++;//n
                return ciclo3(i, valor, tex, token, l);//n
               
            }
            else
            {
               
                return l;//n
            }
            
        }
    }
}
