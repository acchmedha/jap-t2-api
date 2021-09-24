using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Models
{
    public class RatingEntity
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int VideoEntityId { get; set; }
        public int UserEntityId { get; set; }
    }
}
