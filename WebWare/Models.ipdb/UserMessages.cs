using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UserMessages
    {
        public UserMessages()
        {
            CartableLetters = new HashSet<CartableLetters>();
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public int SmailId { get; set; }
        public int InstanceIs { get; set; }

        public ICollection<CartableLetters> CartableLetters { get; set; }
    }
}
