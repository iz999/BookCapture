using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using NLog;

namespace BookCapture
{
    public partial class BookCaptureMainForm : Form
    {
        private Point startPosition;
        private Point mousePosition;

        private Rectangle captureTarget;

        private bool captureProcessStart = false;
        private bool captureMouseDown = false;
        private bool captureMouseMove = false;
        private bool captureTargetSet = false;
        private bool captureMacroStart = false;

        private bool mousePostionSetting = false;

        private string targetWindowName;
        private string targetWindowPID;

        private ProcessSwiching processSwiching = new ProcessSwiching(Process.GetCurrentProcess());

        private static Logger logger = LogManager.GetCurrentClassLogger();        

        private Size mainFormSize;
        private Point mainFormPosition;
        private Timer macroTimer = new Timer();
        private int timerCount = 0;
        private CaptureBoxForm captureBoxForm = new CaptureBoxForm();
        private PdfMaker pdfMaker;

        private Bitmap prevBmap = null; // 빈 비트맵 생성

        enum MacroMode
        {
            KeyMode,
            MouseMode
        }

        private MacroMode macroMode;


        public BookCaptureMainForm()
        {
            InitializeComponent();
            InitializeCapturing(); // 캡쳐 기능 초기화
        }

        private Rectangle CreateRectangle()
        {
            Rectangle captureBox = new Rectangle(Math.Min(startPosition.X, mousePosition.X), Math.Min(startPosition.Y, mousePosition.Y), Math.Abs(startPosition.X - mousePosition.X), Math.Abs(startPosition.Y - mousePosition.Y));
            return captureBox;
        }

        

        private void PbCaptureBox_MouseDown(object sender, MouseEventArgs e) // 영역그리기 시작
        {
            if (captureProcessStart)
            {
                startPosition = e.Location;
                mousePosition = e.Location;

                captureMouseDown = true;
            }
        }

        private void PbCaptureBox_Paint(object sender, PaintEventArgs e) //영역그리기
        {
            if (captureProcessStart && captureMouseDown)
            {
                Pen redPen = new Pen(Color.Red, 1);

                Rectangle redBox = CreateRectangle();

                e.Graphics.DrawRectangle(redPen, redBox);
            }
        }

        private void PbCaptureBox_MouseMove(object sender, MouseEventArgs e) //영역그리는 중
        {
            if (captureProcessStart && captureMouseDown)
            {
                mousePosition = e.Location;

                captureMouseMove = true;
                PbCaptureBox.Invalidate();
            }
        }

        private void PbCaptureBox_MouseUp(object sender, MouseEventArgs e) //영역 지정 완료
        {
            PbCaptureBox.Invalidate();

            captureTargetSet = false;

            if (captureProcessStart && captureMouseDown && captureMouseMove)
            {
                try
                {
                    Rectangle capturedImgBox = CreateRectangle();

                    Bitmap capturedImgBitMap = new Bitmap(capturedImgBox.Width - 1, capturedImgBox.Height - 1);

                    Graphics capturedImgCanvas = Graphics.FromImage(capturedImgBitMap);
                    capturedImgCanvas.CopyFromScreen(capturedImgBox.Left + 1, capturedImgBox.Top + 1, 0, 0, capturedImgBitMap.Size);

                    PbCapturedImg.Image = capturedImgBitMap;

                    captureTarget = new Rectangle(new Point(capturedImgBox.Left + 1, capturedImgBox.Top + 1), capturedImgBitMap.Size);
                    
                    captureTargetSet = true;

                    BtnStartCapture.BackColor = Color.Aquamarine;
                }
                catch (Exception ex)
                {
                    logger.Fatal("Exception Occured at MouseUp Process : " + ex.Message);
                    StopCapturing();
                }
                finally
                {
                    StopCapturing();
                }
            }
            
        }       

