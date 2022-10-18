using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class deathOrNextPillarController : MonoBehaviour
{
    public TextMeshProUGUI score;
    public GameObject prefabOfPillar;
    public Transform PillarSpawnEmpty;
    private int _value = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out MeshCollider meshCollider) | other.gameObject.TryGetComponent(out Rigidbody rigidbody))
        {
            SceneManager.LoadScene(1);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out BoxCollider boxCollider))
        {
            _value += 1;
            score.text = $"{_value}";

            PillarSpawnEmpty.position = new Vector3(PillarSpawnEmpty.position.x, PillarSpawnEmpty.position.y, PillarSpawnEmpty.position.z + 36f);
            SpawnOfPillar(prefabOfPillar, PillarSpawnEmpty);
        }
    }

    public void SpawnOfPillar(GameObject prefabOfPillar, Transform PillarSpawnEmpty)
    {
        Instantiate(prefabOfPillar, new Vector3(7f, Random.Range(-24, 19f), PillarSpawnEmpty.position.z), Quaternion.identity);
    }
} 