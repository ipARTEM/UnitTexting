using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShoppingCartLibrary
{
    [Serializable]
    public class ShoppingCart : IDisposable
    {
        public List<Item> Items = new List<Item>();

        public int Count
        {
            get { return Items.Count; }
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }                                                                                    


        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }
    }
}