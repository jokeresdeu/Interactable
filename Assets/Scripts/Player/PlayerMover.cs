using Interactables;
using UnityEngine;

namespace Player
{
    public class PlayerMover
    {
        private MovementParams _movementParams;
        private InputController _inputController;
        private Interactable _focusedInteractable;
        private PlayerCreature _playerCreature;

        public PlayerMover(MovementParams movementParams, InputController inputController, PlayerCreature playerCreature)
        {
            _movementParams = movementParams;
            _inputController = inputController;
            _playerCreature = playerCreature;
            _inputController.OnFireClicked += OnFireClicked;
            _playerCreature.OnPlayerDestroyed += OnDestroy;
        }

        private void OnFireClicked(Vector2 position)
        {
            Collider2D clickable = Physics2D.OverlapCircle(position, _movementParams.ClickRadius, _movementParams.WhatIsClickable);
            if (clickable == null)
            {
                return;
            }

            MoveTo(position);
            Interactable interactable = clickable.GetComponent<Interactable>();
            if (interactable == null)
            {
                return;
            }

            if (_focusedInteractable != null)
            {
                _focusedInteractable.UnfocusPlayer();
            }

            _focusedInteractable.FocusPlayer(_playerCreature);
            FollowTarget(interactable);
        }

        private void MoveTo(Vector2 position)
        {
            //MoveTo
            //Create mover to use in player and enemies
        }

        private void FollowTarget(Interactable interactable)
        {
            MoveTo(interactable.transform.position);
            LookAt(interactable.transform);
        }

        private void LookAt(Transform target)
        {
            //MoveTo
        }

        private void OnDestroy()
        {
            _playerCreature.OnPlayerDestroyed -= OnDestroy;
            _inputController.OnFireClicked -= OnFireClicked;
        }
    }
}