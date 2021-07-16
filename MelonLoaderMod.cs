using MelonLoader;
using ModThatIsNotMod.BoneMenu;
using System;
using System.Collections;
using UnityEngine;

namespace Random_slowmo
{
    public static class BuildInfo
    {
        public const string Name = "RandomSlowmo"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "extraes, Elarelda"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class RandomSlowmo : MelonMod
    {
        private bool isEnabled = false;
        public override void OnApplicationStart()
        {
            var menu = MenuManager.CreateCategory("Random slow motion", Color.grey);
            menu.CreateBoolElement("Random Slow Motion", Color.grey, false, new Action<bool>((bool b) => { isEnabled = b; }));
            _ = MelonCoroutines.Start(ChangeTime());
        }
        private IEnumerator ChangeTime()
        {
            yield return new WaitForSecondsRealtime(UnityEngine.Random.RandomRange(6, 10));

            var times = new float[] { 0.125f, 0.25f, 0.5f };
            if (isEnabled)
            {
                Time.timeScale = times[UnityEngine.Random.RandomRange(0, times.Length)];
                yield return new WaitForSecondsRealtime(3);
                Time.timeScale = 1;
            }

            _ = MelonCoroutines.Start(ChangeTime());
        }
    }
}
