using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.SceneManagement;

public class TowerBuilder : MonoBehaviour, ITowerBuilder
{
  public int CountWinLevel;
    public int LevelCount => _levelCount;
    public int _levelCount;
    [SerializeField] private float _additionalScale;
    [SerializeField] private LevelRewards _levelRewards;
      [SerializeField] private FinishPlatform _finish;
     private Ball _ball; 
    private float _startAndFinishAditionalScale = 0.5f;
     
    public float BeamScaleY ;
    public GameObject _beam;

        private IGameEventsExecuter _gameEventsExecuter;

         [Inject]
        private void Construct(IGameEventsExecuter gameEventsExecuter)
        {
            _gameEventsExecuter = gameEventsExecuter;
        }

    private void Awake()
    {
      InstantiateBeam();
    }

    private void Start()
    {
      _finish  = FindObjectOfType<FinishPlatform>();
    }

    private void Update()
    {
      if(_finish.isFinish == true)
      {
        _levelRewards.LevelWin();
      }
    }

    private void InstantiateBeam()
    {
        GameObject beam = Instantiate(_beam, transform);
        beam.transform.localScale = new Vector3(2, GetBeamScale(), 2);
    }
   
    public void SetBeam (GameObject beam)
    {
      _beam = beam;
    }

    public float GetBeamScale() 
    {
      BeamScaleY = _levelCount / 2f + _startAndFinishAditionalScale + _additionalScale / 2f;

      return BeamScaleY;
    }

    public void MinusCoint()
    {
      CountWinLevel++;
    }
    
     public void GoMenu()
        {
            SceneManager.LoadScene(GameConstants.MAIN_MENU_SCENE_INDEX);
        }



}


