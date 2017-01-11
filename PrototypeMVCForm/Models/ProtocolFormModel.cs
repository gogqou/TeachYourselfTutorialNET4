using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrototypeMVCForm.Models
{
    public class ProtocolFormModel
    {
        public string ProtocolTitle { get; set; }
        public int NumAnimals { get; set; }
        public string ProtocolOwnerName { get; set; }
        public string ProtocolBody { get; set; }
    }
}