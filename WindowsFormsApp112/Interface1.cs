using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp112
{
    public interface IEmployee
    {

        string FirstName
        {
            get;
            set;
        }
        string lastName
        {
            get;
            set;
        }

        string Concatinate();
    }
}

