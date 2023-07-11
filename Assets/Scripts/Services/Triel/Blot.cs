using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Blot : MonoBehaviour
{
    [SerializeField] private float _offset;

    private SpriteRenderer _spriteRendererBlot;

    private void Awake()
    {
        _spriteRendererBlot = GetComponent<SpriteRenderer>();
    }

    public void Init(Vector3 position,Color color)
    {
        transform.position = position + new Vector3(0, _offset, 0); 
        transform.eulerAngles = new Vector3(90, Random.Range(0, 360), 0);

        _spriteRendererBlot.color = color;
    }


}
