using System.Collections;
using UnityEngine;

public class cactusSpawner : MonoBehaviour
{
    public GameObject gameObj;
    private Transform gameObjPos;
    
    private void Start()
    {
        gameObjPos = GetComponent<Transform>();
        StartCoroutine(Create());
    }
    
    private IEnumerator Create()
    {
        yield return new WaitForSeconds(1f);

        gameObjPos.position = new Vector3(gameObjPos.position.x, gameObjPos.position.y, gameObjPos.position.z + 99);

        Instantiate(gameObj, new Vector3(gameObjPos.position.x, gameObjPos.position.y, gameObjPos.position.z), Quaternion.identity);
        
        StartCoroutine(Create());
    } 
}
