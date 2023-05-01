using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region
    public void Quit()
    {
        Application.Quit();
    }
    public void PlayRange()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayFind()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayTennis()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayPose()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayHockey()
    {
        SceneManager.LoadScene(5);
    }
    public void PlayBilliards()
    {
        SceneManager.LoadScene(6);
    }
    public void PlayFishing()
    {
        SceneManager.LoadScene(7);
    }
    public void PlayCow()
    {
        SceneManager.LoadScene(8);
    }
    public void PlayTank()
    {
        SceneManager.LoadScene(9);
    }
    #endregion
}
