using UnityEngine;
using UnityEngine.Events;

public class NotesLimit : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onNotesLimitReanched;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            onNotesLimitReanched?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
