using System.Collections.Generic;

namespace RegularSeasonResults2018
{
    public abstract class LeagueResults
    {
        public DivisionResults East { get; set; }
        public DivisionResults Central { get; set; }
        public DivisionResults West { get; set; }

        public abstract League League { get; }

        protected LeagueResults(List<Team> _teams)
        {
            List<Team> ALCentral = new List<Team>();
            List<Team> ALEast = new List<Team>();
            List<Team> ALWest = new List<Team>();

            foreach (Team team in _teams)
            {
                switch (team.Division)
                {
                    case Division.Central:
                        ALCentral.Add(team);
                        break;

                    case Division.East:
                        ALEast.Add(team);
                        break;

                    case Division.West:
                        ALWest.Add(team);
                        break;

                    default:
                        break;
                }
            }

            Central = new DivisionResults(ALCentral);
            East = new DivisionResults(ALEast);
            West = new DivisionResults(ALWest);
        }
    }
}
