using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace DisableTskManager
{
    public partial class dTskM
    {
      
        public static void ToggleTaskManager(bool toggle)
        {
            Microsoft.Win32.RegistryKey HKCU = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey key = HKCU.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            key.SetValue("DisableTaskMgr", toggle ? 0 : 1, Microsoft.Win32.RegistryValueKind.DWord);
        }

    }
}
