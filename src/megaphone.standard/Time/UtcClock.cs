using System;

namespace Megaphone.Standard.Time
{
    public class UtcClock : IClock
    {
        public DateTimeOffset Now
        {
            get
            {
                return DateTimeOffset.UtcNow;
            }
        }
    }
}
