using System.Collections.Specialized;

namespace DrasticBomb.Models
{
    public class BaseFilters
    {
        public int Offset { get; set; } = 0;

        public int Limit { get; set; } = 100;

        public virtual NameValueCollection ToNameValueCollection()
        {
            if (this.Limit > 100)
            {
                throw new ArgumentOutOfRangeException("limit must be less than 100");
            }

            var nvc = new NameValueCollection();
            nvc.Add("offset", this.Offset.ToString());
            nvc.Add("limit", this.Limit.ToString());
            return nvc;
        }
    }
}
