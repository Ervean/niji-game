using Ervean.Utilities.Scene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ervean.NijiGame.Login
{
    public class ButtonListeners : MonoBehaviour
    {
        [SerializeField] private SceneSwitcher _sceneSwitcher;
        [SerializeField] private Button buttonStart;
        [SerializeField] private Button buttonSettings;
        [SerializeField] private Button buttonAbout;

        private void Awake()
        {
            AttachListeners();
        }


        private void AttachListeners()
        {
            buttonStart.onClick.AddListener(ButtonStartClicked);
            buttonSettings.onClick.AddListener(ButtonSettingsClicked);
            buttonAbout.onClick.AddListener(ButtonAboutClicked);
        }

        private void ButtonStartClicked()
        {
            _sceneSwitcher.SwitchScene(SceneNames.CharacterSelection);
        }

        private void ButtonSettingsClicked()
        {

        }

        private void ButtonAboutClicked()
        {

        }


    }
}