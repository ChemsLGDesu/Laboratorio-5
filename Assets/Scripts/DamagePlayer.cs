using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField] private int life =100;
    [SerializeField] private float probability;
    void Start()
    {
        probability = Random.Range(4, 10);
        GetDamage(Random.Range(30, 50),true || false);

    }
    void Update()
    {
        DamageReceived();
    }
    public void DamageReceived()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetDamage(15);   
        }
    }

    public void GetDamage(int damageBasic)
    {
        Debug.Log("El jugador recibio_" + damageBasic + "_de daño basico");
        damageBasic = 15;
        life -= damageBasic;
        Death();
    }

    public void GetDamage(int criticalDamage, bool knocback = true || false)
    {
        criticalDamage = Random.Range(30, 50);
        if(probability>= 5)
        {
            life  -= criticalDamage;
            Debug.Log("El jugador recibio daño critico de_" + criticalDamage + " y el knocback_" + knocback);
            knocback = true;
            life -= 15;
            Death();
        }
        else
        {
            life -= criticalDamage;
            Debug.Log("El jugador solamente recibio daño critico_" + criticalDamage +"_u.u");
            knocback = false;
        }
    }
    public void Death()
    {
        if( life < 0)
        {
            Destroy(gameObject);
            Debug.Log("El jugador volo alto");
        }
    }


}
