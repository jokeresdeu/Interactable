using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
   public event Action<Vector2> OnFireClicked;
   private Camera _camera;
   
   private void Start()
   {
      _camera = Camera.main;
   }

   public void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         OnFireClicked(_camera.ScreenToWorldPoint(Input.mousePosition));
      }
   }
}
