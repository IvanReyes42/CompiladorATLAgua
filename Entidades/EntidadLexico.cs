namespace Entidades
{
    public class EntidadLexico
    {
        public int No { get; set; }
        public string Token { get; set; }
        public string Descripcion { get; set; }
        public int Linea { get; set; }

        public EntidadLexico(int no, string token, string descripcion, int linea)
        {
            No = no;
            Token = token;
            Descripcion = descripcion;
            Linea = linea;
        }
    }
}
