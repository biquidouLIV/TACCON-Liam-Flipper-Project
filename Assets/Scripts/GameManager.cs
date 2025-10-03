using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [SerializeField] private GameObject ballSpawner;
    [SerializeField] private GameObject ball;
    [SerializeField] private int life = 4;
    [SerializeField] GameObject[] lifeIcon;
    private int i = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        LoseBall();
    }

    
    public void LoseBall()
    {
        if (life > 0)
        {
            Instantiate(ball, ballSpawner.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("grokk t'as perdu");
        }

        if (life <= 3)
        {
            lifeIcon[i].SetActive(false);
            i++;

        }
        life--;
 
    }
}
