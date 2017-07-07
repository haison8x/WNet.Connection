using System.IO;
using System.Net;

namespace WNet.Connection
{
    public interface NetworkFile
    {
        byte[] ReadAllBytes(string username, string password, string filePath);
    }

    public class NetworkFileImp : NetworkFile
    {
        public byte[] ReadAllBytes(string username, string password, string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            var networkCredential = new NetworkCredential(username, password);
            using (new NetworkConnection(directory, networkCredential))
            {
                return File.ReadAllBytes(filePath);
            }
        }
    }
}
