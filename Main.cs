using UnityEngine;

namespace NameList
{
    class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject();
            _go.AddComponent<Behaviour>();
        }

        public void onDisabled()
        {
            Object.Destroy(_go);
        }

        public string Name
        {
            get { return "Name List"; }
        }

        public string Description
        {
            get { return "Change a name list"; }
        }
    }
}
