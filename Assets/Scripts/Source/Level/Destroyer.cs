using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroyable destroyable = collision.gameObject.GetComponentInParent<Destroyable>();
        if (destroyable != null)
            Destroy(destroyable.gameObject);
    }
}
