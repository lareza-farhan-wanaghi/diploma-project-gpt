  using UnityEngine;
using UnityEngine.UI;

public class FullImageScalar : MonoBehaviour
{

    [SerializeField] private Image image;

    private void Start()
    {
        // Get the original size of the image
        Vector2 originalSize = image.rectTransform.sizeDelta;

        // Check if the height is bigger than the width
        bool heightIsBigger = originalSize.y > originalSize.x;

        // Calculate the scale factor based on the bigger dimension
        float scaleFactor = heightIsBigger ? Screen.height / originalSize.y : Screen.width / originalSize.x;

        // Calculate the new size while maintaining aspect ratio
        Vector2 newSize = originalSize * scaleFactor;

        // Set the new size of the image
        image.rectTransform.sizeDelta = newSize;
    
}

}
