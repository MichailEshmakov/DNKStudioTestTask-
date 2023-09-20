using UnityEngine;

public class ScoreCollector : MonoBehaviour
{
    [SerializeField] private Score _score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreSource source))
        {
            _score.ChangeBy(source.Value);
        }
    }
}
