using UnityEngine;

public class Lane : MonoBehaviour
{
    [SerializeField]
    private Transform notesPrivot;
    [SerializeField]
    private GameObject notePrefabs;
    public Transform NotesPrivot => notesPrivot;
    public GameObject NotePrefab => notePrefabs;
}
