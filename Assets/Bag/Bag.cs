using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    private List<string> tileTypes = new List<string> {
        "Red",
        "Blue",
        "Yellow",
        "Black",
        "Diamond",
    };
    private int tileCount = 20;  // count of tiles of one color in the bag
    private List<GameObject> tiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        tileTypes.ForEach(type => {
            for (int i = 0; i < this.tileCount; i++) {
                
            };
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shuffle()
    {

    }
}
