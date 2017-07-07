/// <summary>
/// https://gist.github.com/AlanBarber/92db36339a129b94b7dd
/// </summary>
/// 
using System.Runtime.InteropServices;
namespace WNet.Connection
{
    [StructLayout(LayoutKind.Sequential)]
    public class NetResource
    {
        /// <summary>
        /// Resource scope.
        /// </summary>
        public ResourceScope Scope { get; set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Display type.
        /// </summary>
        public ResourceDisplaytype DisplayType { get; set; }

        /// <summary>
        /// The usage.
        /// </summary>
        public int Usage { get; set; }

        /// <summary>
        /// The local name.
        /// </summary>
        public string LocalName { get; set; }

        /// <summary>
        /// The remote name.
        /// </summary>
        public string RemoteName { get; set; }

        /// <summary>
        /// The comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// The provider.
        /// </summary>
        public string Provider { get; set; }
    }
}
