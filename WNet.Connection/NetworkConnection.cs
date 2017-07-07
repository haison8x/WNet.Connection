/// <summary>
/// https://gist.github.com/AlanBarber/92db36339a129b94b7dd
/// </summary>
/// 
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

namespace WNet.Connection
{
    public class NetworkConnection : IDisposable
    {
        private readonly string networkName;

        public NetworkConnection(string networkName, NetworkCredential credentials)
        {
            this.networkName = networkName;

            var netResource = new NetResource()
            {
                Scope = ResourceScope.GlobalNetwork,
                ResourceType = ResourceType.Disk,
                DisplayType = ResourceDisplaytype.Share,
                RemoteName = networkName
            };

            var cancelResultCode = WNetCancelConnection2(this.networkName, 0, true);
            var connectResultCode = WNetAddConnection2(
                netResource,
                credentials.Password,
                credentials.UserName,
                0);

            if (connectResultCode != 0)
            {
                var message = $"Error when connect to remote share. networkName: {networkName}."
                    + "WNetAddConnection2: {connectResultCode}. WNetCancelConnection2: {cancelResultCode}";
                throw new Win32Exception(connectResultCode, message);
            }
        }

        ~NetworkConnection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            WNetCancelConnection2(networkName, 0, true);
        }

        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource, string password, string username, int flags);

        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags, bool force);
    }
}
