﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeetySoft.Model
{
    public class Project
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Project: {0}", Name);
        }
    }
}
