using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class PremiumShapes : Shape
{
    // Polimorphism
    public override void SetColor(int index)
    {
        base.SetColor(index);
        Material objectMaterial = Renderer.material;
        objectMaterial.SetFloat("_Metallic", 0.8f);
        
    }
}
