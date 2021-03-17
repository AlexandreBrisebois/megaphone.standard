using System;

namespace Megaphone.Standard.Time
{
    public class UtcClock : IClock
    {
        public DateTimeOffset Now => DateTimeOffset.UtcNow;
    }
}
