using UnityEngine;

public class CameraManager : MonoBehaviour
{
<<<<<<< Updated upstream

=======
<<<<<<< HEAD

=======
    
>>>>>>> d1bf35e0cc7c6e6ed0268ca6c637ec2e101c9f17
>>>>>>> Stashed changes
    public GameObject playerA;
    public GameObject playerB;

    public float minSize;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public float maxSize;
    void Start()
    {

<<<<<<< Updated upstream
=======
=======
    public float maxSize;   
    void Start()
    {
        
>>>>>>> d1bf35e0cc7c6e6ed0268ca6c637ec2e101c9f17
>>>>>>> Stashed changes
    }
    void Update()
    {
        float size = Vector3.Distance(playerA.transform.position, playerB.transform.position) / 1.8f;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        if (size < minSize)
            size = minSize;
        if (size > maxSize)
            size = maxSize;
<<<<<<< Updated upstream
=======
=======
        if(size < minSize)
            size = minSize;
        if(size > maxSize)
            size = maxSize; 
>>>>>>> d1bf35e0cc7c6e6ed0268ca6c637ec2e101c9f17
>>>>>>> Stashed changes

        Vector3 MediumPos = (playerA.transform.position + playerB.transform.position) / 2;

        MediumPos.z = -10;
<<<<<<< Updated upstream
        Camera.main.transform.position = MediumPos;
        Camera.main.orthographicSize = size;
    }
}
=======
<<<<<<< HEAD
        Camera.main.transform.position = MediumPos;
        Camera.main.orthographicSize = size;
    }
}
=======
        Camera.main.transform.position = MediumPos; 
        Camera.main.orthographicSize = size;
    }
}
>>>>>>> d1bf35e0cc7c6e6ed0268ca6c637ec2e101c9f17
>>>>>>> Stashed changes
