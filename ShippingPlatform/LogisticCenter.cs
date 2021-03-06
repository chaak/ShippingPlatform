﻿using System;

namespace ShippingPlatform
{
    public class LogisticCenter
    {
        public int id { get; set; }
        public String name { get; set; }
        public Address logisticCenterAddress { get; set; }
        public int logisticCenterAddressId { get; set; }
        public Route shippingRoute { get; set; }
        public int shippingRouteId { get; set; }
    }
}