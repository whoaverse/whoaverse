﻿using System;
using System.Collections.Generic;
using System.Text;
using Voat.Common;

namespace Voat.Logging
{
    public abstract class QueuedLogger : BaseLogger
    {
        private int _threshold = 5;
        private BatchOperation<ILogInformation> _batchProcessor = null;

        public QueuedLogger() : this(1, TimeSpan.Zero, LogType.All)
        {

        }
        public QueuedLogger(int flushCount, TimeSpan flushSpan, LogType logLevel) : base(logLevel)
        {
            _batchProcessor = new MemoryBatchOperation<ILogInformation>(flushCount, flushSpan, ProcessBatch);

        }
        protected abstract void ProcessBatch(IEnumerable<ILogInformation> batch);

        protected override void ProtectedLog(ILogInformation info)
        {
            _batchProcessor.Add(info);
        }
    }
}
