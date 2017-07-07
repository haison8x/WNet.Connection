/// <summary>
/// https://gist.github.com/AlanBarber/92db36339a129b94b7dd
/// </summary>
/// 

namespace WNet.Connection
{
    public enum ResourceDisplaytype
    {
        /// <summary>
        /// The generic.
        /// </summary>
        Generic = 0x0,

        /// <summary>
        /// The domain.
        /// </summary>
        Domain = 0x01,

        /// <summary>
        /// The server.
        /// </summary>
        Server = 0x02,

        /// <summary>
        /// The share.
        /// </summary>
        Share = 0x03,

        /// <summary>
        /// The file.
        /// </summary>
        File = 0x04,

        /// <summary>
        /// The group.
        /// </summary>
        Group = 0x05,

        /// <summary>
        /// The network.
        /// </summary>
        Network = 0x06,

        /// <summary>
        /// The root.
        /// </summary>
        Root = 0x07,

        /// <summary>
        /// The share admin.
        /// </summary>
        Shareadmin = 0x08,

        /// <summary>
        /// The directory.
        /// </summary>
        Directory = 0x09,

        /// <summary>
        /// The tree.
        /// </summary>
        Tree = 0x0a,

        /// <summary>
        /// The NDS container.
        /// </summary>
        Ndscontainer = 0x0b
    }
}
