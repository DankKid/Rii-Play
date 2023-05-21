using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeMonkey.Utils;
public class TitleManager : MonoBehaviour
{
    [SerializeField] List<GameObject> buttons = new List<GameObject>();
    [SerializeField] List<GameObject> scores = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InitHovers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitHovers()
    {
        buttons[0].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnRange();
        buttons[0].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffRange();
        buttons[1].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnFind();
        buttons[1].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffFind();
        buttons[2].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnTennis();
        buttons[2].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffTennis();
        buttons[3].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnPose();
        buttons[3].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffPose();
        buttons[4].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnHockey();
        buttons[4].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffHockey();
        buttons[5].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnBilliards();
        buttons[5].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffBilliards();
        buttons[6].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnFishing();
        buttons[6].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffFishing();
        buttons[7].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnCow();
        buttons[7].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffCow();
        buttons[8].transform.GetComponent<Button_UI>().MouseOverOnceFunc = () => hoverOnTank();
        buttons[8].transform.GetComponent<Button_UI>().MouseOutOnceFunc = () => hoverOffTank();
    }
    
    #region Hover

    public void hoverOnRange()
    {
        scores[0].SetActive(true);
        buttons[0].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffRange()
    {
        scores[0].SetActive(false);
        buttons[0].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnFind()
    {
        scores[1].SetActive(true);
        buttons[1].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffFind()
    {
        scores[1].SetActive(false);
        buttons[1].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnTennis()
    {
        scores[2].SetActive(true);
        buttons[2].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffTennis()
    {
        scores[2].SetActive(false);
        buttons[2].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnPose()
    {
        scores[3].SetActive(true);
        buttons[3].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffPose()
    {
        scores[3].SetActive(false);
        buttons[3].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnHockey()
    {
        scores[4].SetActive(true);
        buttons[4].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffHockey()
    {
        scores[4].SetActive(false);
        buttons[4].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnBilliards()
    {
        scores[5].SetActive(true);
        buttons[5].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffBilliards()
    {
        scores[5].SetActive(false);
        buttons[5].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnFishing()
    {
        scores[6].SetActive(true);
        buttons[6].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffFishing()
    {
        scores[6].SetActive(false);
        buttons[6].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnCow()
    {
        scores[7].SetActive(true);
        buttons[7].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffCow()
    {
        scores[7].SetActive(false);
        buttons[7].transform.localScale = new Vector3(1f, 1f, 1f);
    }
    public void hoverOnTank()
    {
        scores[8].SetActive(true);
        buttons[8].transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }
    public void hoverOffTank()
    {
        scores[8].SetActive(false);
        buttons[8].transform.localScale = new Vector3(1f, 1f, 1f);
    }

    #endregion

    #region Play
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
