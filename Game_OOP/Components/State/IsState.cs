﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    interface IState
    {
        int CalculatePoints(int i);
        int CalculateForce(int i);
    }
}
