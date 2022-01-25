using UnityEngine;

namespace GDGames.Audio
{
    public class AudioPersister : MonoBehaviour
    {
        static AudioPersister Instance;


        void Awake()
        {
            CreateSingleton();
        }


        void CreateSingleton()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
        }
    }
}