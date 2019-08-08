using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace RegularSeasonResults2018
{
    class SeasonResultsFetcher
    {
        private readonly String seasonResultsPage = "https://api.mobileqa.mlbinfra.com/api/interview/v1/records";

        private List<Team> teams;
        public ALLeagueResults AL { get; set; }
        public NLLeagueResults NL { get; set; }

        public SeasonResultsFetcher()
        {
            GetResults();
        }

        private void GetResults()
        {
            using (WebClient wc = new WebClient())
            {
                String json = wc.DownloadString(seasonResultsPage);
                teams = JsonConvert.DeserializeObject<List<Team>>(json);
            }

            teams = teams.OrderBy(x => x.Losses).ToList();

            SetLeagueResults();
        }

        private void SetLeagueResults()
        {
            List<Team> ALTeams = new List<Team>();
            List<Team> NLTeams = new List<Team>();

            foreach (Team team in teams)
            {
                if (team.League == League.AL)
                {
                    ALTeams.Add(team);
                }
                else
                {
                    NLTeams.Add(team);
                }
            }

            AL = new ALLeagueResults(ALTeams);
            NL = new NLLeagueResults(NLTeams);
        }

    }
}
