using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SceneTransitionSystem;


namespace TeasingGame
{
    public enum TeasingGameScene :int 
    {
        Home,
        Game,
    }
public class TeasingGameHomeSceneController : MonoBehaviour
{
    public TeasingGameScene SceneForButton;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

   public void GoToGameScene()
    {
        STSSceneManager.LoadScene(SceneForButton.ToString());
    }
}
}