﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.ServiceHost;

namespace AxRest.AddressState.ServiceModel
{
    [RestService("/address")]
    [RestService("/address/{Id}")]
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}