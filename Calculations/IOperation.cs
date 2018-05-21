using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Calculations
{
    public interface IOperation
    {

        decimal Calculate();
    }
}
    
