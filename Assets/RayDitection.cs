using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDitection : MonoBehaviour
{

    public int maxAmount = 100;
    public int currentAmount;

    public ProgressBar bar;


    private void Start()
    {
        currentAmount = maxAmount;
        bar.SetMaxAmount(maxAmount);
    }


   


    

    void Update()
    {
       

        if (Input.GetMouseButton(0))
        {

            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit,10000f))
            {
                if (hit.transform.tag == "Trigger")
                {
                    GetRecover(15);
                    Destroy(hit.transform.gameObject);
                }
            }
        }


    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    void GetRecover(int recover)
    {
        currentAmount -= recover;
        bar.SetAmount(currentAmount);
    }

}
