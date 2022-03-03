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

       
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
           
        } // Formas konstruktors
        

        


       

       


        //_____________________________________________________________________________________________

        //___________________________________________________________________________________________
    }
}