using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Using IDisposable and finalization on the same object.
/// </summary>
namespace ProgrammingInCSharp.Chapter2
{
    class ResourceHolder : IDisposable
    {
        // Flag to indicate whenn the object has been disposed.
        bool disposed = false;

        public void Dispose()
        {
            // Call dispose and tell it that it is being called from a Dispose call.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            // Give up if already disposed.
            if (disposed) return;

            if (disposing)
            {
                // free any managed objects here.
            }

            // Free any unmanaged objects here.
        }

        ~ResourceHolder()
        {
            // Dispose only of unmanaged objects.
            Dispose(false);
        }
    }


    class Listening2_65
    {
        public static void Listening2_65Main()
        {
            ResourceHolder r = new ResourceHolder();
            r.Dispose();
        }
    }
}
