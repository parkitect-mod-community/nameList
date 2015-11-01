using UnityEngine;

namespace NameList
{
    class Behaviour : MonoBehaviour
    {

        private System.Random r = new System.Random();

        // some german female forenames
        private string[] forenamesF = { "Angelika", "Johanna", "Martina", "Herta" };
        // some german male forenames
        private string[] forenamesM = { "Albert", "Ludwig", "Martin", "Heino" };

        // some gemran surnames
        private string[] surnames = { "Becker", "Meier", "Fischer", "Müller" };

        private float rMin = 0.001f;
        private float rMax = 1.001f;

        private float getRandomPs()
        {
            return r.NextFloat(rMin, rMax); 
        }

        public void Start()
        {
            Parkitect.UI.NotificationBar.Instance.addNotification("The name list mod has been loaded, yay!");

            float[] psSurnames = new float[surnames.Length];
            for (int i = 0; i < psSurnames.Length; i++)
            {
                psSurnames[i] = getRandomPs();
                Parkitect.UI.NotificationBar.Instance.addNotification(
                    "Surname " + surnames[i] + " & ps " + psSurnames[i].ToString()
                );
            }
            AssetManager.Instance.surnames.setValues(surnames, psSurnames);

            float[] psForenamesF = new float[forenamesF.Length];
            for (int i = 0; i < psForenamesF.Length; i++)
            {
                psForenamesF[i] = getRandomPs();
                Parkitect.UI.NotificationBar.Instance.addNotification(
                    "Forename F " + forenamesF[i] + " & ps " + psForenamesF[i].ToString()
                );
            }
            AssetManager.Instance.forenamesFemale.setValues(forenamesF, psForenamesF);

            float[] psForenamesM = new float[forenamesM.Length];
            for (int i = 0; i < psForenamesM.Length; i++)
            {
                psForenamesM[i] = getRandomPs();
                Parkitect.UI.NotificationBar.Instance.addNotification(
                    "Forename F " + forenamesM[i] + " & ps " + psForenamesM[i].ToString()
                );
            }
            AssetManager.Instance.forenamesMale.setValues(forenamesM, psForenamesM);
        }

        private void OnGUI()
        {
            if (Application.loadedLevel != 2)
                return;

            if (GUI.Button(new Rect(Screen.width / 2 - 200 / 2, 10, 200, 20), "Spawn Guest!"))
            {
                GameController.Instance.park.spawnGuest();
            }
        }

    }
}
