using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem deathPrefab;
    public Vector3 test = new Vector3(0f, 0f, 0f);
    public Transform deathEffectRotation;

    void OnCollisionEnter(Collision col)
    {
        if (CompareTag("Player"))
        {            
            FindObjectOfType<GameManager>().GameOver();
            Instantiate(deathPrefab, transform.position, deathEffectRotation.transform.rotation);           
            Destroy(player);            
        }
    }
}
        
    
    
    
       
    