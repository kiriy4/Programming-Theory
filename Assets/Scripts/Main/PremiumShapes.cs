using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremiumShapes : Shape
{
    public override void SetColor(int index)
    {
        base.SetColor(index);
        Material objectMaterial = Renderer.material;
        objectMaterial.SetFloat("_Metallic", 0.8f);
        
    }
}
