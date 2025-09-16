using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string NameSlim;
    public int LifeA;
    public int LifeB;

    public Slime slime1;
    public Slime slime2; 
    void Start()
    {
        slime1 = new(LifeA);
        slime2 = new(LifeB); 

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Slime slime3 = slime1 + slime2;
            Debug.Log("El " + NameSlim + " se fuciono con " + (LifeA + LifeB) +" y se convirtio en un Super Slime de vida ");
        }
    }
}
