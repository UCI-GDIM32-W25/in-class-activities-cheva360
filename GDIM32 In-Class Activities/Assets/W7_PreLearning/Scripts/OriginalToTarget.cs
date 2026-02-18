using UnityEngine;

public class OriginalToTarget : MonoBehaviour
{
    [SerializeField] private Transform _original;
    [SerializeField] private Transform _target;

    private void Start ()
    {
        // we want to move the original to the target
        Vector3 displacementToTarget = _target.position - _original.position;
        _original.position += displacementToTarget;
    }
}