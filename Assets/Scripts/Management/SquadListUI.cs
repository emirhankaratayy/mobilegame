using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SquadListUI : MonoBehaviour
{
    [SerializeField] private Text listText;

    private void Start()
    {
        Team team = SampleSquadFactory.CreateSampleTeam();

        var sb = new StringBuilder();
        sb.AppendLine(team.Name);
        sb.AppendLine();
        foreach (Player player in team.Squad)
        {
            sb.AppendLine($"{player.Name}  -  {player.Position}  -  {player.Rating}");
        }

        listText.text = sb.ToString();
    }
}
