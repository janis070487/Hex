using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//C:\Users\janis\OneDrive\Dators\Projekti\starpkratuve\app.exe
namespace Hex
{
    public partial class Form1 : MaterialForm
    {
        private string[] result1 = null;
        private string path = null;
        private file[] f = new file[5];   // Masivs kas glaba objektus fails katrai lapai savs
        public void debug(string str)
        {
            failstatus.Text = str;
        }
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        } // Formas konstruktors

        private void maxbyte_TextChanged(object sender, EventArgs e)
        {

        }//Pagaidam nav vajadzīgs

      private void FailStart1()
        {
            f[0].ShowAdres = true;
            f[0].ShowAscii = true;
            f[0].ShowLineNumbers = true;
            f[0].ShowValue = false;
            f[0].Minbyte = 0;
            f[0].Maxbyte = 1024;
            f[0].AllByte = false;
            f[0].WordSize = 2;
            f[0].ColonWord = 4;
            result1 = f[0].Format();
            string print = null;
            for(int i = 0; i < result1.Length; i++)
            {
                print = print + result1[i] + "\n";
               
                //FinishDataPage1
            }
            FinishDataPage1.Text = print;
        }
        private void FailStart2()
        {
            
        }

        private void FailStart3()
        {
           
        }
        private void FailStart4()
        {
           
        }
        private void FailStart5()
        {
            
        }


        private void FailRead_Click(object sender, EventArgs e) // Ja pogu nospiež un fails eksiste tad attīra chebox un ielade failu
        {
      
            if (File.Exists(failPath.Text))
            {
              
                path = failPath.Text;
                if (OpenPage1.Checked) 
                {
                   
                    f[0] = new file(path);
                    FailStart1();
                }
                if (OpenPage2.Checked)
                {
                    f[0] = new file(path);
                }
                if (OpenPage3.Checked)
                {
                    f[0] = new file(path);
                }
                if (OpenPage4.Checked)
                {
                    f[0] = new file(path);
                }
                if (OpenPage5.Checked)
                {
                    f[0] = new file(path);
                }
               
                
            }
        }

        private void failPath_TextChanged(object sender, EventArgs e)
        {
            if(File.Exists(failPath.Text))
                {
                failstatus.Text = "File found";
            }
            else
            {
                failstatus.Text = "File could not be found";
            }
        }

        private void OpenPage1_CheckedChanged(object sender, EventArgs e)
        {
          /*  
            OpenPage2.Checked = false;
            OpenPage3.Checked = false;
            OpenPage4.Checked = false;
            OpenPage5.Checked = false;
            */
        }

        private void OpenPage2_CheckedChanged(object sender, EventArgs e)
        {
            /*
            OpenPage1.Checked = false;
            OpenPage3.Checked = false;
            OpenPage4.Checked = false;
            OpenPage5.Checked = false;
            */
        }

        private void OpenPage3_CheckedChanged(object sender, EventArgs e)
        {
            /*
            OpenPage1.Checked = false;
            OpenPage2.Checked = false;
            OpenPage4.Checked = false;
            OpenPage5.Checked = false;
            */
            }

        private void OpenPage4_CheckedChanged(object sender, EventArgs e)
        {
            /*
            OpenPage1.Checked = false;
            OpenPage3.Checked = false;
            OpenPage2.Checked = false;
            OpenPage5.Checked = false;
            */
        }

        private void OpenPage5_CheckedChanged(object sender, EventArgs e)
        {
            /*
            OpenPage1.Checked = false;
            OpenPage3.Checked = false;
            OpenPage4.Checked = false;
            OpenPage2.Checked = false;
        */
        }
//_____________________________________________________________________________________________
        private void AllByte_CheckedChanged(object sender, EventArgs e)
        {
           
            //f[0].
        }

        private void wordsize1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void woedsize2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wordsize4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //___________________________________________________________________________________________
    }
}
