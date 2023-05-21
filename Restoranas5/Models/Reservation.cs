using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restoranas5.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Request { get; set; }



    }
}
