using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WeeklyReportForCadian
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;       // 엑셀 프로그램 숨김
            excelApp.DisplayAlerts = false; // 경고 메시지를 표시하지 않음

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Name = "주간보고서";   // 시트 이름

            string[] DayOfTheWeek = new string[] { "월", "화", "수", "목", "금" };
            TextBox[] textBox_Job = new TextBox[] { textBox_Mon_Job, textBox_Tue_Job, textBox_Wed_Job, textBox_Thu_Job, textBox_Fri_Job };
            TextBox[] textBox_Unsolved = new TextBox[] { textBox_Mon_Unsolved, textBox_Tue_Unsolved, textBox_Wed_Unsolved, textBox_Thu_Unsolved, textBox_Fri_Unsolved };

            // 타이틀
            workSheet.Cells[1, "B"] = "주간 보고서";
            workSheet.Cells.Range["B1:K1"].Merge();     // B1부터 K1까지 병합
            workSheet.Cells.Range["B1:K1"].Font.Bold = true;    // Bold
            workSheet.Cells.Range["B1:K1"].Font.Underline = true;   // Underline
            workSheet.Cells.Range["B1:K1"].Font.Size = 22;      // 글꼴 크기 22
            workSheet.Cells.Range["B1:K1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬

            // 제출일, 이름
            DateTime submitTime = dateTimePicker_SubmitDate.Value;
            workSheet.Cells[2, "B"] = "제출일:";
            workSheet.Cells[2, "C"] = string.Format("{0:yyyy-MM-dd}", submitTime);
            workSheet.Cells[3, "B"] = "이름  :";
            workSheet.Cells[3, "C"] = textBox_Name.Text;
            
            // 헤더 (1)
            workSheet.Cells[4, "B"] = "일자";
            workSheet.Cells.Range["B4:B4"].Font.Bold = true;    // Bold
            workSheet.Cells.Range["B4:B4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[4, "C"] = "업무 내용";
            workSheet.Cells.Range["C4:G4"].Merge();             // C4부터 G4까지 병합
            workSheet.Cells.Range["C4:G4"].Font.Bold = true;    // Bold
            workSheet.Cells.Range["C4:G4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[4, "H"] = "미해결(계속 진행) 사항";
            workSheet.Cells.Range["H4:K4"].Merge();             // H4부터 K4까지 병합
            workSheet.Cells.Range["H4:K4"].Font.Bold = true;    // Bold
            workSheet.Cells.Range["H4:K4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬

            // 경계선 (헤더 1)
            workSheet.Cells.Range["B4:K4"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B4:K4"].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B4:K4"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B4:B4"].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
            workSheet.Cells.Range["H4:H4"].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;

            // 라인을 계산하기 위한 변수들
            int textBox_lineCount1, textBox_lineCount2;     // 좌우 텍스트박스 텍스트 라인 개수 저장
            string[] contents;

            int curLineNumber = 5;      // 현재 가리키는 라인 번호
            int curCellHeight;          // 현재 가리키는 셀 높이
            int tempLineNumber;         // 임시 라인 번호

            // 월요일부터 금요일까지 기록
            for (int i = 0; i < 5; i++)
            {
                // 경계선 (상단)
                workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
                workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                workSheet.Cells.Range["B" + curLineNumber.ToString() + ":B" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
                workSheet.Cells.Range["H" + curLineNumber.ToString() + ":H" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;

                // 날짜, 요일 기록
                workSheet.Cells[curLineNumber, "B"] = string.Format("{0:MM/dd}", submitTime.AddDays(-4 + i));
                workSheet.Cells[curLineNumber + 1, "B"] = $"({DayOfTheWeek[i]})";
                workSheet.Cells[curLineNumber, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
                workSheet.Cells[curLineNumber + 1, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬

                textBox_lineCount1 = textBox_Job[i].Text.Count(f => (f == '\n'));
                textBox_lineCount2 = textBox_Unsolved[i].Text.Count(f => (f == '\n'));
                curCellHeight = Math.Max(textBox_lineCount1, textBox_lineCount2);

                // 업무 내용
                contents = textBox_Job[i].Text.Split('\n');
                tempLineNumber = curLineNumber;
                foreach (var line in contents)
                {
                    workSheet.Cells[tempLineNumber, "C"] = line.Replace("\n", "").Replace("\r", "");
                    tempLineNumber++;
                }

                // 미해결(계속 진행) 사항
                contents = textBox_Unsolved[i].Text.Split('\n');
                tempLineNumber = curLineNumber;
                foreach (var line in contents)
                {
                    workSheet.Cells[tempLineNumber, "H"] = line.Replace("\n", "").Replace("\r", "");
                    tempLineNumber++;
                }

                curCellHeight = Math.Max(3, curCellHeight);

                // 경계선 (사이드)
                for (int j = curLineNumber; j < curLineNumber + curCellHeight; j++)
                {
                    workSheet.Cells.Range["B" + j.ToString() + ":K" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                    workSheet.Cells.Range["B" + j.ToString() + ":K" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                    workSheet.Cells.Range["B" + j.ToString() + ":B" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
                    workSheet.Cells.Range["H" + j.ToString() + ":H" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
                }

                curLineNumber += curCellHeight;
            }

            // 차주
            workSheet.Cells[curLineNumber, "B"] = "일자";
            workSheet.Cells[curLineNumber, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":B" + curLineNumber.ToString()].Font.Bold = true;    // Bold
            workSheet.Cells[curLineNumber, "C"] = "다음 1주간 개발 및 업무 계획";
            workSheet.Cells[curLineNumber, "C"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells.Range["C" + curLineNumber.ToString() + ":G" + curLineNumber.ToString()].Font.Bold = true;    // Bold
            workSheet.Cells[curLineNumber, "H"] = "기타";
            workSheet.Cells[curLineNumber, "H"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells.Range["H" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Font.Bold = true;    // Bold

            // 날짜, 요일 기록
            workSheet.Cells[curLineNumber + 1, "B"] = string.Format("{0:MM/dd}", submitTime.AddDays(3));
            workSheet.Cells[curLineNumber + 2, "B"] = $"({DayOfTheWeek[0]})";
            workSheet.Cells[curLineNumber + 3, "B"] = "~";
            workSheet.Cells[curLineNumber + 4, "B"] = string.Format("{0:MM/dd}", submitTime.AddDays(7));
            workSheet.Cells[curLineNumber + 5, "B"] = $"({DayOfTheWeek[4]})";
            workSheet.Cells[curLineNumber + 1, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[curLineNumber + 2, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[curLineNumber + 3, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[curLineNumber + 4, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬
            workSheet.Cells[curLineNumber + 5, "B"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // 가운데 정렬

            // 경계선 (헤더 2)
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":K" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
            workSheet.Cells.Range["B" + curLineNumber.ToString() + ":B" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
            workSheet.Cells.Range["H" + curLineNumber.ToString() + ":H" + curLineNumber.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;

            textBox_lineCount1 = textBox_NextWeek_Plan.Text.Count(f => (f == '\n'));
            textBox_lineCount2 = textBox_NextWeek_etc.Text.Count(f => (f == '\n'));
            curCellHeight = Math.Max(textBox_lineCount1, textBox_lineCount2);

            // 다음 1주간 개발 및 업무 계획
            contents = textBox_NextWeek_Plan.Text.Split('\n');
            tempLineNumber = curLineNumber + 1;
            foreach (var line in contents)
            {
                workSheet.Cells[tempLineNumber, "C"] = line.Replace("\n", "").Replace("\r", "");
                tempLineNumber++;
            }

            // 기타
            contents = textBox_NextWeek_etc.Text.Split('\n');
            tempLineNumber = curLineNumber + 1;
            foreach (var line in contents)
            {
                workSheet.Cells[tempLineNumber, "H"] = line.Replace("\n", "").Replace("\r", "");
                tempLineNumber++;
            }

            curCellHeight = Math.Max(6, curCellHeight);

            // 경계선 (사이드)
            for (int j = curLineNumber; j < curLineNumber + curCellHeight; j++)
            {
                workSheet.Cells.Range["B" + j.ToString() + ":K" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlMedium;
                workSheet.Cells.Range["B" + j.ToString() + ":K" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlMedium;
                workSheet.Cells.Range["B" + j.ToString() + ":B" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
                workSheet.Cells.Range["H" + j.ToString() + ":H" + j.ToString()].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
            }

            // 경계선 (하단)
            workSheet.Cells.Range["B" + (curLineNumber + curCellHeight - 1).ToString() + ":K" + (curLineNumber + curCellHeight - 1).ToString()].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlMedium;

            // 전체 굴림체로 설정
            Excel.Range range = workSheet.Range["A1", "Z100"];
            range.Font.Name = "굴림체";

            // 셀 병합
            curLineNumber += curCellHeight;
            for (int i = 5; i < curLineNumber; i++)
            {
                workSheet.Cells.Range["C" + i.ToString() + ":G" + i.ToString()].Merge();
                workSheet.Cells.Range["H" + i.ToString() + ":K" + i.ToString()].Merge();
            }

            // 열 너비 설정
            workSheet.Cells.Range["A1:A1"].ColumnWidth = 1.44;
            workSheet.Cells.Range["B1:B1"].ColumnWidth = 10;
            workSheet.Cells.Range["C1:C1"].ColumnWidth = 15.33;
            workSheet.Cells.Range["D1:D1"].ColumnWidth = 18.78;
            workSheet.Cells.Range["E1:E1"].ColumnWidth = 2.44;
            workSheet.Cells.Range["F1:F1"].ColumnWidth = 6.67;
            workSheet.Cells.Range["G1:G1"].ColumnWidth = 14;
            workSheet.Cells.Range["H1:H1"].ColumnWidth = 3.11;
            workSheet.Cells.Range["I1:I1"].ColumnWidth = 7.22;
            workSheet.Cells.Range["J1:J1"].ColumnWidth = 7.78;
            workSheet.Cells.Range["K1:K1"].ColumnWidth = 10;

            // 저장하고 닫기
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 파일 (*.xlsx)|*.xlsx|모든 파일 (*.*)|*.*";
            saveFileDialog.Title = "주간보고서 저장 저장";
            saveFileDialog.FileName = "연구소 주간 보고서(" + textBox_Name.Text + ")-" + string.Format("{0:yyyyMMdd}", submitTime) + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                // 리소스 해제
                releaseObject(workSheet);
                releaseObject(workbook);
                releaseObject(excelApp);

                MessageBox.Show("주간보고서 내용을 성공적으로 작성했습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel 파일 (*.xls; *.xlsx)|*.xls; *.xlsx|모든 파일 (*.*)|*.*";
            openFileDialog.Title = "Excel 파일 선택";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;       // 엑셀 프로그램 숨김
                excelApp.DisplayAlerts = false; // 경고 메시지를 표시하지 않음

                Excel.Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                Excel.Worksheet workSheet = (Excel.Worksheet)workbook.Sheets[1];    // 첫 번째 시트 선택

                TextBox[] textBox_Job = new TextBox[] { textBox_Mon_Job, textBox_Tue_Job, textBox_Wed_Job, textBox_Thu_Job, textBox_Fri_Job };
                TextBox[] textBox_Unsolved = new TextBox[] { textBox_Mon_Unsolved, textBox_Tue_Unsolved, textBox_Wed_Unsolved, textBox_Thu_Unsolved, textBox_Fri_Unsolved };

                // 제출일 가져오기
                object dateString = workSheet.Cells[2, 3].Value;

                try
                {
                    dateTimePicker_SubmitDate.Value = workSheet.Cells[2, 3].Value;

                    // 이름 가져오기
                    textBox_Name.Text = workSheet.Cells[3, 3].Value;

                    // 월요일부터 금요일까지 내용 가져오기
                    int[] eachLineNumber = new int[7];  // 월~금[0~4], 차주 정보가 있는 각각의 행 번호[5] (마지막[6]은 경계값)
                    int eachIndex = 1;
                    eachLineNumber[0] = 5;      // 월요일 정보가 있는 행 번호
                    eachLineNumber[6] = 500;    // 경계값
                    int curLineNumber = 7;      // 현재 가리키는 라인 번호

                    while ((curLineNumber < 500) && (eachIndex < 6))
                    {
                        object cellContent = workSheet.Cells[curLineNumber, 2].Value;
                        if (cellContent is DateTime)
                        {
                            eachLineNumber[eachIndex] = curLineNumber;
                            eachIndex++;
                            curLineNumber++;
                            continue;
                        }
                        else if ((cellContent is string) && ((string)cellContent != "일자"))
                        {
                            curLineNumber++;
                            continue;
                        }
                        else
                        {
                            curLineNumber++;
                            continue;
                        }
                    }

                    eachLineNumber[5]--;        // 금요일 정보에 대한 인덱스 임시로 1 차감 (경계값 역할)

                    // 가져오기: 업무 내용, 미해결(계속 진행) 사항
                    object leftTextBox_content, rightTextBox_content;
                    List<string> leftContents = new List<string>();
                    List<string> rightContents = new List<string>();
                    string leftContents_string;
                    string rightContents_string;

                    for (int i = 0; i < 5; i++)
                    {
                        leftContents_string = "";
                        rightContents_string = "";

                        for (int j = eachLineNumber[i]; j < eachLineNumber[i + 1]; j++)
                        {
                            // 가져오기: 업무 내용
                            leftTextBox_content = workSheet.Cells[j, 3].Value;
                            if (leftTextBox_content is string)
                                leftContents.Add(workSheet.Cells[j, 3].Value);

                            while(leftContents.Count() > 0)
                            {
                                leftContents_string += (leftContents[0] + "\r\n");
                                leftContents.RemoveAt(0);
                            }

                            // 가져오기: 미해결(계속 진행) 사항
                            rightTextBox_content = workSheet.Cells[j, 8].Value;
                            if (rightTextBox_content is string)
                                rightContents.Add(workSheet.Cells[j, 8].Value);

                            while (rightContents.Count() > 0)
                            {
                                rightContents_string += (rightContents[0] + "\r\n");
                                rightContents.RemoveAt(0);
                            }
                        }

                        textBox_Job[i].Text = leftContents_string;
                        textBox_Unsolved[i].Text = rightContents_string;
                    }

                    eachLineNumber[5]++;        // 금요일 정보에 대한 인덱스 원상복구

                    // 가져오기: 다음 1주간 개발 및 업무 계획, 기타
                    leftContents_string = "";
                    rightContents_string = "";

                    for (int j = eachLineNumber[5]; j < eachLineNumber[6]; j++)
                    {
                        // 가져오기: 업무 내용
                        leftTextBox_content = workSheet.Cells[j, 3].Value;
                        if (leftTextBox_content is string)
                            leftContents.Add(workSheet.Cells[j, 3].Value);

                        while (leftContents.Count() > 0)
                        {
                            leftContents_string += (leftContents[0] + "\r\n");
                            leftContents.RemoveAt(0);
                        }

                        // 가져오기: 미해결(계속 진행) 사항
                        rightTextBox_content = workSheet.Cells[j, 8].Value;
                        if (rightTextBox_content is string)
                            rightContents.Add(workSheet.Cells[j, 8].Value);

                        while (rightContents.Count() > 0)
                        {
                            rightContents_string += (rightContents[0] + "\r\n");
                            rightContents.RemoveAt(0);
                        }
                    }

                    textBox_NextWeek_Plan.Text = leftContents_string;
                    textBox_NextWeek_etc.Text = rightContents_string;

                    MessageBox.Show("주간보고서 내용을 성공적으로 가져왔습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("잘못된 형식의 날짜 문자열입니다.");

                    // 엑셀 어플리케이션 및 워크북 닫기
                    workbook.Close();
                    excelApp.Quit();

                    // 리소스 해제
                    releaseObject(workSheet);
                    releaseObject(workbook);
                    releaseObject(excelApp);
                }

                // 엑셀 어플리케이션 및 워크북 닫기
                workbook.Close();
                excelApp.Quit();

                // 리소스 해제
                releaseObject(workSheet);
                releaseObject(workbook);
                releaseObject(excelApp);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("객체 해제 중 오류 발생: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ModalessForm_HelpInfo = new Form();
            ModalessForm_HelpInfo.Show();

            ModalessForm_HelpInfo.Text = "도움말 - 주간보고서 코드명";
            ModalessForm_HelpInfo.Size = new System.Drawing.Size(600, 300);

            TextBox TextBox_helpText = new TextBox();
            TextBox_helpText.Enabled = true;
            TextBox_helpText.Multiline = true;
            TextBox_helpText.Height = 200;
            TextBox_helpText.Width = 500;
            TextBox_helpText.Location = new System.Drawing.Point(25, 25);
            TextBox_helpText.Name = "textBox_helpText";
            TextBox_helpText.Text =
                "예시)\r\n" +
                "1. [DRO][Plan_Study] for 보호구역 실태조사 프로그램\r\n" +
                "  - 회의: 기술서 작성 검토\r\n" +
                "\r\n" +
                "- 프로젝트 코드: MH01, MH02, DRO, 3DV, 3DE, AI_CE\r\n" +
                "- 1차 작업 코드: Plan(계획) - Development(개발) - Check(확인) - Amend(수정)\r\n" +
                "- 2차 작업 코드: \r\n" +
                "  Plan: Study, Research, Documentation\r\n" +
                "  Development: 없음\r\n" +
                "  Check: Study, Research, Documentation\r\n" +
                "  Amend: Plan, Development\r\n";

            ModalessForm_HelpInfo.Controls.Add(TextBox_helpText);
        }
    }
}
