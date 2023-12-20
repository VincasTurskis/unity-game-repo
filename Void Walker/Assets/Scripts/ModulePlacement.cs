using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulePlacement : MonoBehaviour
{
    private Color highlighted = new Color(0f, 0.8f, 0f, 0.6f);
    private Color notShown = new Color(0f, 0f, 0f, 0f);
    public GameObject cafeteriaShadow;
    public void StartPlacingCafeteria()
    {
        SetFreeAnchorPointColor(highlighted);
        StartCoroutine(PlaceModule());
    }
    private IEnumerator PlaceModule()
    {
        GameObject shadow = CreateShadow(cafeteriaShadow);
        while (!Input.GetKeyDown(KeyCode.Escape))
        {
            Vector3 mousePos = Utility.MouseWorldPosition();
            shadow.transform.SetPositionAndRotation(mousePos, shadow.transform.rotation);
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("clicked");
                RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
                if (hit.collider != null)
                {
                    if (hit.collider.gameObject.CompareTag("AnchorPoint"))
                    {
                        if (hit.collider.gameObject.GetComponent<AnchorPoint>().isUsed == false)
                        {
                            Debug.Log("Unused AnchorPoint was clicked!");
                            hit.collider.gameObject.GetComponent<AnchorPoint>().isUsed = true;
                            break;
                        }
                    }
                }
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                shadow.transform.Rotate(0, 0, 90);
            }
            yield return null;
        }
        SetFreeAnchorPointColor(notShown);
        Destroy(shadow);
    }
    private void SetFreeAnchorPointColor(Color target)
    {
        List<GameObject> anchorPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("AnchorPoint"));
        foreach (GameObject point in anchorPoints)
        {
            AnchorPoint p = point.GetComponent<AnchorPoint>();
            if (p.isUsed == false)
            {
                p.GetColorSprite().color = target;
            }
            else
            {
                p.GetColorSprite().color = notShown;
            }
        }
    }
    private GameObject CreateShadow(GameObject module)
    {
        return Instantiate(module, Utility.MouseWorldPosition(), Quaternion.identity);
    }

}
