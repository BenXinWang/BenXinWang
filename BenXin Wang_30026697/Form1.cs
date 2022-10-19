using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;

        private double[] Numbers1 = new double[3];//存储购买总额，应付金额，找零
        private int[] Numbers2 = new int[15];//存储购买的数量
        private double[] Number3 = new double[15];//存储一件商品的总价
        private string[] Number4 = new string[15];//存储在shopping list的输出
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = 0x20000;
                return cp;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Application1.Properties.Resources.Hi);
            sp.Play();
            sp.Dispose();
            DustbinP.AllowDrop = true;
            Slot.AllowDrop = true;
            timer1.Enabled = false;
        }
        private void FantaOrange_MouseMove(object sender, MouseEventArgs e)
        {
            FantaOrange.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void FantaOrange_MouseLeave(object sender, EventArgs e)
        {
            FantaOrange.BackColor = Color.White;
        }
        private void CocaColaZeroSugar_MouseMove(object sender, MouseEventArgs e)
        {
            CocaColaZeroSugar.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void CocaColaZeroSugar_MouseLeave(object sender, EventArgs e)
        {
            CocaColaZeroSugar.BackColor = Color.White;
        }
        private void DietCoke_MouseMove(object sender, MouseEventArgs e)
        {
            DietCoke.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void DietCoke_MouseLeave(object sender, EventArgs e)
        {
            DietCoke.BackColor = Color.White;
        }
        private void Sprite_MouseMove(object sender, MouseEventArgs e)
        {
            Sprite.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void Sprite_MouseLeave(object sender, EventArgs e)
        {
            Sprite.BackColor = Color.White;
        }
        private void ChickenBaconSandwich_MouseMove(object sender, MouseEventArgs e)
        {
            ChickenBaconSandwich.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void ChickenBaconSandwich_MouseLeave(object sender, EventArgs e)
        {
            ChickenBaconSandwich.BackColor = Color.White;
        }
        private void MayonnaiseSandwich_MouseMove(object sender, MouseEventArgs e)
        {
            MayonnaiseSandwich.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void MayonnaiseSandwich_MouseLeave(object sender, EventArgs e)
        {
            MayonnaiseSandwich.BackColor = Color.White;
        }
        private void CheeseOnionSandwich_MouseMove(object sender, MouseEventArgs e)
        {
            CheeseOnionSandwich.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void CheeseOnionSandwich_MouseLeave(object sender, EventArgs e)
        {
            CheeseOnionSandwich.BackColor = Color.White;
        }
        private void BeefBurger_MouseMove(object sender, MouseEventArgs e)
        {
            BeefBurger.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void BeefBurger_MouseLeave(object sender, EventArgs e)
        {
            BeefBurger.BackColor = Color.White;
        }
        private void CheddarOnionCrisps_MouseMove(object sender, MouseEventArgs e)
        {
            CheddarOnionCrisps.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void CheddarOnionCrisps_MouseLeave(object sender, EventArgs e)
        {
            CheddarOnionCrisps.BackColor = Color.White;
        }
        private void PrawnMarieRoseCrisps_MouseMove(object sender, MouseEventArgs e)
        {
            PrawnMarieRoseCrisps.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void PrawnMarieRoseCrisps_MouseLeave(object sender, EventArgs e)
        {
            PrawnMarieRoseCrisps.BackColor = Color.White;
        }
        private void LightlySaltedCrisps_MouseMove(object sender, MouseEventArgs e)
        {
            LightlySaltedCrisps.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void LightlySaltedCrisps_MouseLeave(object sender, EventArgs e)
        {
            LightlySaltedCrisps.BackColor = Color.White;
        }
        private void RoastBeefCrisps_MouseMove(object sender, MouseEventArgs e)
        {
            RoastBeefCrisps.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void RoastBeefCrisps_MouseLeave(object sender, EventArgs e)
        {
            RoastBeefCrisps.BackColor = Color.White;
        }
        private void KinderSurpriseEgg_MouseMove(object sender, MouseEventArgs e)
        {
            KinderSurpriseEgg.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void KinderSurpriseEgg_MouseLeave(object sender, EventArgs e)
        {
            KinderSurpriseEgg.BackColor = Color.White;
        }
        private void OrangeChocolateBar_MouseMove(object sender, MouseEventArgs e)
        {
            OrangeChocolateBar.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void OrangeChocolateBar_MouseLeave(object sender, EventArgs e)
        {
            OrangeChocolateBar.BackColor = Color.White;
        }
        private void ChocolateDigestives_MouseMove(object sender, MouseEventArgs e)
        {
            ChocolateDigestives.BackColor = Color.FromArgb(192, 192, 255);
        }
        private void ChocolateDigestives_MouseLeave(object sender, EventArgs e)
        {
            ChocolateDigestives.BackColor = Color.White;
        }
        private void CheckOut_Click(object sender, EventArgs e)
        {
            TimerLabel.Text = "30";
            Label.Text = "Check Out";
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Application1.Properties.Resources.CheckOut);
            sp.Play();
            sp.Dispose();
            FantaOrange.Enabled = false;
            CocaColaZeroSugar.Enabled = false;
            DietCoke.Enabled = false;
            Sprite.Enabled = false;
            FantaOrange.Enabled = false;
            ChickenBaconSandwich.Enabled = false;
            MayonnaiseSandwich.Enabled = false;
            CheeseOnionSandwich.Enabled = false;
            BeefBurger.Enabled = false;
            CheddarOnionCrisps.Enabled = false;
            PrawnMarieRoseCrisps.Enabled = false;
            LightlySaltedCrisps.Enabled = false;
            RoastBeefCrisps.Enabled = false;
            KinderSurpriseEgg.Enabled = false;
            OrangeChocolateBar.Enabled = false;
            ChocolateDigestives.Enabled = false;
            DustbinP.AllowDrop = false;
            Numbers1[1] = Numbers1[0];
        }
        private void Cancel_Click(object sender, EventArgs e)//仅显示标题及正文文字，附带OK和Cancel选项
        {
            TimerLabel.Text = "30";
            Label.Text = "Cancel";
            if (MessageBox.Show("Are you sure you want to cancel? You will lose all your purchases.", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Array.Clear(Numbers1, 0, 3);
            Array.Clear(Numbers2, 0, 15);
            Array.Clear(Number3, 0, 15);
            Array.Clear(Number4, 0, 15);
            textBox1.Clear();
            Shopping_List.Items.Clear();
            Total_Price.Items.Clear();
            DietCoke.Enabled = true;
            Sprite.Enabled = true;
            CocaColaZeroSugar.Enabled = true;
            FantaOrange.Enabled = true;
            ChickenBaconSandwich.Enabled = true;
            MayonnaiseSandwich.Enabled = true;
            CheeseOnionSandwich.Enabled = true;
            BeefBurger.Enabled = true;
            CheddarOnionCrisps.Enabled = true;
            PrawnMarieRoseCrisps.Enabled = true;
            LightlySaltedCrisps.Enabled = true;
            RoastBeefCrisps.Enabled = true;
            KinderSurpriseEgg.Enabled = true;
            OrangeChocolateBar.Enabled = true;
            ChocolateDigestives.Enabled = true;
            DustbinP.AllowDrop = true;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void FantaOrange_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[0] == 0)
            {
                Numbers2[0]++;
                Number3[0] = 1.00 * Numbers2[0];
                Numbers1[0] += 1.00;
                Number4[0] = "Fanta Orange *" + Numbers2[0] + "     £" + Number3[0];
                Shopping_List.Items.Add(Number4[0]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[0]++;
                Number3[0] = 1.00 * Numbers2[0];
                Numbers1[0] += 1.00;
                int index = Shopping_List.Items.IndexOf(Number4[0]);
                Shopping_List.Items.RemoveAt(index);
                Number4[0] = "Fanta Orange *" + Numbers2[0] + "     £" + Number3[0];
                Shopping_List.Items.Insert(index, Number4[0]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Fanta Orange";
        }
        private void CocaColaZeroSugar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[1] == 0)
            {
                Numbers2[1]++;
                Number3[1] = 1.50 * Numbers2[1];
                Numbers1[0] += 1.50;
                Number4[1] = "Coca Cola Zero Sugar *" + Numbers2[1] + "     £" + Number3[1];
                Shopping_List.Items.Add(Number4[1]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[1]++;
                Number3[1] = 1.50 * Numbers2[1];
                Numbers1[0] += 1.50;
                int index = Shopping_List.Items.IndexOf(Number4[1]);
                Shopping_List.Items.RemoveAt(index);
                Number4[1] = "Coca Cola Zero Sugar *" + Numbers2[1] + "     £" + Number3[1];
                Shopping_List.Items.Insert(index, Number4[1]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Coca Cola Zero Sugar";
        }
        private void DietCoke_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[2] == 0)
            {
                    Numbers2[2]++;
                    Number3[2] = 1.50 * Numbers2[2];
                    Numbers1[0] += 1.50;
                    Number4[2] = "Diet Coke *" + Numbers2[2] + "     £" + Number3[2];
                    Shopping_List.Items.Add(Number4[2]);
                    Total_Price.Items.Clear();
                    Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                    Numbers2[2]++;
                    Number3[2] = 1.50 * Numbers2[2];
                    Numbers1[0] += 1.50;
                    int index = Shopping_List.Items.IndexOf(Number4[2]);
                    Shopping_List.Items.RemoveAt(index);
                    Number4[2] = "Diet Coke *" + Numbers2[2] + "     £" + Number3[2];
                    Shopping_List.Items.Insert(index, Number4[2]);
                    Total_Price.Items.Clear();
                    Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Diet Coke";

        }
        private void Sprite_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[3] == 0)
            {
                Numbers2[3]++;
                Number3[3] = 1.00 * Numbers2[3];
                Numbers1[0] += 1.00;
                Number4[3] = "Sprite *" + Numbers2[3] + "     £" + Number3[3];
                Shopping_List.Items.Add(Number4[3]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[3]++;
                Number3[3] = 1.00 * Numbers2[3];
                Numbers1[0] += 1.00;
                int index = Shopping_List.Items.IndexOf(Number4[3]);
                Shopping_List.Items.RemoveAt(index);
                Number4[3] = "Sprite *" + Numbers2[3] + "     £" + Number3[3];
                Shopping_List.Items.Insert(index, Number4[3]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Sprite";
        }

        private void ChickenBaconSandwich_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[4] == 0)
            {
                Numbers2[4]++;
                Number3[4] = 3.50 * Numbers2[4];
                Numbers1[0] += 3.50;
                Number4[4] = "Chicken Bacon Sandwich *" + Numbers2[4] + "     £" + Number3[4];
                Shopping_List.Items.Add(Number4[4]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[4]++;
                Number3[4] = 3.50 * Numbers2[4];
                Numbers1[0] += 3.50;
                int index = Shopping_List.Items.IndexOf(Number4[4]);
                Shopping_List.Items.RemoveAt(index);
                Number4[4] = "Chicken Bacon Sandwich *" + Numbers2[4] + "     £" + Number3[4];
                Shopping_List.Items.Insert(index, Number4[4]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Chicken Bacon Sandwich";
        }

        private void MayonnaiseSandwich_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[5] == 0)
            {
                Numbers2[5]++;
                Number3[5] = 3.50 * Numbers2[5];
                Numbers1[0] += 3.50;
                Number4[5] = "Mayonnaise Sandwich *" + Numbers2[5] + "     £" + Number3[5];
                Shopping_List.Items.Add(Number4[5]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[5]++;
                Number3[5] = 3.50 * Numbers2[5];
                Numbers1[0] += 3.50;
                int index = Shopping_List.Items.IndexOf(Number4[5]);
                Shopping_List.Items.RemoveAt(index);
                Number4[5] = "Mayonnaise Sandwich *" + Numbers2[5] + "     £" + Number3[5];
                Shopping_List.Items.Insert(index, Number4[5]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Mayonnaise Sandwich";
        }

        private void CheeseOnionSandwich_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[6] == 0)
            {
                Numbers2[6]++;
                Number3[6] = 3.00 * Numbers2[6];
                Numbers1[0] += 3.00;
                Number4[6] = "Cheese Onion Sandwich *" + Numbers2[6] + "     £" + Number3[6];
                Shopping_List.Items.Add(Number4[6]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[6]++;
                Number3[6] = 3.00 * Numbers2[6];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[6]);
                Shopping_List.Items.RemoveAt(index);
                Number4[6] = "Cheese Onion Sandwich *" + Numbers2[6] + "     £" + Number3[6];
                Shopping_List.Items.Insert(index, Number4[6]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Cheese Onion Sandwich";
        }

        private void BeefBurger_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[7] == 0)
            {
                Numbers2[7]++;
                Number3[7] = 4.00 * Numbers2[7];
                Numbers1[0] += 4.00;
                Number4[7] = "Beef Burger *" + Numbers2[7] + "     £" + Number3[7];
                Shopping_List.Items.Add(Number4[7]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[7]++;
                Number3[7] = 4.00 * Numbers2[7];
                Numbers1[0] += 4.00;
                int index = Shopping_List.Items.IndexOf(Number4[7]);
                Shopping_List.Items.RemoveAt(index);
                Number4[7] = "Beef Burger *" + Numbers2[7] + "     £" + Number3[7];
                Shopping_List.Items.Insert(index, Number4[7]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Beef Burger";
        }

        private void CheddarOnionCrisps_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[8] == 0)
            {
                Numbers2[8]++;
                Number3[8] = 3.00 * Numbers2[8];
                Numbers1[0] += 3.00;
                Number4[8] = "Cheddar Onion Crisps *" + Numbers2[8] + "     £" + Number3[8];
                Shopping_List.Items.Add(Number4[8]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[8]++;
                Number3[8] = 3.00 * Numbers2[8];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[8]);
                Shopping_List.Items.RemoveAt(index);
                Number4[8] = "Cheddar Onion Crisps *" + Numbers2[8] + "     £" + Number3[8];
                Shopping_List.Items.Insert(index, Number4[8]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Cheddar Onion Crisps";
        }
        private void PrawnMarieRoseCrisps_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[9] == 0)
            {
                Numbers2[9]++;
                Number3[9] = 3.00 * Numbers2[9];
                Numbers1[0] += 3.00;
                Number4[9] = "Prawn Marie Rose Crisps *" + Numbers2[9] + "     £" + Number3[9];
                Shopping_List.Items.Add(Number4[9]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[9]++;
                Number3[9] = 3.00 * Numbers2[9];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[9]);
                Shopping_List.Items.RemoveAt(index);
                Number4[9] = "Prawn Marie Rose Crisps *" + Numbers2[9] + "     £" + Number3[9];
                Shopping_List.Items.Insert(index, Number4[9]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Prawn Marie Rose Crisps";
        }
        private void LightlySaltedCrisps_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[10] == 0)
            {
                Numbers2[10]++;
                Number3[10] = 3.00 * Numbers2[10];
                Numbers1[0] += 3.00;
                Number4[10] = "Lightly Salted Crisps *" + Numbers2[10] + "     £" + Number3[10];
                Shopping_List.Items.Add(Number4[10]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[10]++;
                Number3[10] = 3.00 * Numbers2[10];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[10]);
                Shopping_List.Items.RemoveAt(index);
                Number4[10] = "Lightly Salted Crisps *" + Numbers2[10] + "     £" + Number3[10];
                Shopping_List.Items.Insert(index, Number4[10]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Lightly Salted Crisps";
        }
        private void RoastBeefCrisps_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[11] == 0)
            {
                Numbers2[11]++;
                Number3[11] = 3.00 * Numbers2[11];
                Numbers1[0] += 3.00;
                Number4[11] = "Roast Beef Crisps *" + Numbers2[11] + "     £" + Number3[11];
                Shopping_List.Items.Add(Number4[11]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[11]++;
                Number3[11] = 3.00 * Numbers2[11];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[11]);
                Shopping_List.Items.RemoveAt(index);
                Number4[11] = "Roast Beef Crisps *" + Numbers2[11] + "     £" + Number3[11];
                Shopping_List.Items.Insert(index, Number4[11]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Roast Beef Crisps";
        }
        private void KinderSurpriseEgg_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[12] == 0)
            {
                Numbers2[12]++;
                Number3[12] = 2.00 * Numbers2[12];
                Numbers1[0] += 2.00;
                Number4[12] = "Kinder Surprise Egg *" + Numbers2[12] + "     £" + Number3[12];
                Shopping_List.Items.Add(Number4[12]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[12]++;
                Number3[12] = 2.00 * Numbers2[12];
                Numbers1[0] += 2.00;
                int index = Shopping_List.Items.IndexOf(Number4[12]);
                Shopping_List.Items.RemoveAt(index);
                Number4[12] = "Kinder Surprise Egg *" + Numbers2[12] + "     £" + Number3[12];
                Shopping_List.Items.Insert(index, Number4[12]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Kinder Surprise Egg";
        }
        private void OrangeChocolateBar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[13] == 0)
            {
                Numbers2[13]++;
                Number3[13] = 2.50 * Numbers2[13];
                Numbers1[0] += 2.50;
                Number4[13] = "Orange Chocolate Bar *" + Numbers2[13] + "     £" + Number3[13];
                Shopping_List.Items.Add(Number4[13]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[13]++;
                Number3[13] = 2.50 * Numbers2[13];
                Numbers1[0] += 2.50;
                int index = Shopping_List.Items.IndexOf(Number4[13]);
                Shopping_List.Items.RemoveAt(index);
                Number4[13] = "Orange Chocolate Bar *" + Numbers2[13] + "     £" + Number3[13];
                Shopping_List.Items.Insert(index, Number4[13]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Orange Chocolate Bar";
        }
        private void ChocolateDigestives_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            TimerLabel.Text = "30";
            if (Numbers2[14] == 0)
            {
                Numbers2[14]++;
                Number3[14] = 3.00 * Numbers2[14];
                Numbers1[0] += 3.00;
                Number4[14] = "Chocolate Digestives *" + Numbers2[14] + "     £" + Number3[14];
                Shopping_List.Items.Add(Number4[14]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else
            {
                Numbers2[14]++;
                Number3[14] = 3.00 * Numbers2[14];
                Numbers1[0] += 3.00;
                int index = Shopping_List.Items.IndexOf(Number4[14]);
                Shopping_List.Items.RemoveAt(index);
                Number4[14] = "Chocolate Digestives *" + Numbers2[14] + "     £" + Number3[14];
                Shopping_List.Items.Insert(index, Number4[14]);
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Label.Text = "Purchase Chocolate Digestives";
        }
        private void Shopping_List_MouseDown(object sender, MouseEventArgs e)
        {
            if (Shopping_List.Items.Count > 0)
            {
                Shopping_List.DoDragDrop(Shopping_List.SelectedItem, DragDropEffects.Move);
            }
        }

        private void DustbinP_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DustbinP_DragDrop(object sender, DragEventArgs e)
        {
            TimerLabel.Text = "30";
            if (Shopping_List.SelectedItem.ToString() == Number4[0])
            {
                Label.Text = "Deleted Fanta Orange";
                Numbers2[0] = 0;
                Numbers1[0] -=Number3[0];
                Number3[0] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if(Shopping_List.SelectedItem.ToString() == Number4[1])
            {
                Label.Text = "Deleted Coca Cola Zero Sugar";
                Numbers2[1] = 0;
                Numbers1[0] -= Number3[1];
                Number3[1] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[2])
            {
                Label.Text = "Deleted Diet Coke";
                Numbers2[2] = 0;
                Numbers1[0] -= Number3[2];
                Number3[2] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[3])
            {
                Label.Text = "Deleted Sprite";
                Numbers2[3] = 0;
                Numbers1[0] -= Number3[3];
                Number3[3] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[4])
            {
                Label.Text = "Deleted Chicken Bacon Sandwich";
                Numbers2[4] = 0;
                Numbers1[0] -= Number3[4];
                Number3[4] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[5])
            {
                Label.Text = "Deleted Mayonnaise Sandwich";
                Numbers2[5] = 0;
                Numbers1[0] -= Number3[5];
                Number3[5] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[6])
            {
                Label.Text = "Deleted Cheese Onion Sandwich";
                Numbers2[6] = 0;
                Numbers1[0] -= Number3[6];
                Number3[6] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[7])
            {
                Label.Text = "Deleted Beef Burger";
                Numbers2[7] = 0;
                Numbers1[0] -= Number3[7];
                Number3[7] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[8])
            {
                Label.Text = "Deleted Cheddar Onion Crisps";
                Numbers2[8] = 0;
                Numbers1[0] -= Number3[8];
                Number3[8] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[9])
            {
                Label.Text = "Deleted Prawn Marie Rose Crisps";
                Numbers2[9] = 0;
                Numbers1[0] -= Number3[9];
                Number3[9] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[10])
            {
                Label.Text = "Deleted Lightly Salted Crisps";
                Numbers2[10] = 0;
                Numbers1[0] -= Number3[10];
                Number3[10] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[11])
            {
                Label.Text = "Deleted Roast Beef Crisps";
                Numbers2[11] = 0;
                Numbers1[0] -= Number3[11];
                Number3[11] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[12])
            {
                Label.Text = "Deleted Kinder Surprise Egg";
                Numbers2[12] = 0;
                Numbers1[0] -= Number3[12];
                Number3[12] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[13])
            {
                Label.Text = "Deleted Orange Chocolate Bar";
                Numbers2[13] = 0;
                Numbers1[0] -= Number3[13];
                Number3[13] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            else if (Shopping_List.SelectedItem.ToString() == Number4[14])
            {
                Label.Text = "Deleted Chocolate Digestives";
                Numbers2[14] = 0;
                Numbers1[0] -= Number3[14];
                Number3[14] = 0;
                Total_Price.Items.Clear();
                Total_Price.Items.Add("£" + Numbers1[0]);
            }
            Shopping_List.Items.RemoveAt(Shopping_List.SelectedIndex);
           
        }

        private void _50Pence_MouseDown(object sender, MouseEventArgs e)
        {
            Label.Text = "Put in 50 pence";
            _50Pence.DoDragDrop(_50Pence.Image, DragDropEffects.Copy);
                Numbers1[1] -= 0.50;
                textBox1.AppendText("amount payable: £" + Numbers1[1]); 
           if(Numbers1[1] <= 0)
            {
                Numbers1[2] = -1 * Numbers1[1];
                string str;
                str = "\nThe total price:" + Numbers1[0] + "    " + "Change:" + Numbers1[2] + "\nShopping List:";
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\txtwriter.txt", true);
                sw.WriteLine(str);
                for (int i = 0; i < 15; i++)
                {
                    if (Numbers2[i] != 0)
                    {
                        sw.WriteLine(Number4[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Payment has been completed, Change: £" + Numbers1[2], "Remind", MessageBoxButtons.OK, MessageBoxIcon.Question); 
                Array.Clear(Numbers1,0,3);
                Array.Clear(Numbers2, 0, 15);
                Array.Clear(Number3, 0, 15);
                Array.Clear(Number4, 0, 15);
                textBox1.Clear();
                Shopping_List.Items.Clear();
                Total_Price.Items.Clear();
                DietCoke.Enabled = true;
                Sprite.Enabled = true;
                CocaColaZeroSugar.Enabled = true;
                FantaOrange.Enabled = true;
                ChickenBaconSandwich.Enabled = true;
                MayonnaiseSandwich.Enabled = true;
                CheeseOnionSandwich.Enabled = true;
                BeefBurger.Enabled = true;
                CheddarOnionCrisps.Enabled = true;
                PrawnMarieRoseCrisps.Enabled = true;
                LightlySaltedCrisps.Enabled = true;
                RoastBeefCrisps.Enabled = true;
                KinderSurpriseEgg.Enabled = true;
                OrangeChocolateBar.Enabled = true;
                ChocolateDigestives.Enabled = true;
                DustbinP.AllowDrop = true;
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            }
        }

        private void _1Pound_MouseDown(object sender, MouseEventArgs e)
        {
            Label.Text = "Put in 1 Pound";
            _1Pound.DoDragDrop(_1Pound.Image, DragDropEffects.Copy);
            Numbers1[1] -= 1.00;
            textBox1.AppendText("amount payable:" + Numbers1[1]);
            if (Numbers1[1] <= 0)
            {
                Numbers1[2] = -1 * Numbers1[1];
                string str;
                str = "\nThe total price:" + Numbers1[0] + "    " + "Change:" + Numbers1[2] + "\nShopping List:";
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\txtwriter.txt", true);
                sw.WriteLine(str);
                for (int i = 0; i < 15; i++)
                {
                    if (Numbers2[i] != 0)
                    {
                        sw.WriteLine(Number4[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Payment has been completed, Change: £" + Numbers1[2], "Remind", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Array.Clear(Numbers1, 0, 3);
                Array.Clear(Numbers2, 0, 15);
                Array.Clear(Number3, 0, 15);
                Array.Clear(Number4, 0, 15);
                textBox1.Clear();
                Shopping_List.Items.Clear();
                Total_Price.Items.Clear();
                DietCoke.Enabled = true;
                Sprite.Enabled = true;
                CocaColaZeroSugar.Enabled = true;
                FantaOrange.Enabled = true;
                ChickenBaconSandwich.Enabled = true;
                MayonnaiseSandwich.Enabled = true;
                CheeseOnionSandwich.Enabled = true;
                BeefBurger.Enabled = true;
                CheddarOnionCrisps.Enabled = true;
                PrawnMarieRoseCrisps.Enabled = true;
                LightlySaltedCrisps.Enabled = true;
                RoastBeefCrisps.Enabled = true;
                KinderSurpriseEgg.Enabled = true;
                OrangeChocolateBar.Enabled = true;
                ChocolateDigestives.Enabled = true;
                DustbinP.AllowDrop = true;
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            }
        }
        private void _5Pounds_MouseDown(object sender, MouseEventArgs e)
        {
            Label.Text = "Put in 5 Pound";
            _5Pounds.DoDragDrop(_5Pounds.Image, DragDropEffects.Copy);
            Numbers1[1] -= 5.00;
            textBox1.AppendText("amount payable:" + Numbers1[1]);
            if (Numbers1[1] <= 0)
            {
                Numbers1[2] = -1 * Numbers1[1];
                string str;
                str = "\nThe total price:" + Numbers1[0] + "    " + "Change:" + Numbers1[2] + "\nShopping List:";
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\txtwriter.txt", true);
                sw.WriteLine(str);
                for (int i = 0; i < 15; i++)
                {
                    if (Numbers2[i] != 0)
                    {
                        sw.WriteLine(Number4[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Payment has been completed, Change: £" + Numbers1[2], "Remind", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Array.Clear(Numbers1, 0, 3);
                Array.Clear(Numbers2, 0, 15);
                Array.Clear(Number3, 0, 15);
                Array.Clear(Number4, 0, 15);
                textBox1.Clear();
                Shopping_List.Items.Clear();
                Total_Price.Items.Clear();
                DietCoke.Enabled = true;
                Sprite.Enabled = true;
                CocaColaZeroSugar.Enabled = true;
                FantaOrange.Enabled = true;
                ChickenBaconSandwich.Enabled = true;
                MayonnaiseSandwich.Enabled = true;
                CheeseOnionSandwich.Enabled = true;
                BeefBurger.Enabled = true;
                CheddarOnionCrisps.Enabled = true;
                PrawnMarieRoseCrisps.Enabled = true;
                LightlySaltedCrisps.Enabled = true;
                RoastBeefCrisps.Enabled = true;
                KinderSurpriseEgg.Enabled = true;
                OrangeChocolateBar.Enabled = true;
                ChocolateDigestives.Enabled = true;
                DustbinP.AllowDrop = true;
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            }
        }
        private void _10Pounds_MouseDown(object sender, MouseEventArgs e)
        {
            Label.Text = "Put in 10 Pound";
            _10Pounds.DoDragDrop(_10Pounds.Image, DragDropEffects.Copy);
            Numbers1[1] -= 10.00;
            textBox1.AppendText("amount payable:" + Numbers1[1]);
            if (Numbers1[1] <= 0)
            {
                Numbers1[2] = -1 * Numbers1[1];
                string str;
                str = "\nThe total price:" + Numbers1[0] + "    " + "Change:" + Numbers1[2] + "\nShopping List:";
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\txtwriter.txt", true);
                sw.WriteLine(str);
                for (int i = 0; i < 15; i++)
                {
                    if (Numbers2[i] != 0)
                    {
                        sw.WriteLine(Number4[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Payment has been completed, Change: £" + Numbers1[2], "Remind", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Array.Clear(Numbers1, 0, 3);
                Array.Clear(Numbers2, 0, 15);
                Array.Clear(Number3, 0, 15);
                Array.Clear(Number4, 0, 15);
                textBox1.Clear();
                Shopping_List.Items.Clear();
                Total_Price.Items.Clear();
                DietCoke.Enabled = true;
                Sprite.Enabled = true;
                CocaColaZeroSugar.Enabled = true;
                FantaOrange.Enabled = true;
                ChickenBaconSandwich.Enabled = true;
                MayonnaiseSandwich.Enabled = true;
                CheeseOnionSandwich.Enabled = true;
                BeefBurger.Enabled = true;
                CheddarOnionCrisps.Enabled = true;
                PrawnMarieRoseCrisps.Enabled = true;
                LightlySaltedCrisps.Enabled = true;
                RoastBeefCrisps.Enabled = true;
                KinderSurpriseEgg.Enabled = true;
                OrangeChocolateBar.Enabled = true;
                ChocolateDigestives.Enabled = true;
                DustbinP.AllowDrop = true;
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            }
        }

        private void _20Pounds_MouseDown(object sender, MouseEventArgs e)
        {
            Label.Text = "Put in 20 Pound";
            _20Pounds.DoDragDrop(_20Pounds.Image, DragDropEffects.Copy);
            Numbers1[1] -= 20.00;
            textBox1.AppendText("amount payable:" + Numbers1[1]);
            if (Numbers1[1] <= 0)
            {
                Numbers1[2] = -1 * Numbers1[1];
                string str;
                str ="\nThe total price:" + Numbers1[0] + "    " + "Change:" + Numbers1[2] + "\nShopping List:";
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\txtwriter.txt", true);
                sw.WriteLine(str);
                for (int i = 0; i< 15; i++) {
                    if (Numbers2[i] != 0)
                    {
                        sw.WriteLine(Number4[i]);
                    }
                }
                sw.Close();
                MessageBox.Show("Payment has been completed, Change: £" + Numbers1[2], "Remind", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Array.Clear(Numbers1, 0, 3);
                Array.Clear(Numbers2, 0, 15);
                Array.Clear(Number3, 0, 15);
                Array.Clear(Number4, 0, 15);
                textBox1.Clear();
                Shopping_List.Items.Clear();
                Total_Price.Items.Clear();
                DietCoke.Enabled = true;
                Sprite.Enabled = true;
                CocaColaZeroSugar.Enabled = true;
                FantaOrange.Enabled = true;
                ChickenBaconSandwich.Enabled = true;
                MayonnaiseSandwich.Enabled = true;
                CheeseOnionSandwich.Enabled = true;
                BeefBurger.Enabled = true;
                CheddarOnionCrisps.Enabled = true;
                PrawnMarieRoseCrisps.Enabled = true;
                LightlySaltedCrisps.Enabled = true;
                RoastBeefCrisps.Enabled = true;
                KinderSurpriseEgg.Enabled = true;
                OrangeChocolateBar.Enabled = true;
                ChocolateDigestives.Enabled = true;
                DustbinP.AllowDrop = true;
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            }
        }

        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Slot_DragDrop(object sender, DragEventArgs e)
        {
            timer1.Enabled = false;
            TimerLabel.Text = "30";
            textBox1.Clear();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Application1.Properties.Resources.Buy);
            sp.Play();
            sp.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimerLabel.Text == "15")
            {
                timer1.Enabled = false;
                MessageBox.Show("If you have left, this page will reset in 15 seconds.", "Prompt",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = true;
                TimerLabel.Text = Convert.ToString(Convert.ToInt32(TimerLabel.Text) - 1);
            }
            else if(TimerLabel.Text == "0")
            {
                timer1.Enabled = false;
                if (MessageBox.Show("This interface will restart. Are you sure you want to do it ?", "Prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    TimerLabel.Text = "30";
                    timer1.Enabled = true;
                    Array.Clear(Numbers1, 0, 3);
                    Array.Clear(Numbers2, 0, 15);
                    Array.Clear(Number3, 0, 15);
                    Array.Clear(Number4, 0, 15);
                    textBox1.Clear();
                    Shopping_List.Items.Clear();
                    Total_Price.Items.Clear();
                    DietCoke.Enabled = true;
                    Sprite.Enabled = true;
                    CocaColaZeroSugar.Enabled = true;
                    FantaOrange.Enabled = true;
                    ChickenBaconSandwich.Enabled = true;
                    MayonnaiseSandwich.Enabled = true;
                    CheeseOnionSandwich.Enabled = true;
                    BeefBurger.Enabled = true;
                    CheddarOnionCrisps.Enabled = true;
                    PrawnMarieRoseCrisps.Enabled = true;
                    LightlySaltedCrisps.Enabled = true;
                    RoastBeefCrisps.Enabled = true;
                    KinderSurpriseEgg.Enabled = true;
                    OrangeChocolateBar.Enabled = true;
                    ChocolateDigestives.Enabled = true;
                    DustbinP.AllowDrop = true;
                    splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
                }
                timer1.Enabled = true;
            }
            else
            {
                TimerLabel.Text = Convert.ToString(Convert.ToInt32(TimerLabel.Text) - 1);
            }
        }
    }
}
