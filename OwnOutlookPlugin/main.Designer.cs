namespace OwnOutlookPlugin
{
    partial class main : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public main()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.config = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.dziel_plik = this.Factory.CreateRibbonButton();
            this.dziel_folder = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.about = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "Owncloud";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.config);
            this.group1.Label = "Konfiguracja";
            this.group1.Name = "group1";
            // 
            // config
            // 
            this.config.Image = ((System.Drawing.Image)(resources.GetObject("config.Image")));
            this.config.Label = "Konfiguracja";
            this.config.Name = "config";
            this.config.ShowImage = true;
            this.config.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.config_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.dziel_plik);
            this.group2.Items.Add(this.dziel_folder);
            this.group2.Label = "Dziel";
            this.group2.Name = "group2";
            // 
            // dziel_plik
            // 
            this.dziel_plik.Image = ((System.Drawing.Image)(resources.GetObject("dziel_plik.Image")));
            this.dziel_plik.Label = "Dziel plik";
            this.dziel_plik.Name = "dziel_plik";
            this.dziel_plik.ShowImage = true;
            this.dziel_plik.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dziel_plik_Click);
            // 
            // dziel_folder
            // 
            this.dziel_folder.Image = ((System.Drawing.Image)(resources.GetObject("dziel_folder.Image")));
            this.dziel_folder.Label = "Dziel folder";
            this.dziel_folder.Name = "dziel_folder";
            this.dziel_folder.ShowImage = true;
            this.dziel_folder.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dziel_folder_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.about);
            this.group3.Label = "O programie";
            this.group3.Name = "group3";
            // 
            // about
            // 
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.Label = "O programie";
            this.about.Name = "about";
            this.about.ShowImage = true;
            this.about.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.about_Click);
            // 
            // main
            // 
            this.Name = "main";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.main_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton config;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dziel_plik;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dziel_folder;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton about;
    }

    partial class ThisRibbonCollection
    {
        internal main main
        {
            get { return this.GetRibbon<main>(); }
        }
    }
}
