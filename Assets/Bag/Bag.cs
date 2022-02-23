using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject black;
    public GameObject diamond;
    private int tileCount = 20;  // count of tiles of one color in the bag
    private List<GameObject> tiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> tileTypes = new List<GameObject> {
            red,
            blue,
            yellow,
            black,
            diamond,
        };
        tileTypes.ForEach(tileType => {
            for (int i = 0; i < this.tileCount; i++) {
                this.tiles.Add(tileType);
            };
        });

        this.tiles.ForEach(tile => {
            Debug.Log(tile.name);
        });

        // this.Shuffle();
        // foreach (var i in this.tiles){
        //     Console.WriteLine(i);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shuffle()
    {
        
    }
}
