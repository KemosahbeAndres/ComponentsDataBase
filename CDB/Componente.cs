using System;

namespace CDB
{
    public class Componente
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
        public packageType Encapsulado
        {
            get
            {
                return (packageType)this.Capsula;
            }
            set
            {
                this.Capsula = (int)value;
            }
        }
        public string Comentarios { get; set; }
        public bool Imagen { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string AltCodigo { get; set; }
        public string Datasheet { get; set; }
        //public string ID { get; set; }
        private int Capsula;
        public Componente()
        {
            this.Codigo = "";
            this.Descripcion = "";
            this.Cantidad = 0;
            this.Categoria = "";
            this.Encapsulado = packageType.UNKNOW;
            this.Comentarios = "";
            this.Imagen = false;
            this.AltCodigo = "";
            this.Datasheet = "";
        }
    }
}
