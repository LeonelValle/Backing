using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backing
{
    public partial class ValidateTakeOut : Form
    {
        Conexion con = new Conexion();
        User operador = new User();
        LootNo lotno = new LootNo();


        public ValidateTakeOut()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                operador.Id = int.Parse(txt_empleado.Text);
                if (txt_empleado.Text == "")
                    throw new Exception();

                operador.Id_user = int.Parse(operador.ReturnValue("select id_user from tb_User where id = " + txt_empleado.Text));

                if (operador.Id_user > 0)
                {
                    //rl.Crud("update ReceiveLabels set TransStatus = 'Disposed', IdDisponse = '" + operador.Id_user + "', DateDisponse = '" + DateTime.Now + "' where Labels ='" + rl.Labels + "'");

                    lotno.Crud("update tb_LotNo set takeout = 1, TakeOurDate = '" + DateTime.Now + "', id_TO = '" + operador.Id_user + "' where id_lotno = '" + lotno.Id_lotno + "'");

                    //MessageBox.Show("Material Disposed!");

                    this.Close();

                    Form1 frm = new Form1();

                    frm.Show();
                }
                else
                {
                    MessageBox.Show("No se encontro");
                    txt_empleado.Text = "";
                }

                con.Cerrar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existe ese registro", "ERROR!");
                con.Cerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found!");
            }
        }

        private void txt_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_aceptar_Click(this, new EventArgs());
            }
        }
    }
}
