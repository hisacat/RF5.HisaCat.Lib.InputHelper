using BepInEx.IL2CPP.UnityEngine;
using System;

namespace RF5.HisaCat.Lib.InputHelper
{
    public static class InputHelper
    {
        public static bool GetKeyDown(KeyCode key, bool useEvent = false)
        {
            if (UnityEngine.Event.current == null) return false;
            if (UnityEngine.Event.current.type != UnityEngine.EventType.KeyDown) return false;
            if (Input.GetKeyInt(key))
            {
                if (useEvent) UnityEngine.Event.current.Use();
                return true;
            }
            return false;
        }
        public static bool GetKey(KeyCode key, bool useEvent = false)
        {
            if (UnityEngine.Event.current == null) return false;
            if (Input.GetKeyInt(key))
            {
                if (useEvent) UnityEngine.Event.current.Use();
                return true;
            }
            return false;
        }
        public static bool GetKeyUp(KeyCode key, bool useEvent = false)
        {
            if (UnityEngine.Event.current == null) return false;
            if (UnityEngine.Event.current.type != UnityEngine.EventType.KeyUp) return false;
            if (Input.GetKeyInt(key))
            {
                if (useEvent) UnityEngine.Event.current.Use();
                return true;
            }
            return false;
        }

        public static bool GetKeyDown(RF5Input.Key key) { return GetKeyEdge(key); }
        public static bool GetKeyEdge(RF5Input.Key key) { return RF5Input.Pad.Edge(key); }
        public static bool GetKeyDown(RF5Input.AKey key) { return GetKeyEdge(key); }
        public static bool GetKeyEdge(RF5Input.AKey key) { return RF5Input.Pad.Edge(key); }

        public static bool GetKey(RF5Input.Key key) { return GetKeyPush(key); }
        public static bool GetKeyPush(RF5Input.Key key) { return RF5Input.Pad.Push(key); }
        public static bool GetKey(RF5Input.AKey key) { return GetKeyPush(key); }
        public static bool GetKeyPush(RF5Input.AKey key) { return RF5Input.Pad.Push(key); }

        public static bool GetKeyAll(RF5Input.Key key) { return GetKeyPushAll(key); }
        public static bool GetKeyPushAll(RF5Input.Key key)
        {
            if (key == 0) return false;
            return ((RF5Input.Pad.Data.PushData & key) == key);
        }

        public static bool GetKeyUp(RF5Input.Key key) { return GetKeyEnd(key); }
        public static bool GetKeyEnd(RF5Input.Key key) { return RF5Input.Pad.End(key); }
        public static bool GetKeyUp(RF5Input.AKey key) { return GetKeyEnd(key); }
        public static bool GetKeyEnd(RF5Input.AKey key) { return RF5Input.Pad.End(key); }

        public static bool GetKeyRepeat(RF5Input.Key key) { return RF5Input.Pad.Repeat(key); }
        public static bool GetKeyRepeat(RF5Input.AKey key) { return RF5Input.Pad.Repeat(key); }

        public static float GetAnalogLX() { return RF5Input.Pad.AnalogLX(); }
        public static float GetAnalogLY() { return RF5Input.Pad.AnalogLY(); }
        public static UnityEngine.Vector2 GetAnalogL()
        {
            return new UnityEngine.Vector2(RF5Input.Pad.AnalogLX(), RF5Input.Pad.AnalogLY());
        }

        public static float GetAnalogRX() { return RF5Input.Pad.AnalogRX(); }
        public static float GetAnalogRY() { return RF5Input.Pad.AnalogRY(); }
        public static UnityEngine.Vector2 GetAnalogR()
        {
            return new UnityEngine.Vector2(RF5Input.Pad.AnalogRX(), RF5Input.Pad.AnalogRY());
        }

        public static float ScrollWheelY() { return RF5Input.Pad.ScrollWheelY(); }

        public static void PlayVibration(RF5Input.Pad.VibrationType type)
        {
            RF5Input.Pad.PlayVibration(type);
        }
        public static void StopVibration()
        {
            RF5Input.Pad.StopVibration();
        }

        public static bool GetCursorPos(out RF5SteamInput.SteamInputManager.POINT lpPoint)
        {
            return RF5SteamInput.SteamInputManager.GetCursorPos(out lpPoint);
        }
        public static bool GetCursorPos(out UnityEngine.Vector2Int position)
        {
            RF5SteamInput.SteamInputManager.POINT lpPoint;
            if(RF5SteamInput.SteamInputManager.GetCursorPos(out lpPoint))
            {
                position = new UnityEngine.Vector2Int(lpPoint.X, lpPoint.Y);
                return true;
            }
            position = default;
            return false;
        }

        public static UnityEngine.CursorLockMode GetOptionMouseCursorLockMode()
        {
            return RF5SteamInput.SteamInputManager.GetOptionMouseCursorLockMode();
        }
        public static bool SetCursorPos(int X, int Y)
        {
            return RF5SteamInput.SteamInputManager.SetCursorPos(X, Y);
        }
        public static void SetMouseCursorLock(bool doLock)
        {
            RF5SteamInput.SteamInputManager.SetMouseCursorLock(doLock);
        }
    }
}
