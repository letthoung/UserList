using System;
using System.Collections.Generic;

namespace UserListAPI.Models
{
    public partial class PhoneNumbers
    {
        public int Id { get; set; }
        public string PhoneName { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
    }
}
