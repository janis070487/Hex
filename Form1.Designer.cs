namespace Hex
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.FinishDataPage1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.wordsize1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.woedsize2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.wordsize4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.row4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.row2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.row1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.minbyte = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.maxbyte = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.HowByte = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.AllByte = new MaterialSkin.Controls.MaterialCheckbox();
            this.failPath = new MaterialSkin.Controls.MaterialTextBox();
            this.Failtext = new MaterialSkin.Controls.MaterialLabel();
            this.FailRead = new MaterialSkin.Controls.MaterialButton();
            this.failstatus = new MaterialSkin.Controls.MaterialLabel();
            this.OpenPage1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.OpenPage2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.OpenPage3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.OpenPage4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.OpenPage5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage8);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1200, 700);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "icons8-home-48.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1192, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OpenPage5);
            this.tabPage2.Controls.Add(this.OpenPage4);
            this.tabPage2.Controls.Add(this.OpenPage3);
            this.tabPage2.Controls.Add(this.OpenPage2);
            this.tabPage2.Controls.Add(this.OpenPage1);
            this.tabPage2.Controls.Add(this.failstatus);
            this.tabPage2.Controls.Add(this.FailRead);
            this.tabPage2.Controls.Add(this.Failtext);
            this.tabPage2.Controls.Add(this.failPath);
            this.tabPage2.ImageKey = "icons8-open-file-under-cursor-50.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Open File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-open-file-under-cursor-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-search-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-separate-using-a-bar-code-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-settings-48.png");
            this.imageList1.Images.SetKeyName(5, "page1.png");
            this.imageList1.Images.SetKeyName(6, "page2.png");
            this.imageList1.Images.SetKeyName(7, "page3.png");
            this.imageList1.Images.SetKeyName(8, "page4.png");
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "icons8-search-48.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1192, 657);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Serag";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AllByte);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.HowByte);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.maxbyte);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.minbyte);
            this.tabPage4.Controls.Add(this.row4);
            this.tabPage4.Controls.Add(this.row2);
            this.tabPage4.Controls.Add(this.row1);
            this.tabPage4.Controls.Add(this.wordsize4);
            this.tabPage4.Controls.Add(this.woedsize2);
            this.tabPage4.Controls.Add(this.wordsize1);
            this.tabPage4.Controls.Add(this.FinishDataPage1);
            this.tabPage4.ImageKey = "icons8-separate-using-a-bar-code-50.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1192, 657);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Page 1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageKey = "page1.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1192, 657);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Page 2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "page2.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1192, 657);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Page 3";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.ImageKey = "page3.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 39);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1192, 657);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Page 4";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.ImageKey = "page4.png";
            this.tabPage8.Location = new System.Drawing.Point(4, 39);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1192, 657);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Page 5";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // FinishDataPage1
            // 
            this.FinishDataPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FinishDataPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinishDataPage1.Depth = 0;
            this.FinishDataPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FinishDataPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishDataPage1.Hint = "";
            this.FinishDataPage1.Location = new System.Drawing.Point(-4, 80);
            this.FinishDataPage1.MaximumSize = new System.Drawing.Size(900, 550);
            this.FinishDataPage1.MaxLength = 80;
            this.FinishDataPage1.MinimumSize = new System.Drawing.Size(900, 550);
            this.FinishDataPage1.MouseState = MaterialSkin.MouseState.HOVER;
            this.FinishDataPage1.Name = "FinishDataPage1";
            this.FinishDataPage1.ReadOnly = true;
            this.FinishDataPage1.Size = new System.Drawing.Size(900, 550);
            this.FinishDataPage1.TabIndex = 17;
            this.FinishDataPage1.Text = "";
            // 
            // wordsize1
            // 
            this.wordsize1.AutoSize = true;
            this.wordsize1.Depth = 0;
            this.wordsize1.Location = new System.Drawing.Point(960, 80);
            this.wordsize1.Margin = new System.Windows.Forms.Padding(0);
            this.wordsize1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.wordsize1.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordsize1.Name = "wordsize1";
            this.wordsize1.Ripple = true;
            this.wordsize1.Size = new System.Drawing.Size(172, 37);
            this.wordsize1.TabIndex = 18;
            this.wordsize1.Text = "1 bytes in one word";
            this.wordsize1.UseVisualStyleBackColor = true;
            this.wordsize1.CheckedChanged += new System.EventHandler(this.wordsize1_CheckedChanged);
            // 
            // woedsize2
            // 
            this.woedsize2.AutoSize = true;
            this.woedsize2.Checked = true;
            this.woedsize2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.woedsize2.Depth = 0;
            this.woedsize2.Location = new System.Drawing.Point(960, 130);
            this.woedsize2.Margin = new System.Windows.Forms.Padding(0);
            this.woedsize2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.woedsize2.MouseState = MaterialSkin.MouseState.HOVER;
            this.woedsize2.Name = "woedsize2";
            this.woedsize2.Ripple = true;
            this.woedsize2.Size = new System.Drawing.Size(172, 37);
            this.woedsize2.TabIndex = 19;
            this.woedsize2.Text = "2 bytes in one word";
            this.woedsize2.UseVisualStyleBackColor = true;
            this.woedsize2.CheckedChanged += new System.EventHandler(this.woedsize2_CheckedChanged);
            // 
            // wordsize4
            // 
            this.wordsize4.AutoSize = true;
            this.wordsize4.Depth = 0;
            this.wordsize4.Location = new System.Drawing.Point(961, 180);
            this.wordsize4.Margin = new System.Windows.Forms.Padding(0);
            this.wordsize4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.wordsize4.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordsize4.Name = "wordsize4";
            this.wordsize4.Ripple = true;
            this.wordsize4.Size = new System.Drawing.Size(172, 37);
            this.wordsize4.TabIndex = 20;
            this.wordsize4.Text = "4 bytes in one word";
            this.wordsize4.UseVisualStyleBackColor = true;
            this.wordsize4.CheckedChanged += new System.EventHandler(this.wordsize4_CheckedChanged);
            // 
            // row4
            // 
            this.row4.AutoSize = true;
            this.row4.Depth = 0;
            this.row4.Location = new System.Drawing.Point(960, 480);
            this.row4.Margin = new System.Windows.Forms.Padding(0);
            this.row4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.row4.MouseState = MaterialSkin.MouseState.HOVER;
            this.row4.Name = "row4";
            this.row4.Ripple = true;
            this.row4.Size = new System.Drawing.Size(145, 37);
            this.row4.TabIndex = 24;
            this.row4.Text = "Word 4 in a row";
            this.row4.UseVisualStyleBackColor = true;
            // 
            // row2
            // 
            this.row2.AutoSize = true;
            this.row2.Checked = true;
            this.row2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.row2.Depth = 0;
            this.row2.Location = new System.Drawing.Point(960, 430);
            this.row2.Margin = new System.Windows.Forms.Padding(0);
            this.row2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.row2.MouseState = MaterialSkin.MouseState.HOVER;
            this.row2.Name = "row2";
            this.row2.Ripple = true;
            this.row2.Size = new System.Drawing.Size(145, 37);
            this.row2.TabIndex = 23;
            this.row2.Text = "Word 2 in a row";
            this.row2.UseVisualStyleBackColor = true;
            // 
            // row1
            // 
            this.row1.AutoSize = true;
            this.row1.Depth = 0;
            this.row1.Location = new System.Drawing.Point(960, 380);
            this.row1.Margin = new System.Windows.Forms.Padding(0);
            this.row1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.row1.MouseState = MaterialSkin.MouseState.HOVER;
            this.row1.Name = "row1";
            this.row1.Ripple = true;
            this.row1.Size = new System.Drawing.Size(145, 37);
            this.row1.TabIndex = 22;
            this.row1.Text = "Word 1 in a row";
            this.row1.UseVisualStyleBackColor = true;
            // 
            // minbyte
            // 
            this.minbyte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minbyte.Depth = 0;
            this.minbyte.Font = new System.Drawing.Font("Roboto", 12F);
            this.minbyte.Location = new System.Drawing.Point(40, 24);
            this.minbyte.MaximumSize = new System.Drawing.Size(150, 50);
            this.minbyte.MaxLength = 50;
            this.minbyte.MinimumSize = new System.Drawing.Size(150, 50);
            this.minbyte.MouseState = MaterialSkin.MouseState.OUT;
            this.minbyte.Multiline = false;
            this.minbyte.Name = "minbyte";
            this.minbyte.Size = new System.Drawing.Size(150, 50);
            this.minbyte.TabIndex = 25;
            this.minbyte.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(210, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Start Byte";
            // 
            // maxbyte
            // 
            this.maxbyte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxbyte.Depth = 0;
            this.maxbyte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxbyte.Location = new System.Drawing.Point(310, 24);
            this.maxbyte.MaximumSize = new System.Drawing.Size(150, 50);
            this.maxbyte.MaxLength = 50;
            this.maxbyte.MinimumSize = new System.Drawing.Size(150, 50);
            this.maxbyte.MouseState = MaterialSkin.MouseState.OUT;
            this.maxbyte.Multiline = false;
            this.maxbyte.Name = "maxbyte";
            this.maxbyte.Size = new System.Drawing.Size(150, 50);
            this.maxbyte.TabIndex = 27;
            this.maxbyte.Text = "";
            this.maxbyte.TextChanged += new System.EventHandler(this.maxbyte_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(497, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Stop Byte";
            // 
            // HowByte
            // 
            this.HowByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HowByte.Depth = 0;
            this.HowByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HowByte.Location = new System.Drawing.Point(580, 24);
            this.HowByte.MaximumSize = new System.Drawing.Size(150, 50);
            this.HowByte.MaxLength = 50;
            this.HowByte.MinimumSize = new System.Drawing.Size(150, 50);
            this.HowByte.MouseState = MaterialSkin.MouseState.OUT;
            this.HowByte.Multiline = false;
            this.HowByte.Name = "HowByte";
            this.HowByte.Size = new System.Drawing.Size(150, 50);
            this.HowByte.TabIndex = 29;
            this.HowByte.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(750, 38);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "how many bytes";
            // 
            // AllByte
            // 
            this.AllByte.AutoSize = true;
            this.AllByte.Checked = true;
            this.AllByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllByte.Depth = 0;
            this.AllByte.Location = new System.Drawing.Point(960, 20);
            this.AllByte.Margin = new System.Windows.Forms.Padding(0);
            this.AllByte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AllByte.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllByte.Name = "AllByte";
            this.AllByte.Ripple = true;
            this.AllByte.Size = new System.Drawing.Size(87, 37);
            this.AllByte.TabIndex = 31;
            this.AllByte.Text = "All byte";
            this.AllByte.UseVisualStyleBackColor = true;
            this.AllByte.CheckedChanged += new System.EventHandler(this.AllByte_CheckedChanged);
            // 
            // failPath
            // 
            this.failPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failPath.Depth = 0;
            this.failPath.Font = new System.Drawing.Font("Roboto", 12F);
            this.failPath.Location = new System.Drawing.Point(80, 70);
            this.failPath.MaximumSize = new System.Drawing.Size(650, 50);
            this.failPath.MaxLength = 100;
            this.failPath.MinimumSize = new System.Drawing.Size(650, 50);
            this.failPath.MouseState = MaterialSkin.MouseState.OUT;
            this.failPath.Multiline = false;
            this.failPath.Name = "failPath";
            this.failPath.Size = new System.Drawing.Size(650, 50);
            this.failPath.TabIndex = 0;
            this.failPath.Text = "C:\\Users\\janis\\OneDrive\\Dators\\Projekti\\starpkratuve\\app.exe";
            this.failPath.TextChanged += new System.EventHandler(this.failPath_TextChanged);
            // 
            // Failtext
            // 
            this.Failtext.AutoSize = true;
            this.Failtext.Depth = 0;
            this.Failtext.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Failtext.Location = new System.Drawing.Point(79, 33);
            this.Failtext.MouseState = MaterialSkin.MouseState.HOVER;
            this.Failtext.Name = "Failtext";
            this.Failtext.Size = new System.Drawing.Size(152, 19);
            this.Failtext.TabIndex = 1;
            this.Failtext.Text = "Enter the full file path";
            // 
            // FailRead
            // 
            this.FailRead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FailRead.Depth = 0;
            this.FailRead.DrawShadows = true;
            this.FailRead.HighEmphasis = true;
            this.FailRead.Icon = null;
            this.FailRead.Location = new System.Drawing.Point(84, 169);
            this.FailRead.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FailRead.MaximumSize = new System.Drawing.Size(100, 40);
            this.FailRead.MinimumSize = new System.Drawing.Size(100, 40);
            this.FailRead.MouseState = MaterialSkin.MouseState.HOVER;
            this.FailRead.Name = "FailRead";
            this.FailRead.Size = new System.Drawing.Size(100, 40);
            this.FailRead.TabIndex = 2;
            this.FailRead.Text = "OK";
            this.FailRead.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FailRead.UseAccentColor = false;
            this.FailRead.UseVisualStyleBackColor = true;
            this.FailRead.Click += new System.EventHandler(this.FailRead_Click);
            // 
            // failstatus
            // 
            this.failstatus.AutoSize = true;
            this.failstatus.Depth = 0;
            this.failstatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.failstatus.Location = new System.Drawing.Point(466, 33);
            this.failstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.failstatus.Name = "failstatus";
            this.failstatus.Size = new System.Drawing.Size(117, 19);
            this.failstatus.TabIndex = 3;
            this.failstatus.Text = "No files selected";
            // 
            // OpenPage1
            // 
            this.OpenPage1.AutoSize = true;
            this.OpenPage1.Checked = true;
            this.OpenPage1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenPage1.Depth = 0;
            this.OpenPage1.Location = new System.Drawing.Point(787, 29);
            this.OpenPage1.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPage1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpenPage1.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPage1.Name = "OpenPage1";
            this.OpenPage1.Ripple = true;
            this.OpenPage1.Size = new System.Drawing.Size(142, 37);
            this.OpenPage1.TabIndex = 4;
            this.OpenPage1.Text = "Open to page 1";
            this.OpenPage1.UseVisualStyleBackColor = true;
            this.OpenPage1.CheckedChanged += new System.EventHandler(this.OpenPage1_CheckedChanged);
            // 
            // OpenPage2
            // 
            this.OpenPage2.AutoSize = true;
            this.OpenPage2.Depth = 0;
            this.OpenPage2.Location = new System.Drawing.Point(787, 83);
            this.OpenPage2.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPage2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpenPage2.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPage2.Name = "OpenPage2";
            this.OpenPage2.Ripple = true;
            this.OpenPage2.Size = new System.Drawing.Size(142, 37);
            this.OpenPage2.TabIndex = 5;
            this.OpenPage2.Text = "Open to page 2";
            this.OpenPage2.UseVisualStyleBackColor = true;
            this.OpenPage2.CheckedChanged += new System.EventHandler(this.OpenPage2_CheckedChanged);
            // 
            // OpenPage3
            // 
            this.OpenPage3.AutoSize = true;
            this.OpenPage3.Depth = 0;
            this.OpenPage3.Location = new System.Drawing.Point(787, 134);
            this.OpenPage3.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPage3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpenPage3.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPage3.Name = "OpenPage3";
            this.OpenPage3.Ripple = true;
            this.OpenPage3.Size = new System.Drawing.Size(142, 37);
            this.OpenPage3.TabIndex = 6;
            this.OpenPage3.Text = "Open to page 3";
            this.OpenPage3.UseVisualStyleBackColor = true;
            this.OpenPage3.CheckedChanged += new System.EventHandler(this.OpenPage3_CheckedChanged);
            // 
            // OpenPage4
            // 
            this.OpenPage4.AutoSize = true;
            this.OpenPage4.Depth = 0;
            this.OpenPage4.Location = new System.Drawing.Point(787, 186);
            this.OpenPage4.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPage4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpenPage4.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPage4.Name = "OpenPage4";
            this.OpenPage4.Ripple = true;
            this.OpenPage4.Size = new System.Drawing.Size(142, 37);
            this.OpenPage4.TabIndex = 7;
            this.OpenPage4.Text = "Open to page 4";
            this.OpenPage4.UseVisualStyleBackColor = true;
            this.OpenPage4.CheckedChanged += new System.EventHandler(this.OpenPage4_CheckedChanged);
            // 
            // OpenPage5
            // 
            this.OpenPage5.AutoSize = true;
            this.OpenPage5.Depth = 0;
            this.OpenPage5.Location = new System.Drawing.Point(787, 237);
            this.OpenPage5.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPage5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpenPage5.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPage5.Name = "OpenPage5";
            this.OpenPage5.Ripple = true;
            this.OpenPage5.Size = new System.Drawing.Size(142, 37);
            this.OpenPage5.TabIndex = 8;
            this.OpenPage5.Text = "Open to page 5";
            this.OpenPage5.UseVisualStyleBackColor = true;
            this.OpenPage5.CheckedChanged += new System.EventHandler(this.OpenPage5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hex";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private MaterialSkin.Controls.MaterialMultiLineTextBox FinishDataPage1;
        private MaterialSkin.Controls.MaterialCheckbox woedsize2;
        private MaterialSkin.Controls.MaterialCheckbox wordsize1;
        private MaterialSkin.Controls.MaterialCheckbox row4;
        private MaterialSkin.Controls.MaterialCheckbox row2;
        private MaterialSkin.Controls.MaterialCheckbox row1;
        private MaterialSkin.Controls.MaterialCheckbox wordsize4;
        private MaterialSkin.Controls.MaterialTextBox minbyte;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox maxbyte;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox HowByte;
        private MaterialSkin.Controls.MaterialCheckbox AllByte;
        private MaterialSkin.Controls.MaterialTextBox failPath;
        private MaterialSkin.Controls.MaterialLabel Failtext;
        private MaterialSkin.Controls.MaterialButton FailRead;
        private MaterialSkin.Controls.MaterialLabel failstatus;
        private MaterialSkin.Controls.MaterialCheckbox OpenPage5;
        private MaterialSkin.Controls.MaterialCheckbox OpenPage4;
        private MaterialSkin.Controls.MaterialCheckbox OpenPage3;
        private MaterialSkin.Controls.MaterialCheckbox OpenPage2;
        private MaterialSkin.Controls.MaterialCheckbox OpenPage1;
    }
}

