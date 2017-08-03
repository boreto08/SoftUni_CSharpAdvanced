
public class Rebel : IBuyer
{
    public Rebel()
    {
          
    }

    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}

