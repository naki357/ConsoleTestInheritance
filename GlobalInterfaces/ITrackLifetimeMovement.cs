using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToddCorp.GlobalInterfaces
{
    public interface ITrackLifetimeMovement
    {
        float LifetimeMetersMoved { get; set; }
        float LifetimeSecondsOperated { get; set; }

        void TrackLifetimeMovement(float metersMoved, float secondsElapsed);
    }
}
