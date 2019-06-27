using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Camera
    {
        private VideoCaptureDevice camera;
        public Camera()
        {
            FilterInfoCollection videoDevices= new FilterInfoCollection(FilterCategory.VideoInputDevice);//寻找所有的摄像机
            if(videoDevices==null || videoDevices.Count <= 0)
            {
                camera = null;
            }
            else
            {
                camera = new VideoCaptureDevice(videoDevices[0].MonikerString);//选择其中一个摄像机作为源
                camera.VideoResolution = camera.VideoCapabilities[0];//分辨率
            }
           
        }
        public VideoCaptureDevice getCamera()
        {
            return camera;
        }
        public int getWidth()
        {
            return camera.VideoResolution.FrameSize.Width;
        }
        public int getHeight()
        {
            return camera.VideoResolution.FrameSize.Height;
        }
        public int getFrameRate()
        {
            //return camera.VideoResolution.AverageFrameRate;
            return 11;
        }
        public void Start()
        {
            camera.Start();
        }
        public void Stop()
        {
            camera.Stop();
        }
        public Boolean isRun()
        {
            return camera.IsRunning;
        }
        
    }
}
