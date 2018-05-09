using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataCtrl : MonoBehaviour {

    public string userID;
    public int characterType;

    // 싱글톤 패턴
    public static GameDataCtrl _gameDataCtrl = null;
    //public static GameDataCtrl gameDataCtrl
    //{
    //    get
    //    {
    //        if (_gameDataCtrl == null)
    //        {
    //            _gameDataCtrl= FindObjectOfType(typeof(GameDataCtrl)) as GameDataCtrl;
    //            if (_gameDataCtrl == null)
    //                Debug.Log("UserInfo가 없어서 할당 불가능");
    //        }
    //        return _gameDataCtrl;
    //    }
    //}

    // Use this for initialization
    void Start () {
        if (_gameDataCtrl == null) _gameDataCtrl = this;
        else if (_gameDataCtrl != this) Destroy(gameObject);

        DontDestroyOnLoad(this);
    }

    // LoginScene에서 저장
    public void SetData(string userID, int type)
    {
        this.userID = userID;
        characterType = type;
    }

    // MainGame에서 사용
    public bool GetData(out string userID, out int type)
    {
        userID = this.userID;
        type = characterType;
        Debug.Log("ID : " + userID + " type : " + type.ToString());
        return true;
    }
}
