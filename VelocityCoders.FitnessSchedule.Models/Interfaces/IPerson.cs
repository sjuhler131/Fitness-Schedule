using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.FitnessSchedule.Models
{
    public interface IPerson
    {
        string GetFullInfo();

        string Name { get; }
    }
}
