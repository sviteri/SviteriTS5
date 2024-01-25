using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SviteriTS5.Models
{
    public class Estudiante
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Carrera { get; set; }
    }
}
