﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPanel.Model
{
    public class Task : BaseItem
    {
        public string Name { get; set; }
        public string Repeats { get; set; }
        public bool IsCompleted { get; set; }
    }
}
