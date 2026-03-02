using UnityEngine;

public class ActivarSonido : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Entrar", post.transform.position);
            //AudioManager.Instance.Play2D("Entrar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("Salir", post1.transform.position);
            //AudioManager.Instance.Play2D("Salir");
        }
    }
}
