public class Games {
    private String game_name;
    private int game_value;

    public Games() { }
    public Games(String game_name, int game_value) { 
        this.game_name = game_name; 
        this.game_value = game_value;   
    }

    public String Game_name
    {
        get { return game_name; }
        set { game_name = value; }
    }
    public int Game_value
    {
        get { return game_value; }
        set { game_value = value; }
    }
}