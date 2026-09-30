public static class SampleSquadFactory
{
    public static Team CreateSampleTeam()
    {
        var team = new Team("Test FC");

        team.Squad.Add(new Player("Kaan Aydın", PlayerPosition.Goalkeeper, 74));
        team.Squad.Add(new Player("Burak Şahin", PlayerPosition.Goalkeeper, 68));

        team.Squad.Add(new Player("Emre Yıldız", PlayerPosition.Defender, 71));
        team.Squad.Add(new Player("Serkan Çelik", PlayerPosition.Defender, 69));
        team.Squad.Add(new Player("Onur Kaya", PlayerPosition.Defender, 70));
        team.Squad.Add(new Player("Tolga Arslan", PlayerPosition.Defender, 66));

        team.Squad.Add(new Player("Barış Doğan", PlayerPosition.Midfielder, 73));
        team.Squad.Add(new Player("Volkan Öztürk", PlayerPosition.Midfielder, 70));
        team.Squad.Add(new Player("Caner Koç", PlayerPosition.Midfielder, 68));
        team.Squad.Add(new Player("Hakan Yılmaz", PlayerPosition.Midfielder, 72));

        team.Squad.Add(new Player("Deniz Aksoy", PlayerPosition.Forward, 75));
        team.Squad.Add(new Player("Murat Polat", PlayerPosition.Forward, 71));
        team.Squad.Add(new Player("Eren Kurt", PlayerPosition.Forward, 69));

        return team;
    }
}
