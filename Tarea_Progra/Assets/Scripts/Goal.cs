using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;
using GameJolt.UI;

public class Goal : MonoBehaviour
{
    public string nivel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && nivel == "level2")
        {
            Trophies.Get(197399, (Trophy Trophy) =>
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
            SceneManager.LoadScene(nivel);
        }
        if (collision.gameObject.CompareTag("Player") && nivel == "level3")
        {
            Trophies.Get(197997, (Trophy Trophy) =>
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
            SceneManager.LoadScene(nivel);
        }
        if (collision.gameObject.CompareTag("Player") && nivel == "victory")
        {
            Trophies.Get(197998, (Trophy Trophy) =>
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
            SceneManager.LoadScene(nivel);
        }
    }
}
