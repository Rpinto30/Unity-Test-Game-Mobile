using UnityEngine;

public class GameManagerCar : MonoBehaviour
{
    public float speedGroud =  0.05f;
    public MeshRenderer meshRendererGround;
    private Material materialGround;

    void Awake()
    {
        materialGround = meshRendererGround.materials[0];   
    }

    void Update()
    {
        if (materialGround.mainTextureOffset.y < 10f){
            materialGround.mainTextureOffset = new Vector2(0, materialGround.mainTextureOffset.y + (speedGroud * Time.deltaTime));
        }
        else if (materialGround.mainTextureOffset.y > 10f) {
            materialGround.mainTextureOffset = new Vector2(0, 0);
        }
    }
}
