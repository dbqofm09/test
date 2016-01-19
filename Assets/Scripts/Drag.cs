using UnityEngine;
using System.Collections;

public class Drag :MonoBehaviour
{

 private bool _mouseState;
 private GameObject target;

 public GameObject backimg;
 public bool dragging = false;

 void OnMouseDrag()
 {
  if(!dragging)
  {
   dragging = true;
   backimg.SetActive(false);
  }

  Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  Debug.Log(mousePos);

  mousePos.y = 0f;
  transform.position = mousePos;

 }

 void OnMouseUp()
 {
  Debug.Log("에바.. 놨냐?");

  dragging = false;
  backimg.SetActive(false);
 }

 void OnMouseOver()
 {
  if(!dragging)
  {

   Debug.Log("지켜보고????");

   backimg.SetActive(true);
  }

  Debug.Log("지켜보고 있다.");

 }

 void OnMouseExit()
 {
  backimg.SetActive(false);
 }

}
