
namespace WeeklyReportForCadian
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.label_SubmitDate = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_SubmitDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl_Contents = new System.Windows.Forms.TabControl();
            this.tabPage_Mon = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Mon_Unsolved = new System.Windows.Forms.TextBox();
            this.textBox_Mon_Job = new System.Windows.Forms.TextBox();
            this.tabPage_Tue = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Tue_Unsolved = new System.Windows.Forms.TextBox();
            this.textBox_Tue_Job = new System.Windows.Forms.TextBox();
            this.tabPage_Wed = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Wed_Unsolved = new System.Windows.Forms.TextBox();
            this.textBox_Wed_Job = new System.Windows.Forms.TextBox();
            this.tabPage_Thu = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Thu_Unsolved = new System.Windows.Forms.TextBox();
            this.textBox_Thu_Job = new System.Windows.Forms.TextBox();
            this.tabPage_Fri = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Fri_Unsolved = new System.Windows.Forms.TextBox();
            this.textBox_Fri_Job = new System.Windows.Forms.TextBox();
            this.tabPage_NextWeek = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_NextWeek_etc = new System.Windows.Forms.TextBox();
            this.textBox_NextWeek_Plan = new System.Windows.Forms.TextBox();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_Import = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_Contents.SuspendLayout();
            this.tabPage_Mon.SuspendLayout();
            this.tabPage_Tue.SuspendLayout();
            this.tabPage_Wed.SuspendLayout();
            this.tabPage_Thu.SuspendLayout();
            this.tabPage_Fri.SuspendLayout();
            this.tabPage_NextWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(27, 20);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 12);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "이름";
            // 
            // label_SubmitDate
            // 
            this.label_SubmitDate.AutoSize = true;
            this.label_SubmitDate.Location = new System.Drawing.Point(27, 53);
            this.label_SubmitDate.Name = "label_SubmitDate";
            this.label_SubmitDate.Size = new System.Drawing.Size(41, 12);
            this.label_SubmitDate.TabIndex = 1;
            this.label_SubmitDate.Text = "제출일";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(80, 16);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 2;
            // 
            // dateTimePicker_SubmitDate
            // 
            this.dateTimePicker_SubmitDate.Location = new System.Drawing.Point(80, 49);
            this.dateTimePicker_SubmitDate.Name = "dateTimePicker_SubmitDate";
            this.dateTimePicker_SubmitDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_SubmitDate.TabIndex = 3;
            // 
            // tabControl_Contents
            // 
            this.tabControl_Contents.Controls.Add(this.tabPage_Mon);
            this.tabControl_Contents.Controls.Add(this.tabPage_Tue);
            this.tabControl_Contents.Controls.Add(this.tabPage_Wed);
            this.tabControl_Contents.Controls.Add(this.tabPage_Thu);
            this.tabControl_Contents.Controls.Add(this.tabPage_Fri);
            this.tabControl_Contents.Controls.Add(this.tabPage_NextWeek);
            this.tabControl_Contents.Location = new System.Drawing.Point(29, 90);
            this.tabControl_Contents.Name = "tabControl_Contents";
            this.tabControl_Contents.SelectedIndex = 0;
            this.tabControl_Contents.Size = new System.Drawing.Size(747, 333);
            this.tabControl_Contents.TabIndex = 4;
            // 
            // tabPage_Mon
            // 
            this.tabPage_Mon.Controls.Add(this.label2);
            this.tabPage_Mon.Controls.Add(this.label1);
            this.tabPage_Mon.Controls.Add(this.textBox_Mon_Unsolved);
            this.tabPage_Mon.Controls.Add(this.textBox_Mon_Job);
            this.tabPage_Mon.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Mon.Name = "tabPage_Mon";
            this.tabPage_Mon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mon.Size = new System.Drawing.Size(739, 307);
            this.tabPage_Mon.TabIndex = 6;
            this.tabPage_Mon.Text = "월요일";
            this.tabPage_Mon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(497, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "미해결(계속 진행) 사항";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(170, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "업무 내용";
            // 
            // textBox_Mon_Unsolved
            // 
            this.textBox_Mon_Unsolved.Location = new System.Drawing.Point(424, 30);
            this.textBox_Mon_Unsolved.Multiline = true;
            this.textBox_Mon_Unsolved.Name = "textBox_Mon_Unsolved";
            this.textBox_Mon_Unsolved.Size = new System.Drawing.Size(309, 274);
            this.textBox_Mon_Unsolved.TabIndex = 1;
            // 
            // textBox_Mon_Job
            // 
            this.textBox_Mon_Job.Location = new System.Drawing.Point(4, 30);
            this.textBox_Mon_Job.Multiline = true;
            this.textBox_Mon_Job.Name = "textBox_Mon_Job";
            this.textBox_Mon_Job.Size = new System.Drawing.Size(414, 274);
            this.textBox_Mon_Job.TabIndex = 0;
            // 
            // tabPage_Tue
            // 
            this.tabPage_Tue.Controls.Add(this.label3);
            this.tabPage_Tue.Controls.Add(this.label4);
            this.tabPage_Tue.Controls.Add(this.textBox_Tue_Unsolved);
            this.tabPage_Tue.Controls.Add(this.textBox_Tue_Job);
            this.tabPage_Tue.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Tue.Name = "tabPage_Tue";
            this.tabPage_Tue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Tue.Size = new System.Drawing.Size(739, 307);
            this.tabPage_Tue.TabIndex = 1;
            this.tabPage_Tue.Text = "화요일";
            this.tabPage_Tue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(497, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "미해결(계속 진행) 사항";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(170, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "업무 내용";
            // 
            // textBox_Tue_Unsolved
            // 
            this.textBox_Tue_Unsolved.Location = new System.Drawing.Point(424, 30);
            this.textBox_Tue_Unsolved.Multiline = true;
            this.textBox_Tue_Unsolved.Name = "textBox_Tue_Unsolved";
            this.textBox_Tue_Unsolved.Size = new System.Drawing.Size(309, 274);
            this.textBox_Tue_Unsolved.TabIndex = 2;
            // 
            // textBox_Tue_Job
            // 
            this.textBox_Tue_Job.BackColor = System.Drawing.Color.White;
            this.textBox_Tue_Job.Location = new System.Drawing.Point(4, 30);
            this.textBox_Tue_Job.Multiline = true;
            this.textBox_Tue_Job.Name = "textBox_Tue_Job";
            this.textBox_Tue_Job.Size = new System.Drawing.Size(414, 274);
            this.textBox_Tue_Job.TabIndex = 1;
            // 
            // tabPage_Wed
            // 
            this.tabPage_Wed.Controls.Add(this.label5);
            this.tabPage_Wed.Controls.Add(this.label6);
            this.tabPage_Wed.Controls.Add(this.textBox_Wed_Unsolved);
            this.tabPage_Wed.Controls.Add(this.textBox_Wed_Job);
            this.tabPage_Wed.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Wed.Name = "tabPage_Wed";
            this.tabPage_Wed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Wed.Size = new System.Drawing.Size(739, 307);
            this.tabPage_Wed.TabIndex = 2;
            this.tabPage_Wed.Text = "수요일";
            this.tabPage_Wed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(497, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "미해결(계속 진행) 사항";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(170, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "업무 내용";
            // 
            // textBox_Wed_Unsolved
            // 
            this.textBox_Wed_Unsolved.Location = new System.Drawing.Point(424, 30);
            this.textBox_Wed_Unsolved.Multiline = true;
            this.textBox_Wed_Unsolved.Name = "textBox_Wed_Unsolved";
            this.textBox_Wed_Unsolved.Size = new System.Drawing.Size(309, 274);
            this.textBox_Wed_Unsolved.TabIndex = 2;
            // 
            // textBox_Wed_Job
            // 
            this.textBox_Wed_Job.Location = new System.Drawing.Point(4, 30);
            this.textBox_Wed_Job.Multiline = true;
            this.textBox_Wed_Job.Name = "textBox_Wed_Job";
            this.textBox_Wed_Job.Size = new System.Drawing.Size(414, 274);
            this.textBox_Wed_Job.TabIndex = 1;
            // 
            // tabPage_Thu
            // 
            this.tabPage_Thu.Controls.Add(this.label7);
            this.tabPage_Thu.Controls.Add(this.label8);
            this.tabPage_Thu.Controls.Add(this.textBox_Thu_Unsolved);
            this.tabPage_Thu.Controls.Add(this.textBox_Thu_Job);
            this.tabPage_Thu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Thu.Name = "tabPage_Thu";
            this.tabPage_Thu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Thu.Size = new System.Drawing.Size(739, 307);
            this.tabPage_Thu.TabIndex = 3;
            this.tabPage_Thu.Text = "목요일";
            this.tabPage_Thu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F);
            this.label7.Location = new System.Drawing.Point(497, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "미해결(계속 진행) 사항";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(170, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "업무 내용";
            // 
            // textBox_Thu_Unsolved
            // 
            this.textBox_Thu_Unsolved.Location = new System.Drawing.Point(424, 30);
            this.textBox_Thu_Unsolved.Multiline = true;
            this.textBox_Thu_Unsolved.Name = "textBox_Thu_Unsolved";
            this.textBox_Thu_Unsolved.Size = new System.Drawing.Size(309, 274);
            this.textBox_Thu_Unsolved.TabIndex = 2;
            // 
            // textBox_Thu_Job
            // 
            this.textBox_Thu_Job.Location = new System.Drawing.Point(4, 30);
            this.textBox_Thu_Job.Multiline = true;
            this.textBox_Thu_Job.Name = "textBox_Thu_Job";
            this.textBox_Thu_Job.Size = new System.Drawing.Size(414, 274);
            this.textBox_Thu_Job.TabIndex = 1;
            // 
            // tabPage_Fri
            // 
            this.tabPage_Fri.Controls.Add(this.label9);
            this.tabPage_Fri.Controls.Add(this.label10);
            this.tabPage_Fri.Controls.Add(this.textBox_Fri_Unsolved);
            this.tabPage_Fri.Controls.Add(this.textBox_Fri_Job);
            this.tabPage_Fri.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Fri.Name = "tabPage_Fri";
            this.tabPage_Fri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fri.Size = new System.Drawing.Size(739, 307);
            this.tabPage_Fri.TabIndex = 4;
            this.tabPage_Fri.Text = "금요일";
            this.tabPage_Fri.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(497, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "미해결(계속 진행) 사항";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F);
            this.label10.Location = new System.Drawing.Point(170, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "업무 내용";
            // 
            // textBox_Fri_Unsolved
            // 
            this.textBox_Fri_Unsolved.Location = new System.Drawing.Point(424, 30);
            this.textBox_Fri_Unsolved.Multiline = true;
            this.textBox_Fri_Unsolved.Name = "textBox_Fri_Unsolved";
            this.textBox_Fri_Unsolved.Size = new System.Drawing.Size(309, 274);
            this.textBox_Fri_Unsolved.TabIndex = 2;
            // 
            // textBox_Fri_Job
            // 
            this.textBox_Fri_Job.Location = new System.Drawing.Point(4, 30);
            this.textBox_Fri_Job.Multiline = true;
            this.textBox_Fri_Job.Name = "textBox_Fri_Job";
            this.textBox_Fri_Job.Size = new System.Drawing.Size(414, 274);
            this.textBox_Fri_Job.TabIndex = 1;
            // 
            // tabPage_NextWeek
            // 
            this.tabPage_NextWeek.Controls.Add(this.label11);
            this.tabPage_NextWeek.Controls.Add(this.label12);
            this.tabPage_NextWeek.Controls.Add(this.textBox_NextWeek_etc);
            this.tabPage_NextWeek.Controls.Add(this.textBox_NextWeek_Plan);
            this.tabPage_NextWeek.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NextWeek.Name = "tabPage_NextWeek";
            this.tabPage_NextWeek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NextWeek.Size = new System.Drawing.Size(739, 307);
            this.tabPage_NextWeek.TabIndex = 7;
            this.tabPage_NextWeek.Text = "차주";
            this.tabPage_NextWeek.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F);
            this.label11.Location = new System.Drawing.Point(559, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "기타";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F);
            this.label12.Location = new System.Drawing.Point(111, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "다음 1주간 개발 및 업무 계획";
            // 
            // textBox_NextWeek_etc
            // 
            this.textBox_NextWeek_etc.Location = new System.Drawing.Point(424, 30);
            this.textBox_NextWeek_etc.Multiline = true;
            this.textBox_NextWeek_etc.Name = "textBox_NextWeek_etc";
            this.textBox_NextWeek_etc.Size = new System.Drawing.Size(309, 274);
            this.textBox_NextWeek_etc.TabIndex = 2;
            // 
            // textBox_NextWeek_Plan
            // 
            this.textBox_NextWeek_Plan.Location = new System.Drawing.Point(4, 30);
            this.textBox_NextWeek_Plan.Multiline = true;
            this.textBox_NextWeek_Plan.Name = "textBox_NextWeek_Plan";
            this.textBox_NextWeek_Plan.Size = new System.Drawing.Size(414, 274);
            this.textBox_NextWeek_Plan.TabIndex = 1;
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(182, 439);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(115, 23);
            this.button_Export.TabIndex = 5;
            this.button_Export.Text = "엑셀로 내보내기";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // button_Import
            // 
            this.button_Import.Location = new System.Drawing.Point(33, 439);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(124, 23);
            this.button_Import.TabIndex = 6;
            this.button_Import.Text = "엑셀에서 가져오기";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(303, 53);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(241, 12);
            this.label_warning.TabIndex = 7;
            this.label_warning.Text = "반드시 제출 요일을 금요일로 설정하십시오.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "도움말";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.tabControl_Contents);
            this.Controls.Add(this.dateTimePicker_SubmitDate);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_SubmitDate);
            this.Controls.Add(this.label_Name);
            this.Name = "Main";
            this.Text = "주간보고서 작성 프로그램 (개발: 정순범)";
            this.tabControl_Contents.ResumeLayout(false);
            this.tabPage_Mon.ResumeLayout(false);
            this.tabPage_Mon.PerformLayout();
            this.tabPage_Tue.ResumeLayout(false);
            this.tabPage_Tue.PerformLayout();
            this.tabPage_Wed.ResumeLayout(false);
            this.tabPage_Wed.PerformLayout();
            this.tabPage_Thu.ResumeLayout(false);
            this.tabPage_Thu.PerformLayout();
            this.tabPage_Fri.ResumeLayout(false);
            this.tabPage_Fri.PerformLayout();
            this.tabPage_NextWeek.ResumeLayout(false);
            this.tabPage_NextWeek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_SubmitDate;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SubmitDate;
        private System.Windows.Forms.TabControl tabControl_Contents;
        private System.Windows.Forms.TabPage tabPage_Tue;
        private System.Windows.Forms.TabPage tabPage_Wed;
        private System.Windows.Forms.TabPage tabPage_Thu;
        private System.Windows.Forms.TabPage tabPage_Fri;
        private System.Windows.Forms.TabPage tabPage_Mon;
        private System.Windows.Forms.TabPage tabPage_NextWeek;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.TextBox textBox_Mon_Job;
        private System.Windows.Forms.TextBox textBox_Tue_Job;
        private System.Windows.Forms.TextBox textBox_Wed_Job;
        private System.Windows.Forms.TextBox textBox_Thu_Job;
        private System.Windows.Forms.TextBox textBox_Fri_Job;
        private System.Windows.Forms.TextBox textBox_NextWeek_Plan;
        private System.Windows.Forms.TextBox textBox_Mon_Unsolved;
        private System.Windows.Forms.TextBox textBox_Tue_Unsolved;
        private System.Windows.Forms.TextBox textBox_Wed_Unsolved;
        private System.Windows.Forms.TextBox textBox_Thu_Unsolved;
        private System.Windows.Forms.TextBox textBox_Fri_Unsolved;
        private System.Windows.Forms.TextBox textBox_NextWeek_etc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Button button1;
    }
}

