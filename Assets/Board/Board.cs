using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject factory;
    public int playerCount = 2;
    private List<GameObject> factories = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        float scale = 3f;
        List<Vector3> twoPlayers = new List<Vector3>(){
            new Vector3(0, 6 - scale, 0),
            new Vector3(3.2f, 4 - scale, 0),
            new Vector3(-3.2f, 4 - scale, 0),
            new Vector3(-2.5f, -6 + scale, 0), 
            new Vector3(2.5f, -6 + scale, 0),
        };
        if (playerCount == 2) {
            twoPlayers.ForEach(vector => {
                this.factories.Add(Instantiate(factory, vector,  Quaternion.identity));
            });
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // this.factories.ForEach(factory => {
        //     factory.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        // });
    }
}
