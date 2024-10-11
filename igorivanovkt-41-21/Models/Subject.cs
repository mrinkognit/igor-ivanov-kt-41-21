namespace igorivanovkt_41_21.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }
        
        public int GroupId { get; set; }

        public Group Group { get; set; }




    }
}
