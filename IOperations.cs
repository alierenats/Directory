using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public interface IOperations
    {
        void Save();

        void Delete();

        void Show();

        void Update();

        void Search();
    }
}
