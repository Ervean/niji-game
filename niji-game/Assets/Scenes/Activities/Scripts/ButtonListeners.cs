using Ervean.Utilities.Scene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ervean.NijiGame.Activities
{
    public class ButtonListeners : MonoBehaviour
    {
        [SerializeField] private SceneSwitcher _sceneSwitcher;

        [SerializeField] private Button buttonGoBack;
        [SerializeField] private Button buttonMarketPlace;
        [SerializeField] private Button buttonDungeon;

        private void Awake()
        {
            AttachListeners();   
        }

        private void AttachListeners()
        {
            buttonGoBack.onClick.AddListener(ButtonGoBackClicked);
            buttonDungeon.onClick.AddListener(ButtonDungeonClicked);
            buttonMarketPlace.onClick.AddListener(ButtonMarketPlaceClicked);
        }


        private void ButtonGoBackClicked()
        {
            _sceneSwitcher.SwitchScene(SceneNames.CharacterSelection);
        }

        private void ButtonMarketPlaceClicked()
        {

        }

        private void ButtonDungeonClicked()
        {
            _sceneSwitcher.SwitchScene(SceneNames.DungeonSelection);
        }


    }
}