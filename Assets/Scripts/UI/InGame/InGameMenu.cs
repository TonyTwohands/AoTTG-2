using UnityEngine;

namespace Assets.Scripts.UI.InGame
{
    public class InGameMenu : MonoBehaviour
    {
        public GameSettingMenu GameSettingsMenu;
        public RebindMenu RebindMenu;


        public void ShowGameSettingsMenu()
        {
            GameSettingsMenu.gameObject.SetActive(true);
        }

        public void ShowRebindMenu()
        {
            RebindMenu.gameObject.SetActive(true);
        }

        private void SetGameSettingsMenu()
        {

        }

        private void OnDisable()
        {
            GameSettingsMenu.gameObject.SetActive(false);
            RebindMenu.gameObject.SetActive(false);
        }

        public void Quit()
        {
            PhotonNetwork.Disconnect();
        }
    }
}