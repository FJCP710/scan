using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace scan.Services
{
    public class MedicinasDB
    {
        [PrimaryKey]
        public string id { get;}
        public string nombre { get;}
        public string prospecto { get;}
        public int mg { get;}
        public bool prescripcion { get;}
        public bool sns { get;}
        public DateTime fecCaduc { get; set; }
        public int horas { get; set; }

        public MedicinasDB(string id, string nombre, string prospecto, int mg, bool prescripcion, bool sns, DateTime fecCaduc, int horas)
        {
            this.id = id;
            this.nombre = nombre;
            this.prospecto = prospecto;
            this.mg = mg;
            this.prescripcion = prescripcion;
            this.sns = sns;
            this.fecCaduc = fecCaduc;
            this.horas = horas;
        }
    }
}
