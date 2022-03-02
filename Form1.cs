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
            MayInit();
        } // Formas konstruktors
        private void MayInit() // Inicilizācīja manām vērtībām
        {
            
           for(int i = 0; i < f.Length; i++)
            {
                f[i] = new file();
            }
            //minbyte.Text = "0";     // Sākuma iesatatījumi
            //maxbyte.Text = "1024";
            //HowByte.Text = "1024";
           // WordSize.SelectedIndex = 1;
           // WordInLine.SelectedIndex = 1;
        }
       
       //Pagaidam nav vajadzīgs

        private void FailStart1()
        {
            f[0].SetPath(path);
            f[0].ShowAdres = false;
            f[0].ShowAscii = true;
            f[0].ShowLineNumbers = true;
            //f[0].ShowValue = false;
            f[0].Minbyte = 0;
            f[0].Maxbyte = 1024;
            f[0].AllByte = true;
            f[0].WordSize = 2;
            f[0].ColonWord = 4;
            result1 = f[0].Format();
    
            string print = null;
            for (int i = 0; i < result1.Length; i++)
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
                 
                    FailStart1();
                }
                if (OpenPage2.Checked)
                {
                    
                }
                if (OpenPage3.Checked)
                {
                    //f[0] = new file(path);
                }
                if (OpenPage4.Checked)
                {
                   // f[0] = new file(path);
                }
                if (OpenPage5.Checked)
                {
                   // f[0] = new file(path);
                }


            }
        }

        private void MayEvents1() // Ja notiek kādas izmaiņas izsaucas pārlāde visai lapai
        {

            f[0].ShowAdres = ShowLineAdres.Checked;
            f[0].ShowAscii = ShowAsciiSymbols.Checked;
            f[0].ShowLineNumbers = ShowLinenumbers.Checked;
            //f[0].ShowValue = false;
          
            int no = 0;  // minbyte
            int lidz = 0;   // maxbyte
            int.TryParse(minbyte.Text, out no);
            int.TryParse(maxbyte.Text, out lidz);
            f[0].Minbyte = no;
            f[0].Maxbyte = lidz;
           // f[0].AllByte = 
            //   f[0].WordSize = 2;
            //   f[0].ColonWord = 4;
            //   result1 = f[0].Format();
        }

        private void failPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(failPath.Text))
            {
                failstatus.Text = "File found";
            }
            else
            {
                failstatus.Text = "File could not be found";
            }
        }
        //____________________IZMAIŅAS 1 page_________________________________________________
        private void minbyte_TextChanged(object sender, EventArgs e)
        {
            int no = 0;
            int lidz = 0;
            int cik = 0;
            bool aa = int.TryParse(minbyte.Text, out no);
            int.TryParse(maxbyte.Text, out lidz);
            int.TryParse(HowByte.Text, out cik);
            if (aa)
            {
                f[0].Minbyte = no;
                f[0].Maxbyte = lidz;
                materialLabel1.Text = "Start Byte";
                HowByte.Text = Convert.ToString(lidz - no);
                MayEvents1();
            }
            else
            {
                materialLabel1.Text = "Error";
            }
            
        }
        private void maxbyte_TextChanged(object sender, EventArgs e)
        {
            int no = 0;
            int lidz = 0;
            int cik = 0;
            bool aa = int.TryParse(maxbyte.Text, out lidz);
            int.TryParse(minbyte.Text, out no);
            int.TryParse(HowByte.Text, out cik);
            if (aa)
            {
                f[0].Minbyte = no;
                f[0].Maxbyte = lidz;
                materialLabel2.Text = "Stop Byte";
                HowByte.Text = Convert.ToString(lidz - no);
                MayEvents1();
            }
            else
            {
                materialLabel2.Text = "Error";
            }
           
        }
        private void HowByte_TextChanged(object sender, EventArgs e)
        {
            int no = 0;
            int lidz = 0;
            int cik = 0;
            bool aa = int.TryParse(HowByte.Text,out cik);
            int.TryParse(maxbyte.Text, out lidz);
            int.TryParse(minbyte.Text, out no);
            if (aa)
            {
                f[0].Minbyte = no;
                f[0].Maxbyte = lidz;
                materialLabel3.Text = "how many bytes";
                maxbyte.Text = Convert.ToString(no + cik);
                MayEvents1();
            }
            else
            {
                materialLabel3.Text = "Error";
            }
           
        }

        private void AllBytes_CheckedChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

        private void WordSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

        private void WordInLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

        private void ShowLinenumbers_CheckedChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

        private void ShowLineAdres_CheckedChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

        private void ShowAsciiSymbols_CheckedChanged(object sender, EventArgs e)
        {
            MayEvents1();
        }

      

        //_____________________________________________________________________________________________

        //___________________________________________________________________________________________
    }
}