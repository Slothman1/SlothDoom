using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth_Doom.Audio
{
    public interface IMusic
    {
        void StartMusic(Bgm bgm, bool loop);

        public int MaxVolume { get; }
        public int Volume { get; set; }
    }

    public interface ISound
    {
        //sound controls
        public void Update();
        public void Pause();
        public void Resume();
        public void Reset();

        //todo: impliment the mobj listeners and sounds

        public int MaxVolume { get; }
        public int Volume { get; set; }

    }
}
