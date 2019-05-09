using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition : MonoBehaviour
{
    public int scenenumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)) {
            //}
    }

   public void StartGame()
    {
       // SceneManager.LoadScene(0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player") {
            SceneManager.LoadScene(scenenumber);
        }

       // SceneManager.LoadScene(0);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(scenenumber);

    }

}
