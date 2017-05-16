using UnityEngine;

public class FimDeCamera : MonoBehaviour {

    public void CameraAcabou() {
        CutSceneController.instancia.ProximaCamera();
    }
}