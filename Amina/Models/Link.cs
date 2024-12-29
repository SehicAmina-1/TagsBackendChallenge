namespace Amina.Models;

public class Link
{
    public int LinkId;
    public int Test;

    public int Test1
    {
        get => Test;
        set => Test = value;
    }

    public int Test2(Link link)
    {
        Test = link.Test;
        return 0; 
    }
}
