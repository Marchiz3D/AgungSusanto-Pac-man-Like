using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableManager : MonoBehaviour
{
    [SerializeField] private Player player;
    private List<Pickable> pickableList = new List<Pickable>();

    // Start is called before the first frame update
    void Start()
    {
        InitPickableList();
    }

    private void InitPickableList() {
        // Inisialisasi semua object yang memiliki script "Pickable"
        Pickable[] pickableObjects = GameObject.FindObjectsOfType<Pickable>();

        // untuk menghitung jumlah objects yang ada pada game
        for (int i = 0; i < pickableObjects.Length; i++)
        {
            pickableList.Add(pickableObjects[i]);
            pickableList[i].OnPicked += OnPickablePicked;
        }
    }
 
    public void OnPickablePicked(Pickable pickable){
        pickableList.Remove(pickable);
        if (pickable.picakbleType == PicakbleType.PowerUp)
        {
            player?.PickPowerUp();
        }
        if (pickableList.Count <= 0) 
        {
            Debug.Log("WIN!!");           
        }

    }

}