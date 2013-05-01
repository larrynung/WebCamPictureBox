using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebCamPictureBox
{
    [Browsable(true), Description("WebCam PictureBox"), ToolboxBitmap(typeof(WebCamPictureBox), "WebPictureBox.jpg")]
    public class WebCamPictureBox : PictureBox
    {

        #region API Declarations
        [DllImport("user32", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
        public static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);
        #endregion


        #region API Constants
        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GET_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;
        #endregion


        #region Delegate
        public delegate void WebCamConnectStateChangingEventHandler(object sender, EventArgs e);
        public delegate void WebCamConnectStateChangedEventHandler(object sender, EventArgs e);
        #endregion


        #region Var
        private int _CapHwnd;
        private Timer _Timer = new Timer();
        private bool _bIsStart;
        private IDataObject _tempObj;
        #endregion



        #region Private Property
        /// <summary>
        /// Gets or sets a value indicating whether is started.
        /// </summary>
        /// <value><c>true</c> if is started; otherwise, <c>false</c>.</value>
        public bool m_bIsStarted
        {
            get { return _bIsStart; }
            set 
            {
                if (_bIsStart != value){
                OnWebCamConnectStateChanging(new EventArgs());
                _bIsStart = value;
                OnWebCamConnectStateChanged(new EventArgs());
                }
            }

        }
        #endregion




        #region Control Properties

        /// <summary>
        /// The time intervale between frame captures
        /// </summary>
        [Browsable(true), Description("WebCam抓取間隔")]
        public int CaptureInterval
        {
            get
            { return _Timer.Interval; }

            set
            { _Timer.Interval = value; }
        }


        [Browsable(true), Description("是否已啟動WebCam")]
        public bool IsStarted
        {
            get { return m_bIsStarted; }

        }

        #endregion



        #region Event
        public event WebCamConnectStateChangingEventHandler WebCamConnectStateChanging;
        public event WebCamConnectStateChangedEventHandler WebCamConnectStateChanged;
        #endregion



        #region Constructer & Destructer
        public WebCamPictureBox()
        {
            _Timer.Tick += new EventHandler(timer1_Tick);
            _Timer.Interval = 100;
            // setup a capture window
            _CapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, this.Width, this.Height, this.Handle.ToInt32(), 0);
        }
        #endregion




        #region Protected Method
        /// <summary>
        /// Raises the <see cref="E:WebCamConnectStateChanging"/> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void OnWebCamConnectStateChanging(EventArgs e)
        {
            if (WebCamConnectStateChanging != null)
                WebCamConnectStateChanging(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:WebCamConnectStateChanged"/> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void OnWebCamConnectStateChanged(EventArgs e)
        {
            if (WebCamConnectStateChanged != null)
                WebCamConnectStateChanged(this, e);
        }
        #endregion



        #region Public Method
        /// <summary>
        /// Tests the connect.
        /// </summary>
        /// <returns></returns>
        public bool TestConnect()
        {
            try
            {
                SendMessage(_CapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(_CapHwnd, WM_CAP_DISCONNECT, 0, 0);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Starts the video capture
        /// </summary    
        public void Start()
        {
            try
            {
                // for safety, call stop, just in case we are already running
                this.Stop();

                m_bIsStarted = true;

                // connect to the capture device               
                SendMessage(_CapHwnd, WM_CAP_CONNECT, 0, 0);


            
                this._Timer.Start();
            }

            catch (Exception e)
            {
                MessageBox.Show("An error ocurred while starting the video capture. Check that your webcamera is connected properly and turned on.\r\n\n" + e.Message);
                this.Stop();
            }
        }





        /// <summary>
        /// Stops the video capture
        /// </summary>
        public void Stop()
        {
            // stop the timer
            m_bIsStarted = false;
          
            this._Timer.Stop();

            // disconnect from the video source              
            SendMessage(_CapHwnd, WM_CAP_DISCONNECT, 0, 0);


        }

        #endregion






        #region Event Process
        /// <summary>
        /// Capture the next frame from the video feed
        /// </summary>
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // pause the timer
                this._Timer.Stop();

                // get the next frame;
                SendMessage(_CapHwnd, WM_CAP_GET_FRAME, 0, 0);

                // copy the frame to the clipboard
                SendMessage(_CapHwnd, WM_CAP_COPY, 0, 0);


                // get from the clipboard
                _tempObj = Clipboard.GetDataObject();
                this.Image = (System.Drawing.Bitmap)_tempObj.GetData(System.Windows.Forms.DataFormats.Bitmap);



                // restart the timer               

                this._Timer.Start();
            }

            catch (Exception excep)
            {
                MessageBox.Show("An error ocurred while capturing the video image. The video capture will now be terminated.\r\n\n" + excep.Message);
                this.Stop(); // stop the process
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {

        }
        #endregion

        


    }
}
