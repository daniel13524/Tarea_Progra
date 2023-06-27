using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;

public class LoginManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool signedIn) =>
        {
            if (signedIn)
            {
                Trophies.Get(197398, (Trophy Trophy) =>
                {
                    if (Trophy != null)
                    {
                        Trophies.TryUnlock(Trophy, (TryUnlockResult result) =>
                        {
                            switch (result)
                            {
                                case TryUnlockResult.Unlocked:
                                    Debug.Log("Desbloqueado con éxito");
                                    break;
                                case TryUnlockResult.AlreadyUnlocked:
                                    Debug.Log("Ya estaba desbloqueado");
                                    break;
                                case TryUnlockResult.Failure:
                                    Debug.Log("Falló");
                                    break;
                            }
                        });

                    }
                });
                SceneManager.LoadScene("MainMenu");
                PlayerPrefs.SetInt("Deaths", 0);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
