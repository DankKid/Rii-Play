using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveHandler : MonoBehaviour
{
    [SerializeField] TitleManager titleManager;
    private void Awake()
    {
        
    }

    public void SaveScores()
    {
        SaveObject saveObject = new SaveObject
        {
            ShootingScore = titleManager.rangeScoreValues,
            FindScore = titleManager.findScoreValues,
            TennisScore = titleManager.tennisScoreValues,
            PoseScore = titleManager.poseScoreValues,
            HockeyScore = titleManager.hockeyScoreValues,
            BilliardsScore = titleManager.billiardsScoreValues,
            FishingScore = titleManager.fishingScoreValues,
            CowScore = titleManager.cowScoreValues,
            TankScore = titleManager.tankScoreValues

        };
        string json = JsonUtility.ToJson(saveObject);
        File.WriteAllText(Application.persistentDataPath + "/save.txt", json);
    }

    public void LoadScores()
    {

    }

    
}
class SaveObject
{
    public List<int> ShootingScore, FindScore, TennisScore, PoseScore, HockeyScore, BilliardsScore, FishingScore, CowScore, TankScore;
}