using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;
using GameJolt.UI;

public class Player : MonoBehaviour
{
    public GameManager GM;
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private int enemiesPref;
    [SerializeField]
    private int deaths;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        GM = FindObjectOfType<GameManager>();
        enemiesPref = PlayerPrefs.GetInt("Enemies");
        deaths = PlayerPrefs.GetInt("Deaths");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(horizontal, 0f, vertical) * speed;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            enemiesPref += 1;
            PlayerPrefs.SetInt("Enemies", enemiesPref);
            Destroy(other.gameObject);
            GM.enemies--;
            Debug.Log("colison");
            if (enemiesPref == 10)
            {
                Trophies.Get(198001, (Trophy Trophy) =>
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
            }
            if (enemiesPref == 100)
            {
                Trophies.Get(198002, (Trophy Trophy) =>
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
            }
        }

        if (other.gameObject.CompareTag("obstacle"))
        {
            deaths += 1;
            PlayerPrefs.SetInt("Deaths", deaths);
            
            if (deaths == 10)
            {
                Trophies.Get(198000, (Trophy Trophy) =>
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
            }
            SceneManager.LoadScene("Defeat");
        }
    }
}
