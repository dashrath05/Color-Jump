    using UnityEngine;
using UnityEngine.UI;

public class GiveColliderSize : MonoBehaviour
{
 
    public RectTransform itemRectTransform;
    public BoxCollider2D itemBoxCollider2D;
    public Image image;

    private void Start()
    {
        SetBoxCollider();
    }




    void SetBoxCollider()
    {
     
        if (itemBoxCollider2D != null)
        { 

            if (image.preserveAspect)
            {

                int originalWidth = (int)(image.sprite.rect.width);
                int originalHight = (int)(image.sprite.rect.height);

                float currentWidth = image.rectTransform.rect.width;
                float currentHight = image.rectTransform.rect.height;

                float ratio = Mathf.Min(currentWidth / originalWidth, currentHight / originalHight);

                float newWidth = image.sprite.rect.width * ratio;
                float newHight = image.sprite.rect.height * ratio;

                itemBoxCollider2D.size = new Vector2(newWidth, newHight);
            }
            else
            {

                itemBoxCollider2D.size = image.rectTransform.rect.size;

            }
        }
    }

   
}
