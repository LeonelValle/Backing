using System;

namespace Backing
{
    class LootNo :  Conexion
    {
        static int id_lotno;
        public static string lotno { get; set; }
		public DateTime startDate { get; set; }
		public DateTime Due { get; set; }
		public TimeSpan Paused { get; set; }
		public int employStart { get; set; }
		public int id_part { get; set; }

		static string bake;

		static string time;
        public int Id_lotno { get => id_lotno; set => id_lotno = value; }
        public string Bake { get => bake; set => bake = value; }
        public string Time { get => time; set => time = value; }

        public LootNo()
		{
			
		}
		
	}
}
