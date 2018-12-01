using System;

namespace CDB
{
    public class Componente
    {
        public string ID { get; set; }
        public string codigo { get; set; }
        public Capsula capsula { get; set; }
        public int cantidad { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public DateTime fecha { get; set; }
        public string pinout { get; set; }
        public string fabricante { get; set; }
        public string altCodigo { get; set; }
        public string datasheet { get; set; }
        public string descripcion { get; set; }
    }
}
