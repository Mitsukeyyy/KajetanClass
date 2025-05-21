using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    
    public TextMeshProUGUI counter;

    [SerializeField] private GameObject panelLost;

    [SerializeField] private Button buttonReloadLevel; 

    void Start()
    {
        panelLost.SetActive(false);
        buttonReloadLevel.onClick.AddListener(ReloadLevel);
    }
    
    public void UpdateCounter(int newCoinCount)
    {
        counter.text = newCoinCount.ToString();
    }

    public void ShowPanelLost()
    {
        panelLost.SetActive(true);
    }

    void ReloadLevel()
    {
        //SceneManager.LoadScene("SCENE_NAME")
        //SceneManager.LoadScene(1); 1 == Index of Scene in Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
