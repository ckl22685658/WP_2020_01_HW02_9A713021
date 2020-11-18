using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW02_9A713021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Poker
        {
            public List<int> GetPoker(int count)
            {

                List<int> result = new List<int>();
                try
                {
                    //新增N筆資料
                    for (int i = 0; i < count; i++)
                    {
                        result.Add(i);
                    }
                    //模擬發牌
                    for (int i = count - 2; i > 0; i--)
                    {
                        int lastIndex = i + 1;                    //方便閱讀
                        int randomIndex = (new Random()).Next(i); //抽牌

                        //交換
                        int temp = result[lastIndex];
                        result[lastIndex] = result[randomIndex];
                        result[randomIndex] = temp;
                    }

                }
                catch (Exception exp)
                {

                    Console.WriteLine(exp.ToString());
                    throw;
                }
                return result;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int v;
            int m;
            int f;
            
            string g;
            string y;
              
            Random rnd = new Random();
            //v = (Rnd() * 51) + 1;
            j += +1;
            if (j == 53)
            {
                MessageBox.Show("已經52張", "已經52張了");
                j = 0;
            }

            Poker p = new Poker();
            List<int> poker = p.GetPoker(52);

            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
            }
            v = numbers[j];
           // v = rnd.Next(1, 51);
            f = (v % 4) + 1;
            m = (v % 13) + 1;
            switch (f)
            {
                case 1:
                    g = "黑桃";
                    break;
                case 2:
                    g = "紅心";
                    break;
                case 3:
                    g = "梅花";
                    break;
                case 4:
                    g = "方塊";
                    break;
                default:
                    g = "黑桃";
                    break;
            }

            //f = Choose(f, Chr(5), Chr(6), Chr(3), Chr(4));

            // m = Choose(m, " k", "A", 2, 3, 4, 5, 6, 7, 8, 9, 10, "J", "Q");
            switch (m)
            {
                case 1:
                    y = "K";
                    break;
                case 2:
                    y = "A";
                    break;
                case 3:
                    y = "2";
                    break;
                case 4:
                    y = "3";
                    break;
                case 5:
                    y = "4";
                    break;
                case 6:
                    y = "5";
                    break;
                case 7:
                    y = "6";
                    break;
                case 8:
                    y = "7";
                    break;
                case 9:
                    y = "8";
                    break;
                case 10:
                    y = "9";
                    break;
                case 11:
                    y = "10";
                    break;
                case 12:
                    y = "J";
                    break;
                case 13:
                    y = "Q";
                    break;
                default:
                    y = "Q";
                    break;
            }
            textBox1.Text = g + y + "\r\n" + textBox1.Text;
            //pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\Hsieh male\\Desktop\\尚霖\\圖片\\A2.JPG");
            if (g == "黑桃")
            {
                if (g == "黑桃" && y == "A")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A1;
                if (g == "黑桃" && y == "2")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A2;
                if (g == "黑桃" && y == "3")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A3;
                if (g == "黑桃" && y == "4")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A4;
                if (g == "黑桃" && y == "5")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A5;
                if (g == "黑桃" && y == "6")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A6;
                if (g == "黑桃" && y == "7")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A7;
                if (g == "黑桃" && y == "8")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A8;
                if (g == "黑桃" && y == "9")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A9;
                if (g == "黑桃" && y == "10")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A10;
                if (g == "黑桃" && y == "J")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A11;
                if (g == "黑桃" && y == "Q")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A12;
                if (g == "黑桃" && y == "K")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.A13;
            }
            if (g == "紅心")
            {
                if (g == "紅心" && y == "A")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B1;
                if (g == "紅心" && y == "2")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B2;
                if (g == "紅心" && y == "3")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B3;
                if (g == "紅心" && y == "4")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B4;
                if (g == "紅心" && y == "5")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B5;
                if (g == "紅心" && y == "6")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B6;
                if (g == "紅心" && y == "7")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B7;
                if (g == "紅心" && y == "8")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B8;
                if (g == "紅心" && y == "9")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B9;
                if (g == "紅心" && y == "10")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B10;
                if (g == "紅心" && y == "J")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B11;
                if (g == "紅心" && y == "Q")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B12;
                if (g == "紅心" && y == "K")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.B13;
            }
            if (g == "梅花")
            {
                if (g == "梅花" && y == "A")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C1;
                if (g == "梅花" && y == "2")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C2;
                if (g == "梅花" && y == "3")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C3;
                if (g == "梅花" && y == "4")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C4;
                if (g == "梅花" && y == "5")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C5;
                if (g == "梅花" && y == "6")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C6;
                if (g == "梅花" && y == "7")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C7;
                if (g == "梅花" && y == "8")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C8;
                if (g == "梅花" && y == "9")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C9;
                if (g == "梅花" && y == "10")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C10;
                if (g == "梅花" && y == "J")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C11;
                if (g == "梅花" && y == "Q")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C12;
                if (g == "梅花" && y == "K")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.C13;
            }
            if (g == "方塊")
            {
                if (g == "方塊" && y == "A")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D1;
                if (g == "方塊" && y == "2")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D2;
                if (g == "方塊" && y == "3")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D3;
                if (g == "方塊" && y == "4")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D4;
                if (g == "方塊" && y == "5")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D5;
                if (g == "方塊" && y == "6")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D6;
                if (g == "方塊" && y == "7")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D7;
                if (g == "方塊" && y == "8")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D8;
                if (g == "方塊" && y == "9")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D9;
                if (g == "方塊" && y == "10")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D10;
                if (g == "方塊" && y == "J")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D11;
                if (g == "方塊" && y == "Q")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D12;
                if (g == "方塊" && y == "K")
                    pictureBox2.BackgroundImage = global::WP_2020_01_HW02_9A713021.Properties.Resources.D13;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> poker = p.GetPoker(52);
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";
                numbers[i] = poker[i];
            }
        }
    }
}
