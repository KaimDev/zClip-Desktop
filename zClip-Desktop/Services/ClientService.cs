﻿using System;
using System.ComponentModel;
using zClip_Desktop.CustomEventArgs;
using zClip_Desktop.Interfaces;

namespace zClip_Desktop.Services
{
    public class ClientService : IClientService
    {
        public event EventHandler<ClientEventArgs> OnClientChange;

        private BackgroundWorker _backgroundWorker = new BackgroundWorker();
        
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void SendClipboardContent()
        {
            throw new NotImplementedException();
        }

        public void TestForTargetConnection()
        {
            throw new NotImplementedException();
        }
    }
}