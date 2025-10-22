using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Must be public and parameterless to appear in Button -> OnClick()
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
