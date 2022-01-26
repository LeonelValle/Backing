using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace Backing
{
    public partial class Form1 : Form
    {
        Part part = new Part();
        LootNo lotno = new LootNo();
        WO wo = new WO();
        User user = new User();
        BakeTime bt = new BakeTime();
        //System.Windows.Forms.Timer timer1 = new Timer();
        Dictionary<int, Stopwatch> swDct = new Dictionary<int, Stopwatch>();
        DataTable dtStopwatches = new DataTable();
        //int nextID = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lotno.Bake = "125";

            cb_pkg.DataSource = part.LlenarComboBox("select * from tb_Pkg");
            cb_pkg.DisplayMember = "pkg";
            cb_pkg.ValueMember = "id_pkg";
            cb_pkg.SelectedValue = -1;

            cb_PartNo.DataSource = part.LlenarComboBox("select id_part, partno from tb_Part");
            cb_PartNo.DisplayMember = "partno";
            cb_PartNo.ValueMember = "id_part";
            cb_PartNo.SelectedValue = -1;

            cb_MSL.SelectedValue = -1;
            cb_Thickness.SelectedValue = -1;

            //cb_Thickness.DataSource = bt.LlenarComboBox("select * from tb_BackingTime");

            //.ColumnCount = 2;
            dg_Oven.Columns[0].Name = "TakeOut";
            dg_Oven.Columns[1].Name = "Stop";
            //dg_Oven.Columns.Add("Elapsed", "Elapsed");
            //dg_Oven.Rows.Add("1");
            //dg_Oven.Rows.Add("2");

            dtStopwatches.Columns.Add("Name", typeof(string));
            dtStopwatches.Columns.Add("ID", typeof(int));
            dtStopwatches.Columns.Add("Elapsed", typeof(string));

            dtStopwatches = lotno.LlenarDG("select lc.id_lotno, lc.lotno, part.partno, lc.Qty, lc.Wo, usr.name as 'Bake By', lc.startDate, lc.Due, Concat(lc.Bake, ' C for ',DATEDIFF(HOUR, lc.startDate, lc.Due),' Hrs') as 'Bake C/Hrs' from tb_LotNo lc join tb_Part part on lc.id_part = part.id_part join tb_User usr on  usr.id_user = lc.id_user where takeout = 0").Tables[0];

            dg_Oven.DataSource = dtStopwatches;
            dg_Oven.Columns[2].Visible = false;
            dg_Oven.Columns[1].Visible = false;


            if (!string.IsNullOrEmpty(user.Eng.ToString()) && !string.IsNullOrEmpty(user.Quality.ToString()))
            {
                txt_BakeC.Text = lotno.Bake;
                txt_BakeTime.Text = lotno.Time;
                cb_PartNo.SelectedValue = part.Id_part;

            }


            //foreach (string buttonName in new string[] { "Start", "Stop", "Reset", "Restart" })
            //{
            //    DataGridViewButtonColumn colTemp = new DataGridViewButtonColumn();
            //    colTemp.Name = buttonName + "Col";
            //    colTemp.HeaderText = buttonName;
            //    colTemp.Width = 50;
            //    dg_Oven.Columns.Add(colTemp);
            //}


            //timer1.Tick += (timer1_Tick);
            ////timer1.Interval = 50;

            //timer1.Start();



        }


        private void txt_Wo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    FillText();

            //}
        }

        private void FillText()
        {
            if (wo.ExisteROI("SELECT COUNT(*) FROM OPENQUERY([VOYAGER], 'select * from WO_v_1 where Wo_Nbr = ''" + txt_LotCode.Text + "''')"))
            {
                part.partno = wo.GetROI("SELECT left(Part_Nbr,len(Part_Nbr)-3) FROM OPENQUERY([VOYAGER], 'select Part_Nbr from WO_v_1 where Wo_Nbr = ''" + txt_LotCode.Text + "''')");
                cb_PartNo.Text = part.partno;

                try
                {
                    var leer = part.Leer("SELECT * FROM tb_Part where partno = '" + part.partno + "'");

                    if (leer.Read() == true)
                    {

                        txt_PartDesc.Text = leer["descr"].ToString();
                        //txt_Rev.Text = leer["rev"].ToString();
                        cb_Thickness.Text = leer["thickness"].ToString();
                        cb_MSL.Text = leer["level"].ToString();
                        //txt_Level.Text = leer["level"].ToString();

                    }
                    else
                    {
                        txt_PartDesc.Text = "";
                        //txt_Rev.Text = "";
                        cb_Thickness.SelectedValue = -1;
                        cb_MSL.SelectedValue = -1;
                        //txt_Level.Text = "";
                    }
                    wo.Cerrar();

                    txt_BakeTime.Text = bt.ReturnValue("select bakeTime from tb_BackingTime where thickLow <= '" + cb_Thickness.Text + "' and thickHigh >= '" + cb_Thickness.Text + "' and level = '" + cb_MSL.Text + "'");
                }
                catch (System.InvalidOperationException)
                {
                    wo.Cerrar();
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            //nextID++;
            //dtStopwatches.Rows.Add("Stopwatch #" + nextID.ToString(), nextID, "00:00.00");
            //swDct.Add(nextID, new Stopwatch());

            //Stopwatch swTemp = swDct[nextID];

            //swTemp.Start();

            user.Id_user = int.Parse(user.ReturnID("select id_user from tb_User where id = '" + txt_Employ.Text + "'"));
            //part.hours = int.Parse(part.ReturnValue(""));


            if (!string.IsNullOrEmpty(txt_Employ.Text))
            {
                lotno.Crud("insert into tb_LotNo(lotcode, startDate, Due, id_user, id_part, Qty, Wo, Bake, hours,lotno, takeout) values('" + txt_LotCode.Text + "','" + DateTime.Now + "','" + DateTime.Now.AddHours(int.Parse(bt.bakeTime))
                    + "','" + user.Id_user + "','" + cb_PartNo.SelectedValue + "','" + txt_Qty.Text + "','" + txt_WO.Text + "','" + lotno.Bake + "','" + bt.bakeTime + "','" + txt_LotNo.Text + "', '0')");

                Form1_Load(sender, e);
                ClearTextboxes();
            }
            else
            {
                txt_Employ.ForeColor = Color.Red;
                txt_Employ.Focus();
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }

        void ClearTextboxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            cb_Thickness.SelectedValue = -1;
            cb_MSL.SelectedValue = -1;
            cb_PartNo.SelectedValue = -1;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Validate no = new Validate();

            part.Id_part = (int)cb_PartNo.SelectedValue;

            no.Show();
            this.Hide();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        public void TimerBake()
        {
            //Timer timer = new Timer();
            //timer.Interval = (10 * 1000); // 10 secs
            //timer.Tick += new EventHandler(timer1_Tick);
            //timer.Start();
            //lbl_test.Text = "change text";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (DataRow dRow in dtStopwatches.Rows)
            {
                String elapsedString = swDct[(int)dRow["ID"]].Elapsed.ToString(@"mm\:ss\.ff");
                String elapsedString2 = swDct[(int)dRow["ID"]].Elapsed.ToString(@"hh\:mm\:ss");
                //TimeSpan.Parse("00:10:00");
                //TimeSpan.Parse(elapsedString2);


                dRow["Elapsed"] = elapsedString;
                //if (Convert.ToDateTime(elapsedString).Second >= Convert.ToDateTime(DateTime.Now.Second).Second)
                if (TimeSpan.Parse(elapsedString2) == TimeSpan.Parse("00:00:10"))
                {
                    MessageBox.Show("I will be call every minutes !!!");

                }
            }
            //System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromSeconds(10).TotalMilliseconds);
            //timer.AutoReset = true;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(MyMethod);
            //timer.Start();


            timer1.Start();
        }

        public void MyMethod(object sender, ElapsedEventArgs e)
        {
            timer1.Stop();

            MessageBox.Show("I will be call every minutes !!!");
            TimerBake();
            timer1.Start();
        }

        private void cb_PartNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            part.thickness = part.ReturnValue("select thickness from tb_Part where id_part = '" + cb_PartNo.SelectedValue + "'");
            part.msl = part.ReturnValue("select msl from tb_Part where id_part = '" + cb_PartNo.SelectedValue + "'");
            part.descr = part.ReturnValue("select descr from tb_Part where id_part = '" + cb_PartNo.SelectedValue + "'");
            part.Assy = part.ReturnValue("select Assy from tb_Part where id_part = '" + cb_PartNo.SelectedValue + "'");
            part.Id_pkg = int.Parse(part.ReturnValue("select id_pkg from tb_Part where id_part = '" + cb_PartNo.SelectedValue + "'"));

            cb_Thickness.Text = part.thickness;
            cb_MSL.Text = part.msl;
            cb_pkg.SelectedValue = part.Id_pkg;
            txt_Assy.Text = part.Assy;
            //txt_LotCode.Text = part.lo;
            txt_PartDesc.Text = part.descr;


            if (part.thickness != "0" && part.level != "0")
            {
                if (part.msl == "0")
                {
                    bt.bakeTime = "6";
                    txt_BakeTime.Text = bt.bakeTime;
                    txt_BakeC.Text = "125";
                }
                else
                {
                    bt.bakeTime = bt.ReturnValue("select bakeTime from tb_BackingTime where thickLow <= '" + part.thickness + "' and thickHigh >= '" + part.thickness + "' and level = '" + part.msl + "'");
                    txt_BakeTime.Text = bt.bakeTime;
                    txt_BakeC.Text = "125";
                }


            }
        }

        private void dg_Oven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dg_Oven.Columns["TakeOut"].Index)
            {
                DataGridViewRow row = this.dg_Oven.Rows[e.RowIndex];
                if (Convert.ToDateTime(row.Cells["Due"].Value.ToString()) <= DateTime.Now)
                {
                    if (e.RowIndex >= 0)
                    {
                        //DataGridViewRow row = this.dg_Oven.Rows[e.RowIndex];
                        lotno.Id_lotno = int.Parse(row.Cells["id_lotno"].Value.ToString());

                        ValidateTakeOut vto = new ValidateTakeOut();


                        vto.Show();

                        this.Hide();

                        //lotno.Crud("update tb_LotNo set takeout = 1, TakeOurDate = '" + DateTime.Now + "' where id_lotno = '" + lotno.id_lotno + "'");

                        //MessageBox.Show("Take Out!");
                        Form1_Load(sender, e);
                    }
                }
                else
                    MessageBox.Show("not enough time has passed");

            }
        }

        private void Llbl_Reports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
