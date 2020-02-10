using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameEngine : MonoBehaviour
{
    public float totalTime = 0;

    public float timeRatio = 1;

    [SerializeField] public BoostBar boostBar;

    private void Awake()
    {
        Cursor.visible = false;
    }
    void Start()
    {

        //boostBar.SetSize(.5f);
        //FunctionPeriodic.Create(() =>
        //{
            
        //    if (Points.boost > 0)
        //    {
        //        Points.boost += .001f;
        //        boostBar.SetSize(Points.boost);
        //    }
        //}, -0.0000003f);

    }

    // Update is called once per frame
    void Update()
    {
        totalTime = totalTime + Time.deltaTime * timeRatio;
    }

}
