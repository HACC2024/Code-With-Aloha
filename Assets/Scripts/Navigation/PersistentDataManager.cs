using System;
using UnityEngine;

public class PersistentDataManager : MonoBehaviour
{
    public static PersistentDataManager Instance;

    public BirdData selectedBirdData; // The bird data to pass to the next scene

    // public event Action<BirdData> OnBirdDataSet;

    private void Awake()
    {
        // Implement Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object alive across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetBirdData(BirdData newBirdData)
    {
        selectedBirdData = newBirdData;
        // OnBirdDataSet?.Invoke(newBirdData);
    }
}
