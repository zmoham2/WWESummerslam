using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summerslam_App
{
    public partial class Human
    {
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }

    public partial class Man
    {
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public partial class Woman
    {
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
