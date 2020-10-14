using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }


    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }
    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}


public class Test : MonoBehaviour
{


    void Start()
{
    int[] no = { 10, 20, 30, 40, 50 };
        Boss magicboss = new Boss();

        for (int i = 0; i < no.Length; i++)
        {
            Debug.Log(no[i]);
        }
        for (int m = no.Length - 1; m >= 0; m--)
        {
            Debug.Log(no[m]);
        }
        for(int n = 0; n <= 11; n++)
        {
            magicboss.Magic();
        }

    }
    

    // Update is called once per frame
    void Update()
    {

    }
}