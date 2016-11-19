using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeetySoft.Model
{
    public class Defect
    {
        public Project Project { get; set; }
        public User AssignedTo { get; set; }
        public string Summary { get; set; }
        public Severity Severity { get; set; }
        public Status Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public int ID { get; private set; }
            
    }
}
