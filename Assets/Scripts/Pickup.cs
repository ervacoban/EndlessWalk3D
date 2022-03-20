using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private GameObject particle;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickupAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bottle"))
        {
            Score.score++;
            GameObject effect = Instantiate(particle, other.transform.position, Quaternion.identity);
            audioSource.PlayOneShot(pickupAudio);
            Destroy(effect.gameObject, 2);
            Destroy(other.gameObject);
        }
        if(Score.score % 4 == 0)
        {
            Score.speedIncrease += Random.Range(0.03f, 0.05f);
        }
    }
}
