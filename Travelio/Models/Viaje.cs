using System;
using SQLite;

namespace Travelio.Models
{
    public class Viaje
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public DateTime FechaInicio
        {
            get;
            set;
        }
        public DateTime FechaRegreso
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{Nombre} ({FechaInicio:d} - {FechaRegreso:d})]";
        }
    }
}
