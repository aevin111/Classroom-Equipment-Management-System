using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    //A single Interface for all operations. 
    //This uses the Builder Pattern without the Director (the client can act as the director, anyways)
    public interface IFileController
    {
        void ControlFile();
    }
}
