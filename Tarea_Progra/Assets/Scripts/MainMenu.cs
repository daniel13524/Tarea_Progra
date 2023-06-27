using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;
using GameJolt.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameScene()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.SetInt("Enemies", 0);
    }



    public void CreditsScene()
    {
        Trophies.Get(197999, (Trophy Trophy) =>
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
        SceneManager.LoadScene("Credits");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
