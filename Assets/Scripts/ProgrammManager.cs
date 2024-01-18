using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ProgrammManager : MonoBehaviour
{
    [Header("Put your planeMarker here")]
    [SerializeField] private GameObject _planeMarkerPrefab;

    [SerializeField] private ARRaycastManager _ARRaycastManagerScript;

    public List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        _planeMarkerPrefab.SetActive(false);
    }

    void Update()
    {
        ShowMarker();
    }

    void ShowMarker()
    {
        _ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            _planeMarkerPrefab.transform.position = hits[0].pose.position;
            _planeMarkerPrefab.SetActive(true);
        }
    }
}