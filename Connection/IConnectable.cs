using System;
using System.Collections.Generic;
using System.Text;

namespace SizzlingHot
{
    interface IConnectable
    {
        void CloseConnection();
        bool ConnectDB(string user, string password);
        bool TryConnection();
    }
}
