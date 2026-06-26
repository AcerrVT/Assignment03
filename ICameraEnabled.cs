using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    internal interface ICameraEnabled
    {
        //Only implemented by classes/objects capable of capturing images or videos using a camera.

        // Method to capture an image using the camera
        void CaptureImage();
    }
}
