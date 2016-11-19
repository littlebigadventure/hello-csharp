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
        public User CreatedBy { get; set; }
        public int ID { get; private set; }
        public Defect()
        {
            ID = Sequences.Next();
        }
        public override string ToString()
        {
            return string.Format("{0,2}: {1}\r\n    ({2:d}-{3:d}, {4}/{5}, {6} -> {7})",
                 ID, Summary, Created, LastModified, Severity, Status, CreatedBy.Name,
                 AssignedTo == null ? "n/a" : AssignedTo.Name);
        }

    }
}
