using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarietyShow : MonoBehaviour
{
    public GameObject[] lights;

    private int currentLight = 0;

    public Material onMaterial;
    public Material offMaterial;
    public int onTime = 10;
    public int offTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCycle();
    }

    IEnumerator Step()
    {
        Debug.Log("Activating light " + currentLight);
        SwitchOn(lights[currentLight]);

        yield return new WaitForSeconds(onTime);

        Debug.Log("Deactivating light " + currentLight);
        SwitchOff(lights[currentLight]);

        yield return new WaitForSeconds(offTime);

        StartCycle();
    }

    void StartCycle()
    {
        Debug.Log("Timer cycle...");
        currentLight = (currentLight + 1) % lights.Length;

        StartCoroutine(Step());
    }

    void SwitchOn(GameObject light)
    {
        light.GetComponent<Renderer>().material = onMaterial;
        light.transform.GetChild(0).gameObject.SetActive(true);
    }

    void SwitchOff(GameObject light)
    {
        light.GetComponent<Renderer>().material = offMaterial;
        light.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
