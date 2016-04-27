namespace PhotoEditor
{
    partial class MainFrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.mainpnl = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.lbly = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.floatingfooter = new System.Windows.Forms.Panel();
            this.flatclose = new System.Windows.Forms.Button();
            this.flatsave = new System.Windows.Forms.Button();
            this.flatload = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optnpnl1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bluerd = new System.Windows.Forms.RadioButton();
            this.redrd = new System.Windows.Forms.RadioButton();
            this.greenrd = new System.Windows.Forms.RadioButton();
            this.TopPnl = new System.Windows.Forms.Panel();
            this.Mdnbtn = new System.Windows.Forms.Button();
            this.mynbtn = new System.Windows.Forms.Button();
            this.grayscalebtn = new System.Windows.Forms.Button();
            this.busypnl = new System.Windows.Forms.Panel();
            this.busy = new System.Windows.Forms.PictureBox();
            this.inversebtn = new System.Windows.Forms.Button();
            this.linedrawbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pctmdf = new System.Windows.Forms.PictureBox();
            this.pctrgnl = new System.Windows.Forms.PictureBox();
            this.svfldlg = new System.Windows.Forms.SaveFileDialog();
            this.opnfldlg = new System.Windows.Forms.OpenFileDialog();
            this.MdnPnl = new System.Windows.Forms.Panel();
            this.MdnInfoLbl = new System.Windows.Forms.Label();
            this.MdnEdgeScale = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.popupmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnopn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnexit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpnl.SuspendLayout();
            this.footer.SuspendLayout();
            this.floatingfooter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.optnpnl1.SuspendLayout();
            this.TopPnl.SuspendLayout();
            this.busypnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busy)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctmdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrgnl)).BeginInit();
            this.MdnPnl.SuspendLayout();
            this.popupmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpnl
            // 
            this.mainpnl.Controls.Add(this.footer);
            this.mainpnl.Controls.Add(this.panel3);
            this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpnl.Location = new System.Drawing.Point(0, 0);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(693, 389);
            this.mainpnl.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Black;
            this.footer.ContextMenuStrip = this.popupmenu;
            this.footer.Controls.Add(this.lbly);
            this.footer.Controls.Add(this.lblx);
            this.footer.Controls.Add(this.btnexit);
            this.footer.Controls.Add(this.savebtn);
            this.footer.Controls.Add(this.btnload);
            this.footer.Controls.Add(this.floatingfooter);
            this.footer.Controls.Add(this.lblname);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.footer.Location = new System.Drawing.Point(0, 290);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(693, 99);
            this.footer.TabIndex = 10;
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.lbly.Location = new System.Drawing.Point(321, 60);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(0, 24);
            this.lbly.TabIndex = 15;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.lblx.Location = new System.Drawing.Point(233, 60);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(0, 24);
            this.lblx.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(64, 12);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 29);
            this.btnexit.TabIndex = 12;
            this.btnexit.TabStop = false;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Visible = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(214)))));
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(48, 12);
            this.savebtn.Margin = new System.Windows.Forms.Padding(0);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 29);
            this.savebtn.TabIndex = 13;
            this.savebtn.TabStop = false;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Visible = false;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(214)))));
            this.btnload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.Location = new System.Drawing.Point(31, 12);
            this.btnload.Margin = new System.Windows.Forms.Padding(0);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 29);
            this.btnload.TabIndex = 11;
            this.btnload.TabStop = false;
            this.btnload.Text = "Load ...";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Visible = false;
            // 
            // floatingfooter
            // 
            this.floatingfooter.ContextMenuStrip = this.popupmenu;
            this.floatingfooter.Controls.Add(this.flatclose);
            this.floatingfooter.Controls.Add(this.flatsave);
            this.floatingfooter.Controls.Add(this.flatload);
            this.floatingfooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.floatingfooter.Location = new System.Drawing.Point(430, 0);
            this.floatingfooter.Name = "floatingfooter";
            this.floatingfooter.Size = new System.Drawing.Size(263, 99);
            this.floatingfooter.TabIndex = 10;
            // 
            // flatclose
            // 
            this.flatclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.flatclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.flatclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flatclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatclose.Image = ((System.Drawing.Image)(resources.GetObject("flatclose.Image")));
            this.flatclose.Location = new System.Drawing.Point(176, 12);
            this.flatclose.Name = "flatclose";
            this.flatclose.Size = new System.Drawing.Size(75, 72);
            this.flatclose.TabIndex = 12;
            this.flatclose.UseVisualStyleBackColor = false;
            this.flatclose.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // flatsave
            // 
            this.flatsave.BackColor = System.Drawing.Color.Black;
            this.flatsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.flatsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flatsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatsave.Image = ((System.Drawing.Image)(resources.GetObject("flatsave.Image")));
            this.flatsave.Location = new System.Drawing.Point(81, 12);
            this.flatsave.Name = "flatsave";
            this.flatsave.Size = new System.Drawing.Size(75, 72);
            this.flatsave.TabIndex = 11;
            this.flatsave.UseVisualStyleBackColor = false;
            this.flatsave.Visible = false;
            this.flatsave.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // flatload
            // 
            this.flatload.BackColor = System.Drawing.Color.Black;
            this.flatload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.flatload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flatload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatload.Image = ((System.Drawing.Image)(resources.GetObject("flatload.Image")));
            this.flatload.Location = new System.Drawing.Point(0, 12);
            this.flatload.Name = "flatload";
            this.flatload.Size = new System.Drawing.Size(75, 72);
            this.flatload.TabIndex = 10;
            this.flatload.UseVisualStyleBackColor = false;
            this.flatload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ContextMenuStrip = this.popupmenu;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.lblname.Location = new System.Drawing.Point(35, 28);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(187, 39);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Photo Filtre";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.optnpnl1);
            this.panel3.Controls.Add(this.TopPnl);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 389);
            this.panel3.TabIndex = 11;
            // 
            // optnpnl1
            // 
            this.optnpnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.optnpnl1.Controls.Add(this.panel5);
            this.optnpnl1.Controls.Add(this.bluerd);
            this.optnpnl1.Controls.Add(this.redrd);
            this.optnpnl1.Controls.Add(this.greenrd);
            this.optnpnl1.Location = new System.Drawing.Point(146, 56);
            this.optnpnl1.Name = "optnpnl1";
            this.optnpnl1.Size = new System.Drawing.Size(89, 60);
            this.optnpnl1.TabIndex = 11;
            this.optnpnl1.Visible = false;
            this.optnpnl1.Click += new System.EventHandler(this.optnpnl1_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(123, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 60);
            this.panel5.TabIndex = 19;
            // 
            // bluerd
            // 
            this.bluerd.AutoSize = true;
            this.bluerd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bluerd.Location = new System.Drawing.Point(3, 35);
            this.bluerd.Name = "bluerd";
            this.bluerd.Size = new System.Drawing.Size(46, 17);
            this.bluerd.TabIndex = 22;
            this.bluerd.TabStop = true;
            this.bluerd.Text = "Blue";
            this.bluerd.UseVisualStyleBackColor = true;
            this.bluerd.CheckedChanged += new System.EventHandler(this.bluerd_CheckedChanged);
            // 
            // redrd
            // 
            this.redrd.AutoSize = true;
            this.redrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.redrd.Location = new System.Drawing.Point(3, 20);
            this.redrd.Name = "redrd";
            this.redrd.Size = new System.Drawing.Size(54, 17);
            this.redrd.TabIndex = 21;
            this.redrd.TabStop = true;
            this.redrd.Text = "Green";
            this.redrd.UseVisualStyleBackColor = true;
            this.redrd.CheckedChanged += new System.EventHandler(this.redrd_CheckedChanged);
            // 
            // greenrd
            // 
            this.greenrd.AutoSize = true;
            this.greenrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greenrd.Location = new System.Drawing.Point(3, 4);
            this.greenrd.Name = "greenrd";
            this.greenrd.Size = new System.Drawing.Size(45, 17);
            this.greenrd.TabIndex = 20;
            this.greenrd.TabStop = true;
            this.greenrd.Text = "Red";
            this.greenrd.UseVisualStyleBackColor = true;
            this.greenrd.CheckedChanged += new System.EventHandler(this.greenrd_CheckedChanged);
            // 
            // TopPnl
            // 
            this.TopPnl.Controls.Add(this.Mdnbtn);
            this.TopPnl.Controls.Add(this.mynbtn);
            this.TopPnl.Controls.Add(this.grayscalebtn);
            this.TopPnl.Controls.Add(this.busypnl);
            this.TopPnl.Controls.Add(this.inversebtn);
            this.TopPnl.Controls.Add(this.linedrawbtn);
            this.TopPnl.Controls.Add(this.sendbtn);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(693, 50);
            this.TopPnl.TabIndex = 7;
            this.TopPnl.Visible = false;
            // 
            // Mdnbtn
            // 
            this.Mdnbtn.BackColor = System.Drawing.Color.Transparent;
            this.Mdnbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mdnbtn.FlatAppearance.BorderSize = 0;
            this.Mdnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mdnbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Mdnbtn.Image = ((System.Drawing.Image)(resources.GetObject("Mdnbtn.Image")));
            this.Mdnbtn.Location = new System.Drawing.Point(378, 2);
            this.Mdnbtn.Name = "Mdnbtn";
            this.Mdnbtn.Size = new System.Drawing.Size(52, 47);
            this.Mdnbtn.TabIndex = 21;
            this.Mdnbtn.UseVisualStyleBackColor = false;
            this.Mdnbtn.Click += new System.EventHandler(this.Mdnbtn_Click);
            // 
            // mynbtn
            // 
            this.mynbtn.BackColor = System.Drawing.Color.Transparent;
            this.mynbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mynbtn.FlatAppearance.BorderSize = 0;
            this.mynbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mynbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mynbtn.Image = ((System.Drawing.Image)(resources.GetObject("mynbtn.Image")));
            this.mynbtn.Location = new System.Drawing.Point(320, 2);
            this.mynbtn.Name = "mynbtn";
            this.mynbtn.Size = new System.Drawing.Size(52, 47);
            this.mynbtn.TabIndex = 20;
            this.mynbtn.UseVisualStyleBackColor = false;
            this.mynbtn.Click += new System.EventHandler(this.mynbtn_Click);
            // 
            // grayscalebtn
            // 
            this.grayscalebtn.BackColor = System.Drawing.Color.Transparent;
            this.grayscalebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.grayscalebtn.FlatAppearance.BorderSize = 0;
            this.grayscalebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grayscalebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.grayscalebtn.Image = ((System.Drawing.Image)(resources.GetObject("grayscalebtn.Image")));
            this.grayscalebtn.Location = new System.Drawing.Point(262, 2);
            this.grayscalebtn.Name = "grayscalebtn";
            this.grayscalebtn.Size = new System.Drawing.Size(52, 47);
            this.grayscalebtn.TabIndex = 19;
            this.grayscalebtn.UseVisualStyleBackColor = false;
            this.grayscalebtn.Click += new System.EventHandler(this.grayscalebtn_Click);
            // 
            // busypnl
            // 
            this.busypnl.Controls.Add(this.busy);
            this.busypnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.busypnl.Location = new System.Drawing.Point(625, 0);
            this.busypnl.Name = "busypnl";
            this.busypnl.Size = new System.Drawing.Size(68, 50);
            this.busypnl.TabIndex = 18;
            // 
            // busy
            // 
            this.busy.Image = ((System.Drawing.Image)(resources.GetObject("busy.Image")));
            this.busy.Location = new System.Drawing.Point(3, 4);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(38, 38);
            this.busy.TabIndex = 0;
            this.busy.TabStop = false;
            this.busy.Visible = false;
            // 
            // inversebtn
            // 
            this.inversebtn.BackColor = System.Drawing.Color.Transparent;
            this.inversebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.inversebtn.FlatAppearance.BorderSize = 0;
            this.inversebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inversebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.inversebtn.Image = ((System.Drawing.Image)(resources.GetObject("inversebtn.Image")));
            this.inversebtn.Location = new System.Drawing.Point(204, 2);
            this.inversebtn.Name = "inversebtn";
            this.inversebtn.Size = new System.Drawing.Size(52, 47);
            this.inversebtn.TabIndex = 17;
            this.inversebtn.UseVisualStyleBackColor = false;
            this.inversebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // linedrawbtn
            // 
            this.linedrawbtn.AccessibleName = "Select Color";
            this.linedrawbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.linedrawbtn.BackColor = System.Drawing.Color.Transparent;
            this.linedrawbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linedrawbtn.FlatAppearance.BorderSize = 0;
            this.linedrawbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.linedrawbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linedrawbtn.Image = ((System.Drawing.Image)(resources.GetObject("linedrawbtn.Image")));
            this.linedrawbtn.Location = new System.Drawing.Point(146, 2);
            this.linedrawbtn.Name = "linedrawbtn";
            this.linedrawbtn.Size = new System.Drawing.Size(52, 47);
            this.linedrawbtn.TabIndex = 16;
            this.linedrawbtn.Tag = "Select Colors";
            this.linedrawbtn.UseVisualStyleBackColor = false;
            this.linedrawbtn.Click += new System.EventHandler(this.linedrawbtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(214)))));
            this.sendbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.ForeColor = System.Drawing.Color.White;
            this.sendbtn.Location = new System.Drawing.Point(11, 9);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(0);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(112, 27);
            this.sendbtn.TabIndex = 15;
            this.sendbtn.TabStop = false;
            this.sendbtn.Text = "Send =>";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92785F));
            this.tableLayoutPanel1.Controls.Add(this.pctmdf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pctrgnl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 389);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pctmdf
            // 
            this.pctmdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.pctmdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctmdf.Location = new System.Drawing.Point(350, 48);
            this.pctmdf.Name = "pctmdf";
            this.pctmdf.Size = new System.Drawing.Size(340, 338);
            this.pctmdf.TabIndex = 20;
            this.pctmdf.TabStop = false;
            // 
            // pctrgnl
            // 
            this.pctrgnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.pctrgnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrgnl.Location = new System.Drawing.Point(3, 48);
            this.pctrgnl.Name = "pctrgnl";
            this.pctrgnl.Size = new System.Drawing.Size(341, 338);
            this.pctrgnl.TabIndex = 21;
            this.pctrgnl.TabStop = false;
            this.pctrgnl.MouseLeave += new System.EventHandler(this.pctrgnl_MouseLeave);
            this.pctrgnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctrgnl_MouseMove);
            // 
            // svfldlg
            // 
            this.svfldlg.Filter = "Bitmap|*.bmp";
            // 
            // opnfldlg
            // 
            this.opnfldlg.Filter = "Bitmap|*.bmp";
            // 
            // MdnPnl
            // 
            this.MdnPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.MdnPnl.Controls.Add(this.MdnInfoLbl);
            this.MdnPnl.Controls.Add(this.MdnEdgeScale);
            this.MdnPnl.Controls.Add(this.panel2);
            this.MdnPnl.Location = new System.Drawing.Point(378, 56);
            this.MdnPnl.Name = "MdnPnl";
            this.MdnPnl.Size = new System.Drawing.Size(127, 60);
            this.MdnPnl.TabIndex = 12;
            this.MdnPnl.Visible = false;
            this.MdnPnl.Click += new System.EventHandler(this.MdnPnl_Click);
            // 
            // MdnInfoLbl
            // 
            this.MdnInfoLbl.AutoSize = true;
            this.MdnInfoLbl.ForeColor = System.Drawing.Color.White;
            this.MdnInfoLbl.Location = new System.Drawing.Point(17, 4);
            this.MdnInfoLbl.Name = "MdnInfoLbl";
            this.MdnInfoLbl.Size = new System.Drawing.Size(64, 13);
            this.MdnInfoLbl.TabIndex = 22;
            this.MdnInfoLbl.Text = "Select size :";
            // 
            // MdnEdgeScale
            // 
            this.MdnEdgeScale.BackColor = System.Drawing.Color.White;
            this.MdnEdgeScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MdnEdgeScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdnEdgeScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.MdnEdgeScale.Items.AddRange(new object[] {
            "None",
            "Median 3x3",
            "Median 5x5",
            "Median 7x7",
            "Median 9x9",
            "Median 11x11",
            "Median 13x13"});
            this.MdnEdgeScale.Location = new System.Drawing.Point(9, 20);
            this.MdnEdgeScale.Name = "MdnEdgeScale";
            this.MdnEdgeScale.Size = new System.Drawing.Size(108, 24);
            this.MdnEdgeScale.TabIndex = 21;
            this.MdnEdgeScale.SelectedIndexChanged += new System.EventHandler(this.MdnEdgeScale_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 60);
            this.panel2.TabIndex = 19;
            // 
            // popupmenu
            // 
            this.popupmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.popupmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnopn,
            this.mnsv,
            this.mnexit});
            this.popupmenu.Name = "popupmenu";
            this.popupmenu.Size = new System.Drawing.Size(199, 70);
            // 
            // mnopn
            // 
            this.mnopn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mnopn.ForeColor = System.Drawing.Color.Silver;
            this.mnopn.Image = ((System.Drawing.Image)(resources.GetObject("mnopn.Image")));
            this.mnopn.Name = "mnopn";
            this.mnopn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnopn.Size = new System.Drawing.Size(198, 22);
            this.mnopn.Text = "Ouvrir";
            this.mnopn.Click += new System.EventHandler(this.btnload_Click);
            // 
            // mnsv
            // 
            this.mnsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mnsv.ForeColor = System.Drawing.Color.Silver;
            this.mnsv.Image = ((System.Drawing.Image)(resources.GetObject("mnsv.Image")));
            this.mnsv.Name = "mnsv";
            this.mnsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnsv.Size = new System.Drawing.Size(198, 22);
            this.mnsv.Text = "Enregistrer Sous";
            this.mnsv.Visible = false;
            this.mnsv.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // mnexit
            // 
            this.mnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.mnexit.ForeColor = System.Drawing.Color.Silver;
            this.mnexit.Image = ((System.Drawing.Image)(resources.GetObject("mnexit.Image")));
            this.mnexit.Name = "mnexit";
            this.mnexit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnexit.Size = new System.Drawing.Size(198, 22);
            this.mnexit.Text = "Exit";
            this.mnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // MainFrm
            // 
            this.AcceptButton = this.btnload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(693, 389);
            this.Controls.Add(this.MdnPnl);
            this.Controls.Add(this.mainpnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "PhotoFiltre";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.mainpnl.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.floatingfooter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.optnpnl1.ResumeLayout(false);
            this.optnpnl1.PerformLayout();
            this.TopPnl.ResumeLayout(false);
            this.busypnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busy)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctmdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrgnl)).EndInit();
            this.MdnPnl.ResumeLayout(false);
            this.MdnPnl.PerformLayout();
            this.popupmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpnl;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Panel floatingfooter;
        private System.Windows.Forms.Button flatclose;
        private System.Windows.Forms.Button flatsave;
        private System.Windows.Forms.Button flatload;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Button linedrawbtn;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pctmdf;
        private System.Windows.Forms.PictureBox pctrgnl;
        private System.Windows.Forms.SaveFileDialog svfldlg;
        private System.Windows.Forms.OpenFileDialog opnfldlg;
        private System.Windows.Forms.Button inversebtn;
        private System.Windows.Forms.Panel busypnl;
        private System.Windows.Forms.PictureBox busy;
        private System.Windows.Forms.Panel optnpnl1;
        private System.Windows.Forms.RadioButton bluerd;
        private System.Windows.Forms.RadioButton redrd;
        private System.Windows.Forms.RadioButton greenrd;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button grayscalebtn;
        private System.Windows.Forms.Button mynbtn;
        private System.Windows.Forms.Button Mdnbtn;
        private System.Windows.Forms.Panel MdnPnl;
        private System.Windows.Forms.ComboBox MdnEdgeScale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MdnInfoLbl;
        private System.Windows.Forms.ContextMenuStrip popupmenu;
        private System.Windows.Forms.ToolStripMenuItem mnopn;
        private System.Windows.Forms.ToolStripMenuItem mnsv;
        private System.Windows.Forms.ToolStripMenuItem mnexit;
    }
}

