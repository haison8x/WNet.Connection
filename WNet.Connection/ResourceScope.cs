/// <summary>
/// https://gist.github.com/AlanBarber/92db36339a129b94b7dd
/// </summary>
/// 

namespace WNet.Connection
{
    public enum ResourceScope
    {
        None = 0,

        /// <summary>
        /// The connected.
        /// </summary>
        Connected = 1,

        /// <summary>
        /// The global network.
        /// </summary>
        GlobalNetwork,

        /// <summary>
        /// The remembered.
        /// </summary>
        Remembered,

        /// <summary>
        /// The recent.
        /// </summary>
        Recent,

        /// <summary>
        /// The context.
        /// </summary>
        Context
    }
}
