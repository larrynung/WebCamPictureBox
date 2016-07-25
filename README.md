Webcam PictureBox
================

Webcam PictureBox Control

[![Build status](https://ci.appveyor.com/api/projects/status/0e1qusutkfgq04rx?svg=true)](https://ci.appveyor.com/project/larrynung/webcampicturebox)

Test webcam connection

    if (this.webCamPictureBox1.TestConnect())
    {
      MessageBox.Show("WebCam connect state is ok");
    }
    else
    {
      MessageBox.Show("WebCam connect state is error");
    }


Connect to webcam

    this.webCamPictureBox1.Start();


Disconnect to webcam

    this.webCamPictureBox1.Stop();


Distinguish webcam is connected or not

    this.toolStripStatusLabel2.Text = this.webCamPictureBox1 .IsStarted?"Start":"Stop";


Reference
---------
* [[Control][C#]WebCamPictureBox Control - Level Up- 點部落](http://www.dotblogs.com.tw/larrynung/archive/2009/03/29/7750.aspx)
