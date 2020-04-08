using System;
using System.Threading;

namespace Cases.Framework
{
    public static class Wait
    {
        public static bool WaitFor(Func<bool> func, int millisecondsTimout = 250, int waitInterval = 50)
        {
            DateTime start = DateTime.Now;
            do
            {
                if(func())
                    return true;
			
                Thread.Sleep(waitInterval);
            }
            while (DateTime.Now - start < TimeSpan.FromMilliseconds(millisecondsTimout));
		
            return false;
        }	
    }
}