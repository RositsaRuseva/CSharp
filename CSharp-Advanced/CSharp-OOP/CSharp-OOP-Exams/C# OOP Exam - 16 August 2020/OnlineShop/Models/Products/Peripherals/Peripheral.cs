﻿using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        protected Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.ConnectionType = connectionType;
        }
        //without private set
        public string ConnectionType { get; private set; }
        public override string ToString()
        {
            return base.ToString() + string.Format(SuccessMessages.PeripheralToString, this.ConnectionType);
        }
    }
}
