using System;

namespace Chalenge1.Utils {

    public static class ArrayExtend {
        public static string spin(this string[] arr)
        {
            return arr[(new Random()).Next(arr.Length)];
        } 
    }

}
