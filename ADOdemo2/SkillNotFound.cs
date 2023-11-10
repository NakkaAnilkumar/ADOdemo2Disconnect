using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedDemo
{


    [Serializable]
    public class SkillNotFoundException : Exception
    {
        public SkillNotFoundException() { }
        public SkillNotFoundException(string message) : base(message) { }
        public SkillNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected SkillNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}