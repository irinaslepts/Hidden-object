using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obj1 : MonoBehaviour
{
    static int score = 0;
    Transform obj_transform;
    public GameObject text;
    Transform text_transform;
    MeshRenderer display;
    
    // Start is called before the first frame update
    void Start()
    {
        obj_transform = GetComponent<Transform>();
        text_transform = text.GetComponent<Transform>();
        display = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        score = score + 1;
        print(score);
        if (score == 4){
            SceneManager.LoadScene("story2");
        }
        
        //capsule_transform.Translate(-2f,0,0);
        Destroy(text);
        display.enabled = false;
    }
}
