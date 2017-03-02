using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMotionMiami.Core.Model {
    public class WrapGroup {
        public int WrapGroupID { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<Wrap> Wraps { get; set; }
    }
}
