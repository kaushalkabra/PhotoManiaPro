namespace PhotoManiaPro
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.TxtImageName = new MetroFramework.Controls.MetroTextBox();
            this.TxtImageType = new MetroFramework.Controls.MetroTextBox();
            this.TxtImageSize = new MetroFramework.Controls.MetroTextBox();
            this.TxtImageWidth = new MetroFramework.Controls.MetroTextBox();
            this.TxtImageHeight = new MetroFramework.Controls.MetroTextBox();
            this.TxtVerticalResolution = new MetroFramework.Controls.MetroTextBox();
            this.TxtHorizontalResolution = new MetroFramework.Controls.MetroTextBox();
            this.TxtPixelFormat = new MetroFramework.Controls.MetroTextBox();
            this.TxtRawFormat = new MetroFramework.Controls.MetroTextBox();
            this.TxtPalletteFlags = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.MainButtonPanel = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.BtnEditImage = new MetroFramework.Controls.MetroButton();
            this.BtnPrint = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNext = new MetroFramework.Controls.MetroButton();
            this.BtnSlideshow = new MetroFramework.Controls.MetroButton();
            this.BtnBack = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(27, 74);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1279, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faceDetectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // faceDetectionToolStripMenuItem
            // 
            this.faceDetectionToolStripMenuItem.Name = "faceDetectionToolStripMenuItem";
            this.faceDetectionToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.faceDetectionToolStripMenuItem.Text = "Face Detection";
            this.faceDetectionToolStripMenuItem.Click += new System.EventHandler(this.faceDetectionToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.settingsToolStripMenuItem.Text = "Preferences";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09404F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 107);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 597);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(884, 589);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.92857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.07143F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel9, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel10, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel11, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.TxtImageName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtImageType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtImageSize, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtImageWidth, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtImageHeight, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TxtVerticalResolution, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.TxtHorizontalResolution, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.TxtPixelFormat, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.TxtRawFormat, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.TxtPalletteFlags, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel12, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(896, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 589);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(7, 3);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 51);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Property";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(7, 57);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 51);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(7, 111);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 51);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Type";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(7, 165);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 51);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Size";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(7, 219);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 51);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Width";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(7, 273);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 51);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Height";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(7, 381);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(116, 51);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Horizontal Res.";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(7, 489);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(116, 51);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Pallette Flags";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = false;
            this.metroLabel10.CustomForeColor = false;
            this.metroLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel10.Location = new System.Drawing.Point(7, 435);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(116, 51);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.StyleManager = null;
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Pixel Format";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = false;
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(7, 327);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 51);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Vertical Res.";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = false;
            this.metroLabel11.CustomForeColor = false;
            this.metroLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel11.Location = new System.Drawing.Point(7, 543);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(116, 43);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.StyleManager = null;
            this.metroLabel11.TabIndex = 10;
            this.metroLabel11.Text = "Raw Format";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel11.UseStyleColors = true;
            // 
            // TxtImageName
            // 
            this.TxtImageName.CustomBackground = false;
            this.TxtImageName.CustomForeColor = false;
            this.TxtImageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtImageName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtImageName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtImageName.Location = new System.Drawing.Point(134, 61);
            this.TxtImageName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImageName.Multiline = false;
            this.TxtImageName.Name = "TxtImageName";
            this.TxtImageName.SelectedText = "";
            this.TxtImageName.Size = new System.Drawing.Size(235, 43);
            this.TxtImageName.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtImageName.StyleManager = null;
            this.TxtImageName.TabIndex = 12;
            this.TxtImageName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtImageName.UseStyleColors = true;
            // 
            // TxtImageType
            // 
            this.TxtImageType.CustomBackground = false;
            this.TxtImageType.CustomForeColor = false;
            this.TxtImageType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtImageType.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtImageType.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtImageType.Location = new System.Drawing.Point(134, 115);
            this.TxtImageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImageType.Multiline = false;
            this.TxtImageType.Name = "TxtImageType";
            this.TxtImageType.SelectedText = "";
            this.TxtImageType.Size = new System.Drawing.Size(235, 43);
            this.TxtImageType.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtImageType.StyleManager = null;
            this.TxtImageType.TabIndex = 13;
            this.TxtImageType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtImageType.UseStyleColors = true;
            // 
            // TxtImageSize
            // 
            this.TxtImageSize.CustomBackground = false;
            this.TxtImageSize.CustomForeColor = false;
            this.TxtImageSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtImageSize.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtImageSize.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtImageSize.Location = new System.Drawing.Point(134, 169);
            this.TxtImageSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImageSize.Multiline = false;
            this.TxtImageSize.Name = "TxtImageSize";
            this.TxtImageSize.SelectedText = "";
            this.TxtImageSize.Size = new System.Drawing.Size(235, 43);
            this.TxtImageSize.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtImageSize.StyleManager = null;
            this.TxtImageSize.TabIndex = 14;
            this.TxtImageSize.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtImageSize.UseStyleColors = true;
            // 
            // TxtImageWidth
            // 
            this.TxtImageWidth.CustomBackground = false;
            this.TxtImageWidth.CustomForeColor = false;
            this.TxtImageWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtImageWidth.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtImageWidth.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtImageWidth.Location = new System.Drawing.Point(134, 223);
            this.TxtImageWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImageWidth.Multiline = false;
            this.TxtImageWidth.Name = "TxtImageWidth";
            this.TxtImageWidth.SelectedText = "";
            this.TxtImageWidth.Size = new System.Drawing.Size(235, 43);
            this.TxtImageWidth.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtImageWidth.StyleManager = null;
            this.TxtImageWidth.TabIndex = 15;
            this.TxtImageWidth.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtImageWidth.UseStyleColors = true;
            // 
            // TxtImageHeight
            // 
            this.TxtImageHeight.CustomBackground = false;
            this.TxtImageHeight.CustomForeColor = false;
            this.TxtImageHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtImageHeight.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtImageHeight.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtImageHeight.Location = new System.Drawing.Point(134, 277);
            this.TxtImageHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImageHeight.Multiline = false;
            this.TxtImageHeight.Name = "TxtImageHeight";
            this.TxtImageHeight.SelectedText = "";
            this.TxtImageHeight.Size = new System.Drawing.Size(235, 43);
            this.TxtImageHeight.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtImageHeight.StyleManager = null;
            this.TxtImageHeight.TabIndex = 16;
            this.TxtImageHeight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtImageHeight.UseStyleColors = true;
            // 
            // TxtVerticalResolution
            // 
            this.TxtVerticalResolution.CustomBackground = false;
            this.TxtVerticalResolution.CustomForeColor = false;
            this.TxtVerticalResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtVerticalResolution.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtVerticalResolution.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtVerticalResolution.Location = new System.Drawing.Point(134, 331);
            this.TxtVerticalResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtVerticalResolution.Multiline = false;
            this.TxtVerticalResolution.Name = "TxtVerticalResolution";
            this.TxtVerticalResolution.SelectedText = "";
            this.TxtVerticalResolution.Size = new System.Drawing.Size(235, 43);
            this.TxtVerticalResolution.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtVerticalResolution.StyleManager = null;
            this.TxtVerticalResolution.TabIndex = 17;
            this.TxtVerticalResolution.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtVerticalResolution.UseStyleColors = true;
            // 
            // TxtHorizontalResolution
            // 
            this.TxtHorizontalResolution.CustomBackground = false;
            this.TxtHorizontalResolution.CustomForeColor = false;
            this.TxtHorizontalResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtHorizontalResolution.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtHorizontalResolution.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtHorizontalResolution.Location = new System.Drawing.Point(134, 385);
            this.TxtHorizontalResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtHorizontalResolution.Multiline = false;
            this.TxtHorizontalResolution.Name = "TxtHorizontalResolution";
            this.TxtHorizontalResolution.SelectedText = "";
            this.TxtHorizontalResolution.Size = new System.Drawing.Size(235, 43);
            this.TxtHorizontalResolution.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtHorizontalResolution.StyleManager = null;
            this.TxtHorizontalResolution.TabIndex = 18;
            this.TxtHorizontalResolution.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtHorizontalResolution.UseStyleColors = true;
            // 
            // TxtPixelFormat
            // 
            this.TxtPixelFormat.CustomBackground = false;
            this.TxtPixelFormat.CustomForeColor = false;
            this.TxtPixelFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPixelFormat.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtPixelFormat.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtPixelFormat.Location = new System.Drawing.Point(134, 439);
            this.TxtPixelFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPixelFormat.Multiline = false;
            this.TxtPixelFormat.Name = "TxtPixelFormat";
            this.TxtPixelFormat.SelectedText = "";
            this.TxtPixelFormat.Size = new System.Drawing.Size(235, 43);
            this.TxtPixelFormat.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPixelFormat.StyleManager = null;
            this.TxtPixelFormat.TabIndex = 19;
            this.TxtPixelFormat.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPixelFormat.UseStyleColors = true;
            // 
            // TxtRawFormat
            // 
            this.TxtRawFormat.CustomBackground = false;
            this.TxtRawFormat.CustomForeColor = false;
            this.TxtRawFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRawFormat.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtRawFormat.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtRawFormat.Location = new System.Drawing.Point(134, 547);
            this.TxtRawFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRawFormat.Multiline = false;
            this.TxtRawFormat.Name = "TxtRawFormat";
            this.TxtRawFormat.SelectedText = "";
            this.TxtRawFormat.Size = new System.Drawing.Size(235, 35);
            this.TxtRawFormat.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRawFormat.StyleManager = null;
            this.TxtRawFormat.TabIndex = 20;
            this.TxtRawFormat.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRawFormat.UseStyleColors = true;
            // 
            // TxtPalletteFlags
            // 
            this.TxtPalletteFlags.CustomBackground = false;
            this.TxtPalletteFlags.CustomForeColor = false;
            this.TxtPalletteFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPalletteFlags.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TxtPalletteFlags.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TxtPalletteFlags.Location = new System.Drawing.Point(134, 493);
            this.TxtPalletteFlags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPalletteFlags.Multiline = false;
            this.TxtPalletteFlags.Name = "TxtPalletteFlags";
            this.TxtPalletteFlags.SelectedText = "";
            this.TxtPalletteFlags.Size = new System.Drawing.Size(235, 43);
            this.TxtPalletteFlags.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPalletteFlags.StyleManager = null;
            this.TxtPalletteFlags.TabIndex = 21;
            this.TxtPalletteFlags.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPalletteFlags.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.CustomBackground = false;
            this.metroLabel12.CustomForeColor = false;
            this.metroLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel12.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel12.Location = new System.Drawing.Point(134, 3);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(235, 51);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel12.StyleManager = null;
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "Value";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel12.UseStyleColors = true;
            // 
            // MainButtonPanel
            // 
            this.MainButtonPanel.Controls.Add(this.metroButton2);
            this.MainButtonPanel.Controls.Add(this.metroButton1);
            this.MainButtonPanel.Controls.Add(this.trackBar1);
            this.MainButtonPanel.Controls.Add(this.BtnEditImage);
            this.MainButtonPanel.Controls.Add(this.BtnPrint);
            this.MainButtonPanel.Controls.Add(this.panel1);
            this.MainButtonPanel.Controls.Add(this.BtnDelete);
            this.MainButtonPanel.Location = new System.Drawing.Point(31, 711);
            this.MainButtonPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainButtonPanel.Name = "MainButtonPanel";
            this.MainButtonPanel.Size = new System.Drawing.Size(1276, 68);
            this.MainButtonPanel.TabIndex = 2;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(1172, 4);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 59);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Rotate Right";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(1064, 4);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 60);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Rotate Left";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(860, 7);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // BtnEditImage
            // 
            this.BtnEditImage.Highlight = false;
            this.BtnEditImage.Location = new System.Drawing.Point(577, 4);
            this.BtnEditImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditImage.Name = "BtnEditImage";
            this.BtnEditImage.Size = new System.Drawing.Size(133, 60);
            this.BtnEditImage.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnEditImage.StyleManager = null;
            this.BtnEditImage.TabIndex = 9;
            this.BtnEditImage.Text = "Edit Image";
            this.BtnEditImage.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Highlight = false;
            this.BtnPrint.Location = new System.Drawing.Point(436, 4);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(133, 60);
            this.BtnPrint.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnPrint.StyleManager = null;
            this.BtnPrint.TabIndex = 8;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNext);
            this.panel1.Controls.Add(this.BtnSlideshow);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 60);
            this.panel1.TabIndex = 6;
            // 
            // BtnNext
            // 
            this.BtnNext.Highlight = false;
            this.BtnNext.Location = new System.Drawing.Point(287, 4);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(133, 53);
            this.BtnNext.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnNext.StyleManager = null;
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSlideshow
            // 
            this.BtnSlideshow.Highlight = false;
            this.BtnSlideshow.Location = new System.Drawing.Point(145, 4);
            this.BtnSlideshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSlideshow.Name = "BtnSlideshow";
            this.BtnSlideshow.Size = new System.Drawing.Size(133, 53);
            this.BtnSlideshow.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnSlideshow.StyleManager = null;
            this.BtnSlideshow.TabIndex = 2;
            this.BtnSlideshow.Text = "Slideshow ON";
            this.BtnSlideshow.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSlideshow.Click += new System.EventHandler(this.BtnSlideshow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Highlight = false;
            this.BtnBack.Location = new System.Drawing.Point(4, 4);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(133, 53);
            this.BtnBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnBack.StyleManager = null;
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Highlight = false;
            this.BtnDelete.Location = new System.Drawing.Point(719, 4);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 60);
            this.BtnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnDelete.StyleManager = null;
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 800);
            this.Controls.Add(this.MainButtonPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindowForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Photo Mania Pro";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MainButtonPanel.ResumeLayout(false);
            this.MainButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MainButtonPanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnSlideshow;
        private MetroFramework.Controls.MetroButton BtnNext;
        private MetroFramework.Controls.MetroButton BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton BtnPrint;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceDetectionToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox TxtImageName;
        private MetroFramework.Controls.MetroTextBox TxtImageType;
        private MetroFramework.Controls.MetroTextBox TxtImageSize;
        private MetroFramework.Controls.MetroTextBox TxtImageWidth;
        private MetroFramework.Controls.MetroTextBox TxtImageHeight;
        private MetroFramework.Controls.MetroTextBox TxtVerticalResolution;
        private MetroFramework.Controls.MetroTextBox TxtHorizontalResolution;
        private MetroFramework.Controls.MetroTextBox TxtPixelFormat;
        private MetroFramework.Controls.MetroTextBox TxtRawFormat;
        private MetroFramework.Controls.MetroTextBox TxtPalletteFlags;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroButton BtnEditImage;
        private System.Windows.Forms.TrackBar trackBar1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

