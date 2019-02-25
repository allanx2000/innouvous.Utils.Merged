using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Innouvous.Utils.Merged45.MVVM45
{
    public class ViewModel : Innouvous.Utils.MVVM.ViewModel
    {
        private DataBucket.DataBucket bucket = new DataBucket.DataBucket();

        public T Get<T>([CallerMemberName] string name = "")
        {
            return bucket.Get<T>(name);
        }

        public void Set(object value, [CallerMemberName] string name = "")
        {
            bucket.Set(name, value);
        }
    }
}
