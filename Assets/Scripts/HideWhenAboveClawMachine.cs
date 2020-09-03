using UnityEngine;

public class HideWhenAboveClawMachine : MonoBehaviour
{
    private MeshRenderer _renderer;
	
	public float heightRemove;

    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        _renderer.enabled = transform.localPosition.y < heightRemove;
    }
}
