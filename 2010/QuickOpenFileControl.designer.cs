namespace QuickOpenFile
{
    partial class QuickOpenFileControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                searchEngine.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickOpenFileControl));
            this.uxSearch = new System.Windows.Forms.TextBox();
            this.uxHelp = new System.Windows.Forms.Label();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxOpenWithMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxStatus = new System.Windows.Forms.Label();
            this.uxOpenWith = new System.Windows.Forms.Button();
            this.uxOptions = new System.Windows.Forms.Button();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            this.uxOpenWithMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSearch
            // 
            this.uxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSearch.Location = new System.Drawing.Point(3, 19);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(611, 20);
            this.uxSearch.TabIndex = 1;
            this.uxSearch.TextChanged += new System.EventHandler(this.uxSearch_TextChanged);
            this.uxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxSearch_KeyDown);
            // 
            // uxHelp
            // 
            this.uxHelp.AutoSize = true;
            this.uxHelp.Location = new System.Drawing.Point(3, 3);
            this.uxHelp.Name = "uxHelp";
            this.uxHelp.Size = new System.Drawing.Size(491, 13);
            this.uxHelp.TabIndex = 5;
            this.uxHelp.Text = "Type part of the file name here. You can use wildcards: ? matches any character, " +
    "* matches any string.";
            // 
            // uxOpen
            // 
            this.uxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpen.Enabled = false;
            this.uxOpen.Location = new System.Drawing.Point(519, 194);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(95, 25);
            this.uxOpen.TabIndex = 3;
            this.uxOpen.Text = "&Open    ";
            this.uxToolTip.SetToolTip(this.uxOpen, "Opens the selected file(s).");
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.EnabledChanged += new System.EventHandler(this.uxOpen_EnabledChanged);
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxOpenWithMenu
            // 
            this.uxOpenWithMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem});
            this.uxOpenWithMenu.Name = "contextMenuStrip1";
            this.uxOpenWithMenu.Size = new System.Drawing.Size(153, 70);
            this.uxOpenWithMenu.Opening += new System.ComponentModel.CancelEventHandler(this.uxOpenWith_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openWithToolStripMenuItem.Text = "Open With...";
            this.openWithToolStripMenuItem.Click += new System.EventHandler(this.openWithToolStripMenuItem_Click);
            // 
            // uxFiles
            // 
            this.uxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFiles.CheckBoxes = true;
            this.uxFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.uxFiles.ContextMenuStrip = this.uxOpenWithMenu;
            this.uxFiles.FullRowSelect = true;
            this.uxFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxFiles.HideSelection = false;
            this.uxFiles.Location = new System.Drawing.Point(3, 45);
            this.uxFiles.MultiSelect = false;
            this.uxFiles.Name = "uxFiles";
            this.uxFiles.Size = new System.Drawing.Size(611, 145);
            this.uxFiles.TabIndex = 2;
            this.uxFiles.UseCompatibleStateImageBehavior = false;
            this.uxFiles.View = System.Windows.Forms.View.Details;
            this.uxFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.uxFiles_ItemSelectionChanged);
            this.uxFiles.DoubleClick += new System.EventHandler(this.uxFiles_DoubleClick);
            this.uxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxFiles_KeyDown);
            this.uxFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxFiles_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 500;
            // 
            // uxStatus
            // 
            this.uxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.uxStatus.Location = new System.Drawing.Point(34, 199);
            this.uxStatus.Name = "uxStatus";
            this.uxStatus.Size = new System.Drawing.Size(479, 18);
            this.uxStatus.TabIndex = 6;
            // 
            // uxOpenWith
            // 
            this.uxOpenWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOpenWith.Enabled = false;
            this.uxOpenWith.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxOpenWith.Location = new System.Drawing.Point(591, 194);
            this.uxOpenWith.Name = "uxOpenWith";
            this.uxOpenWith.Size = new System.Drawing.Size(23, 25);
            this.uxOpenWith.TabIndex = 4;
            this.uxOpenWith.Text = "▼";
            this.uxToolTip.SetToolTip(this.uxOpenWith, "Displays the open menu.");
            this.uxOpenWith.UseVisualStyleBackColor = true;
            this.uxOpenWith.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxOpenWith_MouseDown);
            // 
            // uxOptions
            // 
            this.uxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxOptions.Image = ((System.Drawing.Image)(resources.GetObject("uxOptions.Image")));
            this.uxOptions.Location = new System.Drawing.Point(3, 193);
            this.uxOptions.Name = "uxOptions";
            this.uxOptions.Size = new System.Drawing.Size(25, 25);
            this.uxOptions.TabIndex = 7;
            this.uxToolTip.SetToolTip(this.uxOptions, "Shows options dialog.");
            this.uxOptions.UseVisualStyleBackColor = true;
            this.uxOptions.Click += new System.EventHandler(this.uxOptions_Click);
            // 
            // uxTimer
            // 
            this.uxTimer.Interval = 350;
            this.uxTimer.Tick += new System.EventHandler(this.uxTimer_Tick);
            // 
            // QuickOpenFileControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.uxOptions);
            this.Controls.Add(this.uxOpenWith);
            this.Controls.Add(this.uxStatus);
            this.Controls.Add(this.uxFiles);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.uxHelp);
            this.Controls.Add(this.uxSearch);
            this.Name = "QuickOpenFileControl";
            this.Size = new System.Drawing.Size(617, 222);
            this.uxOpenWithMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox uxSearch;
        private System.Windows.Forms.Label uxHelp;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.ListView uxFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label uxStatus;
        private System.Windows.Forms.ContextMenuStrip uxOpenWithMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.Button uxOpenWith;
        private System.Windows.Forms.Button uxOptions;
        private System.Windows.Forms.ToolTip uxToolTip;
        private System.Windows.Forms.Timer uxTimer;
    }
}
