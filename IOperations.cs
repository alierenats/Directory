using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    internal interface IOperations
    {
        public void Save() { }

        public void Delete() { }

        public void Show() { }

        public void Update() { }

        public void Search() { }
    }
}
