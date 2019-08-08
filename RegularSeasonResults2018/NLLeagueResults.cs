using System.Collections.Generic;

namespace RegularSeasonResults2018
{
    public class NLLeagueResults : LeagueResults
    {
        public override League League => League.NL;

        public NLLeagueResults(List<Team> _teams) : base(_teams)
        {
        }
    }
}