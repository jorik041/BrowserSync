﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace BrowserSync
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", VERSION, IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.guidEnableSyncCommandPackageString)]
    public sealed class VSPackage : Package
    {
        public const string VERSION = "1.0";
        public const string NAME = "Browser Sync";

        protected override void Initialize()
        {
            Logger.Initialize(this, NAME);
            Telemetry.Initialize(this, VERSION, "5f7a8b5c-b600-46df-9014-b4cadd33d146");

            EnableSyncCommand.Initialize(this);

            base.Initialize();
        }
    }
}
