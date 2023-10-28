using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
      public GameObject prefab;

      void Update()
      {
          // Whenever we hit the B key we will generate a prefab at the
          // position of the original prefab
          // Whenever we hit the space key, we will generate a prefab at the
          // position of the spawn object that this script is attached to
          if (Input.GetKeyDown(KeyCode.B))
          {
               Instantiate(prefab);
          }

          if (Input.GetKeyDown(KeyCode.Space))
          {
               Instantiate(prefab, transform.position, transform.rotation);
          }
      }
      
      int lampSpawns = 10;
      void Start()
      {
            for(int x = 0; x < lampSpawns; x++)
            {
                Instantiate(prefab); prefab.transform.Translate(5f, 0f, 0f);
            }
      }


}