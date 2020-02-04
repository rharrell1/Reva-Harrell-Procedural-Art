using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Art;

public class ArtMakerDemo1 : ArtMakerTemplate
{
    public GameObject Sphere;
    public GameObject Cube;
    public int amount = 10;

	public override void MakeArt()
	{
        bool whichone = Random.value < .5f;
        for (int i = 0; i < amount; i++)
        {
            GameObject g = Instantiate(Cube);
            g.transform.parent = root.transform;
            g.transform.localPosition = new Vector3(Random.value - .5f, Random.value - .5f, Random.value - .5f);// Random.insideUnitSphere*.5f;
            if (whichone == true)
            {
                g.transform.localEulerAngles = new Vector3(0, 0, 45);
            }
            g.transform.localScale = Vector3.one * .1f;
        }
        for (int i = 0; i < amount; i++)
        {
            GameObject g = Instantiate(Sphere);
            g.transform.parent = root.transform;
            g.transform.localPosition = new Vector3(Random.value - .5f, Random.value - .5f, Random.value - .5f);// Random.insideUnitSphere*.5f;
            if (whichone == true)
            {
                g.transform.localEulerAngles = new Vector3(0, 0, 45);
            }
            float S = Random.value *.1f;
            g.transform.localScale = new Vector3(S, S, S);
        }

    }
}
