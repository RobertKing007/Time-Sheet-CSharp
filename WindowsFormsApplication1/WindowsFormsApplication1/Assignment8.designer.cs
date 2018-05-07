namespace WindowsFormsApplication1
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
            this.CheckMonday = new System.Windows.Forms.CheckBox();
            this.CheckSunday = new System.Windows.Forms.CheckBox();
            this.CheckSaturday = new System.Windows.Forms.CheckBox();
            this.CheckFriday = new System.Windows.Forms.CheckBox();
            this.CheckThursday = new System.Windows.Forms.CheckBox();
            this.CheckWednesday = new System.Windows.Forms.CheckBox();
            this.CheckTuesday = new System.Windows.Forms.CheckBox();
            this.LblWeekends = new System.Windows.Forms.Label();
            this.LblHrsWorked = new System.Windows.Forms.Label();
            this.LblDaysofWeek = new System.Windows.Forms.Label();
            this.BtnSumbit = new System.Windows.Forms.Button();
            this.NumUpDownMonday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownSunday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownSaturday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownFriday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownThursday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownWednesday = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownTuesday = new System.Windows.Forms.NumericUpDown();
            this.GrpBoxResults = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.GrpBoxTimeSheet = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSunday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSaturday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTuesday)).BeginInit();
            this.GrpBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 9);
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
            this.LblEmpName.Location = new System.Drawing.Point(12, 117);
            this.LblEmpName.Name = "LblEmpName";
            this.LblEmpName.Size = new System.Drawing.Size(181, 26);
            this.LblEmpName.TabIndex = 1;
            this.LblEmpName.Text = "Employee Name:";
            // 
            // LblCleintName
            // 
            this.LblCleintName.AutoSize = true;
            this.LblCleintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCleintName.Location = new System.Drawing.Point(12, 174);
            this.LblCleintName.Name = "LblCleintName";
            this.LblCleintName.Size = new System.Drawing.Size(139, 26);
            this.LblCleintName.TabIndex = 2;
            this.LblCleintName.Text = "Cleint Name:";
            this.LblCleintName.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProject.Location = new System.Drawing.Point(12, 283);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(86, 26);
            this.LblProject.TabIndex = 4;
            this.LblProject.Text = "Project:";
            // 
            // LblContract
            // 
            this.LblContract.AutoSize = true;
            this.LblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContract.Location = new System.Drawing.Point(12, 226);
            this.LblContract.Name = "LblContract";
            this.LblContract.Size = new System.Drawing.Size(100, 26);
            this.LblContract.TabIndex = 3;
            this.LblContract.Text = "Contract:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(193, 123);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(193, 180);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 6;
            // 
            // comboContract
            // 
            this.comboContract.FormattingEnabled = true;
            this.comboContract.Location = new System.Drawing.Point(193, 232);
            this.comboContract.Name = "comboContract";
            this.comboContract.Size = new System.Drawing.Size(100, 21);
            this.comboContract.TabIndex = 9;
            // 
            // comboProject
            // 
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(193, 283);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(100, 21);
            this.comboProject.TabIndex = 10;
            // 
            // LblMonday
            // 
            this.LblMonday.AutoSize = true;
            this.LblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonday.Location = new System.Drawing.Point(293, 410);
            this.LblMonday.Name = "LblMonday";
            this.LblMonday.Size = new System.Drawing.Size(89, 26);
            this.LblMonday.TabIndex = 11;
            this.LblMonday.Text = "Monday";
            // 
            // LblSunday
            // 
            this.LblSunday.AutoSize = true;
            this.LblSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSunday.Location = new System.Drawing.Point(911, 410);
            this.LblSunday.Name = "LblSunday";
            this.LblSunday.Size = new System.Drawing.Size(86, 26);
            this.LblSunday.TabIndex = 13;
            this.LblSunday.Text = "Sunday";
            // 
            // LblSaturday
            // 
            this.LblSaturday.AutoSize = true;
            this.LblSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaturday.Location = new System.Drawing.Point(806, 410);
            this.LblSaturday.Name = "LblSaturday";
            this.LblSaturday.Size = new System.Drawing.Size(99, 26);
            this.LblSaturday.TabIndex = 14;
            this.LblSaturday.Text = "Saturday";
            // 
            // LblFriday
            // 
            this.LblFriday.AutoSize = true;
            this.LblFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFriday.Location = new System.Drawing.Point(728, 410);
            this.LblFriday.Name = "LblFriday";
            this.LblFriday.Size = new System.Drawing.Size(72, 26);
            this.LblFriday.TabIndex = 15;
            this.LblFriday.Text = "Friday";
            // 
            // LblThursday
            // 
            this.LblThursday.AutoSize = true;
            this.LblThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThursday.Location = new System.Drawing.Point(621, 410);
            this.LblThursday.Name = "LblThursday";
            this.LblThursday.Size = new System.Drawing.Size(101, 26);
            this.LblThursday.TabIndex = 16;
            this.LblThursday.Text = "Thursday";
            // 
            // LblWednesday
            // 
            this.LblWednesday.AutoSize = true;
            this.LblWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWednesday.Location = new System.Drawing.Point(488, 410);
            this.LblWednesday.Name = "LblWednesday";
            this.LblWednesday.Size = new System.Drawing.Size(127, 26);
            this.LblWednesday.TabIndex = 17;
            this.LblWednesday.Text = "Wednesday";
            // 
            // LblTuesday
            // 
            this.LblTuesday.AutoSize = true;
            this.LblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuesday.Location = new System.Drawing.Point(388, 410);
            this.LblTuesday.Name = "LblTuesday";
            this.LblTuesday.Size = new System.Drawing.Size(94, 26);
            this.LblTuesday.TabIndex = 18;
            this.LblTuesday.Text = "Tuesday";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1003, 410);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(59, 26);
            this.LblTotal.TabIndex = 19;
            this.LblTotal.Text = "Total";
            // 
            // CheckMonday
            // 
            this.CheckMonday.AutoSize = true;
            this.CheckMonday.Location = new System.Drawing.Point(298, 474);
            this.CheckMonday.Name = "CheckMonday";
            this.CheckMonday.Size = new System.Drawing.Size(15, 14);
            this.CheckMonday.TabIndex = 29;
            this.CheckMonday.UseVisualStyleBackColor = true;
            // 
            // CheckSunday
            // 
            this.CheckSunday.AutoSize = true;
            this.CheckSunday.Location = new System.Drawing.Point(916, 474);
            this.CheckSunday.Name = "CheckSunday";
            this.CheckSunday.Size = new System.Drawing.Size(15, 14);
            this.CheckSunday.TabIndex = 30;
            this.CheckSunday.UseVisualStyleBackColor = true;
            // 
            // CheckSaturday
            // 
            this.CheckSaturday.AutoSize = true;
            this.CheckSaturday.Location = new System.Drawing.Point(811, 474);
            this.CheckSaturday.Name = "CheckSaturday";
            this.CheckSaturday.Size = new System.Drawing.Size(15, 14);
            this.CheckSaturday.TabIndex = 31;
            this.CheckSaturday.UseVisualStyleBackColor = true;
            // 
            // CheckFriday
            // 
            this.CheckFriday.AutoSize = true;
            this.CheckFriday.Location = new System.Drawing.Point(733, 474);
            this.CheckFriday.Name = "CheckFriday";
            this.CheckFriday.Size = new System.Drawing.Size(15, 14);
            this.CheckFriday.TabIndex = 32;
            this.CheckFriday.UseVisualStyleBackColor = true;
            // 
            // CheckThursday
            // 
            this.CheckThursday.AutoSize = true;
            this.CheckThursday.Location = new System.Drawing.Point(626, 474);
            this.CheckThursday.Name = "CheckThursday";
            this.CheckThursday.Size = new System.Drawing.Size(15, 14);
            this.CheckThursday.TabIndex = 33;
            this.CheckThursday.UseVisualStyleBackColor = true;
            // 
            // CheckWednesday
            // 
            this.CheckWednesday.AutoSize = true;
            this.CheckWednesday.Location = new System.Drawing.Point(493, 474);
            this.CheckWednesday.Name = "CheckWednesday";
            this.CheckWednesday.Size = new System.Drawing.Size(15, 14);
            this.CheckWednesday.TabIndex = 34;
            this.CheckWednesday.UseVisualStyleBackColor = true;
            // 
            // CheckTuesday
            // 
            this.CheckTuesday.AutoSize = true;
            this.CheckTuesday.Location = new System.Drawing.Point(393, 477);
            this.CheckTuesday.Name = "CheckTuesday";
            this.CheckTuesday.Size = new System.Drawing.Size(15, 14);
            this.CheckTuesday.TabIndex = 35;
            this.CheckTuesday.UseVisualStyleBackColor = true;
            // 
            // LblWeekends
            // 
            this.LblWeekends.AutoSize = true;
            this.LblWeekends.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeekends.Location = new System.Drawing.Point(22, 465);
            this.LblWeekends.Name = "LblWeekends";
            this.LblWeekends.Size = new System.Drawing.Size(270, 26);
            this.LblWeekends.TabIndex = 37;
            this.LblWeekends.Text = "Weekend/holiday/Vacation";
            // 
            // LblHrsWorked
            // 
            this.LblHrsWorked.AutoSize = true;
            this.LblHrsWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHrsWorked.Location = new System.Drawing.Point(135, 436);
            this.LblHrsWorked.Name = "LblHrsWorked";
            this.LblHrsWorked.Size = new System.Drawing.Size(157, 26);
            this.LblHrsWorked.TabIndex = 38;
            this.LblHrsWorked.Text = "Hours Worked:";
            // 
            // LblDaysofWeek
            // 
            this.LblDaysofWeek.AutoSize = true;
            this.LblDaysofWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDaysofWeek.Location = new System.Drawing.Point(102, 410);
            this.LblDaysofWeek.Name = "LblDaysofWeek";
            this.LblDaysofWeek.Size = new System.Drawing.Size(190, 26);
            this.LblDaysofWeek.TabIndex = 39;
            this.LblDaysofWeek.Text = "Days of the Week:";
            // 
            // BtnSumbit
            // 
            this.BtnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumbit.Location = new System.Drawing.Point(17, 322);
            this.BtnSumbit.Name = "BtnSumbit";
            this.BtnSumbit.Size = new System.Drawing.Size(276, 36);
            this.BtnSumbit.TabIndex = 41;
            this.BtnSumbit.Text = "Sumbit";
            this.BtnSumbit.UseVisualStyleBackColor = true;
            // 
            // NumUpDownMonday
            // 
            this.NumUpDownMonday.Location = new System.Drawing.Point(298, 443);
            this.NumUpDownMonday.Name = "NumUpDownMonday";
            this.NumUpDownMonday.Size = new System.Drawing.Size(84, 20);
            this.NumUpDownMonday.TabIndex = 42;
            // 
            // NumUpDownTotal
            // 
            this.NumUpDownTotal.Location = new System.Drawing.Point(1008, 443);
            this.NumUpDownTotal.Name = "NumUpDownTotal";
            this.NumUpDownTotal.Size = new System.Drawing.Size(54, 20);
            this.NumUpDownTotal.TabIndex = 43;
            // 
            // NumUpDownSunday
            // 
            this.NumUpDownSunday.Location = new System.Drawing.Point(916, 442);
            this.NumUpDownSunday.Name = "NumUpDownSunday";
            this.NumUpDownSunday.Size = new System.Drawing.Size(81, 20);
            this.NumUpDownSunday.TabIndex = 44;
            // 
            // NumUpDownSaturday
            // 
            this.NumUpDownSaturday.Location = new System.Drawing.Point(811, 442);
            this.NumUpDownSaturday.Name = "NumUpDownSaturday";
            this.NumUpDownSaturday.Size = new System.Drawing.Size(94, 20);
            this.NumUpDownSaturday.TabIndex = 45;
            // 
            // NumUpDownFriday
            // 
            this.NumUpDownFriday.Location = new System.Drawing.Point(733, 442);
            this.NumUpDownFriday.Name = "NumUpDownFriday";
            this.NumUpDownFriday.Size = new System.Drawing.Size(67, 20);
            this.NumUpDownFriday.TabIndex = 46;
            // 
            // NumUpDownThursday
            // 
            this.NumUpDownThursday.Location = new System.Drawing.Point(621, 439);
            this.NumUpDownThursday.Name = "NumUpDownThursday";
            this.NumUpDownThursday.Size = new System.Drawing.Size(101, 20);
            this.NumUpDownThursday.TabIndex = 47;
            // 
            // NumUpDownWednesday
            // 
            this.NumUpDownWednesday.Location = new System.Drawing.Point(493, 442);
            this.NumUpDownWednesday.Name = "NumUpDownWednesday";
            this.NumUpDownWednesday.Size = new System.Drawing.Size(122, 20);
            this.NumUpDownWednesday.TabIndex = 48;
            // 
            // NumUpDownTuesday
            // 
            this.NumUpDownTuesday.Location = new System.Drawing.Point(393, 443);
            this.NumUpDownTuesday.Name = "NumUpDownTuesday";
            this.NumUpDownTuesday.Size = new System.Drawing.Size(89, 20);
            this.NumUpDownTuesday.TabIndex = 49;
            // 
            // GrpBoxResults
            // 
            this.GrpBoxResults.Controls.Add(this.label18);
            this.GrpBoxResults.Controls.Add(this.label17);
            this.GrpBoxResults.Location = new System.Drawing.Point(400, 117);
            this.GrpBoxResults.Name = "GrpBoxResults";
            this.GrpBoxResults.Size = new System.Drawing.Size(676, 209);
            this.GrpBoxResults.TabIndex = 50;
            this.GrpBoxResults.TabStop = false;
            this.GrpBoxResults.Text = "Pay Roll Results";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "label18";
            // 
            // GrpBoxTimeSheet
            // 
            this.GrpBoxTimeSheet.Location = new System.Drawing.Point(27, 391);
            this.GrpBoxTimeSheet.Name = "GrpBoxTimeSheet";
            this.GrpBoxTimeSheet.Size = new System.Drawing.Size(1049, 124);
            this.GrpBoxTimeSheet.TabIndex = 2;
            this.GrpBoxTimeSheet.TabStop = false;
            this.GrpBoxTimeSheet.Text = "Time Sheet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 637);
            this.Controls.Add(this.GrpBoxResults);
            this.Controls.Add(this.NumUpDownTuesday);
            this.Controls.Add(this.NumUpDownWednesday);
            this.Controls.Add(this.NumUpDownThursday);
            this.Controls.Add(this.NumUpDownFriday);
            this.Controls.Add(this.NumUpDownSaturday);
            this.Controls.Add(this.NumUpDownSunday);
            this.Controls.Add(this.NumUpDownTotal);
            this.Controls.Add(this.NumUpDownMonday);
            this.Controls.Add(this.BtnSumbit);
            this.Controls.Add(this.LblDaysofWeek);
            this.Controls.Add(this.LblHrsWorked);
            this.Controls.Add(this.LblWeekends);
            this.Controls.Add(this.CheckTuesday);
            this.Controls.Add(this.CheckWednesday);
            this.Controls.Add(this.CheckThursday);
            this.Controls.Add(this.CheckFriday);
            this.Controls.Add(this.CheckSaturday);
            this.Controls.Add(this.CheckSunday);
            this.Controls.Add(this.CheckMonday);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTuesday);
            this.Controls.Add(this.LblWednesday);
            this.Controls.Add(this.LblThursday);
            this.Controls.Add(this.LblFriday);
            this.Controls.Add(this.LblSaturday);
            this.Controls.Add(this.LblSunday);
            this.Controls.Add(this.LblMonday);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSunday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSaturday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTuesday)).EndInit();
            this.GrpBoxResults.ResumeLayout(false);
            this.GrpBoxResults.PerformLayout();
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
        private System.Windows.Forms.CheckBox CheckMonday;
        private System.Windows.Forms.CheckBox CheckSunday;
        private System.Windows.Forms.CheckBox CheckSaturday;
        private System.Windows.Forms.CheckBox CheckFriday;
        private System.Windows.Forms.CheckBox CheckThursday;
        private System.Windows.Forms.CheckBox CheckWednesday;
        private System.Windows.Forms.CheckBox CheckTuesday;
        private System.Windows.Forms.Label LblWeekends;
        private System.Windows.Forms.Label LblHrsWorked;
        private System.Windows.Forms.Label LblDaysofWeek;
        private System.Windows.Forms.Button BtnSumbit;
        private System.Windows.Forms.NumericUpDown NumUpDownMonday;
        private System.Windows.Forms.NumericUpDown NumUpDownTotal;
        private System.Windows.Forms.NumericUpDown NumUpDownSunday;
        private System.Windows.Forms.NumericUpDown NumUpDownSaturday;
        private System.Windows.Forms.NumericUpDown NumUpDownFriday;
        private System.Windows.Forms.NumericUpDown NumUpDownThursday;
        private System.Windows.Forms.NumericUpDown NumUpDownWednesday;
        private System.Windows.Forms.NumericUpDown NumUpDownTuesday;
        private System.Windows.Forms.GroupBox GrpBoxResults;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox GrpBoxTimeSheet;
    }
}

