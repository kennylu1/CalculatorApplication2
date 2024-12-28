using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
     class TempIsZeroException:ApplicationException
    {
        public TempIsZeroException(string message):base(message) { }
    }
}/*TempIsZeroException 類 繼承了 ApplicationException，這是一個 C# 提供的內建異常類型。*/
