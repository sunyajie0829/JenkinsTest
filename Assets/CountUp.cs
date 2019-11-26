using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    public Text label;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countUp());
    }

    // Update is called once per frame
    void Update()
    {
        label.text = count.ToString();
    }

    IEnumerator countUp()
    {
        while (true)
        {
            count++;
            yield return new WaitForSeconds(1);
        }
    }

}
