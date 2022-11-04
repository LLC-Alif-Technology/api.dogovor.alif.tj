using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TransferObjects
{
    public class ConvertInputsDTO
    {
        public string path { get; set; }
        public string inputName { get; set; }
        public string outputName { get; set; }
        public string format { get; set; }
    }
}
