using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Backing
{
    public partial class Reports : Form
    {
        LootNo lotno = new LootNo();
        public Reports()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            dg_Reports.DataSource = lotno.LlenarDG("select lotcode,p.partno,Due, usr.id as 'Due ID',usr.name as 'DueBy',ln.startDate,ln.Bake, ln.hours, ln.rev, Qty, Wo, lotno, TakeOurDate, tb_User.id as 'TakeOut ID By',tb_User.name as 'TakeOut By' from tb_Lotno ln join tb_Part p on ln.id_part = p.id_part left join tb_User usr on usr.id_user = ln.id_user left join tb_User on tb_User.id_user = ln.id_TO").Tables[0];
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            if (dg_Reports.Rows.Count != 0)
                SaveToCSV(dg_Reports);
            else
                MessageBox.Show("No hay ninguna orden cargada!", "ERROR!");
        }

        private void SaveToCSV(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Fichero CSV (*.csv)|*.csv",
                FileName = "",
                Title = "Exportar a CSV"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < DGV.Columns.Count; i++)
                {
                    if (i == DGV.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            DGV.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\",",
                            DGV.Columns[i].HeaderText));
                    }
                }

                csvMemoria.AppendLine();


                for (int m = 0; m < DGV.Rows.Count; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }

                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlGuardar.FileName, false, System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }


    }
}
