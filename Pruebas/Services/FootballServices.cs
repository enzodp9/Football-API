using Newtonsoft.Json;
using Pruebas.Data;
using Pruebas.Models;
using Pruebas.Services.DTOs;

namespace Pruebas.Services
{
    public class FootballServices
    {
        private readonly FootballDbContext _context;
        private string ApiKey = "22eab87cdcb3578e01459f312c11001c5895deb96de45f65a67aafc836850742";

        public FootballServices(FootballDbContext context)
        {
            _context = context;
        }

        public async Task GetCountries()
        {
            string url = "https://apiv3.apifootball.com/?action=get_countries&APIkey=" + ApiKey;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                List<CountryDTO>? results = JsonConvert.DeserializeObject<List<CountryDTO>>(body);
                Console.WriteLine(results);
                if (results == null)
                {
                    Console.WriteLine("No se encontraron resultados");
                    return;
                }
                else
                {
                    foreach (var result in results)
                    {
                        if (result != null)
                        {
                            Country country = new Country(
                            id: int.Parse(result.Country_id),
                            name: result.Country_name,
                            logo: result.Country_logo
                            );
                            _context.Add<Country>(country);
                        }
                    }

                    await _context.SaveChangesAsync();
                }

            }
        }

        public async Task GetLeagues()
        {
            string url = "https://apiv3.apifootball.com/?action=get_leagues&APIkey=" + ApiKey;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                List<LeagueDTO>? results = JsonConvert.DeserializeObject<List<LeagueDTO>>(body);
                Console.WriteLine(results);
                if (results == null)
                {
                    Console.WriteLine("No se encontraron resultados");
                    return;
                }
                else
                {
                    foreach (var result in results)
                    {
                        League league = new League(
                            id: int.Parse(result.League_id),
                            name: result.League_name,
                            logo: result.League_logo,
                            countryid: int.Parse(result.Country_id)
                            );
                        _context.Add<League>(league);
                    }

                    await _context.SaveChangesAsync();
                }

            }
        }

        public async Task GetTeamsAndPlayers(string leagueId)
        {
            string url = "https://apiv3.apifootball.com/?action=get_teams&league_id=" + leagueId + "&APIkey=" + ApiKey;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                List<TeamDTO>? results = JsonConvert.DeserializeObject<List<TeamDTO>>(body);
                Console.WriteLine(results);
                if (results == null)
                {
                    Console.WriteLine("No se encontraron resultados");
                    return;
                }
                else
                {
                    foreach (var result in results)
                    {
                        int? countryId = _context.Countries.Where(c => c.Name == result.Team_country).Select(c => (int?)c.Id).FirstOrDefault();
                        Team team = new Team(
                            id: int.Parse(result.Team_key),
                            name: result.Team_name,
                            countryId: countryId?? 0,
                            founded: int.Parse(result.Team_founded),
                            logo: result.Team_badge,
                            stadium: result.Venue?.Venue_name,
                            coach: result.Coach?.Coach_name
                        );
                        _context.Add<Team>(team);
                        if (result.Players != null)
                        {
                            foreach (var p in result.Players)
                            {
                                if (p != null)
                                {
                                    int? countryPlayerId = _context.Countries.Where(c => c.Name == p.Player_country).Select(c => (int?)c.Id).FirstOrDefault();
                                    Player player = new Player(
                                    id: int.Parse(p.Player_id),
                                    name: p.Player_name,
                                    image: p.Player_image,
                                    number: int.Parse(p.Player_number),
                                    age: int.Parse(p.Player_age),
                                    position: p.Player_type,
                                    teamId: team.Id,
                                    countryId: countryPlayerId ?? 0
                                    );
                                    _context.Add<Player>(player);
                                }
                            }
                        }
                    }

                    await _context.SaveChangesAsync();
                }

            }
        }

        public async Task GetMatches()
        {
            string url = "https://apiv3.apifootball.com/?action=get_events&timezone=America/Argentina/Cordoba&from=2024-03-20&to=2024-03-29" + "&APIkey=" + ApiKey;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                List<MatchDTO>? results = JsonConvert.DeserializeObject<List<MatchDTO>>(body);
                Console.WriteLine(results);
                if (results == null)
                {
                    Console.WriteLine("No se encontraron resultados");
                    return;
                }
                else
                {
                    foreach (var result in results)
                    {
                        Match match = new Match(
                            id: int.Parse(result.Match_Id),
                            homeTeamId: int.Parse(result.Match_Hometeam_Id),
                            awayTeamId: int.Parse(result.Match_Awayteam_Id),
                            homeGoals: int.Parse(result.Match_Hometeam_Score),
                            awayGoals: int.Parse(result.Match_Awayteam_Score),
                            date: DateTime.Parse(result.Match_Date),
                            status: result.Match_Status,
                            leagueId: int.Parse(result.League_Id));
                        _context.Add<Match>(match);

                    }

                    await _context.SaveChangesAsync();
                }

            }
        }



        public async Task PoblateDatabase()
        {
            await GetCountries();
            await GetLeagues();
            List<string> leagues = _context.Leagues.ToList().Select(l => l.Id.ToString()).ToList();
            foreach (var league in leagues)
            {
                await GetTeamsAndPlayers(league);
            }
            await GetMatches();
        }
    }
}
