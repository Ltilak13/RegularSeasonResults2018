using System.Collections.Generic;

namespace RegularSeasonResults2018
{
    public class ALLeagueResults : LeagueResults
    {
        public override League League => League.AL;

        public ALLeagueResults(List<Team> _teams) : base(_teams)
        {
        }
    }
}