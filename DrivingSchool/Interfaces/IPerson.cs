using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DrivingSchool.Interfaces
{
    public interface IPerson
    {
        string Name { get; }
        void Introduce();
    }
}

