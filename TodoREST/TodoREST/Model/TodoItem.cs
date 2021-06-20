using System;
using System.Collections.Generic;
using System.Text;

namespace TodoREST.Model
{
    public class TodoItem
    {
        public String ID { get; set; }

        public String Name { get; set; }

        public String Notes { get; set; }
        
        public String Done { get; set; }

    }
}
