using System;
namespace WTechCoreSample.Models
{
    public class GroupMember
    {

        public int Id { get; set; }

        public int MusicGroupId { get; set; }

        public string Story { get; set; }

        public string MusicCompany { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string MusicalEnstrument { get; set; }

        public MusicGroup MusicGroup { get; set; }
    }
}
