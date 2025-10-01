namespace GaloshiKursova.Src
{
    public enum KeyCode
    {
        Alpha1 = 0, Alpha2 = 1, Alpha3 = 2, Alpha4 = 3, Alpha5 = 4,
    }

    public class InputManager
    {
        private SortedSet<KeyCode> _pressedKeys = new();

        public bool GetKeyDown(KeyCode keyCode)
        {
            return _pressedKeys.Contains(keyCode);
        }
    }
}