        private void BtnStartCapture_MouseClick(object sender, MouseEventArgs e) // 영역지정시작
        {
            PrepareCapture();
        }

        private void BookCaptureMainForm_Load(object sender, EventArgs e)
        {
            SystemFunction.KeyboardHookingStart(this); //후킹 프로세스 시작

            // 원래 Form 크기 저장
            mainFormPosition = new Point(this.Left, this.Top);
            mainFormSize = new Size(this.Width, this.Height);

        }

        private void BookCaptureMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemFunction.KeyboardHookingStop(); //후킹 종료
        }        

        public void StopCapturing()
        {
            if (captureProcessStart)
            {
                InitializeCapturing();
                MainFormRollBack();
            }

        }

        private void InitializeCapturing() //캡처 초기화
        {
            PbCaptureBox.Invalidate();
            PbCaptureBox.Location = new Point(0, 0);
            PbCaptureBox.Size = new Size(0, 0);
            PbCaptureBox.Visible = false;

            captureProcessStart = false;
            captureMouseDown = false;
            captureMouseMove = false;

            PbCaptureBox.SendToBack();
        }

        private void MainFormRollBack() //메인폼 크기 원래대로
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Location = new Point(mainFormPosition.X, mainFormPosition.Y);
            this.Size = new Size(mainFormSize.Width, this.Height = mainFormSize.Height);
        }

        private void BtnCaptureProgram_Click(object sender, EventArgs e) // 대상 윈도우/프로세스 선택
        {
            SelectCaptureTargetForm selectCaptureTarget = new SelectCaptureTargetForm();

            if (selectCaptureTarget.ShowDialog() == DialogResult.OK)
            {
                targetWindowName = selectCaptureTarget.selectedWindowName;
                targetWindowPID = selectCaptureTarget.selectedWindowPID;

                TxtCaptureProgram.Text = selectCaptureTarget.selectedWindowName;                
            }

            //processSwiching = new ProcessSwiching(Process.GetCurrentProcess().Id, Process.GetProcessById(Int32.Parse(targetWindowPID)).Id);
        }

        private void BtnSaveFolder_Click(object sender, EventArgs e) //저장 폴더 선택
        {
            FolderBrowserDialog saveFolder = new FolderBrowserDialog();

            if (saveFolder.ShowDialog() == DialogResult.OK)
            {
                TxtSaveFolder.Text = saveFolder.SelectedPath;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e) //시작
        {
            if (captureTargetSet == true && TxtRepeatTime.Text != null && TxtSaveFolder.Text != null && TxtCaptureProgram != null && Int32.Parse(targetWindowPID) > 0)
            {
                if (TxtKeyValue.Text != null || TxtMousePosX.Text != null)
                {
                    captureBoxForm = new CaptureBoxForm();

                    captureBoxForm.Show();

                    captureBoxForm.Left = captureTarget.Left;
                    captureBoxForm.Top = captureTarget.Top;
                    captureBoxForm.Size = captureTarget.Size;
                    captureBoxForm.FormBorderStyle = FormBorderStyle.None;
                    captureBoxForm.BackColor = Color.Red;
                    captureBoxForm.TransparencyKey = Color.Violet;

                    Panel formCaptureBox = captureBoxForm.GetCaptureBox();

                    formCaptureBox.BackColor = captureBoxForm.TransparencyKey;
                    formCaptureBox.Location = new Point(1, 1);
                    formCaptureBox.Size = new Size(captureBoxForm.Width - 2, captureBoxForm.Height - 2);
                    formCaptureBox.Visible = true;


                    macroTimer = new Timer();
                    macroTimer.Interval = Int32.Parse(TxtDelayTime.Text);
                    macroTimer.Tick += new EventHandler(CaptureEvent);

                    BtnStart.BackColor = Color.Aquamarine;

                    pdfMaker = new PdfMaker(TxtSaveFolder.Text);

                    macroTimer.Start();
                }
                else
                {
                    MessageBox.Show("매크로 키 또는 마우스 위치가 지정되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (captureTargetSet == false)
                {
                    MessageBox.Show("지정된 영역이 없습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                if (TxtSaveFolder.Text == null)
                {
                    MessageBox.Show("폴더가 지정되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TxtDelayTime.Text == null)
                {
                    MessageBox.Show("지연시간이 정의되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TxtRepeatTime.Text == null)
                {
                    MessageBox.Show("반복횟수가 정의되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TxtKeyValue.Text == null)
                {
                    MessageBox.Show("매크로 키가 정의되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TxtCaptureProgram.Text == null)
                {
                    MessageBox.Show("캡처대상 윈도우가 선택되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Int32.Parse(targetWindowPID) <= 0)
                {
                    MessageBox.Show("캡처대상 윈도우가 선택되지 않았습니다.", "정보부족", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("매크로를 실행할 수 없습니다.", "실행불가", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void CaptureEvent(object sender, EventArgs e) //타이머 이벤트
        {
            captureMacroStart = true;            
            
            Bitmap capturedImg = captureBoxForm.CaptureImg();

            if (!CompareBitmap(prevBmap, capturedImg))
            {
                

                capturedImg.Save(TxtSaveFolder.Text + @"\" + DateTime.Now.ToString("yyyyMMddHHmmssffffff") + ".jpg", ImageFormat.Jpeg);

                MemoryStream stream = new MemoryStream();
                capturedImg.Save(stream, ImageFormat.Bmp);
                pdfMaker.AddPdfPage(stream.ToArray());


                PbCapturedImg.Image = capturedImg;

                timerCount++;

                TxtRepeatCnt.Text = timerCount.ToString();

                logger.Info("타이머 카운트 : " + timerCount.ToString());
            }

            prevBmap = capturedImg;

            /*capturedImg.Save(TxtSaveFolder.Text + @"\" + DateTime.Now.ToString("yyyyMMddHHmmssffffff") + ".jpg", ImageFormat.Jpeg);

            MemoryStream stream = new MemoryStream();
            capturedImg.Save(stream, ImageFormat.Bmp);
            pdfMaker.AddPdfPage(stream.ToArray());
            

            PbCapturedImg.Image = capturedImg;            
            
            timerCount++;

            TxtRepeatCnt.Text = timerCount.ToString();

            logger.Info("타이머 카운트 : " + timerCount.ToString());*/

            if (timerCount >= Int32.Parse(TxtRepeatTime.Text))
            {
                MacroTimerStop();       
            }
            else
            {
                processSwiching.Swiching(Process.GetProcessById(Int32.Parse(targetWindowPID)));

                logger.Info("processSwiching");

                if (macroMode == MacroMode.KeyMode)
                {
                    SystemFunction.VKeyPress(TxtKeyValue.Text);
                }
                else
                {
                    SystemFunction.VMouseClick(Int32.Parse(TxtMousePosX.Text), Int32.Parse(TxtMousePosY.Text));
                }

                processSwiching.Rollback();
            }
        }

        public void MacroTimerStop()
        {
            macroTimer.Stop();
            pdfMaker.ClosePdfFile();
            captureBoxForm.Dispose();
            timerCount = 0;
            TxtRepeatCnt.Text = timerCount.ToString();
            BtnStart.BackColor = SystemColors.ControlLight;
            captureMacroStart = false;
            prevBmap = null;
        }

        private void PrepareCapture() // 캡쳐 준비
        {
            captureProcessStart = true;

            Screen[] screens = Screen.AllScreens;

            int fullScreenWidth = 0;
            int fullScreenHeight = 0;

            for (int i = 0; i < screens.Length; i++)
            {
                fullScreenWidth += screens[i].Bounds.Width;
                fullScreenHeight += screens[i].Bounds.Height;
            }

            Rectangle fullScreenBox = new Rectangle(0, 0, fullScreenWidth, fullScreenHeight);
            Bitmap fullScreenBitMap = new Bitmap(fullScreenBox.Width, fullScreenBox.Height);

            Graphics fullScreenCanvas = Graphics.FromImage(fullScreenBitMap);
            fullScreenCanvas.CopyFromScreen(fullScreenBox.Left, fullScreenBox.Top, 0, 0, fullScreenBox.Size);


            //메인폼 스타일 조정
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = fullScreenBox.Width;
            this.Height = fullScreenBox.Height;
            this.Left = fullScreenBox.Left;
            this.Top = fullScreenBox.Top;

            PbCaptureBox.Image = fullScreenBitMap; // 전체 화면 캡쳐 이미지

            PbCaptureBox.Size = new Size(fullScreenBox.Width, fullScreenBox.Height);
            PbCaptureBox.Left = fullScreenBox.Left;
            PbCaptureBox.Top = fullScreenBox.Top;

            PbCaptureBox.Visible = true;

            PbCaptureBox.BringToFront();
        }

        private void TxtDelayTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void TxtRepeatTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }        

        public bool IsCaptureBoxDrawing() 
        {
            return captureProcessStart;
        }

        public bool IsCaptureMacroRunning() // 캡처매크로 동작 확인
        {
            return captureMacroStart;
        }

        private void BtnSetKey_Click(object sender, EventArgs e)
        {
            TxtKeyValue.BackColor = Color.FloralWhite;
            BtnSetKey.Enabled = false;
        }

        public bool IsSetKey() //매크로 설정모드
        {
            if (TxtKeyValue.BackColor == Color.FloralWhite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetPressedKey() // 설정된 키 보이기
        {
            TxtKeyValue.Text = SystemFunction.GetPressedKey().ToString();
            TxtKeyValue.BackColor = SystemColors.ControlLight;
            BtnSetKey.Enabled = true;
        }

        private void BookCaptureMainForm_LocationChanged(object sender, EventArgs e)
        {
            if (!captureProcessStart)
            {
                mainFormPosition = new Point(this.Left, this.Top);
            }
        }

        private void RdbModeSelect1_CheckedChanged(object sender, EventArgs e)
        {
            macroMode = MacroMode.KeyMode;
            BtnSetKey.Enabled = true;
            BtnSetKey.FlatStyle = FlatStyle.Popup;
            BtnSetMouseXY.Enabled = false;
            BtnSetMouseXY.FlatStyle = FlatStyle.Standard;
        }

        private void RdbModeSelect2_CheckedChanged(object sender, EventArgs e)
        {
            macroMode = MacroMode.MouseMode;
            BtnSetKey.Enabled = false;
            BtnSetKey.FlatStyle = FlatStyle.Standard;
            BtnSetMouseXY.Enabled = true;
            BtnSetMouseXY.FlatStyle = FlatStyle.Popup;
        }

        private void BtnSetMouseXY_Click(object sender, EventArgs e)
        {
            SystemFunction.MouseHookingStart();
            mousePostionSetting = true;
            this.TopMost = true;
        }

        public bool GetMousePostionSetting()
        {
            return mousePostionSetting;
        }

        public void SetMousePostionSetting(bool boolVal)
        {
            mousePostionSetting = boolVal;
            this.TopMost = false;
        }

        public void SetMousePosition(int x, int y)
        {
            TxtMousePosX.Text = x.ToString();
            TxtMousePosY.Text = y.ToString();
        }

        private bool CompareBitmap(Bitmap bMap1, Bitmap bMap2)
        {
            if (bMap1.Width == bMap2.Width && bMap1.Height == bMap2.Height)
            {
                for (int i = 0; i < bMap1.Width; i++)
                {
                    for (int j = 0; j <bMap1.Height; j++)
                    {
                        if (bMap1.GetPixel(i, j) != bMap2.GetPixel(i, j))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
