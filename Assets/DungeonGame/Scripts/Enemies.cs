using UnityEngine;

public class Enemies:MonoBehaviour
{
    public string nome;
    public float speed;
    public float vida;
    public float maxVida;
    public Transform target;
    void Start()
    {
        vida = maxVida;
        Introduction();
    }
    void Introduction()
    {
        Debug.Log("Meu nome é" + nome + "Minha Vida é " + vida + "Meu maximo de vida é " + maxVida);
    }
    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    private void Update()
    {
        Move();
    }
}
