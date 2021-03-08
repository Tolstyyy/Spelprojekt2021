//WIP, tutorial https://www.youtube.com/watch?v=3UO-1suMbNc&ab_channel=PressStart
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundloop : MonoBehaviour
{
    public GameObject background;
    private Camera mainCamera;
    private Vector2 screenBounds;

    void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(screenBounds.width, screenBounds.height, mainCamera.transform.position.z));
        loadChildObjects(background);
    }


    void loadChildObjects(GameObject obj)
    {
        float objectWidth = background.GetComponent<SpriteRenderer>().bounds.sixe.x;
        int childsNeeded = (int)Mathf.Ceil(screenBounds.x * 2 / objectWidth);
        background clone = Instantiate(background) as GameObject;
        GameObject c = Instantiate(clone) as GameObject;
        c.transform.SetParent(obj.transform);
        c.transform.position = new Vector3(objectWidth * childsNeeded, obj.transform.position.y, obj.transform.position.z);
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }
}
