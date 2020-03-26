using System;
using System.Collections.Generic;

namespace UserListAPI.Models
{
    public partial class ShorelineUsers
    {
        public int? PhoneExt { get; set; }
        public string PhoneName { get; set; }
        public bool ExcludeFromDialByName { get; set; }
        public int? Dntype { get; set; }
        public string Didnumber { get; set; }
    }
}
