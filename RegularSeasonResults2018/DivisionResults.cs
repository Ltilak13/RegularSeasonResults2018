using System.Collections.Generic;

namespace RegularSeasonResults2018
{
    public class DivisionResults
    {
        public Team First { get; set; }
        public Team Second { get; set; }
        public Team Third { get; set; }
        public Team Fourth { get; set; }
        public Team Fifth { get; set; }

        public DivisionResults(List<Team> teams)
        {
            First = teams[0];
            Second = teams[1];
            Third = teams[2];
            Fourth = teams[3];
            Fifth = teams[4];
        }
    }
}
