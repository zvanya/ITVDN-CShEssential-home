using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Player : IPlayable, IRecodable
  {
    private string fileName = null;

    enum State
    {
      Playing,
      Paused,
      Stopping,
      Recording
    }

    State st;

    public Player(string filename)
    {
      this.fileName = fileName;
    }

    public void Play()
    {
      Console.WriteLine("Play {0}", fileName);
      st = State.Playing;
    }

    void IPlayable.Pause()
    {
      Console.WriteLine("Pause {0}", fileName);
      st = State.Paused;
    }

    void IPlayable.Stop()
    {
      Console.WriteLine("Stop {0}", fileName);
      st = State.Stopping;
    }

    void IRecodable.Pause()
    {
      Console.WriteLine("Pause {0}", fileName);
      st = State.Paused;
    }

    void IRecodable.Stop()
    {
      Console.WriteLine("Stop {0}", fileName);
      st = State.Stopping;
    }

    public void Record()
    {
      Console.WriteLine("Record {0}", fileName);
      st = State.Recording;
    }

  }
}
