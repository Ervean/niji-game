using Ervean.Utilities.Scene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ervean.NijiGame.Home
{
    public class CharacterSelectionManager : MonoBehaviour
    {
        [SerializeField] private SceneSwitcher _sceneSwitcher;
        [SerializeField] private Characters selectedCharacter = Characters.None;


        [SerializeField] private Button buttonConfirm;





        private void Awake()
        {
            RefreshConfirmButton();
        }


        public void SelectRed()
        {
            selectedCharacter = Characters.Red;
            RefreshConfirmButton();
        }

        public void SelectGreen() {
        selectedCharacter= Characters.Green;
            RefreshConfirmButton();
        }
        public void SelectBlue() { 
            selectedCharacter=Characters.Blue;
            RefreshConfirmButton();
        }

        public void ConfirmClicked()
        {
            _sceneSwitcher.SwitchScene(SceneNames.Acitivites);
        }

        private void RefreshConfirmButton()
        {
            if(selectedCharacter != Characters.None) {
                buttonConfirm.interactable = true;           
            }
            else
            {
                buttonConfirm.interactable = false;
            }
        }

    }

    public enum Characters
    {
        None,
        Red,
        Blue,
        Green
    }
}