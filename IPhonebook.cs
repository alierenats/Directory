using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public interface IPhonebook
    {
        void Save();

        void Delete();

        void Show();

        void Update();

        void Search();
    }
}
