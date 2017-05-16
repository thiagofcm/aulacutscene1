using System.Collections.Generic;
using UnityEngine;

public class CutSceneController : MonoBehaviour {

    public static CutSceneController instancia = null;

    public List<GameObject> cameras = new List<GameObject>();
    int ativa;

    // Use this for initialization
    void Start() {
        if (instancia == null) {
            instancia = this;
        }
        for (int i = 0; i < cameras.Count; i++) {
            cameras[i].SetActive(false);
        }
        cameras[0].SetActive(true);
        ativa = 0;
    }

    public void ProximaCamera() {
        cameras[ativa].SetActive(false);
        if (ativa < cameras.Count - 1) {
            ativa++;
            cameras[ativa].SetActive(true);
        }

    }

} 