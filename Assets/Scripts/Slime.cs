using UnityEngine;

public class Slime 
{
    private string nameSlim;
    private int life; 
    

    public Slime(int _life)
    {
        life = _life;
    }

    public static Slime operator +(Slime a, Slime b)
    {
        return new Slime(a.life + b.life);
    }
}

