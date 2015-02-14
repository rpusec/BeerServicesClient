namespace BeerServicesProj3
{
    partial class Form1
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswLoginField = new System.Windows.Forms.TextBox();
            this.UsernLoginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TokenPassw = new System.Windows.Forms.TextBox();
            this.GetTokenBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GetPriceBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.GetPriceField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SetPriceArg1Field = new System.Windows.Forms.TextBox();
            this.SetPriceBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.SetPriceArg0Field = new System.Windows.Forms.TextBox();
            this.GetCostliestBtn = new System.Windows.Forms.Button();
            this.GetCheapestBtn = new System.Windows.Forms.Button();
            this.GetBeersBtn = new System.Windows.Forms.Button();
            this.GetMethodsBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.ClientPanelTab = new System.Windows.Forms.TabPage();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PasswReinputField = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AgeChField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PasswChField = new System.Windows.Forms.TextBox();
            this.UsernChField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccessDispl = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.UsernDispl = new System.Windows.Forms.Label();
            this.AgeDispl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SignUpTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AgeRegField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswRegField = new System.Windows.Forms.TextBox();
            this.UsernRegField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AvailabilityLabel = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.ServiceTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ClientPanelTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SignUpTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.LoginTab);
            this.MainTab.Controls.Add(this.ServiceTab);
            this.MainTab.Controls.Add(this.ClientPanelTab);
            this.MainTab.Controls.Add(this.SignUpTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(596, 526);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.onMainTabChange);
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.label21);
            this.LoginTab.Controls.Add(this.label3);
            this.LoginTab.Controls.Add(this.LoginBtn);
            this.LoginTab.Controls.Add(this.PasswLoginField);
            this.LoginTab.Controls.Add(this.UsernLoginField);
            this.LoginTab.Controls.Add(this.label2);
            this.LoginTab.Controls.Add(this.label1);
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(588, 500);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(166, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(261, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Welcome to the Beer Service! Please login or sign up.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label3.Location = new System.Drawing.Point(170, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beer Service";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(263, 309);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswLoginField
            // 
            this.PasswLoginField.Location = new System.Drawing.Point(236, 268);
            this.PasswLoginField.Name = "PasswLoginField";
            this.PasswLoginField.PasswordChar = '*';
            this.PasswLoginField.Size = new System.Drawing.Size(163, 20);
            this.PasswLoginField.TabIndex = 3;
            // 
            // UsernLoginField
            // 
            this.UsernLoginField.Location = new System.Drawing.Point(236, 240);
            this.UsernLoginField.Name = "UsernLoginField";
            this.UsernLoginField.Size = new System.Drawing.Size(163, 20);
            this.UsernLoginField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // ServiceTab
            // 
            this.ServiceTab.Controls.Add(this.groupBox6);
            this.ServiceTab.Controls.Add(this.groupBox5);
            this.ServiceTab.Controls.Add(this.label20);
            this.ServiceTab.Controls.Add(this.groupBox4);
            this.ServiceTab.Controls.Add(this.groupBox3);
            this.ServiceTab.Controls.Add(this.GetCostliestBtn);
            this.ServiceTab.Controls.Add(this.GetCheapestBtn);
            this.ServiceTab.Controls.Add(this.GetBeersBtn);
            this.ServiceTab.Controls.Add(this.GetMethodsBtn);
            this.ServiceTab.Controls.Add(this.Output);
            this.ServiceTab.Location = new System.Drawing.Point(4, 22);
            this.ServiceTab.Name = "ServiceTab";
            this.ServiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTab.Size = new System.Drawing.Size(588, 500);
            this.ServiceTab.TabIndex = 1;
            this.ServiceTab.Text = "Service";
            this.ServiceTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.TokenPassw);
            this.groupBox5.Controls.Add(this.GetTokenBtn);
            this.groupBox5.Location = new System.Drawing.Point(6, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 42);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set Token";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Your password:";
            // 
            // TokenPassw
            // 
            this.TokenPassw.Location = new System.Drawing.Point(92, 16);
            this.TokenPassw.Name = "TokenPassw";
            this.TokenPassw.PasswordChar = '*';
            this.TokenPassw.Size = new System.Drawing.Size(141, 20);
            this.TokenPassw.TabIndex = 9;
            // 
            // GetTokenBtn
            // 
            this.GetTokenBtn.Location = new System.Drawing.Point(239, 13);
            this.GetTokenBtn.Name = "GetTokenBtn";
            this.GetTokenBtn.Size = new System.Drawing.Size(83, 23);
            this.GetTokenBtn.TabIndex = 1;
            this.GetTokenBtn.Text = "Set Token";
            this.GetTokenBtn.UseVisualStyleBackColor = true;
            this.GetTokenBtn.Click += new System.EventHandler(this.GetTokenBtn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label20.Location = new System.Drawing.Point(8, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 39);
            this.label20.TabIndex = 16;
            this.label20.Text = "Service";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GetPriceBtn);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.GetPriceField);
            this.groupBox4.Location = new System.Drawing.Point(6, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 54);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Get Price";
            // 
            // GetPriceBtn
            // 
            this.GetPriceBtn.Location = new System.Drawing.Point(202, 19);
            this.GetPriceBtn.Name = "GetPriceBtn";
            this.GetPriceBtn.Size = new System.Drawing.Size(83, 23);
            this.GetPriceBtn.TabIndex = 6;
            this.GetPriceBtn.Text = "Get Price";
            this.GetPriceBtn.UseVisualStyleBackColor = true;
            this.GetPriceBtn.Click += new System.EventHandler(this.GetPriceBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Beer:";
            // 
            // GetPriceField
            // 
            this.GetPriceField.Location = new System.Drawing.Point(46, 21);
            this.GetPriceField.Name = "GetPriceField";
            this.GetPriceField.Size = new System.Drawing.Size(150, 20);
            this.GetPriceField.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.SetPriceArg1Field);
            this.groupBox3.Controls.Add(this.SetPriceBtn);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.SetPriceArg0Field);
            this.groupBox3.Location = new System.Drawing.Point(6, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 54);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Beer:";
            // 
            // SetPriceArg1Field
            // 
            this.SetPriceArg1Field.Location = new System.Drawing.Point(245, 22);
            this.SetPriceArg1Field.Name = "SetPriceArg1Field";
            this.SetPriceArg1Field.Size = new System.Drawing.Size(150, 20);
            this.SetPriceArg1Field.TabIndex = 13;
            // 
            // SetPriceBtn
            // 
            this.SetPriceBtn.Location = new System.Drawing.Point(401, 19);
            this.SetPriceBtn.Name = "SetPriceBtn";
            this.SetPriceBtn.Size = new System.Drawing.Size(83, 23);
            this.SetPriceBtn.TabIndex = 9;
            this.SetPriceBtn.Text = "Set Price";
            this.SetPriceBtn.UseVisualStyleBackColor = true;
            this.SetPriceBtn.Click += new System.EventHandler(this.SetPriceBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(207, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Price:";
            // 
            // SetPriceArg0Field
            // 
            this.SetPriceArg0Field.Location = new System.Drawing.Point(44, 22);
            this.SetPriceArg0Field.Name = "SetPriceArg0Field";
            this.SetPriceArg0Field.Size = new System.Drawing.Size(152, 20);
            this.SetPriceArg0Field.TabIndex = 11;
            // 
            // GetCostliestBtn
            // 
            this.GetCostliestBtn.Location = new System.Drawing.Point(502, 197);
            this.GetCostliestBtn.Name = "GetCostliestBtn";
            this.GetCostliestBtn.Size = new System.Drawing.Size(83, 23);
            this.GetCostliestBtn.TabIndex = 5;
            this.GetCostliestBtn.Text = "Get Costliest";
            this.GetCostliestBtn.UseVisualStyleBackColor = true;
            this.GetCostliestBtn.Click += new System.EventHandler(this.GetCostliestBtn_Click);
            // 
            // GetCheapestBtn
            // 
            this.GetCheapestBtn.Location = new System.Drawing.Point(502, 168);
            this.GetCheapestBtn.Name = "GetCheapestBtn";
            this.GetCheapestBtn.Size = new System.Drawing.Size(83, 23);
            this.GetCheapestBtn.TabIndex = 4;
            this.GetCheapestBtn.Text = "Get Cheapest";
            this.GetCheapestBtn.UseVisualStyleBackColor = true;
            this.GetCheapestBtn.Click += new System.EventHandler(this.GetCheapestBtn_Click);
            // 
            // GetBeersBtn
            // 
            this.GetBeersBtn.Location = new System.Drawing.Point(502, 139);
            this.GetBeersBtn.Name = "GetBeersBtn";
            this.GetBeersBtn.Size = new System.Drawing.Size(83, 23);
            this.GetBeersBtn.TabIndex = 3;
            this.GetBeersBtn.Text = "Get Beers";
            this.GetBeersBtn.UseVisualStyleBackColor = true;
            this.GetBeersBtn.Click += new System.EventHandler(this.GetBeersBtn_Click);
            // 
            // GetMethodsBtn
            // 
            this.GetMethodsBtn.Location = new System.Drawing.Point(502, 110);
            this.GetMethodsBtn.Name = "GetMethodsBtn";
            this.GetMethodsBtn.Size = new System.Drawing.Size(83, 23);
            this.GetMethodsBtn.TabIndex = 2;
            this.GetMethodsBtn.Text = "Get Methods";
            this.GetMethodsBtn.UseVisualStyleBackColor = true;
            this.GetMethodsBtn.Click += new System.EventHandler(this.GetMethodsBtn_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(6, 110);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(490, 259);
            this.Output.TabIndex = 0;
            // 
            // ClientPanelTab
            // 
            this.ClientPanelTab.Controls.Add(this.LogoutBtn);
            this.ClientPanelTab.Controls.Add(this.label16);
            this.ClientPanelTab.Controls.Add(this.groupBox2);
            this.ClientPanelTab.Controls.Add(this.groupBox1);
            this.ClientPanelTab.Location = new System.Drawing.Point(4, 22);
            this.ClientPanelTab.Name = "ClientPanelTab";
            this.ClientPanelTab.Size = new System.Drawing.Size(588, 500);
            this.ClientPanelTab.TabIndex = 2;
            this.ClientPanelTab.Text = "Client Panel";
            this.ClientPanelTab.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(510, 3);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label16.Location = new System.Drawing.Point(20, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 31);
            this.label16.TabIndex = 2;
            this.label16.Text = "Client Control Panel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.PasswReinputField);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.AgeChField);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.PasswChField);
            this.groupBox2.Controls.Add(this.UsernChField);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(3, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Info";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(118, 129);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PasswReinputField
            // 
            this.PasswReinputField.Location = new System.Drawing.Point(118, 103);
            this.PasswReinputField.Name = "PasswReinputField";
            this.PasswReinputField.PasswordChar = '*';
            this.PasswReinputField.Size = new System.Drawing.Size(163, 20);
            this.PasswReinputField.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Current Password";
            // 
            // AgeChField
            // 
            this.AgeChField.Location = new System.Drawing.Point(118, 77);
            this.AgeChField.Name = "AgeChField";
            this.AgeChField.Size = new System.Drawing.Size(163, 20);
            this.AgeChField.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Age";
            // 
            // PasswChField
            // 
            this.PasswChField.Location = new System.Drawing.Point(118, 50);
            this.PasswChField.Name = "PasswChField";
            this.PasswChField.PasswordChar = '*';
            this.PasswChField.Size = new System.Drawing.Size(163, 20);
            this.PasswChField.TabIndex = 13;
            // 
            // UsernChField
            // 
            this.UsernChField.Location = new System.Drawing.Point(118, 22);
            this.UsernChField.Name = "UsernChField";
            this.UsernChField.Size = new System.Drawing.Size(163, 20);
            this.UsernChField.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AccessDispl);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.UsernDispl);
            this.groupBox1.Controls.Add(this.AgeDispl);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // AccessDispl
            // 
            this.AccessDispl.AutoSize = true;
            this.AccessDispl.Location = new System.Drawing.Point(97, 94);
            this.AccessDispl.Name = "AccessDispl";
            this.AccessDispl.Size = new System.Drawing.Size(53, 13);
            this.AccessDispl.TabIndex = 19;
            this.AccessDispl.Text = "<access>";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Access Level";
            // 
            // UsernDispl
            // 
            this.UsernDispl.AutoSize = true;
            this.UsernDispl.Location = new System.Drawing.Point(97, 27);
            this.UsernDispl.Name = "UsernDispl";
            this.UsernDispl.Size = new System.Drawing.Size(65, 13);
            this.UsernDispl.TabIndex = 15;
            this.UsernDispl.Text = "<username>";
            // 
            // AgeDispl
            // 
            this.AgeDispl.AutoSize = true;
            this.AgeDispl.Location = new System.Drawing.Point(97, 71);
            this.AgeDispl.Name = "AgeDispl";
            this.AgeDispl.Size = new System.Drawing.Size(37, 13);
            this.AgeDispl.TabIndex = 17;
            this.AgeDispl.Text = "<age>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(97, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "************";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Password";
            // 
            // SignUpTab
            // 
            this.SignUpTab.Controls.Add(this.label22);
            this.SignUpTab.Controls.Add(this.SignupBtn);
            this.SignUpTab.Controls.Add(this.label7);
            this.SignUpTab.Controls.Add(this.AgeRegField);
            this.SignUpTab.Controls.Add(this.label6);
            this.SignUpTab.Controls.Add(this.PasswRegField);
            this.SignUpTab.Controls.Add(this.UsernRegField);
            this.SignUpTab.Controls.Add(this.label4);
            this.SignUpTab.Controls.Add(this.label5);
            this.SignUpTab.Location = new System.Drawing.Point(4, 22);
            this.SignUpTab.Name = "SignUpTab";
            this.SignUpTab.Size = new System.Drawing.Size(588, 500);
            this.SignUpTab.TabIndex = 3;
            this.SignUpTab.Text = "Sign up";
            this.SignUpTab.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(149, 190);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(308, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Please choose your username, password and age (21 or above)";
            // 
            // SignupBtn
            // 
            this.SignupBtn.Location = new System.Drawing.Point(262, 314);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(75, 23);
            this.SignupBtn.TabIndex = 11;
            this.SignupBtn.Text = "Sign up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label7.Location = new System.Drawing.Point(219, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 47);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sign up";
            // 
            // AgeRegField
            // 
            this.AgeRegField.Location = new System.Drawing.Point(245, 276);
            this.AgeRegField.Name = "AgeRegField";
            this.AgeRegField.Size = new System.Drawing.Size(163, 20);
            this.AgeRegField.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age";
            // 
            // PasswRegField
            // 
            this.PasswRegField.Location = new System.Drawing.Point(245, 249);
            this.PasswRegField.Name = "PasswRegField";
            this.PasswRegField.PasswordChar = '*';
            this.PasswRegField.Size = new System.Drawing.Size(163, 20);
            this.PasswRegField.TabIndex = 7;
            // 
            // UsernRegField
            // 
            this.UsernRegField.Location = new System.Drawing.Point(245, 221);
            this.UsernRegField.Name = "UsernRegField";
            this.UsernRegField.Size = new System.Drawing.Size(163, 20);
            this.UsernRegField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AvailabilityLabel);
            this.groupBox6.Location = new System.Drawing.Point(340, 62);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 42);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Availability";
            // 
            // AvailabilityLabel
            // 
            this.AvailabilityLabel.AutoSize = true;
            this.AvailabilityLabel.Location = new System.Drawing.Point(7, 20);
            this.AvailabilityLabel.Name = "AvailabilityLabel";
            this.AvailabilityLabel.Size = new System.Drawing.Size(67, 13);
            this.AvailabilityLabel.TabIndex = 0;
            this.AvailabilityLabel.Text = "<availability>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 550);
            this.Controls.Add(this.MainTab);
            this.Name = "Form1";
            this.Text = "BeerService Client";
            this.MainTab.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.ServiceTab.ResumeLayout(false);
            this.ServiceTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ClientPanelTab.ResumeLayout(false);
            this.ClientPanelTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SignUpTab.ResumeLayout(false);
            this.SignUpTab.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.TabPage ServiceTab;
        private System.Windows.Forms.TabPage ClientPanelTab;
        private System.Windows.Forms.TabPage SignUpTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswLoginField;
        private System.Windows.Forms.TextBox UsernLoginField;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswRegField;
        private System.Windows.Forms.TextBox UsernRegField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AgeRegField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UsernDispl;
        private System.Windows.Forms.Label AgeDispl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AgeChField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PasswChField;
        private System.Windows.Forms.TextBox UsernChField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PasswReinputField;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button GetTokenBtn;
        private System.Windows.Forms.Button GetCheapestBtn;
        private System.Windows.Forms.Button GetBeersBtn;
        private System.Windows.Forms.Button GetMethodsBtn;
        private System.Windows.Forms.Button GetPriceBtn;
        private System.Windows.Forms.Button GetCostliestBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox GetPriceField;
        private System.Windows.Forms.TextBox SetPriceArg0Field;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button SetPriceBtn;
        private System.Windows.Forms.TextBox SetPriceArg1Field;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label AccessDispl;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TokenPassw;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label AvailabilityLabel;
    }
}

