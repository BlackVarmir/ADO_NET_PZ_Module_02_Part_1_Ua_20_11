using System.Dynamic;
using System.Windows.Forms;

namespace ADO_NET_ПЗ_Модуль_02_Частина_1_Ua
{
    /*using System;
    using System.Windows.Forms;
    using Microsoft.Data.Sqlite;
    using System.Threading.Tasks;*/

    public partial class Form1 : Form
    {

        private readonly FuncDataBase dataBase = new FuncDataBase();

        public Form1()
        {
            InitializeComponent();
            dataBase.CreatDataBase();
            dataBase.PrintDataBase(dataGridView1);
            comboBoxType.SelectedIndex = 0;
            comboBoxMan.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (dataBase.Connect())
            {
                dataBase.PrintDataBase(dataGridView1);
                AllInfo.Checked = true;
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            dataBase.Disconnect(dataGridView1);
        }

        private void AllInfo_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintDataBase(dataGridView1);
        }

        private void AllType_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintAllType(dataGridView1);
        }

        private void AllMan_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintAllMan(dataGridView1);
        }

        private void MaxQuantity_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintMaxQuantity(dataGridView1);
        }

        private void MinQuantity_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintMinQuantity(dataGridView1);
        }

        private void MaxCP_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintMaxCostPrice(dataGridView1);
        }

        private void MinCP_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintMinCostPrice(dataGridView1);
        }

        private void WareHouseByCategory_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintWareHouseByCategory(dataGridView1, comboBoxType.Text, WareHouseByCategory);
        }

        private void WareHouseByCategory_CheckedChanged_1(object sender, EventArgs e)
        {
            dataBase.PrintWareHouseByCategory(dataGridView1, comboBoxType.Text, WareHouseByCategory);
        }

        private void WareHouseByMan_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintWareHouseByMan(dataGridView1, comboBoxMan.Text, WareHouseByMan);
        }

        private void Old_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintWareHouseOld(dataGridView1);
        }

        private void AvarageByType_CheckedChanged(object sender, EventArgs e)
        {
            dataBase.PrintAvarageByType(dataGridView1);
        }
    }
}
