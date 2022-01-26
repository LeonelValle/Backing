using System;
using System.Windows.Forms;

namespace Backing
{
    public partial class Validate : Form
    {
        User user = new User();
        LootNo lotno = new LootNo();

        public Validate()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (user.Existe("select count(*) from tb_User where id = '" + txt_Quality.Text + "'") && user.Existe("select count(*) from tb_User where id = '" + txt_Eng.Text + "'") && !string.IsNullOrEmpty(txt_BakeAt.Text) && !string.IsNullOrEmpty(txt_time.Text))// && txt_Eng.Text != txt_Quality.Text)
            {
                user.Quality = int.Parse(txt_Quality.Text);
                user.Eng = int.Parse(txt_Eng.Text);

                lotno.Bake = txt_BakeAt.Text;
                lotno.Time = txt_time.Text;

                this.Close();

                Form1 frm = new Form1();

                frm.Show();
            }
        }

        private void Validate_Load(object sender, EventArgs e)
        {

        }
    }
}
