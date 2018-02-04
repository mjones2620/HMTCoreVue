using System;

namespace HMTCoreVue.Models
{
    public class Email
    {
        public Email()
        { }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public DateTime? DesiredDate { get; set; }
    }
}