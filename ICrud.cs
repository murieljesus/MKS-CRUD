using System;
using System.Collections.Generic;
using System.Text;

namespace MKcrud
{
    interface ICrud
    {
        public void Create();
        public void Get(int id);
        public void Update(int id);
        public void Delete(int id);

    }
}
