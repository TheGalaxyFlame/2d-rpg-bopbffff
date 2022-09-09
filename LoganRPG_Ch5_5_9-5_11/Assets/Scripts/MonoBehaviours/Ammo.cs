public class Ammo : MonoBehaviour
{
    public int damageInflicted;
    void OnTriggerEnter2D(Collide2D collision)
    {
        if (colision is BoxCollider2D)
        {
            Enemy enemy = collision.gameOBject.GetComponent<enemy>();
            StartCoroutine(enemy.DamageCharacter(damageInflicted, 0.0f));
            gameObject.SetActive(false);
        }
    }
}
