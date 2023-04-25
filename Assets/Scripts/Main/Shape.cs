using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private int colorIndex;
    private int sizeIndex;
    private float minValue = 0;
    private float maxValue = 0;
    public bool physicStatus;
    public MeshRenderer Renderer;
    private Rigidbody shapeRb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
        if (DataManager.Instance.PhysicsStatus)
        {
            shapeRb.useGravity = true;
        }
        else
        {
            shapeRb.useGravity = false;
        }

        colorIndex = DataManager.Instance.ColorType;
        sizeIndex = DataManager.Instance.SizeType;
        SetColor(colorIndex);
        SetSize(sizeIndex);
        
    }

    public virtual void SetColor(int index)
    {
        minValue = 0.0f;
        maxValue = 1.0f;
        Material objectMaterial = Renderer.material;
        
        switch (index)
        {
            case 0:
                objectMaterial.color = new Color(1, 0, 0);
                break;
            case 1:
                objectMaterial.color = new Color(0, 1, 0);
                break;
            case 2:
                objectMaterial.color = new Color(0, 0, 1);
                break;
            case 3:
                objectMaterial.color = new Color(GetRandomNumber(minValue, maxValue), GetRandomNumber(minValue, maxValue), GetRandomNumber(minValue, maxValue));
                break;
            default:
                objectMaterial.color = new Color(1, 0, 0);
                break;

        }
    }
    // Abstraction
    private float GetRandomNumber(float min, float max)
    {
        float random;
        random = Random.Range(min, max);
        return random;
    }

    void SetSize(int index)
    {
        minValue = 1.0f;
        maxValue = 3.0f;
        switch (index)
        {
            case 0:
                transform.localScale = new Vector3(1, 1, 1);
                break;
            case 1:
                transform.localScale = new Vector3(2, 2, 2);
                break;
            case 2:
                transform.localScale = new Vector3(3, 3, 3);
                break;
            case 3:
                transform.localScale = new Vector3(GetRandomNumber(minValue, maxValue), GetRandomNumber(minValue, maxValue), GetRandomNumber(minValue, maxValue));
                break;
            default:
                transform.localScale = new Vector3(1, 1, 1);
                break;

        }
    }

}
