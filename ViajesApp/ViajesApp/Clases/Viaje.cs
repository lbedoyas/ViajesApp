using System;
using SQLite;

namespace ViajesApp.Clases
{
    public class Viaje
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(150)]
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegreso { get; set; }


    }
}
