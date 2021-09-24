using System.Collections.Generic;


namespace JAP_Task_1_MoviesApi.Models
{
    public class ActorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<VideoEntity> Videos { get; set; }
    }
}
