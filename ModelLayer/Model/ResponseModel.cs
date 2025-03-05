﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Model
{
    public class ResponseModel<T>
    //we r using smd
    {

        public bool Success { get; set; } = false;
        public string Message { get; set; } = "";
        public T Data { get; set; } = default(T);
    }
}