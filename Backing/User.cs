using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backing
{
    class User : Conexion
    {
        int id_user;
        string name;
        int id;
        static int quality;
        static int eng;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Quality { get => quality; set => quality = value; }
        public int Eng { get => eng; set => eng = value; }
    }
}
