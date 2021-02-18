﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace SOS.FMS.Client.Services
{
    public class TimerService
    {
        private Timer _timer;

        public void SetTimer(double interval)
        {
            _timer = new Timer(interval);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
            //_timer.Dispose();
        }
        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
