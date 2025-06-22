using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ButtonGlitchAndScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalPosition;
    private Vector3 originalScale;
    private bool isGlitching = false;

    [Header("Glitch Settings")]
    public float glitchAmount = 5f; // How much the position jitters
    public float glitchSpeed = 0.05f; // How fast the position changes

    [Header("Scale Settings")]
    public float scaleFactor = 1.5f; // How much to scale up
    public float scaleSpeed = 20f; // How fast to scale

    void Start()
    {
        originalPosition = transform.localPosition;
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isGlitching)
        {
            StartCoroutine(GlitchAndScale());
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isGlitching = false;
        StopAllCoroutines();
        transform.localPosition = originalPosition;
        transform.localScale = originalScale;
    }

    IEnumerator GlitchAndScale()
    {
        isGlitching = true;

        Vector3 targetScale = originalScale * scaleFactor;

        while (isGlitching)
        {
            // Glitching position
            Vector3 glitchOffset = new Vector3(
                Random.Range(-glitchAmount, glitchAmount),
                Random.Range(-glitchAmount, glitchAmount),
                0f
            );

            transform.localPosition = originalPosition + glitchOffset;

            // Scaling smoothly
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed * Time.deltaTime);

            yield return new WaitForSeconds(glitchSpeed);
        }
    }
}
