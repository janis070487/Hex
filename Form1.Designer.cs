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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.minbyte = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_minbyte = new MaterialSkin.Controls.MaterialLabel();
            this.maxbyte = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_maxbyte = new MaterialSkin.Controls.MaterialLabel();
            this.howbyte = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_howbyte = new MaterialSkin.Controls.MaterialLabel();
            this.AllBytes = new MaterialSkin.Controls.MaterialCheckbox();
            this.WordSize = new MaterialSkin.Controls.MaterialComboBox();
            this.WordInLine = new MaterialSkin.Controls.MaterialComboBox();
            this.ShowLinenumbers = new MaterialSkin.Controls.MaterialCheckbox();
            this.ShowLineAdres = new MaterialSkin.Controls.MaterialCheckbox();
            this.ShowAsciiSymbols = new MaterialSkin.Controls.MaterialCheckbox();
            this.FinishDataPage1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();

            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.minbyte2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_minbyte2 = new MaterialSkin.Controls.MaterialLabel();
            this.maxbyte2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_maxbyte2 = new MaterialSkin.Controls.MaterialLabel();
            this.howbyte2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_howbyte2 = new MaterialSkin.Controls.MaterialLabel();
            this.AllBytes2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.WordSize2 = new MaterialSkin.Controls.MaterialComboBox();
            this.WordInLine2 = new MaterialSkin.Controls.MaterialComboBox();
            this.ShowLinenumbers2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.ShowLineAdres2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.ShowAsciiSymbols2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.FinishDataPage2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();

            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
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
            this.tabPage2.ImageKey = "icons8-open-file-under-cursor-50.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Open File";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            
            this.tabPage4.Controls.Add(this.minbyte);
            this.tabPage4.Controls.Add(this.txt_minbyte);
            this.tabPage4.Controls.Add(this.maxbyte);
            this.tabPage4.Controls.Add(this.txt_maxbyte);
            this.tabPage4.Controls.Add(this.howbyte);
            this.tabPage4.Controls.Add(this.txt_howbyte);
            this.tabPage4.Controls.Add(this.AllBytes);
            this.tabPage4.Controls.Add(this.ShowAsciiSymbols);
            this.tabPage4.Controls.Add(this.ShowLineAdres);
            this.tabPage4.Controls.Add(this.ShowLinenumbers);
            this.tabPage4.Controls.Add(this.WordInLine);
            this.tabPage4.Controls.Add(this.WordSize);
            this.tabPage4.Controls.Add(this.FinishDataPage1);
            this.tabPage4.ImageKey = "icons8-separate-using-a-bar-code-50.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1192, 657);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Page 1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // minbyte
            // 
            this.minbyte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minbyte.Depth = 0;
            this.minbyte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minbyte.Location = new System.Drawing.Point(40, 24);
            this.minbyte.MaximumSize = new System.Drawing.Size(150, 50);
            this.minbyte.MaxLength = 50;
            this.minbyte.MinimumSize = new System.Drawing.Size(150, 50);
            this.minbyte.MouseState = MaterialSkin.MouseState.OUT;
            this.minbyte.Multiline = false;
            this.minbyte.Name = "minbyte";
            this.minbyte.Size = new System.Drawing.Size(150, 50);
            this.minbyte.TabIndex = 25;
            this.minbyte.Text = "0";
            // 
            // txt_minbyte
            // 
            this.txt_minbyte.AutoSize = true;
            this.txt_minbyte.Depth = 0;
            this.txt_minbyte.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_minbyte.Location = new System.Drawing.Point(210, 38);
            this.txt_minbyte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_minbyte.Name = "txt_minbyte";
            this.txt_minbyte.Size = new System.Drawing.Size(70, 19);
            this.txt_minbyte.TabIndex = 26;
            this.txt_minbyte.Text = "Start Byte";

            // 
            // maxbyte
            // 
            this.maxbyte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxbyte.Depth = 0;
            this.maxbyte.Font = new System.Drawing.Font("Roboto", 12F);
            this.maxbyte.Location = new System.Drawing.Point(310, 24);
            this.maxbyte.MaxLength = 50;
            this.maxbyte.MouseState = MaterialSkin.MouseState.OUT;
            this.maxbyte.Multiline = false;
            this.maxbyte.Name = "maxbyte";
            this.maxbyte.Size = new System.Drawing.Size(150, 50);
            this.maxbyte.TabIndex = 27;
            this.maxbyte.Text = "0";
            // 
            // txt_maxbyte
            // 
            this.txt_maxbyte.AutoSize = true;
            this.txt_maxbyte.Depth = 0;
            this.txt_maxbyte.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_maxbyte.Location = new System.Drawing.Point(497, 38);
            this.txt_maxbyte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_maxbyte.Name = "txt_maxbyte";
            this.txt_maxbyte.Size = new System.Drawing.Size(210, 38);
            this.txt_maxbyte.TabIndex = 26;
            this.txt_maxbyte.Text = "Stop Byte";
            // 
            // howbyte
            // 
            this.howbyte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.howbyte.Depth = 0;
            this.howbyte.Font = new System.Drawing.Font("Roboto", 12F);
            this.howbyte.Location = new System.Drawing.Point(580, 24);
            this.howbyte.MaxLength = 50;
            this.howbyte.MouseState = MaterialSkin.MouseState.OUT;
            this.howbyte.Multiline = false;
            this.howbyte.Name = "howbyte";
            this.howbyte.Size = new System.Drawing.Size(150, 50);
            this.howbyte.TabIndex = 27;
            this.howbyte.Text = "0";
            // 
            // txt_howbyte
            // 
            this.txt_howbyte.AutoSize = true;
            this.txt_howbyte.Depth = 0;
            this.txt_howbyte.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_howbyte.Location = new System.Drawing.Point(750, 38);
            this.txt_howbyte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_howbyte.Name = "txt_maxbyte";
            this.txt_howbyte.Size = new System.Drawing.Size(117, 19);
            this.txt_howbyte.TabIndex = 26;
            this.txt_howbyte.Text = "How Byte";
            // 
            // AllBytes
            // 
            this.AllBytes.AutoSize = true;
            this.AllBytes.Depth = 0;
            this.AllBytes.Location = new System.Drawing.Point(923, 24);
            this.AllBytes.Margin = new System.Windows.Forms.Padding(0);
            this.AllBytes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AllBytes.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllBytes.Name = "AllBytes";
            this.AllBytes.Ripple = true;
            this.AllBytes.Size = new System.Drawing.Size(134, 37);
            this.AllBytes.TabIndex = 36;
            this.AllBytes.Text = "Read all bytes";
            this.AllBytes.UseVisualStyleBackColor = true;
            // 
            // WordSize
            // 
            this.WordSize.AutoResize = false;
            this.WordSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WordSize.Depth = 0;
            this.WordSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WordSize.DropDownHeight = 174;
            this.WordSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordSize.DropDownWidth = 121;
            this.WordSize.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WordSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordSize.FormattingEnabled = true;
            this.WordSize.IntegralHeight = false;
            this.WordSize.ItemHeight = 43;
            this.WordSize.Items.AddRange(new object[] {
            "word size 1 bytes",
            "word size 2 bytes",
            "word size 4 bytes"});
            this.WordSize.Location = new System.Drawing.Point(923, 80);
            this.WordSize.MaxDropDownItems = 4;
            this.WordSize.MouseState = MaterialSkin.MouseState.OUT;
            this.WordSize.Name = "WordSize";
            this.WordSize.Size = new System.Drawing.Size(175, 49);
            this.WordSize.TabIndex = 31;
            // 
            // WordInLine
            // 
            this.WordInLine.AutoResize = false;
            this.WordInLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WordInLine.Depth = 0;
            this.WordInLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WordInLine.DropDownHeight = 174;
            this.WordInLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordInLine.DropDownWidth = 121;
            this.WordInLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WordInLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordInLine.FormattingEnabled = true;
            this.WordInLine.IntegralHeight = false;
            this.WordInLine.ItemHeight = 43;
            this.WordInLine.Items.AddRange(new object[] {
            "line 1 words",
            "line 2 words",
            "line 4 words"});
            this.WordInLine.Location = new System.Drawing.Point(923, 135);
            this.WordInLine.MaxDropDownItems = 4;
            this.WordInLine.MouseState = MaterialSkin.MouseState.OUT;
            this.WordInLine.Name = "WordInLine";
            this.WordInLine.Size = new System.Drawing.Size(175, 49);
            this.WordInLine.TabIndex = 32;
           
            // 
            // ShowLinenumbers
            // 
            this.ShowLinenumbers.AutoSize = true;
            this.ShowLinenumbers.Checked = true;
            this.ShowLinenumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLinenumbers.Depth = 0;
            this.ShowLinenumbers.Location = new System.Drawing.Point(923, 201);
            this.ShowLinenumbers.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLinenumbers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowLinenumbers.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLinenumbers.Name = "ShowLinenumbers";
            this.ShowLinenumbers.Ripple = true;
            this.ShowLinenumbers.Size = new System.Drawing.Size(182, 37);
            this.ShowLinenumbers.TabIndex = 33;
            this.ShowLinenumbers.Text = "show line numbering";
            this.ShowLinenumbers.UseVisualStyleBackColor = true;
           
            // 
            // ShowLineAdres
            // 
            this.ShowLineAdres.AutoSize = true;
            this.ShowLineAdres.Depth = 0;
            this.ShowLineAdres.Location = new System.Drawing.Point(923, 253);
            this.ShowLineAdres.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLineAdres.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowLineAdres.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLineAdres.Name = "ShowLineAdres";
            this.ShowLineAdres.Ripple = true;
            this.ShowLineAdres.Size = new System.Drawing.Size(178, 37);
            this.ShowLineAdres.TabIndex = 34;
            this.ShowLineAdres.Text = "show line addresses";
            this.ShowLineAdres.UseVisualStyleBackColor = true;
           
            // 
            // ShowAsciiSymbols
            // 
            this.ShowAsciiSymbols.AutoSize = true;
            this.ShowAsciiSymbols.Depth = 0;
            this.ShowAsciiSymbols.Location = new System.Drawing.Point(923, 302);
            this.ShowAsciiSymbols.Margin = new System.Windows.Forms.Padding(0);
            this.ShowAsciiSymbols.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowAsciiSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAsciiSymbols.Name = "ShowAsciiSymbols";
            this.ShowAsciiSymbols.Ripple = true;
            this.ShowAsciiSymbols.Size = new System.Drawing.Size(171, 37);
            this.ShowAsciiSymbols.TabIndex = 35;
            this.ShowAsciiSymbols.Text = "show ASCII symbol";
            this.ShowAsciiSymbols.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.minbyte2);
            this.tabPage5.Controls.Add(this.txt_minbyte2);
            this.tabPage5.Controls.Add(this.maxbyte2);
            this.tabPage5.Controls.Add(this.txt_maxbyte2);
            this.tabPage5.Controls.Add(this.howbyte2);
            this.tabPage5.Controls.Add(this.txt_howbyte2);
            this.tabPage5.Controls.Add(this.AllBytes2);
            this.tabPage5.Controls.Add(this.ShowAsciiSymbols2);
            this.tabPage5.Controls.Add(this.ShowLineAdres2);
            this.tabPage5.Controls.Add(this.ShowLinenumbers2);
            this.tabPage5.Controls.Add(this.WordInLine2);
            this.tabPage5.Controls.Add(this.WordSize2);
            this.tabPage5.Controls.Add(this.FinishDataPage2);
            this.tabPage5.ImageKey = "page1.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1192, 657);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Page 2";
            this.tabPage5.UseVisualStyleBackColor = true;

            // 
            // minbyte2
            // 
            this.minbyte2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minbyte2.Depth = 0;
            this.minbyte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minbyte2.Location = new System.Drawing.Point(40, 24);
            this.minbyte2.MaximumSize = new System.Drawing.Size(150, 50);
            this.minbyte2.MaxLength = 50;
            this.minbyte2.MinimumSize = new System.Drawing.Size(150, 50);
            this.minbyte2.MouseState = MaterialSkin.MouseState.OUT;
            this.minbyte2.Multiline = false;
            this.minbyte2.Name = "minbyte";
            this.minbyte2.Size = new System.Drawing.Size(150, 50);
            this.minbyte2.TabIndex = 25;
            this.minbyte2.Text = "0";
            // 
            // txt_minbyte2
            // 
            this.txt_minbyte2.AutoSize = true;
            this.txt_minbyte2.Depth = 0;
            this.txt_minbyte2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_minbyte2.Location = new System.Drawing.Point(210, 38);
            this.txt_minbyte2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_minbyte2.Name = "txt_minbyte";
            this.txt_minbyte2.Size = new System.Drawing.Size(70, 19);
            this.txt_minbyte2.TabIndex = 26;
            this.txt_minbyte2.Text = "Start Byte";

            // 
            // maxbyte2
            // 
            this.maxbyte2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxbyte2.Depth = 0;
            this.maxbyte2.Font = new System.Drawing.Font("Roboto", 12F);
            this.maxbyte2.Location = new System.Drawing.Point(310, 24);
            this.maxbyte2.MaxLength = 50;
            this.maxbyte2.MouseState = MaterialSkin.MouseState.OUT;
            this.maxbyte2.Multiline = false;
            this.maxbyte2.Name = "maxbyte";
            this.maxbyte2.Size = new System.Drawing.Size(150, 50);
            this.maxbyte2.TabIndex = 27;
            this.maxbyte2.Text = "0";
            // 
            // txt_maxbyte2
            // 
            this.txt_maxbyte2.AutoSize = true;
            this.txt_maxbyte2.Depth = 0;
            this.txt_maxbyte2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_maxbyte2.Location = new System.Drawing.Point(497, 38);
            this.txt_maxbyte2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_maxbyte2.Name = "txt_maxbyte";
            this.txt_maxbyte2.Size = new System.Drawing.Size(210, 38);
            this.txt_maxbyte2.TabIndex = 26;
            this.txt_maxbyte2.Text = "Stop Byte";
            // 
            // howbyte2
            // 
            this.howbyte2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.howbyte2.Depth = 0;
            this.howbyte2.Font = new System.Drawing.Font("Roboto", 12F);
            this.howbyte2.Location = new System.Drawing.Point(580, 24);
            this.howbyte2.MaxLength = 50;
            this.howbyte2.MouseState = MaterialSkin.MouseState.OUT;
            this.howbyte2.Multiline = false;
            this.howbyte2.Name = "howbyte";
            this.howbyte2.Size = new System.Drawing.Size(150, 50);
            this.howbyte2.TabIndex = 27;
            this.howbyte2.Text = "0";
            // 
            // txt_howbyte2
            // 
            this.txt_howbyte2.AutoSize = true;
            this.txt_howbyte2.Depth = 0;
            this.txt_howbyte2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_howbyte2.Location = new System.Drawing.Point(750, 38);
            this.txt_howbyte2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_howbyte2.Name = "txt_maxbyte";
            this.txt_howbyte2.Size = new System.Drawing.Size(117, 19);
            this.txt_howbyte2.TabIndex = 26;
            this.txt_howbyte2.Text = "How Byte";
            // 
            // AllBytes2
            // 
            this.AllBytes2.AutoSize = true;
            this.AllBytes2.Depth = 0;
            this.AllBytes2.Location = new System.Drawing.Point(923, 24);
            this.AllBytes2.Margin = new System.Windows.Forms.Padding(0);
            this.AllBytes2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AllBytes2.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllBytes2.Name = "AllBytes";
            this.AllBytes2.Ripple = true;
            this.AllBytes2.Size = new System.Drawing.Size(134, 37);
            this.AllBytes2.TabIndex = 36;
            this.AllBytes2.Text = "Read all bytes";
            this.AllBytes2.UseVisualStyleBackColor = true;
            // 
            // WordSize2
            // 
            this.WordSize2.AutoResize = false;
            this.WordSize2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WordSize2.Depth = 0;
            this.WordSize2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WordSize2.DropDownHeight = 174;
            this.WordSize2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordSize2.DropDownWidth = 121;
            this.WordSize2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WordSize2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordSize2.FormattingEnabled = true;
            this.WordSize2.IntegralHeight = false;
            this.WordSize2.ItemHeight = 43;
            this.WordSize2.Items.AddRange(new object[] {
            "word size 1 bytes",
            "word size 2 bytes",
            "word size 4 bytes"});
            this.WordSize2.Location = new System.Drawing.Point(923, 80);
            this.WordSize2.MaxDropDownItems = 4;
            this.WordSize2.MouseState = MaterialSkin.MouseState.OUT;
            this.WordSize2.Name = "WordSize";
            this.WordSize2.Size = new System.Drawing.Size(175, 49);
            this.WordSize2.TabIndex = 31;
            // 
            // WordInLine2
            // 
            this.WordInLine2.AutoResize = false;
            this.WordInLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WordInLine2.Depth = 0;
            this.WordInLine2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WordInLine2.DropDownHeight = 174;
            this.WordInLine2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordInLine2.DropDownWidth = 121;
            this.WordInLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WordInLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordInLine2.FormattingEnabled = true;
            this.WordInLine2.IntegralHeight = false;
            this.WordInLine2.ItemHeight = 43;
            this.WordInLine2.Items.AddRange(new object[] {
            "line 1 words",
            "line 2 words",
            "line 4 words"});
            this.WordInLine2.Location = new System.Drawing.Point(923, 135);
            this.WordInLine2.MaxDropDownItems = 4;
            this.WordInLine2.MouseState = MaterialSkin.MouseState.OUT;
            this.WordInLine2.Name = "WordInLine";
            this.WordInLine2.Size = new System.Drawing.Size(175, 49);
            this.WordInLine2.TabIndex = 32;

            // 
            // ShowLinenumbers2
            // 
            this.ShowLinenumbers2.AutoSize = true;
            this.ShowLinenumbers2.Checked = true;
            this.ShowLinenumbers2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLinenumbers2.Depth = 0;
            this.ShowLinenumbers2.Location = new System.Drawing.Point(923, 201);
            this.ShowLinenumbers2.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLinenumbers2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowLinenumbers2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLinenumbers2.Name = "ShowLinenumbers";
            this.ShowLinenumbers2.Ripple = true;
            this.ShowLinenumbers2.Size = new System.Drawing.Size(182, 37);
            this.ShowLinenumbers2.TabIndex = 33;
            this.ShowLinenumbers2.Text = "show line numbering";
            this.ShowLinenumbers2.UseVisualStyleBackColor = true;

            // 
            // ShowLineAdres2
            // 
            this.ShowLineAdres2.AutoSize = true;
            this.ShowLineAdres2.Depth = 0;
            this.ShowLineAdres2.Location = new System.Drawing.Point(923, 253);
            this.ShowLineAdres2.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLineAdres2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowLineAdres2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLineAdres2.Name = "ShowLineAdres";
            this.ShowLineAdres2.Ripple = true;
            this.ShowLineAdres2.Size = new System.Drawing.Size(178, 37);
            this.ShowLineAdres2.TabIndex = 34;
            this.ShowLineAdres2.Text = "show line addresses";
            this.ShowLineAdres2.UseVisualStyleBackColor = true;

            // 
            // ShowAsciiSymbols2
            // 
            this.ShowAsciiSymbols2.AutoSize = true;
            this.ShowAsciiSymbols2.Depth = 0;
            this.ShowAsciiSymbols2.Location = new System.Drawing.Point(923, 302);
            this.ShowAsciiSymbols2.Margin = new System.Windows.Forms.Padding(0);
            this.ShowAsciiSymbols2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowAsciiSymbols2.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAsciiSymbols2.Name = "ShowAsciiSymbols";
            this.ShowAsciiSymbols2.Ripple = true;
            this.ShowAsciiSymbols2.Size = new System.Drawing.Size(171, 37);
            this.ShowAsciiSymbols2.TabIndex = 35;
            this.ShowAsciiSymbols2.Text = "show ASCII symbol";
            this.ShowAsciiSymbols2.UseVisualStyleBackColor = true;
            // 
            // FinishDataPage12
            // 
            this.FinishDataPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FinishDataPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinishDataPage2.Depth = 0;
            this.FinishDataPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FinishDataPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishDataPage2.Hint = "";
            this.FinishDataPage2.Location = new System.Drawing.Point(-4, 80);
            this.FinishDataPage2.MaximumSize = new System.Drawing.Size(900, 550);
            this.FinishDataPage2.MaxLength = 80;
            this.FinishDataPage2.MinimumSize = new System.Drawing.Size(900, 550);
            this.FinishDataPage2.MouseState = MaterialSkin.MouseState.HOVER;
            this.FinishDataPage2.Name = "FinishDataPage1";
            this.FinishDataPage2.ReadOnly = true;
            this.FinishDataPage2.Size = new System.Drawing.Size(900, 550);
            this.FinishDataPage2.TabIndex = 17;
            this.FinishDataPage2.Text = "";
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
        
        //_________________________ Pecc tam pievoenot____________________________________
        // tabPage4 __________ tabpage 4 ____________________________________________
        private MaterialSkin.Controls.MaterialTextBox minbyte;
        private MaterialSkin.Controls.MaterialLabel txt_minbyte;
        private MaterialSkin.Controls.MaterialTextBox maxbyte;
        private MaterialSkin.Controls.MaterialLabel txt_maxbyte;
        private MaterialSkin.Controls.MaterialTextBox howbyte;
        private MaterialSkin.Controls.MaterialLabel txt_howbyte;
        private MaterialSkin.Controls.MaterialCheckbox AllBytes;
        private MaterialSkin.Controls.MaterialComboBox WordSize;
        private MaterialSkin.Controls.MaterialComboBox WordInLine;
        private MaterialSkin.Controls.MaterialCheckbox ShowAsciiSymbols;
        private MaterialSkin.Controls.MaterialCheckbox ShowLineAdres;
        private MaterialSkin.Controls.MaterialCheckbox ShowLinenumbers;
        private MaterialSkin.Controls.MaterialMultiLineTextBox FinishDataPage1;
        // tabPage5 __________ tabpage 5 ____________________________________________
        private MaterialSkin.Controls.MaterialTextBox minbyte2;
        private MaterialSkin.Controls.MaterialLabel txt_minbyte2;
        private MaterialSkin.Controls.MaterialTextBox maxbyte2;
        private MaterialSkin.Controls.MaterialLabel txt_maxbyte2;
        private MaterialSkin.Controls.MaterialTextBox howbyte2;
        private MaterialSkin.Controls.MaterialLabel txt_howbyte2;
        private MaterialSkin.Controls.MaterialCheckbox AllBytes2;
        private MaterialSkin.Controls.MaterialComboBox WordSize2;
        private MaterialSkin.Controls.MaterialComboBox WordInLine2;
        private MaterialSkin.Controls.MaterialCheckbox ShowAsciiSymbols2;
        private MaterialSkin.Controls.MaterialCheckbox ShowLineAdres2;
        private MaterialSkin.Controls.MaterialCheckbox ShowLinenumbers2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox FinishDataPage2;
    }
}