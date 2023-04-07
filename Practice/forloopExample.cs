using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using System.Collections;

namespace Practice
{
    internal static class forloopExample
    {
        public static void forExamp()
        {
            List<int> data = new List<int>();
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);

            //foreach (var e in data)
            //{
            //    data.Remove(e);
            //}
            //data.ForEach(e => data.Remove(e));
            
            var grupoXindices = data.GroupBy(i => (i % 2) == 0);
            var test = data.Where(i => (i % 2) == 0);
        }
    }
}
