using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneScript : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoNext()
    {
        anim.SetTrigger("FadeOut");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //StartCoroutine(MyAnimationWait());
    }
    /*
    IEnumerator MyAnimationWait()
    {
        anim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length + anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    */
}
