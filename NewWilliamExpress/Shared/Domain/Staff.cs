using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StaffName { get; set; }
        public string Staffpassword { get; set; }
        public string StaffEmailAddress { get; set; }

    }
}
