using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
// Darbojas divas lapas
//C:\Users\janis\OneDrive\Dators\Projekti\starpkratuve\app.exe
namespace Hex
{
    public partial class Form1 : MaterialForm
    {
        private string[] result1 = null;
        private string path = null;
        private file[] f = new file[5];   // Masivs kas glaba objektus fails katrai lapai savs
       // private char[] data;
        //private FileLoad File = new FileLoad();
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           // MayInit();
        } // Formas konstruktors
        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
      //  private void MayInit()
       // {
            
       //    for(int i = 0; i < f.Length; i++) 
       //     {
         //       f[i] = new file();
        //    }
       // }

        //___________________________________ OPEN FILE _______________________________________________

        private void FailRead_Click(object sender, EventArgs e) // Nospiežot pog nolasa faila nosaukumu
        {
            for (int i = 0; i < f.Length; i++) // cikls ja nospiez pogu atkartoti tad visus f objektus 
                //izdzes lai varētu parlādet ja ir gadijuma cits cels vai mainits fails
              {
                if (f[i] != null)
                {
                    f[i] = null;
                }
               }
                if (File.Exists(failPath.Text)) // un ja tāds fails eksistē tad saglabā tā faila nosaukumu
            {
                this.path = failPath.Text;
                
                FileOpenToFileOpen();
            } 
        }

        private void failPath_TextChanged(object sender, EventArgs e) // pie katras teksta izmainas adrese parbauda vai fails eksiste attiecigi pazinojot par rezultatu
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
        private void FileOpenToFileOpen()
        {
            if (OpenPage1.Checked)
            {
               f[0] = new file(path);
                f[0].AllByte = true;

               result1 = f[0].Format();
                string print = null;
                for (int i = 0; i < result1.Length; i++)
                {
                    print = print + "  " + result1[i] + "\n";
                }
                FinishDataPage.Text = print;
            }
            if (OpenPage2.Checked)
            {
                f[1] = new file(path);
                result1 = f[1].Format();
                string print = null;
                for (int i = 0; i < result1.Length; i++)
                {
                    print = print + result1[i] + "\n";
                }
                FinishDataPage2.Text = print;
            }
            if (OpenPage3.Checked)
            {
                f[2] = new file(path);
                result1 = f[2].Format();
                string print = null;
                for (int i = 0; i < result1.Length; i++)
                {
                    print = print + result1[i] + "\n";
                }
                FinishDataPage3.Text = print;
            }
            if (OpenPage4.Checked)
            {
                f[3] = new file(path);
                result1 = f[3].Format();
                string print = null;
                for (int i = 0; i < result1.Length; i++)
                {
                    print = print + result1[i] + "\n";
                }
                FinishDataPage4.Text = print;
            }
            if (OpenPage5.Checked)
            {
                f[4] = new file(path);
                result1 = f[4].Format();
                string print = null;
                for (int i = 0; i < result1.Length; i++)
                {
                    print = print + result1[i] + "\n";
                }
                FinishDataPage5.Text = print;
            }
        } // Ielāde lapās failu atiecīgi pret checkbox stavokliem

        

        //_____________________________________ PAGE 1 _________________________________________________

        //___________________________________________________________________________________________
        
    }
}