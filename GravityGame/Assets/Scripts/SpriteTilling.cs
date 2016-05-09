using UnityEngine;
using System.Collections;

public class SpriteTilling : MonoBehaviour
{
    public GameObject spriteObject;

    public bool randomColor = false;

    // Use this for initialization
    void Start()
    {
        GridObject gridObject = GetComponent<GridObject>();

        Color setColor;
        if (randomColor)
        {
            setColor = new Color(Random.Range(0.2f, 1.0f), Random.Range(0.2f, 1.0f), Random.Range(0.2f, 1.0f));
        }
        else
        {
            setColor = Color.white;
        }

        for (int i = 0; i < gridObject.height; i++)
        {
            for (int j = 0; j < gridObject.width; j++)
            {
                GameObject gameObject = Instantiate(spriteObject);

                gameObject.transform.SetParent(this.transform);
                gameObject.transform.localScale = new Vector3(1.0f / gridObject.width, 1.0f / gridObject.height, 1);

                gameObject.transform.position = gridObject.transform.position + new Vector3(j + 0.5f - (float)gridObject.width / 2, i + 0.5f - (float)gridObject.height / 2, 0);

                gameObject.GetComponent<SpriteRenderer>().color = setColor;
            }
        }
    }
}
