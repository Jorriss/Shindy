using System;

namespace Shindy.Core.Entities
{
    public class Speaker
    {
        public int SessionPersonID { get; set; }
        public int SessionID { get; set; }
        public int PersonID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public virtual Person Person { get; set; }
        public virtual Session Session { get; set; }
    }
}
