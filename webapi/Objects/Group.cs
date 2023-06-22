
public class Group
{
    //variables
    private String group_name;
    //private int total_mark;
    private Dictionary<string, int> game;

    public Group() { }
    public Group(String game_name, int game_mark, String group_name/*, int total_mark*/, Dictionary<String, int> game) {
        this.game = game;
        this.group_name = group_name;
        //this.total_mark = total_mark;
    }

    public Dictionary<String, int> Game
    {
        get { return game; }    
        set { game = value; }   
    }
    public String Group_name
    {
        get { return group_name; }
        set { group_name = value; }
    }
    /*public int Total_mark
    {
        get { return total_mark; }
        set { total_mark = value; }
    }*/

}
//Id, game_name, game_mark, total_mark
