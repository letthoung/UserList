using System;
using System.Collections.Generic;

namespace UserListAPI.Models
{
    public partial class UserList
    {
        public int Id { get; set; }
        public string Uname { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Ext { get; set; }
        public string Didnumber { get; set; }
        public string PhoneCell { get; set; }
    }
}
