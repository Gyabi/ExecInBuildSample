using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    [SerializeField]
    private string str = "";
    [SerializeField]
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public Data GetData()
    {
        return new Data(str, num);
    }

    public struct Data
    {
        public string Str{get;}
        public int Num{get;}

        public Data(string str, int num)
        {
            Str = str;
            Num = num;
        }
    }
}
