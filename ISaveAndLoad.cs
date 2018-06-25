using System;
using System.Collections.Generic;
using System.Text;

namespace AptekaN
{
    interface ISaveAndLoad
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}
