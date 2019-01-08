using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oizoMusicPlayerCsharp
{
    class MediaPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        [DllImport("winmm.dll")]
        public static extern long waveOutSetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern long waveOutGetVolume(IntPtr hwo, uint dwVolume);
    }
}
