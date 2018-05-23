using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public class SaveDataClass : MonoBehaviour
//{
//    GamMnager gameManager;
//    public string SaveID = gameManager.IDInputField.text;

//    private static SaveDataClass _instance = null;
//    public static SaveDataClass Instance
//    {
//        get
//        {
//            if (_instance == null)
//            {
//                _instance = FindObjectOfType(typeof(SaveDataClass)) as SaveDataClass;
//                if (_instance == null)
//                {
//                    Debug.LogError("Threr is no active SaveDataClass object");
//                }
//            }
//            return _instance;
//        }
//    }
//}



public class GamMnager : MonoBehaviour {



    //private static GamMnager _instance = null;
    //public static GamMnager Instance
    //{
    //    get
    //    {
    //        if (_instance == null)
    //        {
    //            _instance = FindObjectOfType(typeof(GamMnager)) as GamMnager;
    //            if (_instance == null)
    //            {
    //                Debug.LogError("Threr is no active GamMnager object");
    //            }
    //        }
    //        return _instance;
    //    }
    //}


    [Header("LoginPanel")]
    public InputField IDInputField;
    public InputField PassInputField;

    [Header("CreateAccountPanel")]
    public InputField New_IDInputField;
    public InputField New_PassInputField;
    public GameObject CreateAccountPanelObj;


    // Use this for initialization
    void Start () {
		

	}
    public void LoginBtn()
    {
        StartCoroutine(LginCo());

        
    }

    IEnumerator LginCo()
    {
        Debug.Log("ID는?"+IDInputField.text);
        Debug.Log("비밀번호는?" + PassInputField.text);

        if (IDInputField.text == null)
        {
            Debug.Log("널 들어왔다");
        }
        yield return null;
    }

    public void OpenCreateAccountBtn()
    {
        CreateAccountPanelObj.SetActive(true);
         
    }

    public void CreateAccountBtn()
    {
        StartCoroutine(CreateCo());
    }

    IEnumerator CreateCo()
    {

        Debug.Log("새로 만드는 계정의 ID는?" + New_IDInputField.text);
        Debug.Log("새로 만드는 계정의 비밀번호는?"+New_PassInputField.text);
        yield return null;
    }
}
