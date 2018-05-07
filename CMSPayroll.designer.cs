namespace WindowsFormsApplication1
{
    partial class FormPayRoll
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Client", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Contract", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Employee", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PayRoll", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Search");
            this.label1 = new System.Windows.Forms.Label();
            this.LblEmpName = new System.Windows.Forms.Label();
            this.LblCleintName = new System.Windows.Forms.Label();
            this.LblProject = new System.Windows.Forms.Label();
            this.LblContract = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.comboContract = new System.Windows.Forms.ComboBox();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.LblMonday = new System.Windows.Forms.Label();
            this.LblSunday = new System.Windows.Forms.Label();
            this.LblSaturday = new System.Windows.Forms.Label();
            this.LblFriday = new System.Windows.Forms.Label();
            this.LblThursday = new System.Windows.Forms.Label();
            this.LblWednesday = new System.Windows.Forms.Label();
            this.LblTuesday = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblWeekends = new System.Windows.Forms.Label();
            this.LblHrsWorked = new System.Windows.Forms.Label();
            this.LblDaysofWeek = new System.Windows.Forms.Label();
            this.BtnSumbit = new System.Windows.Forms.Button();
            this.NumUpDownMonday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownSunday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownSaturday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownFriday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownThursday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownWednesday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownTuesday = new System.Windows.Forms.NumericUpDown();
            this.GrpBoxResults = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOffDays = new System.Windows.Forms.TextBox();
            this.LblOffDays = new System.Windows.Forms.Label();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.TxtTotalHours = new System.Windows.Forms.TextBox();
            this.TxtOTPay = new System.Windows.Forms.TextBox();
            this.TxtOTRate = new System.Windows.Forms.TextBox();
            this.TxtOTHours = new System.Windows.Forms.TextBox();
            this.TxtRegPay = new System.Windows.Forms.TextBox();
            this.TxtRegRate = new System.Windows.Forms.TextBox();
            this.TxtRegHours = new System.Windows.Forms.TextBox();
            this.LblGrossPay = new System.Windows.Forms.Label();
            this.LblTotalHours = new System.Windows.Forms.Label();
            this.LblOTHourlyPay = new System.Windows.Forms.Label();
            this.LblOTHoursWorked = new System.Windows.Forms.Label();
            this.LblOTRate = new System.Windows.Forms.Label();
            this.LblRegHourlyPay = new System.Windows.Forms.Label();
            this.LblRegHours = new System.Windows.Forms.Label();
            this.LblRegRate = new System.Windows.Forms.Label();
            this.GrpBoxTimeSheet = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CbTues = new System.Windows.Forms.CheckBox();
            this.CbWed = new System.Windows.Forms.CheckBox();
            this.CbThurs = new System.Windows.Forms.CheckBox();
            this.CbFri = new System.Windows.Forms.CheckBox();
            this.CbSat = new System.Windows.Forms.CheckBox();
            this.CbSun = new System.Windows.Forms.CheckBox();
            this.CbMon = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.LblWeeksWorked = new System.Windows.Forms.Label();
            this.NumUpDownWeeksWorked = new System.Windows.Forms.NumericUpDown();
            this.TxtSuppName = new System.Windows.Forms.TextBox();
            this.LblSuppName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiwHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCMSSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSunday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSaturday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTuesday)).BeginInit();
            this.GrpBoxResults.SuspendLayout();
            this.GrpBoxTimeSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWeeksWorked)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Payroll";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblEmpName
            // 
            this.LblEmpName.AutoSize = true;
            this.LblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpName.Location = new System.Drawing.Point(157, 116);
            this.LblEmpName.Name = "LblEmpName";
            this.LblEmpName.Size = new System.Drawing.Size(181, 26);
            this.LblEmpName.TabIndex = 1;
            this.LblEmpName.Text = "Employee Name:";
            this.LblEmpName.Click += new System.EventHandler(this.LblEmpName_Click);
            // 
            // LblCleintName
            // 
            this.LblCleintName.AutoSize = true;
            this.LblCleintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCleintName.Location = new System.Drawing.Point(157, 158);
            this.LblCleintName.Name = "LblCleintName";
            this.LblCleintName.Size = new System.Drawing.Size(139, 26);
            this.LblCleintName.TabIndex = 2;
            this.LblCleintName.Text = "Client Name:";
            this.LblCleintName.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProject.Location = new System.Drawing.Point(737, 157);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(86, 26);
            this.LblProject.TabIndex = 4;
            this.LblProject.Text = "Project:";
            // 
            // LblContract
            // 
            this.LblContract.AutoSize = true;
            this.LblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContract.Location = new System.Drawing.Point(449, 157);
            this.LblContract.Name = "LblContract";
            this.LblContract.Size = new System.Drawing.Size(100, 26);
            this.LblContract.TabIndex = 3;
            this.LblContract.Text = "Contract:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(337, 122);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(101, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(337, 164);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(101, 20);
            this.txtClientName.TabIndex = 6;
            // 
            // comboContract
            // 
            this.comboContract.FormattingEnabled = true;
            this.comboContract.Items.AddRange(new object[] {
            "Time and Materials",
            "fixed price"});
            this.comboContract.Location = new System.Drawing.Point(630, 163);
            this.comboContract.Name = "comboContract";
            this.comboContract.Size = new System.Drawing.Size(101, 21);
            this.comboContract.TabIndex = 9;
            // 
            // comboProject
            // 
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Items.AddRange(new object[] {
            "BT",
            "Bharti IBM"});
            this.comboProject.Location = new System.Drawing.Point(909, 164);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(101, 21);
            this.comboProject.TabIndex = 10;
            // 
            // LblMonday
            // 
            this.LblMonday.AutoSize = true;
            this.LblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonday.Location = new System.Drawing.Point(209, 13);
            this.LblMonday.Name = "LblMonday";
            this.LblMonday.Size = new System.Drawing.Size(89, 26);
            this.LblMonday.TabIndex = 11;
            this.LblMonday.Text = "Monday";
            // 
            // LblSunday
            // 
            this.LblSunday.AutoSize = true;
            this.LblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSunday.Location = new System.Drawing.Point(827, 13);
            this.LblSunday.Name = "LblSunday";
            this.LblSunday.Size = new System.Drawing.Size(86, 26);
            this.LblSunday.TabIndex = 13;
            this.LblSunday.Text = "Sunday";
            // 
            // LblSaturday
            // 
            this.LblSaturday.AutoSize = true;
            this.LblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaturday.Location = new System.Drawing.Point(722, 13);
            this.LblSaturday.Name = "LblSaturday";
            this.LblSaturday.Size = new System.Drawing.Size(99, 26);
            this.LblSaturday.TabIndex = 14;
            this.LblSaturday.Text = "Saturday";
            // 
            // LblFriday
            // 
            this.LblFriday.AutoSize = true;
            this.LblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFriday.Location = new System.Drawing.Point(644, 13);
            this.LblFriday.Name = "LblFriday";
            this.LblFriday.Size = new System.Drawing.Size(72, 26);
            this.LblFriday.TabIndex = 15;
            this.LblFriday.Text = "Friday";
            // 
            // LblThursday
            // 
            this.LblThursday.AutoSize = true;
            this.LblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThursday.Location = new System.Drawing.Point(537, 13);
            this.LblThursday.Name = "LblThursday";
            this.LblThursday.Size = new System.Drawing.Size(101, 26);
            this.LblThursday.TabIndex = 16;
            this.LblThursday.Text = "Thursday";
            // 
            // LblWednesday
            // 
            this.LblWednesday.AutoSize = true;
            this.LblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWednesday.Location = new System.Drawing.Point(404, 13);
            this.LblWednesday.Name = "LblWednesday";
            this.LblWednesday.Size = new System.Drawing.Size(127, 26);
            this.LblWednesday.TabIndex = 17;
            this.LblWednesday.Text = "Wednesday";
            // 
            // LblTuesday
            // 
            this.LblTuesday.AutoSize = true;
            this.LblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuesday.Location = new System.Drawing.Point(304, 13);
            this.LblTuesday.Name = "LblTuesday";
            this.LblTuesday.Size = new System.Drawing.Size(94, 26);
            this.LblTuesday.TabIndex = 18;
            this.LblTuesday.Text = "Tuesday";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(919, 13);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(59, 26);
            this.LblTotal.TabIndex = 19;
            this.LblTotal.Text = "Total";
            // 
            // LblWeekends
            // 
            this.LblWeekends.AutoSize = true;
            this.LblWeekends.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeekends.Location = new System.Drawing.Point(6, 67);
            this.LblWeekends.Name = "LblWeekends";
            this.LblWeekends.Size = new System.Drawing.Size(159, 26);
            this.LblWeekends.TabIndex = 37;
            this.LblWeekends.Text = "Vacation Days:";
            // 
            // LblHrsWorked
            // 
            this.LblHrsWorked.AutoSize = true;
            this.LblHrsWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHrsWorked.Location = new System.Drawing.Point(6, 38);
            this.LblHrsWorked.Name = "LblHrsWorked";
            this.LblHrsWorked.Size = new System.Drawing.Size(157, 26);
            this.LblHrsWorked.TabIndex = 38;
            this.LblHrsWorked.Text = "Hours Worked:";
            // 
            // LblDaysofWeek
            // 
            this.LblDaysofWeek.AutoSize = true;
            this.LblDaysofWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDaysofWeek.Location = new System.Drawing.Point(6, 13);
            this.LblDaysofWeek.Name = "LblDaysofWeek";
            this.LblDaysofWeek.Size = new System.Drawing.Size(190, 26);
            this.LblDaysofWeek.TabIndex = 39;
            this.LblDaysofWeek.Text = "Days of the Week:";
            // 
            // BtnSumbit
            // 
            this.BtnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumbit.Location = new System.Drawing.Point(466, 356);
            this.BtnSumbit.Name = "BtnSumbit";
            this.BtnSumbit.Size = new System.Drawing.Size(276, 36);
            this.BtnSumbit.TabIndex = 41;
            this.BtnSumbit.Text = "Sumbit Hours";
            this.BtnSumbit.UseVisualStyleBackColor = true;
            this.BtnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // NumUpDownMonday
            // 
            this.NumUpDownMonday.Location = new System.Drawing.Point(214, 46);
            this.NumUpDownMonday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownMonday.Name = "NumUpDownMonday";
            this.NumUpDownMonday.Size = new System.Drawing.Size(84, 20);
            this.NumUpDownMonday.TabIndex = 42;
            // 
            // NumUpDownSunday
            // 
            this.NumUpDownSunday.Location = new System.Drawing.Point(832, 45);
            this.NumUpDownSunday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownSunday.Name = "NumUpDownSunday";
            this.NumUpDownSunday.Size = new System.Drawing.Size(81, 20);
            this.NumUpDownSunday.TabIndex = 44;
            // 
            // NumUpDownSaturday
            // 
            this.NumUpDownSaturday.Location = new System.Drawing.Point(727, 45);
            this.NumUpDownSaturday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownSaturday.Name = "NumUpDownSaturday";
            this.NumUpDownSaturday.Size = new System.Drawing.Size(94, 20);
            this.NumUpDownSaturday.TabIndex = 45;
            // 
            // NumUpDownFriday
            // 
            this.NumUpDownFriday.Location = new System.Drawing.Point(649, 45);
            this.NumUpDownFriday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownFriday.Name = "NumUpDownFriday";
            this.NumUpDownFriday.Size = new System.Drawing.Size(67, 20);
            this.NumUpDownFriday.TabIndex = 46;
            // 
            // NumUpDownThursday
            // 
            this.NumUpDownThursday.Location = new System.Drawing.Point(537, 42);
            this.NumUpDownThursday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownThursday.Name = "NumUpDownThursday";
            this.NumUpDownThursday.Size = new System.Drawing.Size(101, 20);
            this.NumUpDownThursday.TabIndex = 47;
            // 
            // NumUpDownWednesday
            // 
            this.NumUpDownWednesday.Location = new System.Drawing.Point(409, 45);
            this.NumUpDownWednesday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownWednesday.Name = "NumUpDownWednesday";
            this.NumUpDownWednesday.Size = new System.Drawing.Size(122, 20);
            this.NumUpDownWednesday.TabIndex = 48;
            // 
            // NumUpDownTuesday
            // 
            this.NumUpDownTuesday.Location = new System.Drawing.Point(309, 46);
            this.NumUpDownTuesday.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownTuesday.Name = "NumUpDownTuesday";
            this.NumUpDownTuesday.Size = new System.Drawing.Size(89, 20);
            this.NumUpDownTuesday.TabIndex = 49;
            // 
            // GrpBoxResults
            // 
            this.GrpBoxResults.Controls.Add(this.textBox3);
            this.GrpBoxResults.Controls.Add(this.textBox1);
            this.GrpBoxResults.Controls.Add(this.label2);
            this.GrpBoxResults.Controls.Add(this.label5);
            this.GrpBoxResults.Controls.Add(this.textBox4);
            this.GrpBoxResults.Controls.Add(this.TxtOffDays);
            this.GrpBoxResults.Controls.Add(this.LblOffDays);
            this.GrpBoxResults.Controls.Add(this.label6);
            this.GrpBoxResults.Controls.Add(this.TxtGrossPay);
            this.GrpBoxResults.Controls.Add(this.TxtTotalHours);
            this.GrpBoxResults.Controls.Add(this.TxtOTPay);
            this.GrpBoxResults.Controls.Add(this.TxtOTRate);
            this.GrpBoxResults.Controls.Add(this.TxtOTHours);
            this.GrpBoxResults.Controls.Add(this.TxtRegPay);
            this.GrpBoxResults.Controls.Add(this.TxtRegRate);
            this.GrpBoxResults.Controls.Add(this.TxtRegHours);
            this.GrpBoxResults.Controls.Add(this.LblGrossPay);
            this.GrpBoxResults.Controls.Add(this.LblTotalHours);
            this.GrpBoxResults.Controls.Add(this.LblOTHourlyPay);
            this.GrpBoxResults.Controls.Add(this.LblOTHoursWorked);
            this.GrpBoxResults.Controls.Add(this.LblOTRate);
            this.GrpBoxResults.Controls.Add(this.LblRegHourlyPay);
            this.GrpBoxResults.Controls.Add(this.LblRegHours);
            this.GrpBoxResults.Controls.Add(this.LblRegRate);
            this.GrpBoxResults.Location = new System.Drawing.Point(233, 416);
            this.GrpBoxResults.Name = "GrpBoxResults";
            this.GrpBoxResults.Size = new System.Drawing.Size(676, 209);
            this.GrpBoxResults.TabIndex = 50;
            this.GrpBoxResults.TabStop = false;
            this.GrpBoxResults.Text = "Pay Roll Results";
            this.GrpBoxResults.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Number of Vacation days allowed:";
            // 
            // TxtOffDays
            // 
            this.TxtOffDays.Location = new System.Drawing.Point(586, 139);
            this.TxtOffDays.Name = "TxtOffDays";
            this.TxtOffDays.Size = new System.Drawing.Size(64, 20);
            this.TxtOffDays.TabIndex = 57;
            // 
            // LblOffDays
            // 
            this.LblOffDays.AutoSize = true;
            this.LblOffDays.Location = new System.Drawing.Point(378, 146);
            this.LblOffDays.Name = "LblOffDays";
            this.LblOffDays.Size = new System.Drawing.Size(168, 13);
            this.LblOffDays.TabIndex = 56;
            this.LblOffDays.Text = "Number of Vacation days claimed:";
            this.LblOffDays.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(586, 103);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.Size = new System.Drawing.Size(64, 20);
            this.TxtGrossPay.TabIndex = 15;
            // 
            // TxtTotalHours
            // 
            this.TxtTotalHours.Location = new System.Drawing.Point(586, 36);
            this.TxtTotalHours.Name = "TxtTotalHours";
            this.TxtTotalHours.Size = new System.Drawing.Size(64, 20);
            this.TxtTotalHours.TabIndex = 14;
            // 
            // TxtOTPay
            // 
            this.TxtOTPay.Location = new System.Drawing.Point(404, 103);
            this.TxtOTPay.Name = "TxtOTPay";
            this.TxtOTPay.Size = new System.Drawing.Size(64, 20);
            this.TxtOTPay.TabIndex = 13;
            // 
            // TxtOTRate
            // 
            this.TxtOTRate.Location = new System.Drawing.Point(404, 61);
            this.TxtOTRate.Name = "TxtOTRate";
            this.TxtOTRate.Size = new System.Drawing.Size(64, 20);
            this.TxtOTRate.TabIndex = 12;
            // 
            // TxtOTHours
            // 
            this.TxtOTHours.Location = new System.Drawing.Point(404, 33);
            this.TxtOTHours.Name = "TxtOTHours";
            this.TxtOTHours.Size = new System.Drawing.Size(64, 20);
            this.TxtOTHours.TabIndex = 11;
            // 
            // TxtRegPay
            // 
            this.TxtRegPay.Location = new System.Drawing.Point(189, 110);
            this.TxtRegPay.Name = "TxtRegPay";
            this.TxtRegPay.Size = new System.Drawing.Size(64, 20);
            this.TxtRegPay.TabIndex = 10;
            // 
            // TxtRegRate
            // 
            this.TxtRegRate.Location = new System.Drawing.Point(189, 64);
            this.TxtRegRate.Name = "TxtRegRate";
            this.TxtRegRate.Size = new System.Drawing.Size(64, 20);
            this.TxtRegRate.TabIndex = 9;
            // 
            // TxtRegHours
            // 
            this.TxtRegHours.Location = new System.Drawing.Point(189, 33);
            this.TxtRegHours.Name = "TxtRegHours";
            this.TxtRegHours.Size = new System.Drawing.Size(64, 20);
            this.TxtRegHours.TabIndex = 8;
            // 
            // LblGrossPay
            // 
            this.LblGrossPay.AutoSize = true;
            this.LblGrossPay.Location = new System.Drawing.Point(478, 110);
            this.LblGrossPay.Name = "LblGrossPay";
            this.LblGrossPay.Size = new System.Drawing.Size(58, 13);
            this.LblGrossPay.TabIndex = 7;
            this.LblGrossPay.Text = "Gross Pay:";
            // 
            // LblTotalHours
            // 
            this.LblTotalHours.AutoSize = true;
            this.LblTotalHours.Location = new System.Drawing.Point(474, 36);
            this.LblTotalHours.Name = "LblTotalHours";
            this.LblTotalHours.Size = new System.Drawing.Size(106, 13);
            this.LblTotalHours.TabIndex = 6;
            this.LblTotalHours.Text = "Total Hours Worked:";
            // 
            // LblOTHourlyPay
            // 
            this.LblOTHourlyPay.AutoSize = true;
            this.LblOTHourlyPay.Location = new System.Drawing.Point(259, 110);
            this.LblOTHourlyPay.Name = "LblOTHourlyPay";
            this.LblOTHourlyPay.Size = new System.Drawing.Size(110, 13);
            this.LblOTHourlyPay.TabIndex = 5;
            this.LblOTHourlyPay.Text = "OverTime Hourly Pay:";
            // 
            // LblOTHoursWorked
            // 
            this.LblOTHoursWorked.AutoSize = true;
            this.LblOTHoursWorked.Location = new System.Drawing.Point(259, 36);
            this.LblOTHoursWorked.Name = "LblOTHoursWorked";
            this.LblOTHoursWorked.Size = new System.Drawing.Size(128, 13);
            this.LblOTHoursWorked.TabIndex = 4;
            this.LblOTHoursWorked.Text = "OverTime Hours Worked:";
            // 
            // LblOTRate
            // 
            this.LblOTRate.AutoSize = true;
            this.LblOTRate.Location = new System.Drawing.Point(259, 64);
            this.LblOTRate.Name = "LblOTRate";
            this.LblOTRate.Size = new System.Drawing.Size(108, 13);
            this.LblOTRate.TabIndex = 3;
            this.LblOTRate.Text = "OverTime Hour Rate:";
            // 
            // LblRegHourlyPay
            // 
            this.LblRegHourlyPay.AutoSize = true;
            this.LblRegHourlyPay.Location = new System.Drawing.Point(6, 110);
            this.LblRegHourlyPay.Name = "LblRegHourlyPay";
            this.LblRegHourlyPay.Size = new System.Drawing.Size(101, 13);
            this.LblRegHourlyPay.TabIndex = 2;
            this.LblRegHourlyPay.Text = "Regular Hourly Pay:";
            // 
            // LblRegHours
            // 
            this.LblRegHours.AutoSize = true;
            this.LblRegHours.Location = new System.Drawing.Point(6, 36);
            this.LblRegHours.Name = "LblRegHours";
            this.LblRegHours.Size = new System.Drawing.Size(119, 13);
            this.LblRegHours.TabIndex = 1;
            this.LblRegHours.Text = "Regular Hours Worked:";
            // 
            // LblRegRate
            // 
            this.LblRegRate.AutoSize = true;
            this.LblRegRate.Location = new System.Drawing.Point(6, 64);
            this.LblRegRate.Name = "LblRegRate";
            this.LblRegRate.Size = new System.Drawing.Size(99, 13);
            this.LblRegRate.TabIndex = 0;
            this.LblRegRate.Text = "Regular Hour Rate:";
            // 
            // GrpBoxTimeSheet
            // 
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox1);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox2);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox3);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox4);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox5);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox6);
            this.GrpBoxTimeSheet.Controls.Add(this.checkBox8);
            this.GrpBoxTimeSheet.Controls.Add(this.label4);
            this.GrpBoxTimeSheet.Controls.Add(this.textBox2);
            this.GrpBoxTimeSheet.Controls.Add(this.CbTues);
            this.GrpBoxTimeSheet.Controls.Add(this.CbWed);
            this.GrpBoxTimeSheet.Controls.Add(this.CbThurs);
            this.GrpBoxTimeSheet.Controls.Add(this.CbFri);
            this.GrpBoxTimeSheet.Controls.Add(this.CbSat);
            this.GrpBoxTimeSheet.Controls.Add(this.CbSun);
            this.GrpBoxTimeSheet.Controls.Add(this.CbMon);
            this.GrpBoxTimeSheet.Controls.Add(this.LblDaysofWeek);
            this.GrpBoxTimeSheet.Controls.Add(this.LblHrsWorked);
            this.GrpBoxTimeSheet.Controls.Add(this.LblWeekends);
            this.GrpBoxTimeSheet.Controls.Add(this.LblMonday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblSunday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownTuesday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblSaturday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownWednesday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblFriday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownThursday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblThursday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownFriday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblWednesday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownSaturday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblTuesday);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownSunday);
            this.GrpBoxTimeSheet.Controls.Add(this.LblTotal);
            this.GrpBoxTimeSheet.Controls.Add(this.NumUpDownMonday);
            this.GrpBoxTimeSheet.Location = new System.Drawing.Point(162, 215);
            this.GrpBoxTimeSheet.Name = "GrpBoxTimeSheet";
            this.GrpBoxTimeSheet.Size = new System.Drawing.Size(1049, 124);
            this.GrpBoxTimeSheet.TabIndex = 2;
            this.GrpBoxTimeSheet.TabStop = false;
            this.GrpBoxTimeSheet.Text = "Time Sheet";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(924, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 69;
            // 
            // CbTues
            // 
            this.CbTues.AutoSize = true;
            this.CbTues.Location = new System.Drawing.Point(309, 77);
            this.CbTues.Name = "CbTues";
            this.CbTues.Size = new System.Drawing.Size(67, 17);
            this.CbTues.TabIndex = 70;
            this.CbTues.Text = "Tuesday";
            this.CbTues.UseVisualStyleBackColor = true;
            // 
            // CbWed
            // 
            this.CbWed.AutoSize = true;
            this.CbWed.Location = new System.Drawing.Point(411, 77);
            this.CbWed.Name = "CbWed";
            this.CbWed.Size = new System.Drawing.Size(83, 17);
            this.CbWed.TabIndex = 69;
            this.CbWed.Text = "Wednesday";
            this.CbWed.UseVisualStyleBackColor = true;
            // 
            // CbThurs
            // 
            this.CbThurs.AutoSize = true;
            this.CbThurs.Location = new System.Drawing.Point(537, 77);
            this.CbThurs.Name = "CbThurs";
            this.CbThurs.Size = new System.Drawing.Size(70, 17);
            this.CbThurs.TabIndex = 68;
            this.CbThurs.Text = "Thursday";
            this.CbThurs.UseVisualStyleBackColor = true;
            // 
            // CbFri
            // 
            this.CbFri.AutoSize = true;
            this.CbFri.Location = new System.Drawing.Point(649, 77);
            this.CbFri.Name = "CbFri";
            this.CbFri.Size = new System.Drawing.Size(54, 17);
            this.CbFri.TabIndex = 67;
            this.CbFri.Text = "Friday";
            this.CbFri.UseVisualStyleBackColor = true;
            // 
            // CbSat
            // 
            this.CbSat.AutoSize = true;
            this.CbSat.Location = new System.Drawing.Point(727, 77);
            this.CbSat.Name = "CbSat";
            this.CbSat.Size = new System.Drawing.Size(68, 17);
            this.CbSat.TabIndex = 66;
            this.CbSat.Text = "Saturday";
            this.CbSat.UseVisualStyleBackColor = true;
            // 
            // CbSun
            // 
            this.CbSun.AutoSize = true;
            this.CbSun.Location = new System.Drawing.Point(832, 77);
            this.CbSun.Name = "CbSun";
            this.CbSun.Size = new System.Drawing.Size(62, 17);
            this.CbSun.TabIndex = 65;
            this.CbSun.Text = "Sunday";
            this.CbSun.UseVisualStyleBackColor = true;
            // 
            // CbMon
            // 
            this.CbMon.AutoSize = true;
            this.CbMon.Location = new System.Drawing.Point(214, 76);
            this.CbMon.Name = "CbMon";
            this.CbMon.Size = new System.Drawing.Size(64, 17);
            this.CbMon.TabIndex = 64;
            this.CbMon.Text = "Monday";
            this.CbMon.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(-84, 392);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 61;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // LblWeeksWorked
            // 
            this.LblWeeksWorked.AutoSize = true;
            this.LblWeeksWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeksWorked.Location = new System.Drawing.Point(737, 117);
            this.LblWeeksWorked.Name = "LblWeeksWorked";
            this.LblWeeksWorked.Size = new System.Drawing.Size(166, 26);
            this.LblWeeksWorked.TabIndex = 51;
            this.LblWeeksWorked.Text = "Weeks Worked:";
            // 
            // NumUpDownWeeksWorked
            // 
            this.NumUpDownWeeksWorked.Location = new System.Drawing.Point(909, 123);
            this.NumUpDownWeeksWorked.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpDownWeeksWorked.Name = "NumUpDownWeeksWorked";
            this.NumUpDownWeeksWorked.Size = new System.Drawing.Size(101, 20);
            this.NumUpDownWeeksWorked.TabIndex = 52;
            // 
            // TxtSuppName
            // 
            this.TxtSuppName.Location = new System.Drawing.Point(630, 122);
            this.TxtSuppName.Name = "TxtSuppName";
            this.TxtSuppName.Size = new System.Drawing.Size(101, 20);
            this.TxtSuppName.TabIndex = 54;
            // 
            // LblSuppName
            // 
            this.LblSuppName.AutoSize = true;
            this.LblSuppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSuppName.Location = new System.Drawing.Point(444, 116);
            this.LblSuppName.Name = "LblSuppName";
            this.LblSuppName.Size = new System.Drawing.Size(187, 26);
            this.LblSuppName.TabIndex = 53;
            this.LblSuppName.Text = "Supervisor Name:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 36);
            this.button2.TabIndex = 64;
            this.button2.Text = "Add New Week";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 36);
            this.button1.TabIndex = 65;
            this.button1.Text = "Add New Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.contractToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.contractToolStripMenuItem.Text = "Contract";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFileToolStripMenuItem,
            this.fromFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // recentFileToolStripMenuItem
            // 
            this.recentFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectBTToolStripMenuItem});
            this.recentFileToolStripMenuItem.Name = "recentFileToolStripMenuItem";
            this.recentFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.recentFileToolStripMenuItem.Text = "Recent File";
            // 
            // projectBTToolStripMenuItem
            // 
            this.projectBTToolStripMenuItem.Name = "projectBTToolStripMenuItem";
            this.projectBTToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.projectBTToolStripMenuItem.Text = "ProjectBT";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fromFileToolStripMenuItem.Text = "From File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiwHelpToolStripMenuItem,
            this.technicalSupportToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutCMSSystemsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // veiwHelpToolStripMenuItem
            // 
            this.veiwHelpToolStripMenuItem.Name = "veiwHelpToolStripMenuItem";
            this.veiwHelpToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.veiwHelpToolStripMenuItem.Text = "Veiw Help";
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.technicalSupportToolStripMenuItem.Text = "Technical Support";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // aboutCMSSystemsToolStripMenuItem
            // 
            this.aboutCMSSystemsToolStripMenuItem.Name = "aboutCMSSystemsToolStripMenuItem";
            this.aboutCMSSystemsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutCMSSystemsToolStripMenuItem.Text = "About CMS Systems";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BT",
            "Bharti IBM"});
            this.comboBox1.Location = new System.Drawing.Point(1108, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1016, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 66;
            this.label3.Text = "Country:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 583);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CMS Menu";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(6, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.Text = "Node5";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Client";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Node6";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Contract";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Node7";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Employee";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Node8";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Project";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node4";
            treeNode10.Text = "PayRoll";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Search";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(145, 585);
            this.treeView1.TabIndex = 98;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(309, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 78;
            this.checkBox1.Text = "Tuesday";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(411, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.Text = "Wednesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(537, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 17);
            this.checkBox3.TabIndex = 76;
            this.checkBox3.Text = "Thursday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(649, 108);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 75;
            this.checkBox4.Text = "Friday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(727, 108);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 17);
            this.checkBox5.TabIndex = 74;
            this.checkBox5.Text = "Saturday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(832, 108);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(62, 17);
            this.checkBox6.TabIndex = 73;
            this.checkBox6.Text = "Sunday";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(214, 107);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(64, 17);
            this.checkBox8.TabIndex = 72;
            this.checkBox8.Text = "Monday";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Unpaid Days:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Number of unpaid days allowed:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(586, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Number of unpiad days claimed:";
            // 
            // FormPayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.TxtSuppName);
            this.Controls.Add(this.LblSuppName);
            this.Controls.Add(this.BtnSumbit);
            this.Controls.Add(this.NumUpDownWeeksWorked);
            this.Controls.Add(this.LblWeeksWorked);
            this.Controls.Add(this.GrpBoxResults);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.comboContract);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.LblContract);
            this.Controls.Add(this.LblCleintName);
            this.Controls.Add(this.LblEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrpBoxTimeSheet);
            this.Name = "FormPayRoll";
            this.Text = "PayRoll";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSunday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSaturday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTuesday)).EndInit();
            this.GrpBoxResults.ResumeLayout(false);
            this.GrpBoxResults.PerformLayout();
            this.GrpBoxTimeSheet.ResumeLayout(false);
            this.GrpBoxTimeSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWeeksWorked)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEmpName;
        private System.Windows.Forms.Label LblCleintName;
        private System.Windows.Forms.Label LblProject;
        private System.Windows.Forms.Label LblContract;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ComboBox comboContract;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Label LblMonday;
        private System.Windows.Forms.Label LblSunday;
        private System.Windows.Forms.Label LblSaturday;
        private System.Windows.Forms.Label LblFriday;
        private System.Windows.Forms.Label LblThursday;
        private System.Windows.Forms.Label LblWednesday;
        private System.Windows.Forms.Label LblTuesday;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblWeekends;
        private System.Windows.Forms.Label LblHrsWorked;
        private System.Windows.Forms.Label LblDaysofWeek;
        private System.Windows.Forms.Button BtnSumbit;
        private System.Windows.Forms.NumericUpDown NumUpDownMonday;
        private System.Windows.Forms.NumericUpDown NumUpDownSunday;
        private System.Windows.Forms.NumericUpDown NumUpDownSaturday;
        private System.Windows.Forms.NumericUpDown NumUpDownFriday;
        private System.Windows.Forms.NumericUpDown NumUpDownThursday;
        private System.Windows.Forms.NumericUpDown NumUpDownWednesday;
        private System.Windows.Forms.NumericUpDown NumUpDownTuesday;
        private System.Windows.Forms.GroupBox GrpBoxResults;
        private System.Windows.Forms.Label LblRegHours;
        private System.Windows.Forms.Label LblRegRate;
        private System.Windows.Forms.GroupBox GrpBoxTimeSheet;
        private System.Windows.Forms.Label LblWeeksWorked;
        private System.Windows.Forms.NumericUpDown NumUpDownWeeksWorked;
        private System.Windows.Forms.TextBox TxtSuppName;
        private System.Windows.Forms.Label LblSuppName;
        private System.Windows.Forms.Label LblGrossPay;
        private System.Windows.Forms.Label LblTotalHours;
        private System.Windows.Forms.Label LblOTHourlyPay;
        private System.Windows.Forms.Label LblOTHoursWorked;
        private System.Windows.Forms.Label LblOTRate;
        private System.Windows.Forms.Label LblRegHourlyPay;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.TextBox TxtTotalHours;
        private System.Windows.Forms.TextBox TxtOTPay;
        private System.Windows.Forms.TextBox TxtOTRate;
        private System.Windows.Forms.TextBox TxtOTHours;
        private System.Windows.Forms.TextBox TxtRegPay;
        private System.Windows.Forms.TextBox TxtRegRate;
        private System.Windows.Forms.TextBox TxtRegHours;
        private System.Windows.Forms.TextBox TxtOffDays;
        private System.Windows.Forms.Label LblOffDays;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox CbTues;
        private System.Windows.Forms.CheckBox CbWed;
        private System.Windows.Forms.CheckBox CbThurs;
        private System.Windows.Forms.CheckBox CbFri;
        private System.Windows.Forms.CheckBox CbSat;
        private System.Windows.Forms.CheckBox CbSun;
        private System.Windows.Forms.CheckBox CbMon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectBTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiwHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCMSSystemsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label4;
    }
}

