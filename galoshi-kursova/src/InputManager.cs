namespace GaloshiKursova.Src
{
    public enum KeyCode
    {
        Alpha1 = 0, Alpha2 = 1, Alpha3 = 2, Alpha4 = 3, Alpha5 = 4,
    }

    public class InputManager
    {
        private static readonly InputManager _instance = new();
        private SortedSet<KeyCode> _pressedKeys = new();

        private InputManager() {}

        public static InputManager Get()
        {
            return _instance;
        }

        public static bool GetKeyDown(KeyCode keyCode)
        {
            return _instance._pressedKeys.Contains(keyCode);
        }
    }
}
