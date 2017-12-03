using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint
{
    public  static class Sound
    {
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.fail);
        static SoundPlayer soundWin = new SoundPlayer(Properties.Resources.win);
        static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.key);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.start);
        static bool soundEnabled = true;
       
        public static void PlayFail()
        {
            if(soundEnabled)
               soundFail.Play();
        }
        public static void PlayWin()
        {
            if (soundEnabled)
                soundWin.Play();
        }
        public static void PlayKey()
        {
            if (soundEnabled)
                soundKey.Play();
        }
        public static void PlayStart()
        {
            if (soundEnabled)
                soundStart.Play();
        }
        public static void SoundOn()
        {
            soundEnabled = true;
        }
        public static void SoundOff()
        {
            soundEnabled = false;
        }
    }
    
}
