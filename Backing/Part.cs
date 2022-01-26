using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backing
{
    class Part : Conexion
    {
        static int id_part;
        public string partno { get; set; }
        public string descr { get; set; }
        public string rev { get; set; }
        public string thickness { get; set; }
        public string msl { get; set; }
        public string level { get; set; }
        public string Bake { get; set; }
        public int hours { get; set; }
        public int Id_part { get => id_part; set => id_part = value; }
        public string Assy { get => assy; set => assy = value; }
        public int Id_pkg { get => id_pkg; set => id_pkg = value; }

        string assy;
        int id_pkg;

        public Part()
        {


        }

        public Part(int id_part_, string partno_, string descr_, string rev_, string thickness_, string msl_, string level_, string Bake_, int hours_)
        {
            this.Id_part = id_part_;
            this.partno = partno_;
            this.descr = descr_;
            this.rev = rev_;
            this.thickness = thickness_;
            this.msl = msl_;
            this.level = level_;
            this.Bake = Bake_;
            this.hours = hours_;
        }
    }
}

