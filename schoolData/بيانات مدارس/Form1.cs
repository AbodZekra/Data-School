using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace بيانات_مدارس
{
    public partial class Form1 : Form
    {
        //SQLiteConnection conn;
        //SQLiteCommand cmd;
        //SQLiteDataReader sdr;
        //SQLiteDataAdapter sda;
        //string qury;
        public Form1()
        {
            InitializeComponent();






        }
       /// <summary>
       
       /// </summary>

        //فتح واجهة إضافة شعبة
        int showgB1 = 1;
        private void AddDvsn_Click(object sender, EventArgs e)
        {
            showgB1++;
            if (showgB1 % 2 == 0)
            {
                gB1.Visible = true;
            }
            else
            {
                gB1.Visible = false;
            }
           
        }
        //فتح واجهة إضافة طالب جديد
        int showgB2 = 1;
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            showgB2++;
            if (showgB2 % 2 == 0)
            {
                gB2.Visible = true;
            }
            else
            {
                gB2.Visible = false;
            }
            gB2.Text = "طالب جديد";
            AddStudent.Visible = false;
            UpdateStudent.Visible = true;
        }
        //إضافة شعبة
        string nameGrup;
        private void AddDvsnTo_s_MouseClick(object sender, MouseEventArgs e)
        {
            bool A = true;
            ToolStripMenuItem[] tsmi = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10S, s11S, s12S, s10L, s11L, s12L };
            foreach(ToolStripMenuItem i in tsmi)
            {
                if (i.Text == cB1.Text)
                {
                    foreach (ToolStripMenuItem subItem in i.DropDownItems)
                    {
                        
                        
                        if (subItem.Text == numdvsn.Text)
                        {
                            A = false;
                            break;
                        }
                        else
                        {
                            A = true;
                        }
                        

                        
                    }
                    if (A == true)
                    {
                        ToolStripMenuItem dvsn = new ToolStripMenuItem(numdvsn.Text);
                        i.DropDownItems.Add(dvsn);

                        dvsn.Click += ToolStripMenuItem_Click;
                        nameGrup = i.Text + "  " + dvsn.Text;
                        break;
                    }
                    else
                    {
                        MessageBox.Show(numdvsn.Text + " موجودة بالفعل في " + i.Text);
                    }
                }
                
            }
            
        }
        int showDvsn = 1;
        //حدث الضغط على شعبة ما
        private void ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            gBDvsn.Text = nameGrup;
            showDvsn++;
            if (showDvsn % 2 == 0)
            {
                gBDvsn.Visible = true;
            }
            else
            {
                gBDvsn.Visible = false;
            }
            //يجب البحث عن جدول الشعبة في قاعدة البيانات وهو بإسم [nameGrup]المتغير    
            
        }

        private void UpdateInfo_MouseClick(object sender, MouseEventArgs e)
        {
            showgB2++;
            if (showgB2 % 2 == 0)
            {
                gB2.Visible = true;
            }
            else
            {
                gB2.Visible = false;
            }

            gB2.Text = "تعديل بيانات الطالب";
            AddStudent.Visible = false;
            UpdateStudent.Visible = true;
            //إنشاء اتصال مع الجدول بإسم الحقل inputNameS.text+numberS.Text 
        }

        private void ShowDataS_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox2.Visible = true;
            //أنشئ جدول جديد للطالب 
            // اسم الجدول يؤخذ من AllName.Text
            //إذا كان الجدول موجود اعرض بياناته
        }

        private void numberS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputNameS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputTephon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        int showP = 1;
        private void showMT_MouseClick(object sender, MouseEventArgs e)
        {
            showP++;
            if (showP % 2 == 0)
            {
                GrupS.Visible = true;
            }
            else
            {
                GrupS.Visible = false;
            }
        }
        ///////////////DISIN COD///////////////



    }
}
