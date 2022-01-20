using System;
using System.IO;

namespace Vullis
{
    public class UnmanagedRes : IDisposable
    {
        private static bool isOpen = false;
        private FileStream file;

        public void Open()
        {
            if (!isOpen)
            {
                System.Console.WriteLine("Openen....");
                isOpen = true;
                file = File.Create(@"D:\bla.txt");
            }
            else
            {
                System.Console.WriteLine("Jammer dan. Al in gebruik");
            }
        }
        public void Close()
        {
            System.Console.WriteLine("Closing...");
            isOpen = false;
        }

        public virtual void RuimOp(bool fromDispose)
        {
            Close();
            if (fromDispose)
            {
                file.Dispose();
            }
        }
        
        public void Dispose()
        {
            RuimOp(true);
            GC.SuppressFinalize(this);
        }
        ~UnmanagedRes()
        {
            RuimOp(false);
        }
    }
}