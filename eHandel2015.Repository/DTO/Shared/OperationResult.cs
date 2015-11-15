using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository.DTO.Shared
{
    public class OperationResult
    {
        public string MessageResult { get; set; }
        public int ObjectId { get; set; }
        public object Object { get; set; }
        public bool Result { get; set; }
    }
}
