﻿using System;
using DevExpress.ExpressApp.Xpo;

namespace LearnSaveAttachmentOnServer.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}
