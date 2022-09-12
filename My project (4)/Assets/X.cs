using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }

    void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = playerPos;

    }

}
