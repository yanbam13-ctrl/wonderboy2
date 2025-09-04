using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverSelector : MonoBehaviour
{
    Vector2 currentPos;
    Vector2 leftPos;
    Vector2 rightPos;


    private void Start()
    {
        currentPos = transform.position;
        leftPos = currentPos + new Vector2(-1f, 0);
        rightPos = currentPos + new Vector2(1f, 0);
    }

    void Update()
    {
        Move();
        Select();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = leftPos;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = rightPos;
        }
    }

    void Select()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (Vector2.Distance(transform.position, leftPos) == 0)
            {
                SceneManager.LoadScene(2);
            }
            else if (Vector2.Distance(transform.position, rightPos) == 0)
            {
                SceneManager.LoadScene(0);
            }
        }

    }

}