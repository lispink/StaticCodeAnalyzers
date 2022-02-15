using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCodeAnalysisPackageConfig
{
    public class Class1
    {
        Disposable disposable;

        public Class1()
        {
            disposable = new Disposable();
        }
        public void test()
        {
            var thing = new Disposable();

        }
    }

    public class Disposable : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
