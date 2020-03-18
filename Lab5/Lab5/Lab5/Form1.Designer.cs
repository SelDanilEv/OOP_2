namespace Lab5
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1Course = new System.Windows.Forms.GroupBox();
            this.radioButtonCourse4 = new System.Windows.Forms.RadioButton();
            this.radioButtonCourse3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCourse2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCourse1 = new System.Windows.Forms.RadioButton();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.numericUpDownSemester = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfControl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpLectures = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownLabs = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAllowLabs = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPulpit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.richTextBoxShow = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLectures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(48, 40);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitle_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Items.AddRange(new object[] {
            "POIT",
            "ISIT",
            "DEVI",
            "POIMBS"});
            this.comboBox1.Location = new System.Drawing.Point(198, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // groupBox1Course
            // 
            this.groupBox1Course.Controls.Add(this.radioButtonCourse4);
            this.groupBox1Course.Controls.Add(this.radioButtonCourse3);
            this.groupBox1Course.Controls.Add(this.radioButtonCourse2);
            this.groupBox1Course.Controls.Add(this.radioButtonCourse1);
            this.groupBox1Course.Location = new System.Drawing.Point(48, 96);
            this.groupBox1Course.Name = "groupBox1Course";
            this.groupBox1Course.Size = new System.Drawing.Size(67, 130);
            this.groupBox1Course.TabIndex = 3;
            this.groupBox1Course.TabStop = false;
            this.groupBox1Course.Text = "Course";
            this.groupBox1Course.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1Course_Validating);
            // 
            // radioButtonCourse4
            // 
            this.radioButtonCourse4.AutoSize = true;
            this.radioButtonCourse4.Location = new System.Drawing.Point(6, 100);
            this.radioButtonCourse4.Name = "radioButtonCourse4";
            this.radioButtonCourse4.Size = new System.Drawing.Size(37, 21);
            this.radioButtonCourse4.TabIndex = 3;
            this.radioButtonCourse4.TabStop = true;
            this.radioButtonCourse4.Text = "4";
            this.radioButtonCourse4.UseVisualStyleBackColor = true;
            // 
            // radioButtonCourse3
            // 
            this.radioButtonCourse3.AutoSize = true;
            this.radioButtonCourse3.Location = new System.Drawing.Point(6, 73);
            this.radioButtonCourse3.Name = "radioButtonCourse3";
            this.radioButtonCourse3.Size = new System.Drawing.Size(37, 21);
            this.radioButtonCourse3.TabIndex = 2;
            this.radioButtonCourse3.TabStop = true;
            this.radioButtonCourse3.Text = "3";
            this.radioButtonCourse3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCourse2
            // 
            this.radioButtonCourse2.AutoSize = true;
            this.radioButtonCourse2.Location = new System.Drawing.Point(6, 46);
            this.radioButtonCourse2.Name = "radioButtonCourse2";
            this.radioButtonCourse2.Size = new System.Drawing.Size(37, 21);
            this.radioButtonCourse2.TabIndex = 1;
            this.radioButtonCourse2.TabStop = true;
            this.radioButtonCourse2.Text = "2";
            this.radioButtonCourse2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCourse1
            // 
            this.radioButtonCourse1.AutoSize = true;
            this.radioButtonCourse1.Location = new System.Drawing.Point(6, 21);
            this.radioButtonCourse1.Name = "radioButtonCourse1";
            this.radioButtonCourse1.Size = new System.Drawing.Size(37, 21);
            this.radioButtonCourse1.TabIndex = 0;
            this.radioButtonCourse1.TabStop = true;
            this.radioButtonCourse1.Text = "1";
            this.radioButtonCourse1.UseVisualStyleBackColor = true;
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(195, 18);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(65, 17);
            this.labelSpecialty.TabIndex = 4;
            this.labelSpecialty.Text = "Specialty";
            // 
            // numericUpDownSemester
            // 
            this.numericUpDownSemester.Location = new System.Drawing.Point(48, 257);
            this.numericUpDownSemester.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSemester.Name = "numericUpDownSemester";
            this.numericUpDownSemester.Size = new System.Drawing.Size(43, 22);
            this.numericUpDownSemester.TabIndex = 5;
            this.numericUpDownSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type of control";
            // 
            // comboBoxTypeOfControl
            // 
            this.comboBoxTypeOfControl.FormattingEnabled = true;
            this.comboBoxTypeOfControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxTypeOfControl.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет"});
            this.comboBoxTypeOfControl.Location = new System.Drawing.Point(198, 169);
            this.comboBoxTypeOfControl.Name = "comboBoxTypeOfControl";
            this.comboBoxTypeOfControl.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTypeOfControl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity of lectures";
            // 
            // numericUpLectures
            // 
            this.numericUpLectures.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpLectures.Location = new System.Drawing.Point(198, 116);
            this.numericUpLectures.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpLectures.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpLectures.Name = "numericUpLectures";
            this.numericUpLectures.Size = new System.Drawing.Size(121, 22);
            this.numericUpLectures.TabIndex = 11;
            this.numericUpLectures.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity of labs";
            // 
            // numericUpDownLabs
            // 
            this.numericUpDownLabs.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLabs.Location = new System.Drawing.Point(198, 262);
            this.numericUpDownLabs.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownLabs.Name = "numericUpDownLabs";
            this.numericUpDownLabs.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownLabs.TabIndex = 13;
            // 
            // checkBoxAllowLabs
            // 
            this.checkBoxAllowLabs.AutoSize = true;
            this.checkBoxAllowLabs.Checked = true;
            this.checkBoxAllowLabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllowLabs.Location = new System.Drawing.Point(198, 218);
            this.checkBoxAllowLabs.Name = "checkBoxAllowLabs";
            this.checkBoxAllowLabs.Size = new System.Drawing.Size(69, 21);
            this.checkBoxAllowLabs.TabIndex = 15;
            this.checkBoxAllowLabs.Text = "Labs?";
            this.checkBoxAllowLabs.UseVisualStyleBackColor = true;
            this.checkBoxAllowLabs.CheckedChanged += new System.EventHandler(this.checkBoxAllowLabs_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(370, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Lector?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pulpit";
            // 
            // textBoxPulpit
            // 
            this.textBoxPulpit.Location = new System.Drawing.Point(370, 91);
            this.textBoxPulpit.Name = "textBoxPulpit";
            this.textBoxPulpit.Size = new System.Drawing.Size(165, 22);
            this.textBoxPulpit.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Full name";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(370, 143);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(165, 22);
            this.textBoxFullName.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(354, 218);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(181, 166);
            this.richTextBoxLog.TabIndex = 22;
            this.richTextBoxLog.Text = "";
            // 
            // richTextBoxShow
            // 
            this.richTextBoxShow.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxShow.Location = new System.Drawing.Point(541, 12);
            this.richTextBoxShow.Name = "richTextBoxShow";
            this.richTextBoxShow.ReadOnly = true;
            this.richTextBoxShow.Size = new System.Drawing.Size(247, 372);
            this.richTextBoxShow.TabIndex = 23;
            this.richTextBoxShow.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(354, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 22);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBoxShow);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPulpit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxAllowLabs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownLabs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpLectures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeOfControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSemester);
            this.Controls.Add(this.labelSpecialty);
            this.Controls.Add(this.groupBox1Course);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.MaximumSize = new System.Drawing.Size(818, 443);
            this.MinimumSize = new System.Drawing.Size(818, 443);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1Course.ResumeLayout(false);
            this.groupBox1Course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLectures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1Course;
        private System.Windows.Forms.RadioButton radioButtonCourse4;
        private System.Windows.Forms.RadioButton radioButtonCourse3;
        private System.Windows.Forms.RadioButton radioButtonCourse2;
        private System.Windows.Forms.RadioButton radioButtonCourse1;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.NumericUpDown numericUpDownSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeOfControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpLectures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownLabs;
        private System.Windows.Forms.CheckBox checkBoxAllowLabs;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPulpit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.RichTextBox richTextBoxShow;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

