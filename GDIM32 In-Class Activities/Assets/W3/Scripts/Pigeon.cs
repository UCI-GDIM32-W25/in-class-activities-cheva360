using UnityEngine;

public enum MovementState {
    Idle, Flying
}

public class Pigeon : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    // (1) add a member variable to represent the Pigeon's state

    private MovementState _currentState;

    void Update()
    {
        UpdateState();
        UpdateAppearance(_currentState);
    }

    // (2) fill in this method to update the pigeon's state based on input
    // if the player is pressing the 'A' key, the state should be set to Flying
    // - otherwise, it should be Idle
    private void UpdateState ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _spriteRenderer.flipX = true;
            _currentState = MovementState.Flying;
            transform.Translate(Vector3.left * _speed);
        }
        else
        {
            _currentState = MovementState.Idle;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _currentState = MovementState.Flying;
            transform.Translate(Vector3.down * _speed);
        }
        else
        {
            _currentState = MovementState.Idle;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _spriteRenderer.flipX = false;
            _currentState = MovementState.Flying;
            transform.Translate(Vector3.right * _speed);
        }
        else
        {
            _currentState = MovementState.Idle;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _currentState = MovementState.Flying;
            transform.Translate(Vector3.up * _speed);
        }
        else
        {
            _currentState = MovementState.Idle;
        }

    }

    // (3) fill in this method to update the pigeon's animation based on its state
    // based on whether the player is Flying or Idling, use the given methods PlayFlyAnimation and PlayIdleAnimation
    // to play the correct animation
    // use a Switch statement!
    private void UpdateAppearance(MovementState Anim)
    {
        switch (Anim)
        {
            case MovementState.Idle:
                PlayIdleAnimation(); break;
            case MovementState.Flying:
                PlayFlyAnimation(); break;
        }
    }

    private void PlayFlyAnimation () {
        _animator.SetBool("isFlying", true);
    }

    private void PlayIdleAnimation () {
        _animator.SetBool("isFlying", false);
    }
}
