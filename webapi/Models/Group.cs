
using MongoDB.Bson.Serialization.Attributes;

public class Group
{
    //variables
    private String group_name;
    private int total_score;
    //private Dictionary<string, int> game;
    private List<Games> games;

    public Group() { }
    /*public Group(String game_name, int game_mark, String group_name/*, int total_mark*, Dictionary<String, int> game) {
        this.game = game;
        this.group_name = group_name;
        //this.total_mark = total_mark;
    }

    public Dictionary<String, int> Game
    {
        get { return game; }    
        set { game = value; }   
    }*/

    public Group(String group_name, List<Games> games, int total_score)
    {
        this.group_name = group_name;
        this.games = games;
        this.total_score = total_score;
    }
    public String Group_name
    {
        get { return group_name; }
        set { group_name = value; }
    }
    public List<Games> Games
    {
        get { return games; }
        set { games = value; }
    }
    public int TotalScore
    {
        get { return total_score; }
        set { total_score = value; }
    }
    /*public int Total_mark
    {
        get { return total_mark; }
        set { total_mark = value; }
    }*/

}
//Id, game_name, game_mark, total_mark
