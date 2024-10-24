namespace igorivanovkt_41_21.Models
{
    namespace Project.Models
    {
        public class SubjectGroup
        {
            public int SubjectGroupId { get; set; }
            public string SubjectGroupName { get; set; }

            public ICollection<Group> Groups { get; set; }

            public SubjectGroup()
            {
                Groups = new List<Group>();
            }
        }
    }
}