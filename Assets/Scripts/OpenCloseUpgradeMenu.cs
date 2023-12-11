using System.Collections;
using UnityEngine;

public class OpenCloseUpgradeMenu : MonoBehaviour
{
    [SerializeField] private GameObject darkBackground;
    [SerializeField] private GameObject upgradeMenu;
    [SerializeField] private float animationDuration = 0.05f;
    [SerializeField] private Vector3 startScale = new Vector3(0.8f, 0.8f, 1f);
    [SerializeField] private Vector3 endScale = new Vector3(1f, 1f, 1f);
  
    public void OpenUpgradeMenu()
    {
        darkBackground.SetActive(true);
        upgradeMenu.SetActive(true);
        StartCoroutine(ScaleOverTime(upgradeMenu.transform, startScale, endScale, animationDuration));
    }
    
    public void CloseUpgradeMenu()
    {
        StartCoroutine(ScaleOverTime(upgradeMenu.transform, endScale, startScale, animationDuration, () =>
        {
            darkBackground.SetActive(false);
            upgradeMenu.SetActive(false);
        }));
    }
    
    private static IEnumerator ScaleOverTime(Transform objectToScale, Vector3 startScale, Vector3 endScale, float duration, System.Action onComplete = null)
    {
        var startTime = Time.time;
    
        while (Time.time < startTime + duration)
        {
            var progress = (Time.time - startTime) / duration;
            objectToScale.localScale = Vector3.Lerp(startScale, endScale, progress);
            yield return null;
        }

        objectToScale.localScale = endScale;

        onComplete?.Invoke();
    }
}