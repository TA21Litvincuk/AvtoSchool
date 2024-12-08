using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DrivingSchool.Services
{
    public class Repository<T>
    {
        private List<T> _items = new();

        public void Add(T item) => _items.Add(item);
        public IEnumerable<T> GetAll() => _items;
    }
}

