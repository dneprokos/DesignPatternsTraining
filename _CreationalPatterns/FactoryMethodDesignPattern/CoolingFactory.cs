﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.FactoryMethod
{
    public class CoolingFactory: AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Cooling(temperature);
    }
}