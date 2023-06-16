using System;
using SQLite;

namespace PM2E11248.Models
{
    public class Lugares
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Latitud { get; set; }

        [MaxLength(100)]
        public string Longitud { get; set; }

        [MaxLength(200)]
        public string Descripcion { get; set; }

        public byte[] Foto { get; set; }
    }
}
